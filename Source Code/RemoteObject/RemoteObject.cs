using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Runtime.InteropServices;
using System.IO;
using System.Net.Sockets;
using System.Drawing;
using System.Drawing.Imaging;

namespace RemoteObject
{
	/// <summary>
	/// Summary description for RemoteObject.
	/// </summary>
	public class RemoteProcesses:MarshalByRefObject
	{
		public RemoteProcesses()
		{
			Console.WriteLine("RemoteProcess Object Instantiated");
		}

		public Process[] GetRProcesses()
		{
			return Process.GetProcesses();
		}

		public bool RKillProcess(int ID)
		{
			try
			{
				Process.GetProcessById(ID).Kill();
				return true;
			}
			catch(Exception e)
			{
				Console.Write(e);
				return false;
			}
		}
	}

	public class RemoteServices:MarshalByRefObject
	{
		public RemoteServices()
		{
			Console.WriteLine("RemoteProcess Object Instantiated");
		}
		public ServiceController[] GetRServices()
		{
			return ServiceController.GetServices();
		}

		public bool RStopService(string srv)
		{
			try
			{
				ServiceController s=new ServiceController(srv);
				s.Stop();
				return true;
			}
			catch(Exception e1)
			{
				Console.WriteLine(e1);
				return false;
			}
		}

