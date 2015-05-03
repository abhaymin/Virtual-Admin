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
	/// Summary description for frmConnect.
	/// </summary>
	public class frmConnect : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRemoteMachine;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmConnect()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmConnect));
			this.label1 = new System.Windows.Forms.Label();
			this.txtRemoteMachine = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Location = new System.Drawing.Point(104, 120);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Connect To";
			// 
			// txtRemoteMachine
			// 
			this.txtRemoteMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRemoteMachine.Location = new System.Drawing.Point(208, 120);
			this.txtRemoteMachine.Name = "txtRemoteMachine";
			this.txtRemoteMachine.Size = new System.Drawing.Size(144, 21);
			this.txtRemoteMachine.TabIndex = 1;
			this.txtRemoteMachine.Text = "localhost";
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConnect.Location = new System.Drawing.Point(136, 160);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(160, 24);
			this.btnConnect.TabIndex = 2;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.pictureBox2,
																				 this.label2});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 80);
			this.panel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(136, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Connect To";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(72, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(40, 8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// frmConnect
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(480, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox1,
																		  this.panel1,
																		  this.btnConnect,
																		  this.txtRemoteMachine,
																		  this.label1});
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmConnect";
			this.Text = "Connect To";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmConnect_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			Global.trvNode.Clear();
			try
			{
				Global.RemoteMachine=txtRemoteMachine.Text;
				TreeNode trvNode;
				
				Global.rObj.rProc=(RemoteObject.RemoteProcesses)Activator.GetObject(
					typeof(RemoteObject.RemoteProcesses),
					"tcp://" + Global.RemoteMachine +":9090/RemoteObject.RemoteProcesses");

				Global.rObj.rServ=(RemoteObject.RemoteServices)Activator.GetObject(
					typeof(RemoteObject.RemoteServices),
					"tcp://" + Global.RemoteMachine +":9090/RemoteObject.RemoteServices");

				Global.rObj.eEve=(RemoteObject.Eves)Activator.GetObject(typeof(RemoteObject.Eves),"tcp://"+Global.RemoteMachine+":9090/RemoteObject.Eves");


				Global.rObj.rProc.GetRProcesses();

 				trvNode=new TreeNode(txtRemoteMachine.Text,1,1);

				Global.trvNode.Add(trvNode);

				int tmpnd=trvNode.Nodes.Add(new TreeNode("Processes/Applications",0,0));
				trvNode.Nodes[tmpnd].Nodes.Add(new TreeNode("Processes",2,2));
				trvNode.Nodes[tmpnd].Nodes.Add(new TreeNode("Applications",14,14));

				trvNode.Nodes.Add(new TreeNode("Services",2,2));
				
				trvNode.Nodes.Add(new TreeNode("Desktop",4,4));
				
				 tmpnd=trvNode.Nodes.Add(new TreeNode("Event Logs",15,15));
				trvNode.Nodes[tmpnd].Nodes.Add(new TreeNode("Application",14,14));
				trvNode.Nodes[tmpnd].Nodes.Add(new TreeNode("Security",9,9));
				trvNode.Nodes[tmpnd].Nodes.Add(new TreeNode("System",15,15));
				
				//trvNode.Nodes.Add(new TreeNode("Current User",3,3));

				Global.frmMain.SetStatus("Connected to \\\\"+Global.RemoteMachine,0);

				//this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Unable to connect to Remote Machine! \n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

			}

		}

		private void frmConnect_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
