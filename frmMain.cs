using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using System.Drawing.Printing;
namespace Notepad
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		public DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite barTopDockSite;
		private DevComponents.DotNetBar.DockSite barBottomDockSite;
		private DevComponents.DotNetBar.DockSite barLeftDockSite;
		private DevComponents.DotNetBar.DockSite barRightDockSite;
		private System.Windows.Forms.ImageList imageList1;
		private DevComponents.DotNetBar.TabStrip tabStrip1;
		private System.ComponentModel.IContainer components;
		private BalloonSearch m_Search=null;
		private System.Drawing.Printing.PrintDocument printDoc;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private Balloon m_InfoBalloon=null;

		public frmMain()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
            this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.barBottomDockSite = new DevComponents.DotNetBar.DockSite();
            this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            // 
            // barLeftDockSite
            // 
            this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barLeftDockSite.BackgroundImageAlpha = ((byte)(255));
            this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
            this.barLeftDockSite.Location = new System.Drawing.Point(0, 38);
            this.barLeftDockSite.Name = "barLeftDockSite";
            this.barLeftDockSite.Size = new System.Drawing.Size(0, 457);
            this.barLeftDockSite.TabIndex = 3;
            this.barLeftDockSite.TabStop = false;
            // 
            // barTopDockSite
            // 
            this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barTopDockSite.BackgroundImageAlpha = ((byte)(255));
            this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
            this.barTopDockSite.Location = new System.Drawing.Point(0, 0);
            this.barTopDockSite.Name = "barTopDockSite";
            this.barTopDockSite.Size = new System.Drawing.Size(819, 38);
            this.barTopDockSite.TabIndex = 1;
            this.barTopDockSite.TabStop = false;
            this.barTopDockSite.Click += new System.EventHandler(this.barTopDockSite_Click);
            // 
            // dotNetBarManager1
            // 
            this.dotNetBarManager1.BottomDockSite = this.barBottomDockSite;
            this.dotNetBarManager1.DefinitionName = "frmMain.dotNetBarManager1.xml";
            this.dotNetBarManager1.Images = this.imageList1;
            this.dotNetBarManager1.LeftDockSite = this.barLeftDockSite;
            this.dotNetBarManager1.MdiSystemItemVisible = false;
            this.dotNetBarManager1.ParentForm = this;
            this.dotNetBarManager1.RightDockSite = this.barRightDockSite;
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dotNetBarManager1.TopDockSite = this.barTopDockSite;
            this.dotNetBarManager1.ItemClick += new System.EventHandler(this.BarItemClick);
            this.dotNetBarManager1.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.dotNetBarManager1_PopupOpen);
            this.dotNetBarManager1.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
            this.dotNetBarManager1.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
            this.dotNetBarManager1.DefinitionLoaded += new System.EventHandler(this.ManagerDefinitionLoaded);
            this.dotNetBarManager1.ContainerLoadControl += new System.EventHandler(this.ContainerLoadControl);
            this.dotNetBarManager1.DockTabChange += new DevComponents.DotNetBar.DotNetBarManager.DockTabChangeEventHandler(this.dotNetBarManager1_DockTabChange);
            // 
            // barBottomDockSite
            // 
            this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barBottomDockSite.BackgroundImageAlpha = ((byte)(255));
            this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barBottomDockSite.Location = new System.Drawing.Point(0, 495);
            this.barBottomDockSite.Name = "barBottomDockSite";
            this.barBottomDockSite.Size = new System.Drawing.Size(819, 21);
            this.barBottomDockSite.TabIndex = 2;
            this.barBottomDockSite.TabStop = false;
            // 
            // barRightDockSite
            // 
            this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barRightDockSite.BackgroundImageAlpha = ((byte)(255));
            this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
            this.barRightDockSite.Location = new System.Drawing.Point(576, 38);
            this.barRightDockSite.Name = "barRightDockSite";
            this.barRightDockSite.Size = new System.Drawing.Size(243, 457);
            this.barRightDockSite.TabIndex = 4;
            this.barRightDockSite.TabStop = false;
            // 
            // tabStrip1
            // 
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonVisible = true;
            this.dotNetBarManager1.SetContextMenuEx(this.tabStrip1, "bTabContext");
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Location = new System.Drawing.Point(0, 38);
            this.tabStrip1.MdiTabbedDocuments = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip1.Size = new System.Drawing.Size(576, 48);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.OneNote;
            this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip1.TabIndex = 6;
            this.tabStrip1.Text = "tabStrip1";
            this.tabStrip1.VariableTabWidth = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDoc;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(11, 24);
            this.ClientSize = new System.Drawing.Size(819, 516);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.barLeftDockSite);
            this.Controls.Add(this.barRightDockSite);
            this.Controls.Add(this.barTopDockSite);
            this.Controls.Add(this.barBottomDockSite);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "建设工程规划许可证";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.MdiChildActivated);
            this.Move += new System.EventHandler(this.frmMain_Move);
            this.ResumeLayout(false);

		}
		#endregion

		#region AppCreation
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}
		#endregion

		public void EditContextMenu()
		{
		}

		private void BarItemClick(object sender, EventArgs e)
		{
			BaseItem objItem=sender as BaseItem;
			frmDocument activedocument=this.ActiveMdiChild as frmDocument;

			switch(objItem.Name)
			{
				// File menu
				case "bNew":
					CreateNewDocument();
					break;
				case "bTaskNewDocument":
					CreateNewDocument();
					break;
				case "bOpen":
					OpenDocument(objItem);
					break;
				case "bTaskOpenDocument":
					OpenDocument(objItem);
					break;
				case "bSave":
					SaveDocument();
					break;
				case "bClose":
				{
					if(activedocument!=null)
						activedocument.Close();
					break;
				}
				case "bPageSetup":
					MessageBox.Show("Not implemented yet.");
					break;
				case "bPrintPreview":
					PrintPreview();
					break;
				case "bPrint":
					Printer();
					break;
				case "bExit":
					this.Close();
					break;
				case "bTaskHelp":
					MessageBox.Show("Starts the help file.");
					break;
				default:
				{
					// Pass them to the active document
					if(activedocument!=null)
						activedocument.ExecuteCommand(objItem.Name,null);
					break;
				}
			}
		}

		private void CreateNewDocument()
		{
			frmDocument doc=new frmDocument();
			doc.MdiParent=this;
			doc.WindowState=FormWindowState.Maximized;
			doc.Show();
			doc.Update();
			doc.Text="空白发票 "+this.MdiChildren.Length.ToString();
		}
		/// <summary>
		/// Verifies current context and enables/disables menu items...
		/// </summary>
		private void EnableFileItems()
		{
			// Accessing items through the Items collection and setting the properties on them
			// will propagate certain properties to all items with the same name...
			if(this.ActiveMdiChild==null)
			{
				dotNetBarManager1.Items["bSave"].Enabled=false;
				dotNetBarManager1.Items["bSaveAs"].Enabled=false;
				dotNetBarManager1.Items["bPrint"].Enabled=false;
				dotNetBarManager1.Items["bPrintPreview"].Enabled=false;
				dotNetBarManager1.Items["bPageSetup"].Enabled=false;
				dotNetBarManager1.Items["bClose"].Enabled=false;
			}
			else
			{
				dotNetBarManager1.Items["bSave"].Enabled=true;
				dotNetBarManager1.Items["bSaveAs"].Enabled=true;
				dotNetBarManager1.Items["bPrint"].Enabled=true;
				dotNetBarManager1.Items["bPrintPreview"].Enabled=true;
				dotNetBarManager1.Items["bPageSetup"].Enabled=true;
				dotNetBarManager1.Items["bClose"].Enabled=true;
			}
		}

		private void MdiChildActivated(object sender, System.EventArgs e)
		{
			EnableFileItems();
		}

		private void OpenDocument(BaseItem bi)
		{
			BalloonSearch bs=new BalloonSearch();
			bs.Owner=this;
			bs.Show(bi,true);
		
			return;
		}

		/// <summary>
		/// Save active document
		/// </summary>
		private void SaveDocument()
		{
			if(this.ActiveMdiChild==null)
				return;
			frmDocument doc=this.ActiveMdiChild as frmDocument;
			if(doc==null)
				return;
			doc.Save();
		}
		private void ContainerLoadControl(object sender, System.EventArgs e)
		{
			BaseItem item=sender as BaseItem;
			if(item==null)
				return;
			if(item.Name=="cTaskShowatstartup")
			{
				ControlContainerItem containerItem=item as ControlContainerItem;
				CheckBox box=new CheckBox();
				box.Text="Show at startup";
				box.FlatStyle=FlatStyle.Flat;
				box.Size = new System.Drawing.Size(95, 17);
				box.TabStop=false;
				box.Checked=true;
				box.CheckedChanged+=new EventHandler(this.TaskPaneShowAtStartup);
				containerItem.Control=box;
			}
			else if(item.Name=="dockTaskList")
			{
			}
			else if(item.Name=="dockSearchResults")
			{
				// Just add the list box as a example...
				DockContainerItem dockItem=item as DockContainerItem;
				ListBox listbox=new ListBox();
				// This will set the minimum size for the DockContainerItem
				listbox.Size=new Size(32,32);
				// Must let the DockContainerItem resize it at will...
				listbox.IntegralHeight=false;
				dockItem.Control=listbox;				
			}
		}

		private void ChangeDotNetBarStyle(eDotNetBarStyle style)
		{
			
			((ButtonItem)dotNetBarManager1.GetItem("bStyle2000")).Checked=(style==eDotNetBarStyle.Office2000);
			((ButtonItem)dotNetBarManager1.GetItem("bStyle2003")).Checked=(style==eDotNetBarStyle.Office2003);
			((ButtonItem)dotNetBarManager1.GetItem("bStyleXP")).Checked=(style==eDotNetBarStyle.OfficeXP);

            dotNetBarManager1.Style=style;
			if(style==eDotNetBarStyle.Office2003 || style==eDotNetBarStyle.OfficeXP)
			{
				if(dotNetBarManager1.IsThemeActive)
				{
					BaseItem item=dotNetBarManager1.GetItem("bThemes");
					item.Visible=true;
					((Bar)item.ContainerControl).RecalcLayout();
				}
			}
			else if(dotNetBarManager1.IsThemeActive)
			{
				dotNetBarManager1.GetItem("bThemes").Visible=false;
			}

			if(style==eDotNetBarStyle.Office2003)
			{
				tabStrip1.Style=eTabStripStyle.OneNote;
				dotNetBarManager1.Bars["barTaskPane"].BackColor=Color.Empty;
				((ControlContainerItem)dotNetBarManager1.GetItem("cTaskShowatstartup")).Control.BackColor=dotNetBarManager1.Bars[0].ColorScheme.BarBackground2;
			}
			else
			{
				tabStrip1.Style=eTabStripStyle.Flat;
				dotNetBarManager1.Bars["barTaskPane"].BackColor=Color.FromArgb(245,245,245);
				((ControlContainerItem)dotNetBarManager1.GetItem("cTaskShowatstartup")).Control.BackColor=Color.FromArgb(245,245,245);
			}
		}

		private void TaskPaneShowAtStartup(object sender, EventArgs e)
		{
			MessageBox.Show("This item is here for demonstration purposes only and code should be added to save the state of it.");
		}

		private void ManagerDefinitionLoaded(object sender, EventArgs e)
		{
			// Assign optional "Customize" menu to the bar that contains this item
			dotNetBarManager1.Bars["barTaskList"].CustomizeMenu=(PopupItem)dotNetBarManager1.ContextMenus["bTaskListMenu"];
		}

		private void dotNetBarManager1_MouseEnter(object sender, System.EventArgs e)
		{
			// Sync Status-bar with the item tooltip...
			BaseItem item=sender as BaseItem;
			if(item==null)
				return;
            dotNetBarManager1.Bars["barStatus"].Items["lStatus"].Text=item.Tooltip;
			// Disable timer...
		}

		private void dotNetBarManager1_MouseLeave(object sender, System.EventArgs e)
		{
            dotNetBarManager1.Bars["barStatus"].Items["lStatus"].Text="";		
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			ChangeDotNetBarStyle(eDotNetBarStyle.Office2003);

			EnableFileItems();

			// This makes sure that Theme support is enabled by the end-user as well as present on this OS
			// Neccessary for Automatic Tab-Strip Mdi support
			tabStrip1.MdiForm=this;

			// Setup Context menu for the barTaskList TabStrip...
			Bar bar=dotNetBarManager1.Bars["barTaskList"];
			dotNetBarManager1.SetContextMenuEx(bar,"bDockContext");
		}


		private void SwitchWorkingMode(bool tabbedMdi)
		{
			if(tabbedMdi)
			{
				// Switch to Tabbed Mdi Interface
				dotNetBarManager1.MdiSystemItemVisible=false;
				tabStrip1.MdiTabbedDocuments=true;
				dotNetBarManager1.Bars["windowlist"].Visible=false;
			}
			else
			{
				// Switch to standard Mdi Interface
				tabStrip1.Visible=false;
				dotNetBarManager1.MdiSystemItemVisible=true;
				tabStrip1.MdiTabbedDocuments=false;
                tabStrip1.MdiForm=null;
				SyncMdiTabbedBar();
			}
		}

		private void MdiClientControlAddRemove(object sender, ControlEventArgs e)
		{
			if(e.Control is Form)
				SyncMdiTabbedBar();
		}
		private void SyncMdiTabbedBar()
		{
			if(tabStrip1.Visible)
			{
				// Hide window list bar
				dotNetBarManager1.Bars["windowlist"].Visible=false;
			}
			else
			{
				if(this.MdiChildren.Length>0)
				{
					dotNetBarManager1.Bars["windowlist"].Visible=true;
					dotNetBarManager1.Bars["windowlist"].DockLine=1;
					dotNetBarManager1.Bars["windowlist"].RecalcLayout();
				}
				else
					dotNetBarManager1.Bars["windowlist"].Visible=false;
			}
		}

		private TabItem TabItemFromPoint(Point pClient)
		{
			if(!tabStrip1.ClientRectangle.Contains(pClient))
				return null;
			foreach(TabItem tab in tabStrip1.Tabs)
			{
				if(tab.Visible && tab.DisplayRectangle.Contains(pClient))
					return tab;
			}

			return null;
		}

		private void dotNetBarManager1_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
		{
			BaseItem item=sender as BaseItem;
			if(item==null)
				return;
			if(item.Name=="bTabContext")
			{
				// Enable/Disable the document related menu items based on where user right-clicked...
				TabItem tab=TabItemFromPoint(tabStrip1.PointToClient(Control.MousePosition));
				// If no tab is under the mouse disable document related items...
				if(tab==null)
				{
					item.SubItems["bClose"].Enabled=false;
					item.SubItems["bSave"].Enabled=false;
				}
				else
				{
					item.SubItems["bClose"].Enabled=true;
					item.SubItems["bSave"].Enabled=true;
					// Make sure that tab under the mouse is active tab
					tabStrip1.SelectedTab=tab;
				}
			}
			else if(item.Name=="bDockContext")
			{
				Bar bar=dotNetBarManager1.Bars["barTaskList"];
				// Display our context menu only if user clicks on the bar caption or tab strip control
				if(!bar.GrabHandleRect.Contains(bar.PointToClient(Control.MousePosition)) && bar.DockTabControl!=null && !bar.DockTabControl.Bounds.Contains(bar.PointToClient(Control.MousePosition)))
				{
					e.Cancel=true;
					return;
				}
				item.SubItems.Clear();
				ButtonItem contextItem=null;
				foreach(BaseItem dockItem in bar.Items)
				{
					contextItem=new ButtonItem(dockItem.Name,dockItem.Text);
					contextItem.GlobalItem=false;
					contextItem.Click+=new EventHandler(this.DockContextClick);
					item.SubItems.Add(contextItem);
					contextItem.Checked=dockItem.Visible;
				}
				contextItem=new ButtonItem("bc_tabnavigation","Tab Navigation");
				contextItem.Checked=bar.TabNavigation;
				contextItem.BeginGroup=true;
				contextItem.Click+=new EventHandler(this.DockContextClick);
				item.SubItems.Add(contextItem);
				PopupItem popup=item as PopupItem;
			}
		}

		private void DockContextClick(object sender, EventArgs e)
		{
			ButtonItem item=sender as ButtonItem;
			if(item==null)
				return;

			Bar bar=dotNetBarManager1.Bars["barTaskList"];
			if(item.Name=="bc_tabnavigation")
			{
				bar.TabNavigation=!item.Checked;
				bar.DockTabControl.Refresh();
				return;
			}
			
			
			if(bar.Items.Contains(item.Name))
				bar.Items[item.Name].Visible=!item.Checked;
			bar.RecalcLayout();
		}

		private void frmMain_Move(object sender, System.EventArgs e)
		{
			this.CloseInfoBalloon();
			this.CloseSearch();
		}

		private void CloseInfoBalloon()
		{
			if(m_InfoBalloon!=null)
			{
				m_InfoBalloon.Close();
				m_InfoBalloon.Dispose();
				m_InfoBalloon=null;
			}
		}

		private void CloseSearch()
		{
			if(m_Search!=null)
			{
				m_Search.Close();
				m_Search.Dispose();
				m_Search=null;
			}
		}

		public void SearchActiveDocument(string text)
		{
			try
			{
				string path=System.IO.Path.GetDirectoryName(Application.ExecutablePath)+@"\BillData\"+text+@".xml";
				System.Xml.XmlDocument xmldoc=new System.Xml.XmlDocument();
				xmldoc.Load(path);
				frmDocument doc=new frmDocument();
				doc.MdiParent=this;
				doc.WindowState=FormWindowState.Maximized;
				doc.Show();
				doc.Update();
				doc.Text=text;
				forOpen(doc,ref xmldoc);

			}
			catch
			{
				MessageBox.Show("未能打开发票信息，可能该发票不存在或数据已经被损坏！");
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
				if(crl.Controls[i].Name.Substring(0,3)=="Tbx")
				{
					crl.Controls[i].Text=xmldoc["Bill"][crl.Controls[i].Name].InnerText;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Cbx")
				{
					crl.Controls[i].Text=xmldoc["Bill"][crl.Controls[i].Name].InnerText;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Lbx")
				{
					ListView lvi=crl.Controls[i] as ListView;
					try
					{
						for(int j=0;j<6;j++)
						{
							ListViewItem lvitem=new ListViewItem();
							lvitem.Text=xmldoc["Bill"][crl.Controls[i].Name+j.ToString()+"0"].InnerText;
							lvitem.SubItems.Add(xmldoc["Bill"][crl.Controls[i].Name+j.ToString()+"1"].InnerText);
							lvitem.SubItems.Add(xmldoc["Bill"][crl.Controls[i].Name+j.ToString()+"2"].InnerText);
							lvitem.SubItems.Add(xmldoc["Bill"][crl.Controls[i].Name+j.ToString()+"3"].InnerText);
							lvi.Items.Add(lvitem);
						}
					}
					catch
					{}

//					for(int j=0;j<lvi.Items.Count;j++)
//					{
//						XmlElement newTitle=xmldoc.CreateElement(crl.Controls[i].Name+j.ToString());
//						newTitle.InnerText=lvi.Items[j].SubItems[0].Text;
//						xmldoc["Bill"].AppendChild(newTitle);
//					}
				}
			}
		}


		private void dotNetBarManager1_DockTabChange(object sender, DevComponents.DotNetBar.DockTabChangeEventArgs e)
		{
			Bar bar=sender as Bar;
			if(bar==null || e.NewTab==null)
				return;
			bar.Text=e.NewTab.Text;
		}
		private void PrintPreview()
		{
			this.pageSetupDialog1.ShowDialog();
			return;
		}
		private void Printer()
		{
//			PageSettings ps = new PageSettings();
//			ps.PaperSize = new PaperSize("ABC2",600,100);
//			ps.Margins = new Margins(0,0,0,0);
//			this.printDoc.DefaultPageSettings=ps;
			this.printDoc.DefaultPageSettings=this.pageSetupDialog1.PageSettings;
			this.printDoc.Print();
		}


		private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.HasMorePages = false;
//			e.Graphics.DrawString("江苏金茂",new Font("宋体",10F),Brushes.Black,192F,100F);

			try
			{
				string path=System.IO.Path.GetDirectoryName(Application.ExecutablePath)+@"\SetPoint.xml";
				System.Xml.XmlDocument xmldoc=new System.Xml.XmlDocument();
				xmldoc.Load(path);


			if(this.ActiveMdiChild==null)
				return;
			frmDocument doc=this.ActiveMdiChild as frmDocument;
			if(doc==null)
				return;
			this.forPrint(doc,ref e,ref xmldoc);
			}
			catch(Exception err)
			{
				MessageBox.Show("打印格式未被找到或已经损坏！");
				return;
			}


		}
		private void forPrint(System.Windows.Forms.Control crl,ref System.Drawing.Printing.PrintPageEventArgs e,ref System.Xml.XmlDocument xmldoc)
		{
			string font=xmldoc["Setup"]["Font"].InnerText;
			float size=float.Parse(xmldoc["Setup"]["Size"].InnerText);
			for(int i=0;i<crl.Controls.Count;i++)
			{
				if(crl.Controls[i].Controls.Count>0)
				{
					this.forPrint(crl.Controls[i],ref e,ref xmldoc);
				}
				if(crl.Controls[i].Name.Length<=3||crl.Controls[i].Name=="TbxID")
				{
					continue;
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Cbx"||crl.Controls[i].Name.Substring(0,3)=="Tbx")
				{
					try
					{
						float x=(float.Parse(xmldoc["Setup"][crl.Controls[i].Name].Attributes["x"].InnerText)+float.Parse(xmldoc["Setup"]["TheX"].InnerText))*40;
						float y=(float.Parse(xmldoc["Setup"][crl.Controls[i].Name].Attributes["y"].InnerText)+float.Parse(xmldoc["Setup"]["TheY"].InnerText))*40;
						e.Graphics.DrawString(crl.Controls[i].Text,new Font(font,size),Brushes.Black,x,y);
					}
					catch(Exception err)
					{
						string ii=err.ToString();
					}
				}
				if(crl.Controls[i].Name.Substring(0,3)=="Lbx")
				{
					ListView lvi=crl.Controls[i] as ListView;
					for(int j=0;j<lvi.Items.Count;j++)
					{
						for(int k=0;k<lvi.Items[j].SubItems.Count;k++)
						{
							try
							{
								float x=(float.Parse(xmldoc["Setup"][crl.Controls[i].Name].Attributes["x"].InnerText)+float.Parse(xmldoc["Setup"]["TheX"].InnerText)+float.Parse(xmldoc["Setup"][crl.Controls[i].Name].Attributes["row"+k.ToString()].InnerText))*40;
								float y=(float.Parse(xmldoc["Setup"][crl.Controls[i].Name].Attributes["y"].InnerText)+float.Parse(xmldoc["Setup"]["TheY"].InnerText)+float.Parse(xmldoc["Setup"][crl.Controls[i].Name].Attributes["cow"+j.ToString()].InnerText))*40;
								e.Graphics.DrawString(lvi.Items[j].SubItems[k].Text,new Font(font,size),Brushes.Black,x,y);
							}
							catch
							{}
						}
					}

				}
			}
		}

        private void barTopDockSite_Click(object sender, EventArgs e)
        {

        }
    }
}

