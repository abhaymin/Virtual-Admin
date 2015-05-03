using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Diagnostics;
namespace Client
{
	/// <summary>
	/// Summary description for frmRTaskManager.
	/// </summary>
	public class frmRTaskManager : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader Process;
		private System.Windows.Forms.ColumnHeader UserName;
		private System.Windows.Forms.ColumnHeader CPU;
		private System.Windows.Forms.ColumnHeader MemUsage;
		private System.Windows.Forms.ColumnHeader Threads;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ListView lstvwProcesses;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TabPage tabProcesses;
		private System.Windows.Forms.TabPage tabApps;
		private System.Windows.Forms.ImageList imglst;
		private System.Windows.Forms.ColumnHeader AppName;
		private System.Windows.Forms.ColumnHeader AppStatus;
		private System.Windows.Forms.ListView lstvwApps;
		private System.Windows.Forms.ContextMenu mnuProc;
		private System.Windows.Forms.MenuItem mnuTerminate;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuRefresh;
		private System.Windows.Forms.ContextMenu cmnuApp;
		private System.Windows.Forms.MenuItem mnuEndTask;
		private System.Windows.Forms.ColumnHeader AppPid;
		private System.ComponentModel.IContainer components;

		public frmRTaskManager()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmRTaskManager));
			this.Process = new System.Windows.Forms.ColumnHeader();
			this.UserName = new System.Windows.Forms.ColumnHeader();
			this.CPU = new System.Windows.Forms.ColumnHeader();
			this.MemUsage = new System.Windows.Forms.ColumnHeader();
			this.Threads = new System.Windows.Forms.ColumnHeader();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabProcesses = new System.Windows.Forms.TabPage();
			this.lstvwProcesses = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.mnuProc = new System.Windows.Forms.ContextMenu();
			this.mnuTerminate = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuRefresh = new System.Windows.Forms.MenuItem();
			this.tabApps = new System.Windows.Forms.TabPage();
			this.lstvwApps = new System.Windows.Forms.ListView();
			this.AppName = new System.Windows.Forms.ColumnHeader();
			this.AppPid = new System.Windows.Forms.ColumnHeader();
			this.AppStatus = new System.Windows.Forms.ColumnHeader();
			this.cmnuApp = new System.Windows.Forms.ContextMenu();
			this.mnuEndTask = new System.Windows.Forms.MenuItem();
			this.imglst = new System.Windows.Forms.ImageList(this.components);
			this.tabControl1.SuspendLayout();
			this.tabProcesses.SuspendLayout();
			this.tabApps.SuspendLayout();
			this.SuspendLayout();
			// 
			// Process
			// 
			this.Process.Text = "Process";
			this.Process.Width = 56;
			// 
			// UserName
			// 
			this.UserName.Text = "UserName";
			this.UserName.Width = 71;
			// 
			// CPU
			// 
			this.CPU.Text = "CPU";
			this.CPU.Width = 36;
			// 
			// MemUsage
			// 
			this.MemUsage.Text = "MemUsage";
			this.MemUsage.Width = 74;
			// 
			// Threads
			// 
			this.Threads.Text = "Threads";
			this.Threads.Width = 167;
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabProcesses,
																					  this.tabApps});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.ImageList = this.imglst;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(416, 266);
			this.tabControl1.TabIndex = 0;
			// 
			// tabProcesses
			// 
			this.tabProcesses.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.lstvwProcesses});
			this.tabProcesses.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabProcesses.ImageIndex = 0;
			this.tabProcesses.Location = new System.Drawing.Point(4, 26);
			this.tabProcesses.Name = "tabProcesses";
			this.tabProcesses.Size = new System.Drawing.Size(408, 236);
			this.tabProcesses.TabIndex = 0;
			this.tabProcesses.Text = "Processes";
			// 
			// lstvwProcesses
			// 
			this.lstvwProcesses.AllowColumnReorder = true;
			this.lstvwProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							 this.columnHeader1,
																							 this.columnHeader3,
																							 this.columnHeader4,
																							 this.columnHeader6});
			this.lstvwProcesses.ContextMenu = this.mnuProc;
			this.lstvwProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstvwProcesses.FullRowSelect = true;
			this.lstvwProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lstvwProcesses.Name = "lstvwProcesses";
			this.lstvwProcesses.Size = new System.Drawing.Size(408, 236);
			this.lstvwProcesses.TabIndex = 2;
			this.lstvwProcesses.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Process";
			this.columnHeader1.Width = 56;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "CPU";
			this.columnHeader3.Width = 36;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "MemUsage";
			this.columnHeader4.Width = 74;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Process ID";
			// 
			// mnuProc
			// 
			this.mnuProc.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuTerminate,
																					this.menuItem1,
																					this.mnuRefresh});
			// 
			// mnuTerminate
			// 
			this.mnuTerminate.Index = 0;
			this.mnuTerminate.Text = "&Terminate Process";
			this.mnuTerminate.Click += new System.EventHandler(this.mnuTerminate_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// mnuRefresh
			// 
			this.mnuRefresh.Index = 2;
			this.mnuRefresh.Text = "&Refresh";
			this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
			// 
			// tabApps
			// 
			this.tabApps.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.lstvwApps});
			this.tabApps.ImageIndex = 4;
			this.tabApps.Location = new System.Drawing.Point(4, 26);
			this.tabApps.Name = "tabApps";
			this.tabApps.Size = new System.Drawing.Size(408, 236);
			this.tabApps.TabIndex = 1;
			this.tabApps.Text = "Applications";
			// 
			// lstvwApps
			// 
			this.lstvwApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.AppName,
																						this.AppPid,
																						this.AppStatus});
			this.lstvwApps.ContextMenu = this.cmnuApp;
			this.lstvwApps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstvwApps.Name = "lstvwApps";
			this.lstvwApps.Size = new System.Drawing.Size(408, 236);
			this.lstvwApps.TabIndex = 0;
			this.lstvwApps.View = System.Windows.Forms.View.Details;
			// 
			// AppName
			// 
			this.AppName.Text = "Application";
			this.AppName.Width = 74;
			// 
			// AppPid
			// 
			this.AppPid.Text = "Process ID";
			this.AppPid.Width = 62;
			// 
			// AppStatus
			// 
			this.AppStatus.Text = "Respondng";
			this.AppStatus.Width = 268;
			// 
			// cmnuApp
			// 
			this.cmnuApp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuEndTask});
			// 
			// mnuEndTask
			// 
			this.mnuEndTask.Index = 0;
			this.mnuEndTask.Text = "&End Task";
			this.mnuEndTask.Click += new System.EventHandler(this.mnuEndTask_Click);
			// 
			// imglst
			// 
			this.imglst.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imglst.ImageSize = new System.Drawing.Size(16, 16);
			this.imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst.ImageStream")));
			this.imglst.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// frmRTaskManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(416, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1});
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmRTaskManager";
			this.Text = "Processes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmRTaskManager_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabProcesses.ResumeLayout(false);
			this.tabApps.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmRTaskManager_Load(object sender, System.EventArgs e)
		{
			ListProcesses();
		}
		public void nRefresh()
		{
			ListProcesses();
		}
		public void ShowTab(int tab)
		{
			switch(tab)
			{
				case 1:
					//tabProcesses.Show();
					tabControl1.SelectedTab=tabProcesses;
					break;

				case 2:
					tabControl1.SelectedTab=tabApps;
					//tabApps.Show();
					break;
			}
		}
		public void ListProcesses()
		{
			string[] procval=new string[6];
			try
			{
				System.Diagnostics.Process[] p=Global.rObj.rProc.GetRProcesses();
				lstvwProcesses.Items.Clear();
				lstvwApps.Items.Clear();
				for(int i=0;i<p.Length;i++)
				{
                    if (p[i].ProcessName.CompareTo("Idle") == 0) continue;
					procval[0]=p[i].ProcessName;
				
					procval[1]=p[i].TotalProcessorTime.Seconds.ToString();
				
					procval[2]=p[i].WorkingSet64.ToString();
					
					procval[3]=p[i].Id.ToString();
					lstvwProcesses.Items.Add(new ListViewItem(procval));
					if(p[i].MainWindowTitle.Length>0)
					{
						AppName.Width=-2;
						AppPid.Width=-2;
					
						lstvwApps.Items.Add
							(new ListViewItem
							(new string[]{p[i].MainWindowTitle,p[i].Id.ToString(),p[i].Responding.ToString()}));
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}

		private void mnuTerminate_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(MessageBox.Show("End Process "+lstvwProcesses.SelectedItems[0].SubItems[0].Text+"!","Terminater Process",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1)
					== DialogResult.Yes)
				{
					int pid=int.Parse(lstvwProcesses.SelectedItems[0].SubItems[3].Text);
					if(Global.rObj.rProc.RKillProcess(pid))
					{
						ListProcesses();
					}
					else
					{
						MessageBox.Show("End Process "+lstvwProcesses.SelectedItems[0].SubItems[0].Text+"!","Terminater Process",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}


		}

		private void mnuRefresh_Click(object sender, System.EventArgs e)
		{
			ListProcesses();
		}

		private void mnuEndTask_Click(object sender, System.EventArgs e)
		{
			try
			{
				int pid=int.Parse(lstvwApps.SelectedItems[0].SubItems[1].Text);
				if(Global.rObj.rProc.RKillProcess(pid))
				{
					ListProcesses();
				}
				else
				{
					MessageBox.Show("End Task "+lstvwApps.SelectedItems[0].SubItems[0].Text+"!","End Task - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}

		}
	}
}
