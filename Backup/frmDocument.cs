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
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
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
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
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
		private System.Windows.Forms.Panel panel20;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.TextBox TbxID;
		private System.Windows.Forms.TextBox TbxBankName;
		private System.Windows.Forms.TextBox TbxAccount;
		private System.Windows.Forms.TextBox TbxBoxNumber;
		private System.Windows.Forms.ListView LbxListProject;
		private System.Windows.Forms.TextBox TbxBulk;
		private System.Windows.Forms.TextBox TbxWeight;
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
		private System.Windows.Forms.TextBox Quantity;
		private System.Windows.Forms.TextBox UnitPrice;
		private System.Windows.Forms.ComboBox Unit;
		private System.Windows.Forms.Label TbxTotalInCapita;
		private System.Windows.Forms.Label TbxLumpSum;
		private System.Windows.Forms.ComboBox CbxBusinessRegisterNo;
		private System.Windows.Forms.ComboBox CbxRegisterNo;
		private System.Windows.Forms.ComboBox CbxIssuedBy;
		private System.Windows.Forms.ComboBox CbxDescriptions;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label TbxB;
		private System.Windows.Forms.Label TbxL;
		private System.Windows.Forms.Label TbxQ;
		private System.Windows.Forms.Label TbxForNo;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Panel panel24;
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
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TbxB = new System.Windows.Forms.Label();
			this.TbxBoxNumber = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.LbxListProject = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.btnDel = new System.Windows.Forms.Button();
			this.panel12 = new System.Windows.Forms.Panel();
			this.CbxDescriptions = new System.Windows.Forms.ComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.panel14 = new System.Windows.Forms.Panel();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.Quantity = new System.Windows.Forms.TextBox();
			this.panel13 = new System.Windows.Forms.Panel();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.UnitPrice = new System.Windows.Forms.TextBox();
			this.Unit = new System.Windows.Forms.ComboBox();
			this.TbxBulk = new System.Windows.Forms.TextBox();
			this.TbxL = new System.Windows.Forms.Label();
			this.TbxQ = new System.Windows.Forms.Label();
			this.TbxWeight = new System.Windows.Forms.TextBox();
			this.panel20 = new System.Windows.Forms.Panel();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.TbxTotalInCapita = new System.Windows.Forms.Label();
			this.panel21 = new System.Windows.Forms.Panel();
			this.label54 = new System.Windows.Forms.Label();
			this.label55 = new System.Windows.Forms.Label();
			this.TbxLumpSum = new System.Windows.Forms.Label();
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
			this.label24 = new System.Windows.Forms.Label();
			this.TbxBankName = new System.Windows.Forms.TextBox();
			this.TbxAccount = new System.Windows.Forms.TextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.TbxDateSailed = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
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
			this.panel24 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel14.SuspendLayout();
			this.panel13.SuspendLayout();
			this.panel20.SuspendLayout();
			this.panel21.SuspendLayout();
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
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel22.SuspendLayout();
			this.panel23.SuspendLayout();
			this.panel24.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader4
			// 
			this.columnHeader4.Width = 108;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Width = 142;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.LbxListProject);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label27);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.panel12);
			this.groupBox1.Controls.Add(this.panel14);
			this.groupBox1.Controls.Add(this.panel13);
			this.groupBox1.Controls.Add(this.panel20);
			this.groupBox1.Controls.Add(this.panel21);
			this.groupBox1.Controls.Add(this.panel24);
			this.groupBox1.Location = new System.Drawing.Point(16, 232);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(768, 272);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			// 
			// TbxB
			// 
			this.TbxB.Location = new System.Drawing.Point(8, 8);
			this.TbxB.Name = "TbxB";
			this.TbxB.Size = new System.Drawing.Size(96, 16);
			this.TbxB.TabIndex = 0;
			this.TbxB.Text = "箱量";
			// 
			// TbxBoxNumber
			// 
			this.TbxBoxNumber.Location = new System.Drawing.Point(16, 24);
			this.TbxBoxNumber.Name = "TbxBoxNumber";
			this.TbxBoxNumber.Size = new System.Drawing.Size(112, 21);
			this.TbxBoxNumber.TabIndex = 14;
			this.TbxBoxNumber.Text = "";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnAdd.Location = new System.Drawing.Point(600, 240);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(56, 24);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "添 加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// LbxListProject
			// 
			this.LbxListProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LbxListProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							 this.columnHeader1,
																							 this.columnHeader2,
																							 this.columnHeader3,
																							 this.columnHeader4});
			this.LbxListProject.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.LbxListProject.FullRowSelect = true;
			this.LbxListProject.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.LbxListProject.Location = new System.Drawing.Point(80, 56);
			this.LbxListProject.Name = "LbxListProject";
			this.LbxListProject.Size = new System.Drawing.Size(496, 112);
			this.LbxListProject.TabIndex = 0;
			this.LbxListProject.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 137;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Width = 107;
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label26.Location = new System.Drawing.Point(8, 16);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(448, 16);
			this.label26.TabIndex = 0;
			this.label26.Text = "收费内容(货 物 名 称        数    量       单         价)";
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label27.Location = new System.Drawing.Point(8, 32);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(352, 16);
			this.label27.TabIndex = 0;
			this.label27.Text = "PARTICULARS(DESCRIPTIONS,QUANTITY,UNIT PRICE)";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label28.Location = new System.Drawing.Point(464, 16);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(88, 16);
			this.label28.TabIndex = 0;
			this.label28.Text = "金      额";
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(464, 32);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(88, 16);
			this.label29.TabIndex = 0;
			this.label29.Text = "A M O U N T";
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label30.Location = new System.Drawing.Point(616, 16);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(88, 16);
			this.label30.TabIndex = 0;
			this.label30.Text = "备       注";
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label31.Location = new System.Drawing.Point(616, 32);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(88, 16);
			this.label31.TabIndex = 0;
			this.label31.Text = "R E M A R K";
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.SystemColors.Control;
			this.btnDel.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnDel.Location = new System.Drawing.Point(680, 240);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(56, 24);
			this.btnDel.TabIndex = 20;
			this.btnDel.Text = "删 除";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.CbxDescriptions);
			this.panel12.Controls.Add(this.label32);
			this.panel12.Controls.Add(this.label33);
			this.panel12.Location = new System.Drawing.Point(8, 232);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(192, 32);
			this.panel12.TabIndex = 11;
			// 
			// CbxDescriptions
			// 
			this.CbxDescriptions.Location = new System.Drawing.Point(96, 8);
			this.CbxDescriptions.Name = "CbxDescriptions";
			this.CbxDescriptions.Size = new System.Drawing.Size(88, 20);
			this.CbxDescriptions.TabIndex = 113;
			this.CbxDescriptions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(8, 0);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(56, 16);
			this.label32.TabIndex = 0;
			this.label32.Text = "收费项目";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(8, 16);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(80, 16);
			this.label33.TabIndex = 0;
			this.label33.Text = "DESCRIPTIONS";
			// 
			// panel14
			// 
			this.panel14.Controls.Add(this.label36);
			this.panel14.Controls.Add(this.label37);
			this.panel14.Controls.Add(this.Quantity);
			this.panel14.Location = new System.Drawing.Point(208, 232);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(136, 32);
			this.panel14.TabIndex = 12;
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(8, 0);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(56, 16);
			this.label36.TabIndex = 0;
			this.label36.Text = "数    量";
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(8, 16);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(56, 16);
			this.label37.TabIndex = 0;
			this.label37.Text = "QUANTITY";
			// 
			// Quantity
			// 
			this.Quantity.Location = new System.Drawing.Point(64, 8);
			this.Quantity.Name = "Quantity";
			this.Quantity.Size = new System.Drawing.Size(64, 21);
			this.Quantity.TabIndex = 114;
			this.Quantity.Text = "";
			// 
			// panel13
			// 
			this.panel13.Controls.Add(this.label34);
			this.panel13.Controls.Add(this.label35);
			this.panel13.Controls.Add(this.UnitPrice);
			this.panel13.Controls.Add(this.Unit);
			this.panel13.Location = new System.Drawing.Point(360, 232);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(224, 32);
			this.panel13.TabIndex = 13;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(8, 0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(56, 16);
			this.label34.TabIndex = 0;
			this.label34.Text = "单    价";
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(8, 16);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(72, 16);
			this.label35.TabIndex = 0;
			this.label35.Text = "UNITPRICE";
			// 
			// UnitPrice
			// 
			this.UnitPrice.Location = new System.Drawing.Point(80, 8);
			this.UnitPrice.Name = "UnitPrice";
			this.UnitPrice.Size = new System.Drawing.Size(80, 21);
			this.UnitPrice.TabIndex = 115;
			this.UnitPrice.Text = "";
			// 
			// Unit
			// 
			this.Unit.Items.AddRange(new object[] {
													  "RMB",
													  "USD"});
			this.Unit.Location = new System.Drawing.Point(160, 8);
			this.Unit.Name = "Unit";
			this.Unit.Size = new System.Drawing.Size(56, 20);
			this.Unit.TabIndex = 116;
			this.Unit.Text = "RMB";
			this.Unit.SelectedIndexChanged += new System.EventHandler(this.Unit_SelectedIndexChanged);
			// 
			// TbxBulk
			// 
			this.TbxBulk.Location = new System.Drawing.Point(16, 64);
			this.TbxBulk.Name = "TbxBulk";
			this.TbxBulk.Size = new System.Drawing.Size(112, 21);
			this.TbxBulk.TabIndex = 15;
			this.TbxBulk.Text = "";
			// 
			// TbxL
			// 
			this.TbxL.Location = new System.Drawing.Point(8, 48);
			this.TbxL.Name = "TbxL";
			this.TbxL.Size = new System.Drawing.Size(96, 16);
			this.TbxL.TabIndex = 0;
			this.TbxL.Text = "体积";
			// 
			// TbxQ
			// 
			this.TbxQ.Location = new System.Drawing.Point(8, 88);
			this.TbxQ.Name = "TbxQ";
			this.TbxQ.Size = new System.Drawing.Size(96, 16);
			this.TbxQ.TabIndex = 0;
			this.TbxQ.Text = "重量";
			// 
			// TbxWeight
			// 
			this.TbxWeight.Location = new System.Drawing.Point(16, 104);
			this.TbxWeight.Name = "TbxWeight";
			this.TbxWeight.Size = new System.Drawing.Size(112, 21);
			this.TbxWeight.TabIndex = 16;
			this.TbxWeight.Text = "";
			// 
			// panel20
			// 
			this.panel20.Controls.Add(this.label51);
			this.panel20.Controls.Add(this.label52);
			this.panel20.Controls.Add(this.TbxTotalInCapita);
			this.panel20.Location = new System.Drawing.Point(8, 176);
			this.panel20.Name = "panel20";
			this.panel20.Size = new System.Drawing.Size(296, 48);
			this.panel20.TabIndex = 0;
			// 
			// label51
			// 
			this.label51.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label51.Location = new System.Drawing.Point(8, 8);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(104, 16);
			this.label51.TabIndex = 0;
			this.label51.Text = "金额合计(大写)";
			// 
			// label52
			// 
			this.label52.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label52.Location = new System.Drawing.Point(8, 24);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(120, 16);
			this.label52.TabIndex = 0;
			this.label52.Text = "TOTAL IN CAPITAL";
			// 
			// TbxTotalInCapita
			// 
			this.TbxTotalInCapita.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.TbxTotalInCapita.Location = new System.Drawing.Point(128, 24);
			this.TbxTotalInCapita.Name = "TbxTotalInCapita";
			this.TbxTotalInCapita.Size = new System.Drawing.Size(160, 16);
			this.TbxTotalInCapita.TabIndex = 0;
			// 
			// panel21
			// 
			this.panel21.Controls.Add(this.label54);
			this.panel21.Controls.Add(this.label55);
			this.panel21.Controls.Add(this.TbxLumpSum);
			this.panel21.Location = new System.Drawing.Point(456, 176);
			this.panel21.Name = "panel21";
			this.panel21.Size = new System.Drawing.Size(192, 48);
			this.panel21.TabIndex = 0;
			// 
			// label54
			// 
			this.label54.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label54.Location = new System.Drawing.Point(8, 8);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(64, 16);
			this.label54.TabIndex = 0;
			this.label54.Text = "合    计";
			// 
			// label55
			// 
			this.label55.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label55.Location = new System.Drawing.Point(8, 24);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(64, 16);
			this.label55.TabIndex = 0;
			this.label55.Text = "LUMP SUM";
			// 
			// TbxLumpSum
			// 
			this.TbxLumpSum.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.TbxLumpSum.Location = new System.Drawing.Point(88, 24);
			this.TbxLumpSum.Name = "TbxLumpSum";
			this.TbxLumpSum.Size = new System.Drawing.Size(96, 16);
			this.TbxLumpSum.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.TbxDateIssued);
			this.panel4.Location = new System.Drawing.Point(320, 104);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(192, 32);
			this.panel4.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 0;
			this.label7.Text = "开票日期";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "DATE ISSUED";
			// 
			// TbxDateIssued
			// 
			this.TbxDateIssued.Location = new System.Drawing.Point(88, 8);
			this.TbxDateIssued.Name = "TbxDateIssued";
			this.TbxDateIssued.Size = new System.Drawing.Size(96, 21);
			this.TbxDateIssued.TabIndex = 105;
			this.TbxDateIssued.Text = "";
			// 
			// panel18
			// 
			this.panel18.Controls.Add(this.label47);
			this.panel18.Controls.Add(this.label48);
			this.panel18.Controls.Add(this.CbxIssuedBy);
			this.panel18.Location = new System.Drawing.Point(584, 512);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(192, 32);
			this.panel18.TabIndex = 20;
			// 
			// label47
			// 
			this.label47.Location = new System.Drawing.Point(8, 0);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(72, 16);
			this.label47.TabIndex = 0;
			this.label47.Text = "制    单";
			// 
			// label48
			// 
			this.label48.Location = new System.Drawing.Point(8, 16);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(80, 16);
			this.label48.TabIndex = 0;
			this.label48.Text = "ISSUED BY";
			// 
			// CbxIssuedBy
			// 
			this.CbxIssuedBy.Location = new System.Drawing.Point(88, 4);
			this.CbxIssuedBy.Name = "CbxIssuedBy";
			this.CbxIssuedBy.Size = new System.Drawing.Size(104, 20);
			this.CbxIssuedBy.TabIndex = 121;
			this.CbxIssuedBy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
			// 
			// panel19
			// 
			this.panel19.Controls.Add(this.label49);
			this.panel19.Controls.Add(this.label50);
			this.panel19.Controls.Add(this.CbxRegisterNo);
			this.panel19.Location = new System.Drawing.Point(128, 544);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(224, 32);
			this.panel19.TabIndex = 18;
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(8, 0);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(96, 16);
			this.label49.TabIndex = 0;
			this.label49.Text = "税 务 登 记 号";
			// 
			// label50
			// 
			this.label50.Location = new System.Drawing.Point(8, 16);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(104, 16);
			this.label50.TabIndex = 0;
			this.label50.Text = "TAX REGISTER NO.";
			// 
			// CbxRegisterNo
			// 
			this.CbxRegisterNo.Location = new System.Drawing.Point(120, 8);
			this.CbxRegisterNo.Name = "CbxRegisterNo";
			this.CbxRegisterNo.Size = new System.Drawing.Size(104, 20);
			this.CbxRegisterNo.TabIndex = 121;
			this.CbxRegisterNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
			// 
			// panel17
			// 
			this.panel17.Controls.Add(this.label45);
			this.panel17.Controls.Add(this.label46);
			this.panel17.Controls.Add(this.TbxCheckedBy);
			this.panel17.Location = new System.Drawing.Point(376, 512);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(200, 32);
			this.panel17.TabIndex = 19;
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point(8, 0);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(72, 16);
			this.label45.TabIndex = 0;
			this.label45.Text = "复      核";
			// 
			// label46
			// 
			this.label46.Location = new System.Drawing.Point(8, 16);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(80, 16);
			this.label46.TabIndex = 0;
			this.label46.Text = "CHECKED BY";
			// 
			// TbxCheckedBy
			// 
			this.TbxCheckedBy.Location = new System.Drawing.Point(96, 8);
			this.TbxCheckedBy.Name = "TbxCheckedBy";
			this.TbxCheckedBy.Size = new System.Drawing.Size(96, 21);
			this.TbxCheckedBy.TabIndex = 121;
			this.TbxCheckedBy.Text = "";
			// 
			// panel15
			// 
			this.panel15.Controls.Add(this.label41);
			this.panel15.Controls.Add(this.label42);
			this.panel15.Location = new System.Drawing.Point(8, 512);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(112, 32);
			this.panel15.TabIndex = 0;
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(8, 0);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(56, 16);
			this.label41.TabIndex = 0;
			this.label41.Text = "企业签章";
			// 
			// label42
			// 
			this.label42.Location = new System.Drawing.Point(8, 16);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(88, 16);
			this.label42.TabIndex = 0;
			this.label42.Text = "BUSINESS SEAL";
			// 
			// TbxForNo
			// 
			this.TbxForNo.Location = new System.Drawing.Point(0, 8);
			this.TbxForNo.Name = "TbxForNo";
			this.TbxForNo.Size = new System.Drawing.Size(72, 16);
			this.TbxForNo.TabIndex = 0;
			this.TbxForNo.Text = "外运编号：";
			// 
			// TbxTrafficNo
			// 
			this.TbxTrafficNo.Location = new System.Drawing.Point(72, 8);
			this.TbxTrafficNo.Name = "TbxTrafficNo";
			this.TbxTrafficNo.Size = new System.Drawing.Size(184, 21);
			this.TbxTrafficNo.TabIndex = 112;
			this.TbxTrafficNo.Text = "";
			// 
			// panel16
			// 
			this.panel16.Controls.Add(this.label43);
			this.panel16.Controls.Add(this.label44);
			this.panel16.Controls.Add(this.CbxBusinessRegisterNo);
			this.panel16.Location = new System.Drawing.Point(128, 512);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(248, 32);
			this.panel16.TabIndex = 17;
			// 
			// label43
			// 
			this.label43.Location = new System.Drawing.Point(8, 0);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(128, 16);
			this.label43.TabIndex = 0;
			this.label43.Text = "工  商  登  记  号";
			// 
			// label44
			// 
			this.label44.Location = new System.Drawing.Point(8, 16);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(128, 16);
			this.label44.TabIndex = 0;
			this.label44.Text = "BUSINESS REGISTER NO.";
			// 
			// CbxBusinessRegisterNo
			// 
			this.CbxBusinessRegisterNo.Location = new System.Drawing.Point(144, 4);
			this.CbxBusinessRegisterNo.Name = "CbxBusinessRegisterNo";
			this.CbxBusinessRegisterNo.Size = new System.Drawing.Size(104, 20);
			this.CbxBusinessRegisterNo.TabIndex = 120;
			this.CbxBusinessRegisterNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.label19);
			this.panel10.Controls.Add(this.label20);
			this.panel10.Controls.Add(this.TbxDestination);
			this.panel10.Location = new System.Drawing.Point(528, 168);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(248, 32);
			this.panel10.TabIndex = 9;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(56, 16);
			this.label19.TabIndex = 0;
			this.label19.Text = "目的港";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 16);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(72, 16);
			this.label20.TabIndex = 0;
			this.label20.Text = "DESTINATOIN";
			// 
			// TbxDestination
			// 
			this.TbxDestination.Location = new System.Drawing.Point(80, 8);
			this.TbxDestination.Name = "TbxDestination";
			this.TbxDestination.Size = new System.Drawing.Size(160, 21);
			this.TbxDestination.TabIndex = 111;
			this.TbxDestination.Text = "";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.label17);
			this.panel9.Controls.Add(this.label18);
			this.panel9.Controls.Add(this.TbxDisPort);
			this.panel9.Location = new System.Drawing.Point(256, 168);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(272, 32);
			this.panel9.TabIndex = 8;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(8, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(56, 16);
			this.label17.TabIndex = 0;
			this.label17.Text = "卸货港";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 16);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 16);
			this.label18.TabIndex = 0;
			this.label18.Text = "DIS. PORT";
			// 
			// TbxDisPort
			// 
			this.TbxDisPort.Location = new System.Drawing.Point(72, 8);
			this.TbxDisPort.Name = "TbxDisPort";
			this.TbxDisPort.Size = new System.Drawing.Size(184, 21);
			this.TbxDisPort.TabIndex = 110;
			this.TbxDisPort.Text = "";
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.label21);
			this.panel11.Controls.Add(this.label22);
			this.panel11.Controls.Add(this.TbxID);
			this.panel11.Controls.Add(this.label23);
			this.panel11.Controls.Add(this.label24);
			this.panel11.Controls.Add(this.TbxBankName);
			this.panel11.Controls.Add(this.TbxAccount);
			this.panel11.Location = new System.Drawing.Point(552, 32);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(224, 104);
			this.panel11.TabIndex = 1;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 8);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(104, 16);
			this.label21.TabIndex = 0;
			this.label21.Text = "苏地(03034)字 NO";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(8, 32);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(96, 16);
			this.label22.TabIndex = 0;
			this.label22.Text = "开户银行名称：";
			// 
			// TbxID
			// 
			this.TbxID.Location = new System.Drawing.Point(120, 0);
			this.TbxID.Name = "TbxID";
			this.TbxID.Size = new System.Drawing.Size(96, 21);
			this.TbxID.TabIndex = 100;
			this.TbxID.Text = "";
			this.TbxID.TextChanged += new System.EventHandler(this.TbxID_TextChanged);
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(8, 56);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(96, 16);
			this.label23.TabIndex = 0;
			this.label23.Text = "账        号：";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(8, 72);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(96, 16);
			this.label24.TabIndex = 0;
			this.label24.Text = "BANK ACCOUNT：";
			// 
			// TbxBankName
			// 
			this.TbxBankName.Enabled = false;
			this.TbxBankName.Location = new System.Drawing.Point(104, 24);
			this.TbxBankName.Name = "TbxBankName";
			this.TbxBankName.Size = new System.Drawing.Size(112, 21);
			this.TbxBankName.TabIndex = 101;
			this.TbxBankName.Text = "";
			// 
			// TbxAccount
			// 
			this.TbxAccount.Enabled = false;
			this.TbxAccount.Location = new System.Drawing.Point(104, 48);
			this.TbxAccount.Name = "TbxAccount";
			this.TbxAccount.Size = new System.Drawing.Size(112, 21);
			this.TbxAccount.TabIndex = 102;
			this.TbxAccount.Text = "";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label13);
			this.panel7.Controls.Add(this.label14);
			this.panel7.Controls.Add(this.TbxDateSailed);
			this.panel7.Location = new System.Drawing.Point(568, 136);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(208, 32);
			this.panel7.TabIndex = 6;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 16);
			this.label13.TabIndex = 0;
			this.label13.Text = "开航日期";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 16);
			this.label14.TabIndex = 0;
			this.label14.Text = "DATE SAILED";
			// 
			// TbxDateSailed
			// 
			this.TbxDateSailed.Location = new System.Drawing.Point(80, 8);
			this.TbxDateSailed.Name = "TbxDateSailed";
			this.TbxDateSailed.Size = new System.Drawing.Size(120, 21);
			this.TbxDateSailed.TabIndex = 108;
			this.TbxDateSailed.Text = "";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(264, 56);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(136, 40);
			this.panel3.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.Location = new System.Drawing.Point(16, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "R E C O R D";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.Location = new System.Drawing.Point(8, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "记    账    联";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.CbxPayer);
			this.panel2.Location = new System.Drawing.Point(8, 104);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(264, 32);
			this.panel2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(8, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "付款单位";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "PAYER";
			// 
			// CbxPayer
			// 
			this.CbxPayer.Location = new System.Drawing.Point(64, 8);
			this.CbxPayer.Name = "CbxPayer";
			this.CbxPayer.Size = new System.Drawing.Size(192, 20);
			this.CbxPayer.TabIndex = 104;
			this.CbxPayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyUp);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(120, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 48);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(384, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "INTERNATIONAL FREIGHT FORWARDING SPECIAL INVOICE";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(384, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "国  际  货  物  运  输  代  理  业  专  用  发  票";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.label11);
			this.panel6.Controls.Add(this.label12);
			this.panel6.Controls.Add(this.TbxBLNo);
			this.panel6.Location = new System.Drawing.Point(376, 136);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(192, 32);
			this.panel6.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "提(运)单号";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 0;
			this.label12.Text = "B/L NO.";
			// 
			// TbxBLNo
			// 
			this.TbxBLNo.Location = new System.Drawing.Point(64, 8);
			this.TbxBLNo.Name = "TbxBLNo";
			this.TbxBLNo.Size = new System.Drawing.Size(104, 21);
			this.TbxBLNo.TabIndex = 107;
			this.TbxBLNo.Text = "";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.TbxVessel);
			this.panel5.Location = new System.Drawing.Point(8, 136);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(376, 32);
			this.panel5.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "船名/航次/航班/车次";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(152, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "VESSEL/VOY/FRT/TRAIN NO.";
			// 
			// TbxVessel
			// 
			this.TbxVessel.Location = new System.Drawing.Point(160, 8);
			this.TbxVessel.Name = "TbxVessel";
			this.TbxVessel.Size = new System.Drawing.Size(200, 21);
			this.TbxVessel.TabIndex = 106;
			this.TbxVessel.Text = "";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.label15);
			this.panel8.Controls.Add(this.label16);
			this.panel8.Controls.Add(this.TbxLoadPort);
			this.panel8.Location = new System.Drawing.Point(8, 168);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(256, 32);
			this.panel8.TabIndex = 7;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 16);
			this.label15.TabIndex = 0;
			this.label15.Text = "起运港";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 16);
			this.label16.TabIndex = 0;
			this.label16.Text = "LOAD PORT";
			// 
			// TbxLoadPort
			// 
			this.TbxLoadPort.Location = new System.Drawing.Point(72, 8);
			this.TbxLoadPort.Name = "TbxLoadPort";
			this.TbxLoadPort.Size = new System.Drawing.Size(168, 21);
			this.TbxLoadPort.TabIndex = 109;
			this.TbxLoadPort.Text = "";
			// 
			// panel22
			// 
			this.panel22.Controls.Add(this.label53);
			this.panel22.Controls.Add(this.label56);
			this.panel22.Location = new System.Drawing.Point(384, 544);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(264, 32);
			this.panel22.TabIndex = 9;
			// 
			// label53
			// 
			this.label53.Location = new System.Drawing.Point(8, 0);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(96, 16);
			this.label53.TabIndex = 0;
			this.label53.Text = "手写无效";
			// 
			// label56
			// 
			this.label56.Location = new System.Drawing.Point(8, 16);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(192, 16);
			this.label56.TabIndex = 0;
			this.label56.Text = "HAND WRITING NULL AND VOID";
			// 
			// panel23
			// 
			this.panel23.Controls.Add(this.TbxForNo);
			this.panel23.Controls.Add(this.TbxTrafficNo);
			this.panel23.Location = new System.Drawing.Point(16, 208);
			this.panel23.Name = "panel23";
			this.panel23.Size = new System.Drawing.Size(264, 32);
			this.panel23.TabIndex = 10;
			// 
			// panel24
			// 
			this.panel24.Controls.Add(this.TbxBulk);
			this.panel24.Controls.Add(this.TbxL);
			this.panel24.Controls.Add(this.TbxQ);
			this.panel24.Controls.Add(this.TbxWeight);
			this.panel24.Controls.Add(this.TbxB);
			this.panel24.Controls.Add(this.TbxBoxNumber);
			this.panel24.Location = new System.Drawing.Point(616, 48);
			this.panel24.Name = "panel24";
			this.panel24.Size = new System.Drawing.Size(136, 128);
			this.panel24.TabIndex = 16;
			// 
			// frmDocument
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(968, 638);
			this.Controls.Add(this.panel23);
			this.Controls.Add(this.groupBox1);
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
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel22);
			this.Name = "frmDocument";
			this.Text = "frmDocument";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FormClosing);
			this.Load += new System.EventHandler(this.frmDocument_Load);
			this.Closed += new System.EventHandler(this.FormClosed);
			this.VisibleChanged += new System.EventHandler(this.FormVisibleChanged);
			this.Activated += new System.EventHandler(this.FormActivated);
			this.Deactivate += new System.EventHandler(this.FormDeactivated);
			this.groupBox1.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			this.panel13.ResumeLayout(false);
			this.panel20.ResumeLayout(false);
			this.panel21.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel18.ResumeLayout(false);
			this.panel19.ResumeLayout(false);
			this.panel17.ResumeLayout(false);
			this.panel15.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel22.ResumeLayout(false);
			this.panel23.ResumeLayout(false);
			this.panel24.ResumeLayout(false);
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

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			if(this.LbxListProject.Items.Count>6)
			{
				MessageBox.Show("项目内容不能超过6条！");
				return;
			}
			ListViewItem lvitem=new ListViewItem();
			lvitem.Text=this.CbxDescriptions.Text;
			lvitem.SubItems.Add(this.Quantity.Text);
			lvitem.SubItems.Add(this.UnitPrice.Text);
			try
			{
				lvitem.SubItems.Add(this.Unit.Text+": "+(float.Parse(this.UnitPrice.Text.Trim())*float.Parse(this.Quantity.Text.Trim())).ToString());
			}
			catch
			{
				lvitem.SubItems.Add("无法计算");
			}
			this.LbxListProject.Items.Add(lvitem);
			double total=0;
			for(int i=0;i<this.LbxListProject.Items.Count;i++)
			{
				try
				{
					total+=float.Parse(this.LbxListProject.Items[i].SubItems[1].Text)*float.Parse(this.LbxListProject.Items[i].SubItems[2].Text);
				}
				catch
				{}
			}
			int tmpt=(int)(total*100);
			double tmpc=(double)tmpt/100;
			this.TbxLumpSum.Text=this.Unit.Text+": "+tmpc.ToString();
			Print.AMT_GB2312 amt=new Print.AMT_GB2312();
			string ut="";
			if(this.Unit.Text=="RMB")
			{
				ut="人民币";
			}
			else
			{
				ut="美元";
			}
			this.TbxTotalInCapita.Text=ut+"  "+amt.ConvertToGB2312(total);
			this.Unit.Enabled=false;
			if(total==0)
			{
				this.TbxLumpSum.Text="";
				this.TbxTotalInCapita.Text="";
			}
			string strxml=@"<?xml version='1.0' encoding='utf-8' ?><Setup></Setup>";
			System.Xml.XmlDocument xmldoc=new System.Xml.XmlDocument();
			xmldoc.LoadXml(strxml);
			forSaveList(this,ref xmldoc);
			string path=System.IO.Path.GetDirectoryName(Application.ExecutablePath)+@"\setup.xml";
			xmldoc.Save(path);
			this.CbxDescriptions.Text="";

		}

		private void Unit_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.Unit.Enabled=false;
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			if(this.LbxListProject.SelectedIndices.Count<=0) return;
			for(int i=0;i<this.LbxListProject.SelectedIndices.Count;i++)
			{
				this.LbxListProject.Items.RemoveAt(this.LbxListProject.SelectedIndices[i]);
			}
			double total=0;
			for(int i=0;i<this.LbxListProject.Items.Count;i++)
			{
				try
				{
					total+=float.Parse(this.LbxListProject.Items[i].SubItems[1].Text)*float.Parse(this.LbxListProject.Items[i].SubItems[2].Text);
				}
				catch
				{}
			}
			int tmpt=(int)(total*100);
			double tmpc=(double)tmpt/100;
			this.TbxLumpSum.Text=this.Unit.Text+": "+tmpc.ToString();
			Print.AMT_GB2312 amt=new Print.AMT_GB2312();
			string ut="";
			if(this.Unit.Text=="RMB")
			{
				ut="人民币";
			}
			else
			{
				ut="美元";
			}
			this.TbxTotalInCapita.Text=ut+"    "+amt.ConvertToGB2312(total);
			if(total==0)
			{
				this.TbxLumpSum.Text="";
				this.TbxTotalInCapita.Text="";
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
