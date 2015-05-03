using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using RemoteObject;

namespace Client
{
	/// <summary>
	/// Summary description for frmRDesktopViewer.
	/// </summary>
	public class frmRDesktopViewer : System.Windows.Forms.Form
	{
		private Client.RemoteDesktopControl remoteDesktopControl1;
		private Thread MonitorThread = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRDesktopViewer()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmRDesktopViewer));
			this.remoteDesktopControl1 = new Client.RemoteDesktopControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// remoteDesktopControl1
			// 
			this.remoteDesktopControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.remoteDesktopControl1.AutoScroll = true;
			this.remoteDesktopControl1.Location = new System.Drawing.Point(0, 72);
			this.remoteDesktopControl1.Name = "remoteDesktopControl1";
			this.remoteDesktopControl1.Size = new System.Drawing.Size(600, 448);
			this.remoteDesktopControl1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.pictureBox1,
																				 this.checkBox1,
																				 this.label1});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 72);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(24, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.checkBox1.Location = new System.Drawing.Point(512, 48);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(72, 16);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Control";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(120, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Desktop  of";
			// 
			// frmRDesktopViewer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(600, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.remoteDesktopControl1});
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmRDesktopViewer";
			this.Text = "Remote Destop";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmRDesktopViewer_Closing);
			this.Load += new System.EventHandler(this.frmRDesktopViewer_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Monitor()
		{
			while (true)
			{
				remoteDesktopControl1.UpdateDisplay();
			}
		}


		private void frmRDesktopViewer_Load(object sender, System.EventArgs e)
		{
			try
			{
		
					remoteDesktopControl1.Initialize(Global.RemoteMachine);
					label1.Text = "Desktop of \\\\" + Global.RemoteMachine;

				MonitorThread = new Thread(new ThreadStart(Monitor));
				MonitorThread.Start();
			}
			catch(Exception)
			{
				MessageBox.Show("Event Error!!","Error!!");
				Application.Exit();
			}
			
		}

		private void frmRDesktopViewer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				System.Threading.Monitor.Enter(remoteDesktopControl1);

				//				// Cancel the monitoring by aborting its thread.
				//				// Then the program can close.
				MonitorThread.Abort();

				System.Threading.Monitor.Exit(remoteDesktopControl1);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}

		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				remoteDesktopControl1.SetControl(((CheckBox) sender).Checked);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}
	
	}
}
