using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Xml;
namespace Notepad
{
	/// <summary>
	/// Summary description for frmDocument.
	/// </summary>
	public class frmDocument : System.Windows.Forms.Form
	{
		public bool DocumentChanged=false;
		public string FileName="";
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox TbxID;
		private System.Windows.Forms.TextBox TbxBankName;
		private System.Windows.Forms.TextBox TbxDateIssued;
		private System.Windows.Forms.TextBox TbxCheckedBy;
		private System.Windows.Forms.TextBox TbxTrafficNo;
		private System.Windows.Forms.TextBox TbxDestination;
		private System.Windows.Forms.TextBox TbxDisPort;
		private System.Windows.Forms.TextBox TbxDateSailed;
		private System.Windows.Forms.ComboBox CbxPayer;
		private System.Windows.Forms.TextBox TbxBLNo;
		private System.Windows.Forms.TextBox TbxVessel;
		private System.Windows.Forms.TextBox TbxLoadPort;
		private System.Windows.Forms.ComboBox CbxBusinessRegisterNo;
		private System.Windows.Forms.ComboBox CbxRegisterNo;
		private System.Windows.Forms.ComboBox CbxIssuedBy;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label TbxForNo;
		private System.Windows.Forms.Panel panel23;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDocument()
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxDateIssued = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.CbxIssuedBy = new System.Windows.Forms.ComboBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.CbxRegisterNo = new System.Windows.Forms.ComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.TbxCheckedBy = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.TbxForNo = new System.Windows.Forms.Label();
            this.TbxTrafficNo = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.CbxBusinessRegisterNo = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TbxDestination = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TbxDisPort = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TbxID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TbxBankName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TbxDateSailed = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxPayer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TbxBLNo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxVessel = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TbxLoadPort = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.TbxDateIssued);
            this.panel4.Location = new System.Drawing.Point(587, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 55);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "开票日期";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "DATE ISSUED";
            // 
            // TbxDateIssued
            // 
            this.TbxDateIssued.Location = new System.Drawing.Point(161, 14);
            this.TbxDateIssued.Name = "TbxDateIssued";
            this.TbxDateIssued.Size = new System.Drawing.Size(176, 31);
            this.TbxDateIssued.TabIndex = 105;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label47);
            this.panel18.Controls.Add(this.label48);
            this.panel18.Controls.Add(this.CbxIssuedBy);
            this.panel18.Location = new System.Drawing.Point(1071, 878);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(352, 55);
            this.panel18.TabIndex = 20;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(15, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(132, 27);
            this.label47.TabIndex = 0;
            this.label47.Text = "制    单";
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(15, 27);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(146, 28);
            this.label48.TabIndex = 0;
            this.label48.Text = "ISSUED BY";
            // 
            // CbxIssuedBy
            // 
            this.CbxIssuedBy.Location = new System.Drawing.Point(161, 7);
            this.CbxIssuedBy.Name = "CbxIssuedBy";
            this.CbxIssuedBy.Size = new System.Drawing.Size(191, 29);
            this.CbxIssuedBy.TabIndex = 121;
            this.CbxIssuedBy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label49);
            this.panel19.Controls.Add(this.label50);
            this.panel19.Controls.Add(this.CbxRegisterNo);
            this.panel19.Location = new System.Drawing.Point(235, 933);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(410, 54);
            this.panel19.TabIndex = 18;
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(15, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(176, 27);
            this.label49.TabIndex = 0;
            this.label49.Text = "税 务 登 记 号";
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(15, 27);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(190, 28);
            this.label50.TabIndex = 0;
            this.label50.Text = "TAX REGISTER NO.";
            // 
            // CbxRegisterNo
            // 
            this.CbxRegisterNo.Location = new System.Drawing.Point(220, 14);
            this.CbxRegisterNo.Name = "CbxRegisterNo";
            this.CbxRegisterNo.Size = new System.Drawing.Size(191, 29);
            this.CbxRegisterNo.TabIndex = 121;
            this.CbxRegisterNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label45);
            this.panel17.Controls.Add(this.label46);
            this.panel17.Controls.Add(this.TbxCheckedBy);
            this.panel17.Location = new System.Drawing.Point(689, 878);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(367, 55);
            this.panel17.TabIndex = 19;
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(15, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(132, 27);
            this.label45.TabIndex = 0;
            this.label45.Text = "复      核";
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(15, 27);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(146, 28);
            this.label46.TabIndex = 0;
            this.label46.Text = "CHECKED BY";
            // 
            // TbxCheckedBy
            // 
            this.TbxCheckedBy.Location = new System.Drawing.Point(176, 14);
            this.TbxCheckedBy.Name = "TbxCheckedBy";
            this.TbxCheckedBy.Size = new System.Drawing.Size(176, 31);
            this.TbxCheckedBy.TabIndex = 121;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label41);
            this.panel15.Controls.Add(this.label42);
            this.panel15.Location = new System.Drawing.Point(15, 878);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(205, 55);
            this.panel15.TabIndex = 0;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(15, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(102, 27);
            this.label41.TabIndex = 0;
            this.label41.Text = "企业签章";
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(15, 27);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(161, 28);
            this.label42.TabIndex = 0;
            this.label42.Text = "BUSINESS SEAL";
            // 
            // TbxForNo
            // 
            this.TbxForNo.Location = new System.Drawing.Point(0, 14);
            this.TbxForNo.Name = "TbxForNo";
            this.TbxForNo.Size = new System.Drawing.Size(132, 27);
            this.TbxForNo.TabIndex = 0;
            this.TbxForNo.Text = "外运编号：";
            // 
            // TbxTrafficNo
            // 
            this.TbxTrafficNo.Location = new System.Drawing.Point(132, 14);
            this.TbxTrafficNo.Name = "TbxTrafficNo";
            this.TbxTrafficNo.Size = new System.Drawing.Size(337, 31);
            this.TbxTrafficNo.TabIndex = 112;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label43);
            this.panel16.Controls.Add(this.label44);
            this.panel16.Controls.Add(this.CbxBusinessRegisterNo);
            this.panel16.Location = new System.Drawing.Point(235, 878);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(454, 55);
            this.panel16.TabIndex = 17;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(15, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(234, 27);
            this.label43.TabIndex = 0;
            this.label43.Text = "工  商  登  记  号";
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(15, 27);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(234, 28);
            this.label44.TabIndex = 0;
            this.label44.Text = "BUSINESS REGISTER NO.";
            // 
            // CbxBusinessRegisterNo
            // 
            this.CbxBusinessRegisterNo.Location = new System.Drawing.Point(264, 7);
            this.CbxBusinessRegisterNo.Name = "CbxBusinessRegisterNo";
            this.CbxBusinessRegisterNo.Size = new System.Drawing.Size(191, 29);
            this.CbxBusinessRegisterNo.TabIndex = 120;
            this.CbxBusinessRegisterNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label19);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.TbxDestination);
            this.panel10.Location = new System.Drawing.Point(968, 288);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(455, 55);
            this.panel10.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(15, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 27);
            this.label19.TabIndex = 0;
            this.label19.Text = "目的港";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(15, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 28);
            this.label20.TabIndex = 0;
            this.label20.Text = "DESTINATOIN";
            // 
            // TbxDestination
            // 
            this.TbxDestination.Location = new System.Drawing.Point(147, 14);
            this.TbxDestination.Name = "TbxDestination";
            this.TbxDestination.Size = new System.Drawing.Size(293, 31);
            this.TbxDestination.TabIndex = 111;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Controls.Add(this.TbxDisPort);
            this.panel9.Location = new System.Drawing.Point(469, 288);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(499, 55);
            this.panel9.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(15, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 27);
            this.label17.TabIndex = 0;
            this.label17.Text = "卸货港";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(15, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 28);
            this.label18.TabIndex = 0;
            this.label18.Text = "DIS. PORT";
            // 
            // TbxDisPort
            // 
            this.TbxDisPort.Location = new System.Drawing.Point(132, 14);
            this.TbxDisPort.Name = "TbxDisPort";
            this.TbxDisPort.Size = new System.Drawing.Size(337, 31);
            this.TbxDisPort.TabIndex = 110;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label21);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Controls.Add(this.TbxID);
            this.panel11.Controls.Add(this.label23);
            this.panel11.Controls.Add(this.TbxBankName);
            this.panel11.Location = new System.Drawing.Point(62, 120);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1317, 48);
            this.panel11.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(0, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 31);
            this.label21.TabIndex = 0;
            this.label21.Text = "建字第";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(486, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 28);
            this.label22.TabIndex = 0;
            this.label22.Text = "发证机关";
            // 
            // TbxID
            // 
            this.TbxID.Location = new System.Drawing.Point(99, 0);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(290, 31);
            this.TbxID.TabIndex = 100;
            this.TbxID.TextChanged += new System.EventHandler(this.TbxID_TextChanged);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(389, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 28);
            this.label23.TabIndex = 0;
            this.label23.Text = "号";
            // 
            // TbxBankName
            // 
            this.TbxBankName.Enabled = false;
            this.TbxBankName.Location = new System.Drawing.Point(598, 0);
            this.TbxBankName.Name = "TbxBankName";
            this.TbxBankName.Size = new System.Drawing.Size(498, 31);
            this.TbxBankName.TabIndex = 101;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.TbxDateSailed);
            this.panel7.Location = new System.Drawing.Point(1041, 233);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(382, 55);
            this.panel7.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(15, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 27);
            this.label13.TabIndex = 0;
            this.label13.Text = "开航日期";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(15, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "DATE SAILED";
            // 
            // TbxDateSailed
            // 
            this.TbxDateSailed.Location = new System.Drawing.Point(147, 14);
            this.TbxDateSailed.Name = "TbxDateSailed";
            this.TbxDateSailed.Size = new System.Drawing.Size(220, 31);
            this.TbxDateSailed.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CbxPayer);
            this.panel2.Location = new System.Drawing.Point(15, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 55);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "付款单位";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "PAYER";
            // 
            // CbxPayer
            // 
            this.CbxPayer.Location = new System.Drawing.Point(117, 14);
            this.CbxPayer.Name = "CbxPayer";
            this.CbxPayer.Size = new System.Drawing.Size(352, 29);
            this.CbxPayer.TabIndex = 104;
            this.CbxPayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(220, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 82);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(704, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "INTERNATIONAL FREIGHT FORWARDING SPECIAL INVOICE";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "国  际  货  物  运  输  代  理  业  专  用  发  票";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.TbxBLNo);
            this.panel6.Location = new System.Drawing.Point(689, 233);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(352, 55);
            this.panel6.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(15, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "提(运)单号";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "B/L NO.";
            // 
            // TbxBLNo
            // 
            this.TbxBLNo.Location = new System.Drawing.Point(117, 14);
            this.TbxBLNo.Name = "TbxBLNo";
            this.TbxBLNo.Size = new System.Drawing.Size(191, 31);
            this.TbxBLNo.TabIndex = 107;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.TbxVessel);
            this.panel5.Location = new System.Drawing.Point(15, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(689, 55);
            this.panel5.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "船名/航次/航班/车次";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(15, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "VESSEL/VOY/FRT/TRAIN NO.";
            // 
            // TbxVessel
            // 
            this.TbxVessel.Location = new System.Drawing.Point(293, 14);
            this.TbxVessel.Name = "TbxVessel";
            this.TbxVessel.Size = new System.Drawing.Size(367, 31);
            this.TbxVessel.TabIndex = 106;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.TbxLoadPort);
            this.panel8.Location = new System.Drawing.Point(15, 288);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(469, 55);
            this.panel8.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(15, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "起运港";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(15, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "LOAD PORT";
            // 
            // TbxLoadPort
            // 
            this.TbxLoadPort.Location = new System.Drawing.Point(132, 14);
            this.TbxLoadPort.Name = "TbxLoadPort";
            this.TbxLoadPort.Size = new System.Drawing.Size(308, 31);
            this.TbxLoadPort.TabIndex = 109;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label53);
            this.panel22.Controls.Add(this.label56);
            this.panel22.Location = new System.Drawing.Point(704, 933);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(484, 54);
            this.panel22.TabIndex = 9;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(15, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(176, 27);
            this.label53.TabIndex = 0;
            this.label53.Text = "手写无效";
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(15, 27);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(352, 28);
            this.label56.TabIndex = 0;
            this.label56.Text = "HAND WRITING NULL AND VOID";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.TbxForNo);
            this.panel23.Controls.Add(this.TbxTrafficNo);
            this.panel23.Location = new System.Drawing.Point(29, 357);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(484, 54);
            this.panel23.TabIndex = 10;
            // 
            // frmDocument
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(11, 24);
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 668);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel22);
            this.Name = "frmDocument";
            this.Text = "frmDocument";
            this.Activated += new System.EventHandler(this.FormActivated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormClosing);
            this.Closed += new System.EventHandler(this.FormClosed);
            this.Deactivate += new System.EventHandler(this.FormDeactivated);
            this.Load += new System.EventHandler(this.frmDocument_Load);
            this.VisibleChanged += new System.EventHandler(this.FormVisibleChanged);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			return;
			if(e.Button!=MouseButtons.Right)
				return;

			frmMain mdi=this.ParentForm as frmMain;
			mdi.EditContextMenu();
		}

		//		private void TextSelectionChanged(object sender, System.EventArgs e)
		//		{
		//			EnableSelectionItems();
		//		}

		private void UpdateStatusBar()
		{
			//			frmMain mdi=this.ParentForm as frmMain;
			//			DevComponents.DotNetBar.DotNetBarManager m=mdi.dotNetBarManager1;
			//			m.Bars["barStatus"].Items["lPosition"].Text="Ln "+(rtfText.GetLineFromCharIndex(rtfText.SelectionStart)+1)+"\tCh "+rtfText.SelectionStart;
		}

		private void EnableSelectionItems()
		{
			//			frmMain mdi=this.ParentForm as frmMain;
			//			DevComponents.DotNetBar.DotNetBarManager m=mdi.dotNetBarManager1;
			//
			//			UpdateStatusBar();
			//
			//			if(rtfText.SelectionLength==0)
			//			{
			//				m.Items["bCut"].Enabled=false;
			//				m.Items["bCopy"].Enabled=false;
			//				m.Items["bDelete"].Enabled=false;
			//			}
			//			else
			//			{
			//				m.Items["bCut"].Enabled=true;
			//				m.Items["bCopy"].Enabled=true;
			//				m.Items["bDelete"].Enabled=true;
			//				
			//			}
			//			((ButtonItem)m.Items["bBold"]).Checked=rtfText.SelectionFont.Bold;
			//			((ButtonItem)m.Items["bItalic"]).Checked=rtfText.SelectionFont.Italic;
			//			((ButtonItem)m.Items["bUnderline"]).Checked=rtfText.SelectionFont.Underline;
			//			((ButtonItem)m.Items["bStrikethrough"]).Checked=rtfText.SelectionFont.Strikeout;
			//
			//			((ButtonItem)m.Items["bAlignLeft"]).Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Left);
			//			((ButtonItem)m.Items["bAlignRight"]).Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Right);
			//			((ButtonItem)m.Items["bAlignCenter"]).Checked=(rtfText.SelectionAlignment==HorizontalAlignment.Center);
		}

		private void FormActivated(object sender, System.EventArgs e)
		{
			//			EnableDocMenuItems();
			//			UpdateStatusBar();
		}

		private void EnableDocMenuItems()
		{
			if(!this.Visible)
				return;

			frmMain mdi=this.ParentForm as frmMain;
			DevComponents.DotNetBar.DotNetBarManager m=mdi.dotNetBarManager1;

			// Disabled Edit items
			m.Items["bPaste"].Enabled=true;
			m.Items["bSelectAll"].Enabled=true;
			m.Items["bFind"].Enabled=true;
			m.Items["bFindNext"].Enabled=true;
			m.Items["bReplace"].Enabled=true;

			// Disable Format items
			m.Items["bAlignLeft"].Enabled=true;
			m.Items["bAlignRight"].Enabled=true;
			m.Items["bAlignCenter"].Enabled=true;

			m.Items["bBold"].Enabled=true;
			m.Items["bItalic"].Enabled=true;
			m.Items["bUnderline"].Enabled=true;
			m.Items["bStrikethrough"].Enabled=true;

			m.Items["bTextColor"].Enabled=true;

			EnableSelectionItems();
		}

		private void FormDeactivated(object sender, System.EventArgs e)
		{
			DisableDocMenuItems();
		}

		private void DisableDocMenuItems()
		{
			frmMain mdi=this.ParentForm as frmMain;
			DevComponents.DotNetBar.DotNetBarManager m=mdi.dotNetBarManager1;

			// Disabled Edit items
			m.Items["bCut"].Enabled=false;
			m.Items["bCopy"].Enabled=false;
			m.Items["bPaste"].Enabled=false;
			m.Items["bDelete"].Enabled=false;
			m.Items["bSelectAll"].Enabled=false;
			m.Items["bFind"].Enabled=false;
			m.Items["bFindNext"].Enabled=false;
			m.Items["bReplace"].Enabled=false;

			// Disable Format items
			m.Items["bBold"].Enabled=false;
			m.Items["bItalic"].Enabled=false;
			m.Items["bUnderline"].Enabled=false;
			m.Items["bStrikethrough"].Enabled=false;
			m.Items["bAlignLeft"].Enabled=false;
			m.Items["bAlignRight"].Enabled=false;
			m.Items["bAlignCenter"].Enabled=false;
			m.Items["bTextColor"].Enabled=false;
		}

		/// <summary>
		/// Process Menu/Toolbar commands
		/// </summary>
		/// <param name="cmd">Command string</param>
		public void ExecuteCommand(string cmd, object data)
		{
			//			switch(cmd)
			//			{
			//				// Edit Menu
			//				case "bUndo":
			//					rtfText.Undo();
			//					break;
			//				case "bCut":
			//					rtfText.Cut();
			//					break;
			//				case "bCopy":
			//					rtfText.Copy();
			//					break;
			//				case "bPaste":
			//					rtfText.Paste();
			//					break;
			//				case "bDelete":
			//					rtfText.SelectedText="";
			//					break;
			//				case "bSelectAll":
			//					rtfText.SelectAll();
			//					break;
			//				case "bFindNext":
			//					MessageBox.Show("Not implemented yet.");
			//					break;
			//				case "bReplace":
			//					MessageBox.Show("Not implemented yet.");
			//					break;
			//					// Format menu
			//				case "bBold":
			//				{
			//					if(rtfText.SelectionFont.Bold)
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Bold)));
			//					else
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Bold));
			//					break;
			//				}
			//				case "bItalic":
			//				{
			//					if(rtfText.SelectionFont.Italic)
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Italic)));
			//					else
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Italic));
			//					break;
			//				}
			//				case "bUnderline":
			//				{
			//					if(rtfText.SelectionFont.Underline)
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Underline)));
			//					else
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Underline));
			//					break;
			//				}
			//				case "bStrikethrough":
			//					if(rtfText.SelectionFont.Strikeout)
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style & ~(rtfText.SelectionFont.Style & FontStyle.Strikeout)));
			//					else
			//						rtfText.SelectionFont=new Font(rtfText.SelectionFont,(rtfText.SelectionFont.Style | FontStyle.Strikeout));
			//					break;
			//				case "bAlignLeft":
			//					rtfText.SelectionAlignment=HorizontalAlignment.Left;
			//					break;
			//				case "bAlignCenter":
			//					rtfText.SelectionAlignment=HorizontalAlignment.Center;
			//					break;
			//				case "bAlignRight":
			//					rtfText.SelectionAlignment=HorizontalAlignment.Right;
			//					break;
			//				case "bTextColor":
			//				{
			//					if(data!=null && data is Color)
			//						rtfText.SelectionColor=(Color)data;
			//					break;
			//				}
			//				case "bFind":
			//				{
			//					if(data!=null)
			//					{
			//						string searchText=data.ToString();
			//						rtfText.Find(searchText,rtfText.SelectionStart+rtfText.SelectionLength,RichTextBoxFinds.None);
			//					}
			//					break;
			//				}
			//			}
			//			DocumentChanged=true;
			//			EnableSelectionItems();
		}

		private void rtfText_TextChanged(object sender, System.EventArgs e)
		{
			DocumentChanged=true;
		}

		public void OpenFile(string filename)
		{
			//			if(filename.Substring(filename.Length-4,4).ToLower()==".txt")
			//				rtfText.LoadFile(filename,RichTextBoxStreamType.PlainText);
			//			else
			//                rtfText.LoadFile(filename,RichTextBoxStreamType.RichText);
			//			this.FileName=filename;
			//			DocumentChanged=false;
		}

		public void SaveFile()
		{
			//			if(this.FileName.Substring(this.FileName.Length-4,4).ToLower()==".txt")
			//				rtfText.SaveFile(this.FileName,RichTextBoxStreamType.PlainText);
			//			else
			//				rtfText.LoadFile(this.FileName,RichTextBoxStreamType.RichText);
			//            
			//			DocumentChanged=false;
		}

		private void FormClosed(object sender, System.EventArgs e)
		{
			frmMain mdi=this.ParentForm as frmMain;
			DevComponents.DotNetBar.DotNetBarManager m=mdi.dotNetBarManager1;
			m.Bars["barStatus"].Items["lPosition"].Text="";
			DisableDocMenuItems();
		}

		private void FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.DocumentChanged)
			{
				DialogResult dlg=MessageBox.Show(this,"Document '"+this.FileName+"' has changed. Save changes?","Notepad",MessageBoxButtons.YesNoCancel);
				if(dlg==DialogResult.Cancel)
				{
					e.Cancel=true;
				}
				else if(dlg==DialogResult.Yes)
				{
					if(this.FileName=="")
						if(this.FileName!="")
							SaveFile();
				}
			}
		}

		private void FormVisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible)
				EnableDocMenuItems();
			else
				DisableDocMenuItems();
		}

		private void frmDocument_Load(object sender, System.EventArgs e)
		{
			try
			{
				string path=System.IO.Path.GetDirectoryName(Application.ExecutablePath)+@"\setup.xml";
				System.Xml.XmlDocument xmldoc=new System.Xml.XmlDocument();
				xmldoc.Load(path);
				forOpen(this,ref xmldoc);

			}
			catch
			{
				MessageBox.Show("未能打开发票信息，可能该发票不存在或数据已经被损坏！");
			}

		}
		public void Save()
		{
			forCheckCbx(this);
			if(this.TbxID.Text.Trim().Length==0)
			{
				MessageBox.Show("请填入发票编号");
				this.TbxID.Focus();
				return;
			}
			string strxml=@"<?xml version='1.0' encoding='utf-8' ?><Bill></Bill>";
			System.Xml.XmlDocument xmldoc=new System.Xml.XmlDocument();
			xmldoc.LoadXml(strxml);
			forSave(this,ref xmldoc);
			string path=System.IO.Path.GetDirectoryName(Application.ExecutablePath)+@"\BillData\"+this.TbxID.Text+@".xml";
			xmldoc.Save(path);
			strxml=@"<?xml version='1.0' encoding='utf-8' ?><Setup></Setup>";
			xmldoc=new System.Xml.XmlDocument();
			xmldoc.LoadXml(strxml);
			forSaveList(this,ref xmldoc);
			path=System.IO.Path.GetDirectoryName(Application.ExecutablePath)+@"\setup.xml";
			xmldoc.Save(path);
		}
		private void forSave(System.Windows.Forms.Control crl,ref System.Xml.XmlDocument xmldoc)
		{
			
			for(int i=0;i<crl.Controls.Count;i++)
			{
				if(crl.Controls[i].Controls.Count>0)
				{
					forSave(crl.Controls[i],ref xmldoc);
				}
				if(crl.Controls[i].Name.Length<=3)
				{
					continue;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Tbx")
				{
					XmlElement newTitle=xmldoc.CreateElement(crl.Controls[i].Name);
					try
					{
						newTitle.InnerText=crl.Controls[i].Text;
					}
					catch
					{
						newTitle.InnerText="";
					}
					xmldoc["Bill"].AppendChild(newTitle);
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Cbx")
				{
					XmlElement newTitle=xmldoc.CreateElement(crl.Controls[i].Name);
					try
					{
						newTitle.InnerText=crl.Controls[i].Text;
					}
					catch
					{
						newTitle.InnerText="";
					}
					xmldoc["Bill"].AppendChild(newTitle);
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Lbx")
				{
					ListView lvi=crl.Controls[i] as ListView;
					for(int j=0;j<lvi.Items.Count;j++)
					{
						for(int k=0;k<lvi.Items[j].SubItems.Count;k++)
						{
							XmlElement newTitle=xmldoc.CreateElement(crl.Controls[i].Name+j.ToString()+k.ToString());
							newTitle.InnerText=lvi.Items[j].SubItems[k].Text;
							xmldoc["Bill"].AppendChild(newTitle);
						}
					}
				}
			}
		}

		private void forSaveList(System.Windows.Forms.Control crl,ref System.Xml.XmlDocument xmldoc)
		{
			for(int i=0;i<crl.Controls.Count;i++)
			{
				if(crl.Controls[i].Controls.Count>0)
				{
					forSaveList(crl.Controls[i],ref xmldoc);
				}
				if(crl.Controls[i].Name.Length<=3)
				{
					continue;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Cbx")
				{
					XmlElement newTitle=xmldoc.CreateElement(crl.Controls[i].Name);
					newTitle.InnerText="";
					ComboBox cbx=crl.Controls[i] as ComboBox;
					bool isexist=false;
					for(int j=0;j<cbx.Items.Count;j++)
					{
						if(cbx.Items[j].ToString()==crl.Controls[i].Text) isexist=true;
					}
					if(!isexist&&crl.Controls[i].Text.Trim().Length!=0)
					{
						XmlElement newItem=xmldoc.CreateElement("Item");
						newItem.InnerText=crl.Controls[i].Text;
						newTitle.AppendChild(newItem);
					}
					for(int j=0;j<cbx.Items.Count;j++)
					{
						XmlElement newItem=xmldoc.CreateElement("Item");
						newItem.InnerText=cbx.Items[j].ToString();
						newTitle.AppendChild(newItem);
					}
					xmldoc["Setup"].AppendChild(newTitle);
				}
			}
		}

		private void forOpen(System.Windows.Forms.Control crl,ref System.Xml.XmlDocument xmldoc)
		{
			
			for(int i=0;i<crl.Controls.Count;i++)
			{
				if(crl.Controls[i].Controls.Count>0)
				{
					forOpen(crl.Controls[i],ref xmldoc);
				}
				if(crl.Controls[i].Name.Length<=3)
				{
					continue;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Cbx")
				{
					try
					{
						ComboBox cbx=crl.Controls[i] as ComboBox;
						//					cbx.Text=xmldoc["Setup"][crl.Controls[i].Name].InnerText;
						for(int j=0;j<xmldoc["Setup"][crl.Controls[i].Name].ChildNodes.Count;j++)
						{
							cbx.Items.Add(xmldoc["Setup"][crl.Controls[i].Name].ChildNodes[j].InnerText);
						}
					}
					catch(Exception err)
					{
						string ii=err.ToString();
					}
				}
			}
		}

		private void forCheckCbx(System.Windows.Forms.Control crl)
		{
			
			for(int i=0;i<crl.Controls.Count;i++)
			{
				if(crl.Controls[i].Controls.Count>0)
				{
					forCheckCbx(crl.Controls[i]);
				}
				if(crl.Controls[i].Name.Length<=3)
				{
					continue;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Cbx")
				{
					try
					{
						if(crl.Controls[i].Text.Trim().Length==0)
							crl.Controls[i].Text="";
					}
					catch(Exception err)
					{
						ComboBox cbx=crl.Controls[i] as ComboBox;
						cbx.Text="";
					}
				}
			}
		}


		private void loadeList(System.Windows.Forms.Control crl,ref System.Xml.XmlDocument xmldoc)
		{
			
			for(int i=0;i<crl.Controls.Count;i++)
			{
				if(crl.Controls[i].Controls.Count>0)
				{
					forSaveList(crl.Controls[i],ref xmldoc);
				}
				if(crl.Controls[i].Name.Length<=3)
				{
					continue;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Cbx")
				{
					XmlElement newTitle=xmldoc.CreateElement(crl.Controls[i].Name);
					newTitle.InnerText=crl.Controls[i].Text;
					ComboBox cbx=crl.Controls[i] as ComboBox;
					for(int j=0;j<cbx.Items.Count;j++)
					{
						XmlElement newItem=xmldoc.CreateElement("Item");
						newItem.InnerText=cbx.Items[j].ToString();
						newTitle.AppendChild(newItem);
					}
					xmldoc["Setup"].AppendChild(newTitle);
				}
			}
		}

	

		

		

		private void TbxID_TextChanged(object sender, System.EventArgs e)
		{
			this.Text=this.TbxID.Text;
		}

		private void Cbx_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Delete)
			{	ComboBox cbx=sender as ComboBox;
				if(cbx.SelectedIndex>=0)
				{
					cbx.Items.RemoveAt(cbx.SelectedIndex);
					cbx.Text="";
				}
			}		
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.ScrollControlIntoView(this);
		}


	}
}
