using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Client
{
	/// <summary>
	/// Summary description for frmClient.
	/// </summary>
	public class frmClient : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglst;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem mnuAction;
		private System.Windows.Forms.MenuItem mnuActionRefresh;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.ContextMenu cmenuTrv;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem cmnuDisconnect;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TreeView trvPanel;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem mnuConnect;
		private System.ComponentModel.IContainer components;

		public frmClient()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClient));
			this.imglst = new System.Windows.Forms.ImageList(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuConnect = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.mnuAction = new System.Windows.Forms.MenuItem();
			this.mnuActionRefresh = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuAbout = new System.Windows.Forms.MenuItem();
			this.cmenuTrv = new System.Windows.Forms.ContextMenu();
			this.cmnuDisconnect = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.trvPanel = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imglst
			// 
			this.imglst.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imglst.ImageSize = new System.Drawing.Size(16, 16);
			this.imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst.ImageStream")));
			this.imglst.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuFile,
																					  this.mnuAction,
																					  this.menuItem1});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuConnect,
																					this.menuItem4,
																					this.mnuFileExit});
			this.mnuFile.Text = "&File";
			// 
			// mnuConnect
			// 
			this.mnuConnect.Index = 0;
			this.mnuConnect.Text = "&Connect";
			this.mnuConnect.Click += new System.EventHandler(this.mnuConnect_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Index = 2;
			this.mnuFileExit.Text = "&Exit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuAction
			// 
			this.mnuAction.Index = 1;
			this.mnuAction.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuActionRefresh});
			this.mnuAction.Text = "&Action";
			// 
			// mnuActionRefresh
			// 
			this.mnuActionRefresh.Index = 0;
			this.mnuActionRefresh.Text = "&Refresh";
			this.mnuActionRefresh.Click += new System.EventHandler(this.mnuActionRefresh_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuAbout});
			this.menuItem1.Text = "&Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Index = 0;
			this.mnuAbout.Text = "&About";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// cmenuTrv
			// 
			this.cmenuTrv.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmnuDisconnect,
																					 this.menuItem2});
			// 
			// cmnuDisconnect
			// 
			this.cmnuDisconnect.Index = 0;
			this.cmnuDisconnect.Text = "&Disconnect";
			this.cmnuDisconnect.Click += new System.EventHandler(this.cmnuDisconnect_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "-";
			// 
			// statusBar1
			// 
			this.statusBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 242);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(368, 24);
			this.statusBar1.TabIndex = 2;
			this.statusBar1.Text = "statusBar1";
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.MinWidth = 2;
			this.statusBarPanel1.Width = 176;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel2.Width = 176;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.splitter1,
																				 this.trvPanel});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(128, 242);
			this.panel1.TabIndex = 6;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(125, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 242);
			this.splitter1.TabIndex = 5;
			this.splitter1.TabStop = false;
			// 
			// trvPanel
			// 
			this.trvPanel.ContextMenu = this.cmenuTrv;
			this.trvPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.trvPanel.ImageList = this.imglst;
			this.trvPanel.Name = "trvPanel";
			this.trvPanel.SelectedImageIndex = 1;
			this.trvPanel.Size = new System.Drawing.Size(121, 242);
			this.trvPanel.TabIndex = 2;
			this.trvPanel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvPanel_AfterSelect);
			// 
			// frmClient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(368, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.statusBar1});
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "frmClient";
			this.Text = "Client";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.frmClient_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		static void Main()
		{
			Application.Run(new frmClient());
		}

		private void frmClient_Load(object sender, System.EventArgs e)
		{
			//Global.trvNode=new TreeNode("Not Connected..");
			
			frmSplash f=new frmSplash();
			f.ShowDialog(this);
			this.WindowState=FormWindowState.Maximized;
			this.Show();

			ChannelServices.RegisterChannel(new TcpChannel(),false);
			Global.frmMain=this;
			Global.trvNode=trvPanel.Nodes;

			Global.frmCon=new frmConnect();
			Global.frmCon.MdiParent=this;
			Global.frmCon.Show();
			SetStatus("Not Connected",0);
		}

		public void SetStatus(string s,int index)
		{
			statusBar1.Panels[index].Width=200;
			statusBar1.Panels[index].Text=s;
		}
		public void SetTree(string machine)
		{
			trvPanel.Nodes.Add(machine);
		}
		private void mnuConnect_Click(object sender, System.EventArgs e)
		{
			Global.ShowConnect();
			mnuConnect.Enabled=false;
			cmnuDisconnect.Enabled=true;
			
		}

		private void trvPanel_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			switch(trvPanel.SelectedNode.Text)
			{
				case "Processes":
					//if(Global.frmDesktop!=null || !Global.frmDesktop.Is) Global.frmDesktop.Close();
					Global.ShowTask(1);
					break;

				case "Applications":
					//if(Global.frmDesktop!=null || !Global.frmDesktop.IsDisposed) Global.frmDesktop.Close();
					Global.ShowTask(2);
					break;

				case "Services":
					//if(Global.frmDesktop!=null || !Global.frmDesktop.IsDisposed) Global.frmDesktop.Close();
					Global.ShowServices();
					break;
				
				case "Event Logs":
					//if(Global.frmDesktop!=null || !Global.frmDesktop.IsDisposed) Global.frmDesktop.Close();
					Global.ShowEvents(1);
					break;

				case "Application":
					//if(Global.frmDesktop!=null || !Global.frmDesktop.IsDisposed) Global.frmDesktop.Close();
					Global.ShowEvents(1);
					break;
	
				case "Security":
					//if(Global.frmDesktop!=null || !Global.frmDesktop.IsDisposed) Global.frmDesktop.Close();
					Global.ShowEvents(2);
					break;

				case "System":
					//if(Global.frmDesktop!=null || !Global.frmDesktop.IsDisposed) Global.frmDesktop.Close();
					Global.ShowEvents(3);
					break;

				case "Desktop":
					Global.ShowDesktop();
					break;
			}
		}

		private void mnuActionRefresh_Click(object sender, System.EventArgs e)
		{
			if(ActiveMdiChild==Global.frmServices)
			{
				Global.frmServices.nRefresh();
			}
			else if(ActiveMdiChild==Global.frmTasks)
			{
				Global.frmTasks.nRefresh();
			}
		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void cmnuDisconnect_Click(object sender, System.EventArgs e)
		{
			if(trvPanel.SelectedNode.Index==0)
			{
				for(int i=0;i<MdiChildren.Length;i++)
				{
					MdiChildren[i].Close();
				}
				Global.trvNode.Clear();
				mnuConnect.Enabled=true;
			
				cmnuDisconnect.Enabled=false;
			}
			SetStatus("Disconnected",0);
		}

		private void cmnuRefresh_Click(object sender, System.EventArgs e)
		{
		
		}

		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			frmAbout abt=new frmAbout();
			abt.ShowDialog(this);
		}

	}
}
