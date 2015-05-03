using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace Client
{
	/// <summary>
	/// Summary description for frmEvent.
	/// </summary>
	public class frmEvent : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tab;
		private System.Windows.Forms.TabPage App;
		private System.Windows.Forms.TabPage Sec;
		private System.Windows.Forms.TabPage Sys;
		private System.Windows.Forms.ColumnHeader Typ;
		private System.Windows.Forms.ColumnHeader Dat;
		private System.Windows.Forms.ColumnHeader Tim;
		private System.Windows.Forms.ColumnHeader Sou;
		private System.Windows.Forms.ColumnHeader Cat;
		private System.Windows.Forms.ColumnHeader Eve;
		private System.Windows.Forms.ColumnHeader Use;
		private System.Windows.Forms.ColumnHeader Com;
		private System.Windows.Forms.ListView lstEvent;
		private System.Windows.Forms.ListView lstEvent1;
		private System.Windows.Forms.ColumnHeader Typ1;
		private System.Windows.Forms.ColumnHeader Dat1;
		private System.Windows.Forms.ColumnHeader Tim1;
		private System.Windows.Forms.ColumnHeader Sou1;
		private System.Windows.Forms.ColumnHeader Cat1;
		private System.Windows.Forms.ColumnHeader Eve1;
		private System.Windows.Forms.ColumnHeader Use1;
		private System.Windows.Forms.ColumnHeader Com1;
		private System.Windows.Forms.ListView lstEvent2;
		private System.Windows.Forms.ColumnHeader Typ2;
		private System.Windows.Forms.ColumnHeader Dat2;
		private System.Windows.Forms.ColumnHeader Tim2;
		private System.Windows.Forms.ColumnHeader Sou2;
		private System.Windows.Forms.ColumnHeader Cat2;
		private System.Windows.Forms.ColumnHeader Eve2;
		private System.Windows.Forms.ColumnHeader Use2;
		private System.Windows.Forms.ColumnHeader Com2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader Mes;
        private ProgressBar progressBar1;
        private ProgressBar pbarLoading;
		private System.ComponentModel.IContainer components;

		public frmEvent()
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
            try
            {
                this.components = new System.ComponentModel.Container();
                System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvent));
                this.tab = new System.Windows.Forms.TabControl();
                this.App = new System.Windows.Forms.TabPage();
                this.lstEvent = new System.Windows.Forms.ListView();
                this.Typ = new System.Windows.Forms.ColumnHeader();
                this.Dat = new System.Windows.Forms.ColumnHeader();
                this.Tim = new System.Windows.Forms.ColumnHeader();
                this.Sou = new System.Windows.Forms.ColumnHeader();
                this.Cat = new System.Windows.Forms.ColumnHeader();
                this.Eve = new System.Windows.Forms.ColumnHeader();
                this.Use = new System.Windows.Forms.ColumnHeader();
                this.Com = new System.Windows.Forms.ColumnHeader();
                this.Mes = new System.Windows.Forms.ColumnHeader();
                this.imageList1 = new System.Windows.Forms.ImageList(this.components);
                this.Sec = new System.Windows.Forms.TabPage();
                this.lstEvent1 = new System.Windows.Forms.ListView();
                this.Typ1 = new System.Windows.Forms.ColumnHeader();
                this.Dat1 = new System.Windows.Forms.ColumnHeader();
                this.Tim1 = new System.Windows.Forms.ColumnHeader();
                this.Sou1 = new System.Windows.Forms.ColumnHeader();
                this.Cat1 = new System.Windows.Forms.ColumnHeader();
                this.Eve1 = new System.Windows.Forms.ColumnHeader();
                this.Use1 = new System.Windows.Forms.ColumnHeader();
                this.Com1 = new System.Windows.Forms.ColumnHeader();
                this.Sys = new System.Windows.Forms.TabPage();
                this.lstEvent2 = new System.Windows.Forms.ListView();
                this.Typ2 = new System.Windows.Forms.ColumnHeader();
                this.Dat2 = new System.Windows.Forms.ColumnHeader();
                this.Tim2 = new System.Windows.Forms.ColumnHeader();
                this.Sou2 = new System.Windows.Forms.ColumnHeader();
                this.Cat2 = new System.Windows.Forms.ColumnHeader();
                this.Eve2 = new System.Windows.Forms.ColumnHeader();
                this.Use2 = new System.Windows.Forms.ColumnHeader();
                this.Com2 = new System.Windows.Forms.ColumnHeader();
                this.panel1 = new System.Windows.Forms.Panel();
                this.label1 = new System.Windows.Forms.Label();
                this.pictureBox1 = new System.Windows.Forms.PictureBox();
                this.progressBar1 = new System.Windows.Forms.ProgressBar();
                this.pbarLoading = new System.Windows.Forms.ProgressBar();
                this.tab.SuspendLayout();
                this.App.SuspendLayout();
                this.Sec.SuspendLayout();
                this.Sys.SuspendLayout();
                this.panel1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                this.SuspendLayout();
                // 
                // tab
                // 
                this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
                this.tab.Controls.Add(this.App);
                this.tab.Controls.Add(this.Sec);
                this.tab.Controls.Add(this.Sys);
                this.tab.Location = new System.Drawing.Point(0, 96);
                this.tab.Name = "tab";
                this.tab.SelectedIndex = 0;
                this.tab.Size = new System.Drawing.Size(863, 503);
                this.tab.TabIndex = 0;
                this.tab.Click += new System.EventHandler(this.tab_Click);
                this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
                // 
                // App
                // 
                this.App.Controls.Add(this.progressBar1);
                this.App.Controls.Add(this.lstEvent);
                this.App.Location = new System.Drawing.Point(4, 25);
                this.App.Name = "App";
                this.App.Size = new System.Drawing.Size(855, 474);
                this.App.TabIndex = 0;
                this.App.Text = "Application";
                // 
                // lstEvent
                // 
                this.lstEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Typ,
            this.Dat,
            this.Tim,
            this.Sou,
            this.Cat,
            this.Eve,
            this.Use,
            this.Com,
            this.Mes});
                this.lstEvent.Dock = System.Windows.Forms.DockStyle.Fill;
                this.lstEvent.FullRowSelect = true;
                this.lstEvent.Location = new System.Drawing.Point(0, 0);
                this.lstEvent.MultiSelect = false;
                this.lstEvent.Name = "lstEvent";
                this.lstEvent.Size = new System.Drawing.Size(855, 474);
                this.lstEvent.SmallImageList = this.imageList1;
                this.lstEvent.TabIndex = 0;
                this.lstEvent.UseCompatibleStateImageBehavior = false;
                this.lstEvent.View = System.Windows.Forms.View.Details;
                this.lstEvent.DoubleClick += new System.EventHandler(this.lstEvent_DoubleClick);
                // 
                // Typ
                // 
                this.Typ.Text = "Type";
                // 
                // Dat
                // 
                this.Dat.Text = "Date";
                // 
                // Tim
                // 
                this.Tim.Text = "Time";
                // 
                // Sou
                // 
                this.Sou.Text = "Source";
                // 
                // Cat
                // 
                this.Cat.Text = "Category";
                // 
                // Eve
                // 
                this.Eve.Text = "Event";
                // 
                // Use
                // 
                this.Use.Text = "User";
                // 
                // Com
                // 
                this.Com.Text = "Computer";
                // 
                // Mes
                // 
                this.Mes.Text = "Message";
                this.Mes.Width = 60;// ((int)(configurationAppSettings.GetValue("0", typeof(int))));
                // 
                // imageList1
                // 
                this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
                this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
                this.imageList1.Images.SetKeyName(0, "");
                this.imageList1.Images.SetKeyName(1, "");
                this.imageList1.Images.SetKeyName(2, "");
                this.imageList1.Images.SetKeyName(3, "");
                // 
                // Sec
                // 
                this.Sec.Controls.Add(this.lstEvent1);
                this.Sec.Location = new System.Drawing.Point(4, 25);
                this.Sec.Name = "Sec";
                this.Sec.Size = new System.Drawing.Size(584, 299);
                this.Sec.TabIndex = 1;
                this.Sec.Text = "Security";
                // 
                // lstEvent1
                // 
                this.lstEvent1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Typ1,
            this.Dat1,
            this.Tim1,
            this.Sou1,
            this.Cat1,
            this.Eve1,
            this.Use1,
            this.Com1});
                this.lstEvent1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.lstEvent1.FullRowSelect = true;
                this.lstEvent1.Location = new System.Drawing.Point(0, 0);
                this.lstEvent1.MultiSelect = false;
                this.lstEvent1.Name = "lstEvent1";
                this.lstEvent1.Size = new System.Drawing.Size(584, 299);
                this.lstEvent1.SmallImageList = this.imageList1;
                this.lstEvent1.TabIndex = 1;
                this.lstEvent1.UseCompatibleStateImageBehavior = false;
                this.lstEvent1.View = System.Windows.Forms.View.Details;
                this.lstEvent1.DoubleClick += new System.EventHandler(this.lstEvent1_DoubleClick);
                // 
                // Typ1
                // 
                this.Typ1.Text = "Type";
                // 
                // Dat1
                // 
                this.Dat1.Text = "Date";
                // 
                // Tim1
                // 
                this.Tim1.Text = "Time";
                // 
                // Sou1
                // 
                this.Sou1.Text = "Source";
                // 
                // Cat1
                // 
                this.Cat1.Text = "Category";
                // 
                // Eve1
                // 
                this.Eve1.Text = "Event";
                // 
                // Use1
                // 
                this.Use1.Text = "User";
                // 
                // Com1
                // 
                this.Com1.Text = "Computer";
                // 
                // Sys
                // 
                this.Sys.Controls.Add(this.lstEvent2);
                this.Sys.Location = new System.Drawing.Point(4, 25);
                this.Sys.Name = "Sys";
                this.Sys.Size = new System.Drawing.Size(584, 299);
                this.Sys.TabIndex = 2;
                this.Sys.Text = "System";
                // 
                // lstEvent2
                // 
                this.lstEvent2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Typ2,
            this.Dat2,
            this.Tim2,
            this.Sou2,
            this.Cat2,
            this.Eve2,
            this.Use2,
            this.Com2});
                this.lstEvent2.Dock = System.Windows.Forms.DockStyle.Fill;
                this.lstEvent2.FullRowSelect = true;
                this.lstEvent2.Location = new System.Drawing.Point(0, 0);
                this.lstEvent2.MultiSelect = false;
                this.lstEvent2.Name = "lstEvent2";
                this.lstEvent2.Size = new System.Drawing.Size(584, 299);
                this.lstEvent2.SmallImageList = this.imageList1;
                this.lstEvent2.TabIndex = 1;
                this.lstEvent2.UseCompatibleStateImageBehavior = false;
                this.lstEvent2.View = System.Windows.Forms.View.Details;
                this.lstEvent2.DoubleClick += new System.EventHandler(this.lstEvent2_DoubleClick);
                // 
                // Typ2
                // 
                this.Typ2.Text = "Type";
                // 
                // Dat2
                // 
                this.Dat2.Text = "Date";
                // 
                // Tim2
                // 
                this.Tim2.Text = "Time";
                // 
                // Sou2
                // 
                this.Sou2.Text = "Source";
                // 
                // Cat2
                // 
                this.Cat2.Text = "Category";
                // 
                // Eve2
                // 
                this.Eve2.Text = "Event";
                // 
                // Use2
                // 
                this.Use2.Text = "User";
                // 
                // Com2
                // 
                this.Com2.Text = "Computer";
                // 
                // panel1
                // 
                this.panel1.BackColor = System.Drawing.Color.White;
                this.panel1.Controls.Add(this.label1);
                this.panel1.Controls.Add(this.pictureBox1);
                this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                this.panel1.Location = new System.Drawing.Point(0, 0);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(863, 88);
                this.panel1.TabIndex = 1;
                // 
                // label1
                // 
                this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.Location = new System.Drawing.Point(152, 32);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(144, 32);
                this.label1.TabIndex = 1;
                this.label1.Text = "Event Logs";
                // 
                // pictureBox1
                // 
                this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                this.pictureBox1.Location = new System.Drawing.Point(40, 8);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(64, 64);
                this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox1.TabIndex = 0;
                this.pictureBox1.TabStop = false;
                // 
                // progressBar1
                // 
                this.progressBar1.Location = new System.Drawing.Point(681, 496);
                this.progressBar1.Name = "progressBar1";
                this.progressBar1.Size = new System.Drawing.Size(8, 8);
                this.progressBar1.TabIndex = 1;
                // 
                // pbarLoading
                // 
                this.pbarLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.pbarLoading.Location = new System.Drawing.Point(0, 596);
                this.pbarLoading.Name = "pbarLoading";
                this.pbarLoading.Size = new System.Drawing.Size(863, 31);
                this.pbarLoading.Step = 1;
                this.pbarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                this.pbarLoading.TabIndex = 2;
                // 
                // frmEvent
                // 
                this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
                this.ClientSize = new System.Drawing.Size(863, 627);
                this.Controls.Add(this.pbarLoading);
                this.Controls.Add(this.panel1);
                this.Controls.Add(this.tab);
                this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Name = "frmEvent";
                this.Text = "Event Log";
                this.Load += new System.EventHandler(this.frmEvent_Load);
                this.tab.ResumeLayout(false);
                this.App.ResumeLayout(false);
                this.Sec.ResumeLayout(false);
                this.Sys.ResumeLayout(false);
                this.panel1.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                this.ResumeLayout(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

		}
		#endregion

		public void ShowTab(int tb)
		{
			switch(tb)
			{
				case 1:
					tab.SelectedTab=App;
					break;

				case 2:
					tab.SelectedTab=Sec;
					break;
				case 3:
					tab.SelectedTab=Sys;
					break;
			}
		}
		private void tab_Click(object sender, System.EventArgs e)
		{
			int im=0;
			lstEvent.Items.Clear();
			lstEvent1.Items.Clear();
			lstEvent2.Items.Clear();
			//MessageBox.Show(Global.rObj.eEve.ary.ToString());

			string[,] ar=new string[0,9];
			ListViewItem lvw;
			try
			{
				switch(tab.SelectedIndex)
				{
					case 0:
                        pbarLoading.Minimum = 0;
						ar=Global.rObj.eEve.ShowEves(tab.SelectedTab.Name.ToString());
                        if (ar.GetUpperBound(0) < 0)
                            break;
                        pbarLoading.Maximum = ar.GetUpperBound(0);
						//MessageBox.Show(ar[1,0]);
                        Typ.Width = -2;
                        Dat.Width = -2;
                        Tim.Width = -2;
                        Sou.Width = -2;
                        Cat.Width = -2;
                        Eve.Width = -2;
                        Use.Width = -2;
                        Com.Width = -2;
                        Mes.Width = 0;
                        for (int i = 0; i < pbarLoading.Maximum; i++)
						{						
							if (ar[i,0]=="Information") im=1;
							if (ar[i,0]=="Warning") im=2;
							if (ar[i,0]=="Error") im=3;
							lvw=lstEvent.Items.Add(ar[i,0],im);
							
							for(int j=1;j<9;j++)
							{								
								lvw.SubItems.Add(ar[i,j]);			
						
							}
                            pbarLoading.Value = i;
						}
						break;						
					case 1:
                        pbarLoading.Minimum = 0;
						ar=Global.rObj.eEve.ShowEves(tab.SelectedTab.Name.ToString());
                        if (ar.GetUpperBound(0) < 0)
                            break;
                        pbarLoading.Maximum = ar.GetUpperBound(0);
                        Typ1.Width = -2;
                        Dat1.Width = -2;
                        Tim1.Width = -2;
                        Sou1.Width = -2;
                        Cat1.Width = -2;
                        Eve1.Width = -2;
                        Use1.Width = -2;
                        Com1.Width = -2;
                        Mes.Width = 0;
                        for (int i = 0; i < pbarLoading.Maximum; i++)
						{						

							if (ar[i,0]=="Information") im=1;
							if (ar[i,0]=="Warning") im=2;
							if (ar[i,0]=="Error") im=3;
							
							lvw=lstEvent1.Items.Add(ar[i,0],im);
							for(int j=1;j<9;j++)
							{								
								lvw.SubItems.Add(ar[i,j]);			
						
							}
                            pbarLoading.Value = i;
						}
						break;
					case 2:
                        pbarLoading.Minimum = 0;
						ar=Global.rObj.eEve.ShowEves(tab.SelectedTab.Name.ToString());
                        if (ar.GetUpperBound(0) < 0)
                            break;
                        pbarLoading.Maximum = ar.GetUpperBound(0);
                        Typ2.Width = -2;
                        Dat2.Width = -2;
                        Tim2.Width = -2;
                        Sou2.Width = -2;
                        Cat2.Width = -2;
                        Eve2.Width = -2;
                        Use2.Width = -2;
                        Com2.Width = -2;
                        Mes.Width = 0;
                        for (int i = 0; i < pbarLoading.Maximum; i++)
						{						

							if (ar[i,0]=="Information") im=1;
							if (ar[i,0]=="Warning") im=2;
							if (ar[i,0]=="Error") im=3;
							
							lvw=lstEvent2.Items.Add(ar[i,0],im);
							for(int j=1;j<9;j++)
							{								
								lvw.SubItems.Add(ar[i,j]);			
						
							}
                            pbarLoading.Value = i;
						}
						break;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void frmEvent_Load(object sender, System.EventArgs e)
		{
            this.Show();
			lstEvent.Items.Clear();
			int im=0;
			//MessageBox.Show(Global.rObj.eEve.ary.ToString());

			string[,] ar=new string[0,9];
			ListViewItem lvw;

			try
			{
                pbarLoading.Minimum = 0;
				ar=Global.rObj.eEve.ShowEves(tab.SelectedTab.Name.ToString());
                pbarLoading.Maximum = ar.GetUpperBound(0);
                Typ.Width = -2;
                Dat.Width = -2;
                Tim.Width = -2;
                Sou.Width = -2;
                Cat.Width = -2;
                Eve.Width = -2;
                Use.Width = -2;
                Com.Width = -2;
                Mes.Width = 0;
                for (int i = 0; i < pbarLoading.Maximum; i++)
				{						
					if (ar[i,0]=="Information") im=1;
					if (ar[i,0]=="Warning") im=2;
					if (ar[i,0]=="Error") im=3;
					lvw=lstEvent.Items.Add(ar[i,0],im);
					for(int j=1;j<9;j++)
					{								
						lvw.SubItems.Add(ar[i,j]);			
					}
                    pbarLoading.Value = i;
                    
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
			}
		}

		private void tab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void lstEvent_DoubleClick(object sender, System.EventArgs e)
		{
			frmEveMesssage f=new frmEveMesssage(lstEvent.SelectedItems[0].SubItems[8].Text);
			f.ShowDialog(Global.frmMain);
		}

		private void lstEvent1_DoubleClick(object sender, System.EventArgs e)
		{
			frmEveMesssage f=new frmEveMesssage(lstEvent1.SelectedItems[0].SubItems[8].Text);
			f.ShowDialog(Global.frmMain);
		}

		private void lstEvent2_DoubleClick(object sender, System.EventArgs e)
		{
			frmEveMesssage f=new frmEveMesssage(lstEvent2.SelectedItems[0].SubItems[8].Text);
			f.ShowDialog(Global.frmMain);
		}

		
	}
}