		public bool RStartService(string srv)
		{
			try
			{
				ServiceController s=new ServiceController(srv);
				
				s.Start();
				return true;
			}
			catch(Exception e1)
			{
				Console.WriteLine(e1);
				return false;
			}
		}
		public bool RPauseService(string srv)
		{
			try
			{
				ServiceController sc=new ServiceController(srv);
				sc.Pause();
				return true;
			}
			catch(Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}

		public bool RResumeService(string srv)
		{
			try
			{
				ServiceController sc=new ServiceController(srv);
				sc.Continue();
				
				return true;
			}
			catch(Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}
	}


	public class Eves:MarshalByRefObject
	{
		public int st;
		public Eves()
		{
				
		}
		
		public int ary
		{
			get { return st; }
			set { st=value; }
		}	
		
		public string[,] ShowEves(string eve)
		{			
			EventLog ev;			

			string[,] eveval=new string[0,0];
			if(eve=="App")
			{
				ev= new EventLog("Application");

				int LastLogToShow = ev.Entries.Count;
				ary=LastLogToShow;
				eveval=new string[ary,9];
//Warning	1	'System.Diagnostics.EventLogEntry.EventID' is obsolete: 'This property has been deprecated.  Please use System.Diagnostics.EventLogEntry.InstanceId instead.  http://go.microsoft.com/fwlink/?linkid=14202'	C:\Documents and Settings\Nirmal\Desktop\Project\Single\Single\RemoteObject\RemoteObject.cs	152	18	RemoteObject

                int i;			
				for (i=0;i<= ary-1;i++) //ev.Entries.Count - 1
				{
					EventLogEntry CurrentEntry = ev.Entries[i];						
					eveval[i,0]=CurrentEntry.EntryType.ToString();
					eveval[i,1]=CurrentEntry.TimeWritten.ToLongDateString();
					eveval[i,2]=CurrentEntry.TimeWritten.ToLongTimeString();				
					eveval[i,3]=CurrentEntry.Source;						
					eveval[i,4]=CurrentEntry.Category;						
					eveval[i,5]=CurrentEntry.InstanceId.ToString();
					eveval[i,6]=CurrentEntry.UserName;
					eveval[i,7]=CurrentEntry.MachineName;	
					eveval[i,8]=CurrentEntry.Message;	
				}
				ev.Close();
				return eveval;
			}
			else if(eve=="Sys")
			{
				ev= new EventLog("System");
				int LastLogToShow = ev.Entries.Count;
				ary=LastLogToShow;
				eveval=new string[ary,9];

				int i;			
				for (i=0;i<= ary-1;i++) 
				{
					EventLogEntry CurrentEntry = ev.Entries[i];						
					eveval[i,0]=CurrentEntry.EntryType.ToString();
					eveval[i,1]=CurrentEntry.TimeWritten.ToLongDateString();
					eveval[i,2]=CurrentEntry.TimeWritten.ToLongTimeString();				
					eveval[i,3]=CurrentEntry.Source;						
					eveval[i,4]=CurrentEntry.Category;						
					eveval[i,5]=CurrentEntry.InstanceId.ToString();
					eveval[i,6]=CurrentEntry.UserName;
					eveval[i,7]=CurrentEntry.MachineName;											
					eveval[i,8]=CurrentEntry.Message;
				
				}
				ev.Close();				
				return eveval;
			}
			else if(eve=="Sec")
			{
				ev= new EventLog("Security");
				int LastLogToShow = ev.Entries.Count;
				ary=LastLogToShow;
				eveval=new string[ary,9];

				int i;			
				for (i=0;i<= ev.Entries.Count - 1;i++)
				{
					EventLogEntry CurrentEntry = ev.Entries[i];						
					eveval[i,0]=CurrentEntry.EntryType.ToString();
					eveval[i,1]=CurrentEntry.TimeWritten.ToLongDateString();
					eveval[i,2]=CurrentEntry.TimeWritten.ToLongTimeString();				
					eveval[i,3]=CurrentEntry.Source;						
					eveval[i,4]=CurrentEntry.Category;						
					eveval[i,5]=CurrentEntry.InstanceId.ToString();
					eveval[i,6]=CurrentEntry.UserName;
					eveval[i,7]=CurrentEntry.MachineName;										
					eveval[i,8]=CurrentEntry.Message;
				}
				ev.Close();	
				return eveval;
			}
			return eveval;		
		}
	}

	public class RemoteDesktop : System.MarshalByRefObject
	{
		public RemoteDesktop() 
		{ 
		} 

		[DllImport("user32.dll")]
		private static extern IntPtr GetDesktopWindow();

		[DllImport("gdi32.dll")]
		private static extern bool BitBlt(
			IntPtr hdcDest, // handle to destination DC
			int nXDest, // x-coord of destination upper-left corner
			int nYDest, // y-coord of destination upper-left corner
			int nWidth, // width of destination rectangle
			int nHeight, // height of destination rectangle
			IntPtr hdcSrc, // handle to source DC
			int nXSrc, // x-coordinate of source upper-left corner
			int nYSrc, // y-coordinate of source upper-left corner
			System.Int32 dwRop // raster operation code
			);

		private const Int32 SRCCOPY = 0xCC0020;

		[DllImport("user32.dll")]
		private static extern int GetSystemMetrics(int nIndex);

		private const int SM_CXSCREEN = 0;
		private const int SM_CYSCREEN = 1;

		public Size GetDesktopBitmapSize()
		{
			return new Size(GetSystemMetrics(SM_CXSCREEN), GetSystemMetrics(SM_CYSCREEN));
		}

		private const uint MOUSEEVENTF_MOVE       = 0x0001; /* mouse move */
		private const uint MOUSEEVENTF_LEFTDOWN   = 0x0002; /* left button down */
		private const uint MOUSEEVENTF_LEFTUP     = 0x0004; /* left button up */
		private const uint MOUSEEVENTF_RIGHTDOWN  = 0x0008; /* right button down */
		private const uint MOUSEEVENTF_RIGHTUP    = 0x0010; /* right button up */
		private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
		private const uint MOUSEEVENTF_MIDDLEUP   = 0x0040; /* middle button up */
		private const uint MOUSEEVENTF_WHEEL      = 0x0800; /* wheel button rolled */
		private const uint MOUSEEVENTF_ABSOLUTE   = 0x8000; /* absolute move */

		private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
		private const uint KEYEVENTF_KEYUP       = 0x0002;

		private const uint INPUT_MOUSE    = 0;
		private const uint INPUT_KEYBOARD = 1;

		struct MOUSE_INPUT
		{
			public uint dx;
			public uint dy;
			public uint mouseData;
			public uint dwFlags;
			public uint time;
			public uint dwExtraInfo;
		}

		struct KEYBD_INPUT
		{
			public ushort wVk;
			public ushort wScan;
			public uint   dwFlags;
			public uint   time;
			public uint   dwExtraInfo;
		}

		[StructLayout(LayoutKind.Explicit)]
			struct INPUT
		{
			[FieldOffset(0)]
			public uint type;

			// union
			[FieldOffset(4)]
			public MOUSE_INPUT mi;

			[FieldOffset(4)]
			public KEYBD_INPUT ki;
		}

		[DllImport("user32.dll")]
		private static extern uint SendInput(
			uint nInputs,     // count of input events
			ref INPUT input,
			int cbSize        // size of structure
			);

		public void PressOrReleaseMouseButton(bool Press, bool Left, int X, int Y)
		{
			INPUT input = new INPUT();

			input.type           = INPUT_MOUSE;
			input.mi.dx          = (uint) X;
			input.mi.dy          = (uint) Y;
			input.mi.mouseData   = 0;
			input.mi.dwFlags     = 0;
			input.mi.time        = 0;
			input.mi.dwExtraInfo = 0;

			if (Left)
			{
				input.mi.dwFlags = Press ? MOUSEEVENTF_LEFTDOWN : MOUSEEVENTF_LEFTUP;
			}
			else
			{
				input.mi.dwFlags = Press ? MOUSEEVENTF_RIGHTDOWN : MOUSEEVENTF_RIGHTUP;
			}

			SendInput(1, ref input, Marshal.SizeOf(input));
		}

		[DllImport("user32.dll")]
		private static extern void SetCursorPos(int x, int y);

		public void MoveMouse(int x, int y)
		{
			SetCursorPos(x, y);
		}

		public void SendKeystroke(byte VirtualKeyCode, byte ScanCode, bool KeyDown, bool ExtendedKey)
		{
			INPUT input = new INPUT();

			input.type           = INPUT_KEYBOARD;
			input.ki.wVk         = VirtualKeyCode;
			input.ki.wScan       = ScanCode;
			input.ki.dwExtraInfo = 0;
			input.ki.time        = 0;

			if (!KeyDown)
			{
				input.ki.dwFlags |= KEYEVENTF_KEYUP;
			}

			if (ExtendedKey)
			{
				input.ki.dwFlags |= KEYEVENTF_EXTENDEDKEY;
			}

			SendInput(1, ref input, Marshal.SizeOf(input));
		}

		private Bitmap GetDesktopBitmap()
		{
			int Start = Environment.TickCount;

			Size DesktopBitmapSize = GetDesktopBitmapSize();

			Graphics Graphic = Graphics.FromHwnd(GetDesktopWindow());

			int GraphicsFromHwndTime = Environment.TickCount - Start;
			Start = Environment.TickCount;

			Bitmap MemImage = new Bitmap(DesktopBitmapSize.Width, DesktopBitmapSize.Height, Graphic);

			int MemImageTime = Environment.TickCount - Start;
			Start = Environment.TickCount;

			Graphics MemGraphic = Graphics.FromImage(MemImage);

			int FromImageTime = Environment.TickCount - Start;

			IntPtr dc1 = Graphic.GetHdc();
			IntPtr dc2 = MemGraphic.GetHdc();
			BitBlt(dc2, 0, 0, DesktopBitmapSize.Width, DesktopBitmapSize.Height, dc1, 0, 0, SRCCOPY);

			int BitBltTime = Environment.TickCount - Start;

			Graphic.ReleaseHdc(dc1);
			MemGraphic.ReleaseHdc(dc2);
	
			Graphic.Dispose();
			MemGraphic.Dispose();

			return MemImage;
		}

		private static byte[] PreviousBitmapBytes = null;

		private static bool BitmapsAreEqual(ref byte[] a, ref byte[] b)
		{
			bool Result = a != null && b != null && a.Length == b.Length;

			if (Result)
			{
				for (int i = 0; Result && i < a.Length; i++)
				{
					if (a[i] != b[i])
					{
						Result = false;
					}
				}
			}

			return Result;
		}

		public byte []GetDesktopBitmapBytes()
		{
			int Start = Environment.TickCount;

			Bitmap CurrentBitmap = GetDesktopBitmap();

			int CurrentBitmapTime = Environment.TickCount - Start;

			Start = Environment.TickCount;

			MemoryStream MS = new MemoryStream();

			CurrentBitmap.Save(MS, ImageFormat.Jpeg);
			CurrentBitmap.Dispose();

			int SaveBitmapTime = Environment.TickCount - Start;
			Start = Environment.TickCount;

			MS.Seek(0, SeekOrigin.Begin);

			byte []CurrentBitmapBytes = new byte[MS.Length];

			int NumBytesToRead = (int) MS.Length;
			int NumBytesRead = 0;

			while (NumBytesToRead > 0) 
			{
				// Read may return anything from 0 to numBytesToRead.
				int n = MS.Read(CurrentBitmapBytes, NumBytesRead, NumBytesToRead);

				if (n==0)  // We're at EOF
					break;

				NumBytesRead   += n;
				NumBytesToRead -= n;
			}

			MS.Close();

			int ReadTime = Environment.TickCount - Start;
			Start = Environment.TickCount;

			byte []Result = new byte[0];

			if (!BitmapsAreEqual(ref CurrentBitmapBytes, ref PreviousBitmapBytes))
			{
				Result = CurrentBitmapBytes;
				PreviousBitmapBytes = CurrentBitmapBytes;
			}

			int CompareTime = Environment.TickCount - Start;
			return Result;
		}
	} 
}
