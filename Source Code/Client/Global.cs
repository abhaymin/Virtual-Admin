using System;
using System.Diagnostics;

namespace Client
{
	/// <summary>
	/// Summary description for Global.
	/// </summary>
	public class RemoteObjectCl
	{
		public RemoteObject.RemoteProcesses rProc;
		public RemoteObject.RemoteServices rServ;
		public RemoteObject.Eves eEve;
		public RemoteObject.RemoteDesktop rDesk;
	}

	public class Global
	{
		public static string RemoteMachine;
		
		public static RemoteObjectCl rObj=new RemoteObjectCl();
		public static frmClient frmMain=null;
		public static frmConnect frmCon=null;
		public static frmRTaskManager frmTasks=null;
		public static frmRServices frmServices=null;
		public static frmRDesktopViewer frmDesktop=null;
		public static frmEvent eve=null;

		public static System.Windows.Forms.TreeNodeCollection trvNode;

		public static void ShowEvents(int tab)
		{
			if(eve==null || eve.IsDisposed)
			{
				eve=new frmEvent();
				eve.MdiParent=frmMain;
				eve.Show();
				if(tab==1)
					eve.ShowTab(1);
				else if(tab==2)
					eve.ShowTab(2);
				else if(tab==3)
					eve.ShowTab(3);
			
			}
			else
			{
				eve.BringToFront();
				if(tab==1)
					eve.ShowTab(1);
				else if(tab==2)
					eve.ShowTab(2);
				else if(tab==3)
					eve.ShowTab(3);
			
			}
		}

		public static void ShowConnect()
		{
			if(frmCon==null || frmCon.IsDisposed)
			{
				frmCon=new frmConnect();
				frmCon.MdiParent=frmMain;
				frmCon.Show();
			}
			else
			{
				frmCon.BringToFront();
			}
		}


		public static void ShowTask(int tab)
		{
			if(frmTasks==null || frmTasks.IsDisposed)
			{
				frmTasks=new frmRTaskManager();
				frmTasks.MdiParent=frmMain;
				frmTasks.Show();
				if(tab==1)
					frmTasks.ShowTab(1);
				else if(tab==2)
					frmTasks.ShowTab(2);
			}
			else
			{
				frmTasks.BringToFront();
				if(tab==1)
					frmTasks.ShowTab(1);
				else if(tab==2)
					frmTasks.ShowTab(2);
			}
		}
		public static void ShowServices()
		{
			if(frmServices==null || frmServices.IsDisposed)
			{
				frmServices=new frmRServices();
				frmServices.MdiParent=frmMain;
				frmServices.Show();
			}
			else
			{
				frmServices.BringToFront();
			}
		}

		public static void ShowDesktop()
		{
			if(frmDesktop==null || frmDesktop.IsDisposed)
			{
				frmDesktop=new frmRDesktopViewer();
				frmDesktop.MdiParent=frmMain;
				frmDesktop.Show();
			}
			else
			{
				frmDesktop.BringToFront();
			}
		}
	}
}
