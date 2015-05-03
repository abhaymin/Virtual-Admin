using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client
{
	/// <summary>
	/// Summary description for frmEveMesssage.
	/// </summary>
	public class frmEveMesssage : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtEveMessage;
		private System.Windows.Forms.Button btnOk;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmEveMesssage()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public frmEveMesssage(string msg)
		{
				InitializeComponent();
			txtEveMessage.Text=msg;
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
			this.txtEveMessage = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEveMessage
			// 
			this.txtEveMessage.Location = new System.Drawing.Point(8, 16);
			this.txtEveMessage.Multiline = true;
			this.txtEveMessage.Name = "txtEveMessage";
			this.txtEveMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtEveMessage.Size = new System.Drawing.Size(232, 192);
			this.txtEveMessage.TabIndex = 0;
			this.txtEveMessage.Text = "";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(160, 224);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Ok";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// frmEveMesssage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(248, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnOk,
																		  this.txtEveMessage});
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frmEveMesssage";
			this.Text = "Event Message";
			this.Load += new System.EventHandler(this.frmEveMesssage_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmEveMesssage_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
