using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Notepad
{
	/// <summary>
	/// Summary description for BalloonSearch.
	/// </summary>
	public class BalloonSearch : DevComponents.DotNetBar.Balloon
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.TextBox no;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BalloonSearch()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BalloonSearch));
			this.no = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// no
			// 
			this.no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.no.Location = new System.Drawing.Point(125, 60);
			this.no.Name = "no";
			this.no.Size = new System.Drawing.Size(277, 21);
			this.no.TabIndex = 0;
			this.no.Text = "";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.button1.Location = new System.Drawing.Point(278, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "打      开";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(124, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "发票编号：";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(14, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(110, 80);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// BalloonSearch
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(414, 129);
			this.Controls.Add(this.no);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "BalloonSearch";
			this.Activated += new System.EventHandler(this.BalloonSearch_Activated);
			this.Deactivate += new System.EventHandler(this.BalloonSearch_Deactivate);
			this.ResumeLayout(false);

		}
		#endregion

		private void BalloonSearch_Deactivate(object sender, System.EventArgs e)
		{
			this.Opacity=.75;
		}

		private void BalloonSearch_Activated(object sender, System.EventArgs e)
		{
			this.Opacity=1;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.Owner!=null)
			{
				if(no.Text=="")
					MessageBox.Show("请输入发票编号.","打开发票",MessageBoxButtons.OK,MessageBoxIcon.Information);
				else
				{
					((frmMain)this.Owner).SearchActiveDocument(no.Text);
					this.Close();
				}
			}
		}

	}
}
