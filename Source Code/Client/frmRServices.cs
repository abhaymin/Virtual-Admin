using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.ServiceProcess;

namespace Client
{
	/// <summary>
	/// Summary description for frmRServices.
	/// </summary>
	public class frmRServices : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMachine;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView lstvwServices;
		private System.Windows.Forms.ColumnHeader clmName;
		private System.Windows.Forms.ColumnHeader clmStatus;
		private System.Windows.Forms.ColumnHeader clmActualName;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenu cmnuServices;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem mnuStart;
		private System.Windows.Forms.MenuItem mnuStop;
		private System.Windows.Forms.MenuItem mnuPause;
		private System.Windows.Forms.MenuItem mnuResume;
		private System.Windows.Forms.MenuItem mnuRestart;
		private System.Windows.Forms.MenuItem mnuRefresh;
		private System.ComponentModel.IContainer components;

		public frmRServices()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmRServices));
			this.lstvwServices = new System.Windows.Forms.ListView();
			this.clmName = new System.Windows.Forms.ColumnHeader();
			this.clmStatus = new System.Windows.Forms.ColumnHeader();
			this.clmActualName = new System.Windows.Forms.ColumnHeader();
			this.cmnuServices = new System.Windows.Forms.ContextMenu();
			this.mnuStart = new System.Windows.Forms.MenuItem();
			this.mnuStop = new System.Windows.Forms.MenuItem();
			this.mnuPause = new System.Windows.Forms.MenuItem();
			this.mnuResume = new System.Windows.Forms.MenuItem();
			this.mnuRestart = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.mnuRefresh = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblMachine = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstvwServices
			// 
			this.lstvwServices.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lstvwServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							this.clmName,
																							this.clmStatus,
																							this.clmActualName});
			this.lstvwServices.ContextMenu = this.cmnuServices;
			this.lstvwServices.FullRowSelect = true;
			this.lstvwServices.Location = new System.Drawing.Point(0, 72);
			this.lstvwServices.MultiSelect = false;
			this.lstvwServices.Name = "lstvwServices";
			this.lstvwServices.Size = new System.Drawing.Size(360, 192);
			this.lstvwServices.SmallImageList = this.imageList1;
			this.lstvwServices.TabIndex = 0;
			this.lstvwServices.View = System.Windows.Forms.View.Details;
			this.lstvwServices.SelectedIndexChanged += new System.EventHandler(this.lstvwServices_SelectedIndexChanged);
			// 
			// clmName
			// 
			this.clmName.Text = "Name";
			// 
			// clmStatus
			// 
			this.clmStatus.Text = "Status";
			// 
			// clmActualName
			// 
			this.clmActualName.Text = "Actual Name";
			// 
			// cmnuServices
			// 
			this.cmnuServices.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnuStart,
																						 this.mnuStop,
																						 this.mnuPause,
																						 this.mnuResume,
																						 this.mnuRestart,
																						 this.menuItem6,
																						 this.mnuRefresh});
			// 
			// mnuStart
			// 
			this.mnuStart.Index = 0;
			this.mnuStart.Text = "Start";
			this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
			// 
			// mnuStop
			// 
			this.mnuStop.Index = 1;
			this.mnuStop.Text = "Stop";
			this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
			// 
			// mnuPause
			// 
			this.mnuPause.Index = 2;
			this.mnuPause.Text = "Pause";
			this.mnuPause.Click += new System.EventHandler(this.mnuPause_Click);
			// 
			// mnuResume
			// 
			this.mnuResume.Index = 3;
			this.mnuResume.Text = "Resume";
			this.mnuResume.Click += new System.EventHandler(this.mnuResume_Click);
			// 
			// mnuRestart
			// 
			this.mnuRestart.Index = 4;
			this.mnuRestart.Text = "Restart";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.Text = "-";
			// 
			// mnuRefresh
			// 
			this.mnuRefresh.Index = 6;
			this.mnuRefresh.Text = "Refresh";
			this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.pictureBox1,
																				 this.lblMachine,
																				 this.label1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 72);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// lblMachine
			// 
			this.lblMachine.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMachine.AutoSize = true;
			this.lblMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblMachine.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMachine.Location = new System.Drawing.Point(116, 42);
			this.lblMachine.Name = "lblMachine";
			this.lblMachine.Size = new System.Drawing.Size(0, 16);
			this.lblMachine.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Services ";
			// 
			// frmRServices
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(360, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.lstvwServices});
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmRServices";
			this.Text = "Services";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmRServices_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void frmRServices_Load(object sender, System.EventArgs e)
		{
			lblMachine.Text=Global.RemoteMachine;
			ListServices();
		}
		public void ListServices()
		{
			string[] list=new string[5];
			ListViewItem lsti;
			try
			{
				ServiceController[] ser=Global.rObj.rServ.GetRServices();
				lstvwServices.Items.Clear();
				for(int i=0;i<ser.Length;i++)
				{
					list[0]=ser[i].DisplayName;
					list[1]=ser[i].Status.ToString();
					list[2]=ser[i].ServiceName;
					clmName.Width=-2;
					clmActualName.Width=-2;
				
					lsti=lstvwServices.Items.Add(new ListViewItem(list,0));
					switch(ser[i].Status)
					{
						case ServiceControllerStatus.Running:
							lsti.BackColor=Color.FromArgb(200,200,240);
							break;

						default:
							lsti.BackColor=Color.FromArgb(255,255,255);
							break;
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}

		private void lstvwServices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lstvwServices.SelectedItems.Count>0)
			switch(lstvwServices.SelectedItems[0].SubItems[1].Text)
			{
				case "Running":
					mnuStart.Enabled=false;
					mnuResume.Enabled=false;
					mnuStop.Enabled=true;
					mnuRestart.Enabled=true;
					mnuPause.Enabled=true;
					break;

				case "Paused":
					mnuStart.Enabled=false;
					mnuResume.Enabled=true;
					mnuStop.Enabled=true;
					mnuRestart.Enabled=true;
					mnuPause.Enabled=false;
					break;

				case "Stopped":
					mnuStart.Enabled=true;
					mnuResume.Enabled=false;
					mnuStop.Enabled=false;
					mnuRestart.Enabled=false;
					mnuPause.Enabled=false;
					break;

				case "StopPending":
					mnuStart.Enabled=false;
					mnuResume.Enabled=false;
					mnuStop.Enabled=false;
					mnuRestart.Enabled=false;
					mnuPause.Enabled=false;
					break;
				
				case "StartPending":
					mnuStart.Enabled=false;
					mnuResume.Enabled=false;
					mnuStop.Enabled=false;
					mnuRestart.Enabled=false;
					mnuPause.Enabled=false;
					break;
					
				case "PausePending":
					mnuStart.Enabled=false;
					mnuResume.Enabled=true;
					mnuStop.Enabled=true;
					mnuRestart.Enabled=true;
					mnuPause.Enabled=false;
					break;
				
				case "ContinuePending":
					mnuStart.Enabled=false;
					mnuResume.Enabled=false;
					mnuStop.Enabled=false;
					mnuRestart.Enabled=false;
					mnuPause.Enabled=false;
					break;
			}
		}
		public void nRefresh()
		{
			ListServices();
		}
		private void mnuRefresh_Click(object sender, System.EventArgs e)
		{
			ListServices();
		}

		private void mnuStart_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(Global.rObj.rServ.RStartService(lstvwServices.SelectedItems[0].SubItems[2].Text))
				{
					ListServices();
				}
				else
				{
					MessageBox.Show("The service cannot be started!","Service not started!",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}

		private void mnuStop_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(Global.rObj.rServ.RStopService(lstvwServices.SelectedItems[0].SubItems[2].Text))
				{
					ListServices();
				}
				else
				{
					MessageBox.Show("The service cannot be stopped!","Service !",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}

		private void mnuResume_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(Global.rObj.rServ.RResumeService(lstvwServices.SelectedItems[0].SubItems[2].Text))
				{
					ListServices();
				}
				else
				{
					MessageBox.Show("The service cannot be resumed!\n","Service !",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}

		private void mnuPause_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(Global.rObj.rServ.RPauseService(lstvwServices.SelectedItems[0].SubItems[2].Text))
				{
					ListServices();
				}
				else
				{
					MessageBox.Show("The service cannot be Paused!","Service !",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}
	}
}
