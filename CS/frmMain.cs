using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

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
		private System.Windows.Forms.MdiClient mdiClient1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Timer timer1;
		private DevComponents.DotNetBar.TabStrip tabStrip1;
		private System.ComponentModel.IContainer components;
		private BalloonSearch m_Search=null;
		private Balloon m_InfoBalloon=null;
		private System.Windows.Forms.Timer timerInfoBallon;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			mdiClient1.ControlAdded+=new ControlEventHandler(MdiClientControlAddRemove);
			mdiClient1.ControlRemoved+=new ControlEventHandler(MdiClientControlAddRemove);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.mdiClient1 = new System.Windows.Forms.MdiClient();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
			this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
			this.barBottomDockSite = new DevComponents.DotNetBar.DockSite();
			this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
			this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timerInfoBallon = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "*.rtf";
			this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
			this.openFileDialog1.FilterIndex = 2;
			this.openFileDialog1.Title = "Open File";
			// 
			// mdiClient1
			// 
			this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mdiClient1.Location = new System.Drawing.Point(0, 100);
			this.mdiClient1.Name = "mdiClient1";
			this.mdiClient1.TabIndex = 5;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.BackgroundImageAlpha = ((System.Byte)(255));
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.Location = new System.Drawing.Point(0, 74);
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 278);
			this.barLeftDockSite.TabIndex = 3;
			this.barLeftDockSite.TabStop = false;
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.BackgroundImageAlpha = ((System.Byte)(255));
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.Size = new System.Drawing.Size(683, 74);
			this.barTopDockSite.TabIndex = 1;
			this.barTopDockSite.TabStop = false;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "*.rtf";
			this.saveFileDialog1.FileName = "doc1";
			this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
			this.saveFileDialog1.FilterIndex = 2;
			this.saveFileDialog1.Title = "Save File";
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
			this.dotNetBarManager1.PopupContainerLoad += new System.EventHandler(this.LoadPopup);
			this.dotNetBarManager1.MouseLeave += new System.EventHandler(this.dotNetBarManager1_MouseLeave);
			this.dotNetBarManager1.ContainerLoadControl += new System.EventHandler(this.ContainerLoadControl);
			this.dotNetBarManager1.ItemClick += new System.EventHandler(this.BarItemClick);
			this.dotNetBarManager1.DockTabChange += new DevComponents.DotNetBar.DotNetBarManager.DockTabChangeEventHandler(this.dotNetBarManager1_DockTabChange);
			this.dotNetBarManager1.MouseEnter += new System.EventHandler(this.dotNetBarManager1_MouseEnter);
			this.dotNetBarManager1.DefinitionLoaded += new System.EventHandler(this.ManagerDefinitionLoaded);
			this.dotNetBarManager1.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.dotNetBarManager1_PopupOpen);
			this.dotNetBarManager1.PopupContainerUnload += new System.EventHandler(this.UnloadPopup);
			// 
			// barBottomDockSite
			// 
			this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barBottomDockSite.BackgroundImageAlpha = ((System.Byte)(255));
			this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 352);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.Size = new System.Drawing.Size(683, 128);
			this.barBottomDockSite.TabIndex = 2;
			this.barBottomDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.BackgroundImageAlpha = ((System.Byte)(255));
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.Location = new System.Drawing.Point(519, 74);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.Size = new System.Drawing.Size(164, 278);
			this.barRightDockSite.TabIndex = 4;
			this.barRightDockSite.TabStop = false;
			// 
			// tabStrip1
			// 
			this.tabStrip1.CanReorderTabs = true;
			this.tabStrip1.CloseButtonVisible = true;
			this.dotNetBarManager1.SetContextMenuEx(this.tabStrip1, "bTabContext");
			this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabStrip1.Location = new System.Drawing.Point(0, 74);
			this.tabStrip1.MdiTabbedDocuments = true;
			this.tabStrip1.Name = "tabStrip1";
			this.tabStrip1.SelectedTab = null;
			this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabStrip1.Size = new System.Drawing.Size(519, 26);
			this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.OneNote;
			this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
			this.tabStrip1.TabIndex = 6;
			this.tabStrip1.Text = "tabStrip1";
			this.tabStrip1.VariableTabWidth = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timerInfoBallon
			// 
			this.timerInfoBallon.Enabled = true;
			this.timerInfoBallon.Interval = 3000;
			this.timerInfoBallon.Tick += new System.EventHandler(this.timerInfoBallon_Tick);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(683, 480);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabStrip1,
																		  this.barLeftDockSite,
																		  this.barRightDockSite,
																		  this.barTopDockSite,
																		  this.barBottomDockSite,
																		  this.mdiClient1});
			this.IsMdiContainer = true;
			this.Name = "frmMain";
			this.Text = "DotNetBar Notepad Sample";
			this.MdiChildActivate += new System.EventHandler(this.MdiChildActivated);
			this.Load += new System.EventHandler(this.frmMain_Load);
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
			ButtonItem objItem=dotNetBarManager1.ContextMenus["bEditPopup"] as ButtonItem;
			objItem.Displayed=false;
			objItem.PopupMenu(Control.MousePosition);
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
					OpenDocument();
					break;
				case "bTaskOpenDocument":
					OpenDocument();
					break;
				case "bSave":
					SaveDocument();
					break;
				case "bSaveAs":
					SaveDocumentAs();
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
					MessageBox.Show("Not implemented yet.");
					break;
				case "bPrint":
					MessageBox.Show("Not implemented yet.");
					break;
				case "bExit":
					this.Close();
					break;
				// Window menu
				case "bArrangeAll":
					this.LayoutMdi(MdiLayout.Cascade);
					break;
				case "bNewWindow":
					goto case "bNew";
				case "window_list":
					((Form)objItem.Tag).Activate();
					break;
				// Style switching
				case "bSwitchStyle":
					dotNetBarManager1.Style=(objItem.Style==eDotNetBarStyle.Office2000)?eDotNetBarStyle.OfficeXP:eDotNetBarStyle.Office2000;
					break;
				case "bTaskNewFromExisting":
					MessageBox.Show("Not implemented.");
					break;
				case "bTaskHelp":
					MessageBox.Show("Starts the help file.");
					break;
				case "bTaskSampleDoc":
					MessageBox.Show("This is only a sample item that when clicked should open most recently used document.");
					break;
				case "bThemes":
					EnableThemes((ButtonItem)objItem);
					break;
				case "bTabbedMdi":
				{
					ButtonItem button=objItem as ButtonItem;
					SwitchWorkingMode(!button.Checked);
					button.Checked=!button.Checked;
					break;
				}
				case "bStyle2000":
					ChangeDotNetBarStyle(eDotNetBarStyle.Office2000);
					break;
				case "bStyle2003":
					ChangeDotNetBarStyle(eDotNetBarStyle.Office2003);
					break;
				case "bStyleXP":
					ChangeDotNetBarStyle(eDotNetBarStyle.OfficeXP);
					break;
				case "bFind":
				{
					if(m_Search==null || m_Search.IsDisposed)
					{
						m_Search=new BalloonSearch();
						m_Search.Owner=this;
						m_Search.Show(objItem,true);
					}
					break;
				}
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
			doc.Text="New Document "+this.MdiChildren.Length.ToString();
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

		private void OpenDocument()
		{
			openFileDialog1.FileName="";
			openFileDialog1.ShowDialog();
			if(openFileDialog1.FileName=="")
				return;
			frmDocument doc=new frmDocument();
			doc.Text=openFileDialog1.FileName;
			doc.MdiParent=this;
			doc.Show();
			doc.OpenFile(openFileDialog1.FileName);
		}

		/// <summary>
		/// Save active document
		/// </summary>
		private void SaveDocument()
		{
			if(this.ActiveMdiChild==null)
				return;
			frmDocument doc=this.ActiveMdiChild as frmDocument;
			if(doc==null || !doc.DocumentChanged)
				return;
            SaveDocument(doc);
		}
		internal void SaveDocument(frmDocument doc)
		{
			if(doc.FileName=="")
			{
				if(saveFileDialog1.ShowDialog()!=DialogResult.OK)
					return;
				if(saveFileDialog1.FileName=="")
					return;
				doc.FileName=saveFileDialog1.FileName;
			}
			if(doc.FileName!="")
				doc.SaveFile();
		}
		private void SaveDocumentAs()
		{
			if(this.ActiveMdiChild==null)
				return;
			frmDocument doc=this.ActiveMdiChild as frmDocument;
			if(doc==null || !doc.DocumentChanged)
				return;
			if(doc.FileName=="")
			{
				SaveDocument(doc);
				return;
			}

			saveFileDialog1.ShowDialog();
			if(saveFileDialog1.FileName=="")
				return;
			doc.FileName=saveFileDialog1.FileName;
			doc.SaveFile();
		}

		private void LoadPopup(object sender, System.EventArgs e)
		{
			ButtonItem item=sender as ButtonItem;
			if(item.Name=="bTextColor" || item.Name=="bTabColor")
			{
				DevComponents.DotNetBar.PopupContainerControl container=item.PopupContainerControl as PopupContainerControl;
				ColorPicker clr=new ColorPicker();
				container.Controls.Add(clr);
				if(((ButtonItem)dotNetBarManager1.GetItem("bStyle2003")).Checked)
				{
					clr.BackColor=dotNetBarManager1.Bars[0].ColorScheme.BarBackground2;
					clr.tabStrip1.Style=eTabStripStyle.Office2003;
				}
				clr.Location=container.ClientRectangle.Location;
				container.ClientSize=clr.Size;
			}
		}

		private void UnloadPopup(object sender, System.EventArgs e)
		{
			ButtonItem item=sender as ButtonItem;
			if(item.Name=="bTextColor")
			{
				DevComponents.DotNetBar.PopupContainerControl container=item.PopupContainerControl as PopupContainerControl;
				ColorPicker clr=container.Controls[0] as ColorPicker;
				if(clr.SelectedColor!=Color.Empty)
				{
					frmDocument activedocument=this.ActiveMdiChild as frmDocument;
					if(activedocument!=null)
						activedocument.ExecuteCommand(item.Name,clr.SelectedColor);
				}
			}	
			else if(item.Name=="bTabColor")
			{
				DevComponents.DotNetBar.PopupContainerControl container=item.PopupContainerControl as PopupContainerControl;
				ColorPicker clr=container.Controls[0] as ColorPicker;
				if(clr.SelectedColor!=Color.Empty)
				{
					tabStrip1.ColorScheme.TabBackground=ControlPaint.LightLight(clr.SelectedColor);
					tabStrip1.ColorScheme.TabBackground2=clr.SelectedColor;
					tabStrip1.Refresh();
				}
				// Close popup menu, since it is not closed when Popup Container is closed...
				item.Parent.Expanded=false;
			}
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
				// See DefinitionLoaded event handler for Customize menu assignment for the bar that is containing this dock item 
				DockContainerItem dockItem=item as DockContainerItem;
				dockItem.Control=new TaskList();
				// Setting Displayed property for DockContainerItem will make sure that its tab is displayed first
				dockItem.Displayed=true;
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
			if(item.Name=="bThemes" && timer1.Enabled)
			{
				timer1.Enabled=false;
				((ButtonItem)item).ForeColor=Color.Empty;
			}
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
			if(dotNetBarManager1.IsThemeActive)
			{
				dotNetBarManager1.GetItem("bThemes").Visible=true;
				timer1.Enabled=true;
			}

			// Neccessary for Automatic Tab-Strip Mdi support
			tabStrip1.MdiForm=this;

			// Setup Context menu for the barTaskList TabStrip...
			Bar bar=dotNetBarManager1.Bars["barTaskList"];
			dotNetBarManager1.SetContextMenuEx(bar,"bDockContext");
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// Flash Item to attract attention...
            ButtonItem item=dotNetBarManager1.GetItem("bThemes") as ButtonItem;
			if(item.ForeColor==Color.Red)
				item.ForeColor=Color.Empty;
			else
				item.ForeColor=Color.Red;

			ProgressBarItem progress=dotNetBarManager1.GetItem("itemProgressBar") as ProgressBarItem;
			if(progress.Value==progress.Maximum)
				progress.Value=progress.Minimum;
			else
				progress.Increment(10);
		}

		private void EnableThemes(ButtonItem item)
		{
			bool bEnable=!item.Checked;
			item.Checked=bEnable;
			if(bEnable)
				item.Text="Disable Themes";
			else
				item.Text="Enable Themes";

			dotNetBarManager1.ThemeAware=bEnable;

			if(bEnable)
                tabStrip1.Style=eTabStripStyle.Themed;
			else if(((ButtonItem)dotNetBarManager1.GetItem("bStyle2003")).Checked)
				tabStrip1.Style=eTabStripStyle.Office2003;
			else
				tabStrip1.Style=eTabStripStyle.Flat;

			this.Refresh();
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

		private void timerInfoBallon_Tick(object sender, System.EventArgs e)
		{
			timerInfoBallon.Enabled=false;
			m_InfoBalloon=new Balloon();
			m_InfoBalloon.CaptionImage=new Bitmap(typeof(frmMain),"Info.png");
			m_InfoBalloon.CaptionText="New DotNetBar Feature Alert...";
			m_InfoBalloon.Text="DotNetBar now includes Balloon control to help you convey your information effectively to the end-user.\nCheck out Find command implementation in this sample for an example of highly customized Balloon control.";
			m_InfoBalloon.AutoResize();
			BaseItem item=dotNetBarManager1.Bars["edit"].Items["bFind"];
			m_InfoBalloon.AutoCloseTimeOut=10;
			m_InfoBalloon.Owner=this;
			m_InfoBalloon.Show(item,false);
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
			frmDocument activedocument=this.ActiveMdiChild as frmDocument;
			if(activedocument!=null)
				activedocument.ExecuteCommand("bFind",text);
		}

		private void dotNetBarManager1_DockTabChange(object sender, DevComponents.DotNetBar.DockTabChangeEventArgs e)
		{
			Bar bar=sender as Bar;
			if(bar==null || e.NewTab==null)
				return;
			bar.Text=e.NewTab.Text;
		}
	}
}

