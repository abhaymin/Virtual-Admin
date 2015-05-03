using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Remoting; 
//using Server;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;
using RemoteObject;

namespace Client
{
	/// <summary>
	/// Summary description for RemoteDesktopControl.
	/// </summary>
	public class RemoteDesktopControl : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		private RemoteDesktop rbj = null;
		private Bitmap m_Bitmap = null;
		private bool Control = false;

		public RemoteDesktopControl()
		{
			InitializeComponent();
		}

		public void Initialize(String RemoteMachineName)
		{
				try
				{
					//ChannelServices.RegisterChannel(new TcpChannel());
					
					rbj =(RemoteDesktop) Activator.GetObject(typeof(RemoteDesktop),
						"tcp://" + RemoteMachineName + ":9090/RemoteObject.RemoteDesktop");
					
					
					Size DesktopWindowSize = rbj.GetDesktopBitmapSize();
					

					m_Bitmap = new Bitmap(DesktopWindowSize.Width, DesktopWindowSize.Height);
					
					AutoScrollMinSize = DesktopWindowSize;
					
					UpdateDisplay();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Need to run Server on remote machine" + ex.Message);
					throw(ex);
				}
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// RemoteDesktopControl
			// 
			this.AutoScroll = true;
			this.Name = "RemoteDesktopControl";
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoteDesktopControl_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.RemoteDesktopControl_Paint);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemoteDesktopControl_KeyUp);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoteDesktopControl_KeyDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoteDesktopControl_MouseMove);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoteDesktopControl_MouseDown);

		}
		#endregion

		private void RemoteDesktopControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Monitor.Enter(this);

			if (m_Bitmap != null)
			{
				Point P = new Point(AutoScrollPosition.X, AutoScrollPosition.Y); 
				e.Graphics.DrawImage(m_Bitmap, P);
			}

			Monitor.Exit(this);
		}

		private void RemoteDesktopControl_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (Control)
			{
				rbj.MoveMouse(e.X, e.Y);
			}
		}

		private void RemoteDesktopControl_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			rbj.PressOrReleaseMouseButton(false, e.Button == MouseButtons.Left, e.X, e.Y);
		}

		private void RemoteDesktopControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			rbj.PressOrReleaseMouseButton(true, e.Button == MouseButtons.Left, e.X, e.Y);
		}

		[DllImport("user32.dll")]
		private static extern uint MapVirtualKey(
			uint uCode,     // virtual-key code or scan code
			uint uMapType   // translation to perform
			);

		private void RemoteDesktopControl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			e.Handled = true;

			rbj.SendKeystroke((byte) e.KeyCode, (byte) MapVirtualKey((uint) e.KeyCode, 0), true, false);
		}

		private void RemoteDesktopControl_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			e.Handled = true;

			rbj.SendKeystroke((byte) e.KeyCode, (byte) MapVirtualKey((uint) e.KeyCode, 0), false, false);
		}

		public void SetControl(bool Control)
		{
			this.Control = Control;
		}

		public void UpdateDisplay()
		{
			Monitor.Enter(this);

			try
			{
				int Start = Environment.TickCount;

				byte []BitmapBytes = rbj.GetDesktopBitmapBytes();

				int GetDesktopBitmapBytesTime = Environment.TickCount - Start;

				if (BitmapBytes.Length > 0)
				{
					Start = Environment.TickCount;

					MemoryStream MS = new MemoryStream(BitmapBytes, false);

					m_Bitmap = (Bitmap) Image.FromStream(MS);

					int FromStreamTime = Environment.TickCount - Start;
					Start = Environment.TickCount;

					Point P = new Point(AutoScrollPosition.X, AutoScrollPosition.Y); 
					CreateGraphics().DrawImage(m_Bitmap, P);

					int DrawImageTime = Environment.TickCount - Start;
				}
			}
			catch (Exception)
			{
			}
			Monitor.Exit(this);
		}
	}
}
