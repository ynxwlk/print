Imports DevComponents.DotNetBar
Public Class frmMain
    Inherits System.Windows.Forms.Form

    Private WithEvents m_CheckStyle As CheckBox
    Private WithEvents m_CheckTaskShowStartup As CheckBox

    Private m_Search As BalloonSearch
    Private m_InfoBalloon As Balloon

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents dotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tabStrip1 As DevComponents.DotNetBar.TabStrip
    Friend WithEvents timerInfoBallon As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.dotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerInfoBallon = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'dotNetBarManager1
        '
        Me.dotNetBarManager1.BottomDockSite = Me.barBottomDockSite
        Me.dotNetBarManager1.DefinitionName = "frmMain.dotNetBarManager1.xml"
        Me.dotNetBarManager1.Images = Me.imageList1
        Me.dotNetBarManager1.LeftDockSite = Me.barLeftDockSite
        Me.dotNetBarManager1.ParentForm = Me
        Me.dotNetBarManager1.RightDockSite = Me.barRightDockSite
        Me.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.dotNetBarManager1.TopDockSite = Me.barTopDockSite
        '
        'barBottomDockSite
        '
        Me.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barBottomDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 335)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(702, 128)
        Me.barBottomDockSite.TabIndex = 4
        Me.barBottomDockSite.TabStop = False
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.Location = New System.Drawing.Point(0, 74)
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 261)
        Me.barLeftDockSite.TabIndex = 1
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.Location = New System.Drawing.Point(538, 74)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(164, 261)
        Me.barRightDockSite.TabIndex = 2
        Me.barRightDockSite.TabStop = False
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(702, 74)
        Me.barTopDockSite.TabIndex = 3
        Me.barTopDockSite.TabStop = False
        '
        'tabStrip1
        '
        Me.tabStrip1.CanReorderTabs = True
        Me.tabStrip1.CloseButtonVisible = True
        Me.dotNetBarManager1.SetContextMenuEx(Me.tabStrip1, "bTabContext")
        Me.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabStrip1.ImageList = Nothing
        Me.tabStrip1.Location = New System.Drawing.Point(0, 74)
        Me.tabStrip1.MdiTabbedDocuments = True
        Me.tabStrip1.Name = "tabStrip1"
        Me.tabStrip1.SelectedTab = Nothing
        Me.tabStrip1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStrip1.Size = New System.Drawing.Size(538, 26)
        Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.OneNote
        Me.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.tabStrip1.TabIndex = 7
        Me.tabStrip1.Text = "tabStrip1"
        Me.tabStrip1.VariableTabWidth = False
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.FileName = "doc1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timerInfoBallon
        '
        Me.timerInfoBallon.Enabled = True
        Me.timerInfoBallon.Interval = 3000
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(702, 463)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabStrip1, Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite})
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub dotNetBarManager1_PopupContainerLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.PopupContainerLoad
        Dim item As ButtonItem = CType(sender, ButtonItem)

        If item Is Nothing Then Exit Sub

        If item.Name = "bTextColor" Or item.Name = "bTabColor" Then
            Dim container As PopupContainerControl = CType(item.PopupContainerControl, PopupContainerControl)
            Dim clr As ColorPicker = New ColorPicker()
            container.Controls.Add(clr)
            clr.Location = container.ClientRectangle.Location
            container.ClientSize = clr.Size
        End If

    End Sub

    Private Sub dotNetBarManager1_PopupContainerUnload(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.PopupContainerUnload
        Dim item As ButtonItem = CType(sender, ButtonItem)
        Dim clr As ColorPicker
        Dim container As PopupContainerControl

        If item Is Nothing Then Exit Sub

        If item.Name = "bTextColor" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
                If Not activedocument Is Nothing Then
                    activedocument.ExecuteCommand(item.Name, clr.SelectedColor)
                End If
            End If
        ElseIf item.Name = "bTabColor" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                tabStrip1.ColorScheme.TabBackground = ControlPaint.LightLight(clr.SelectedColor)
                tabStrip1.ColorScheme.TabBackground2 = clr.SelectedColor
                tabStrip1.Refresh()
            End If
            ' Close popup menu, since it is not closed when Popup Container is closed...
            item.Parent.Expanded = False
        End If
    End Sub

    Public Sub EditContextMenu()
        Dim objItem As ButtonItem = CType(dotNetBarManager1.ContextMenus("bEditPopup"), ButtonItem)
        objItem.Displayed = False
        objItem.PopupMenu(Control.MousePosition)
    End Sub

    Private Sub dotNetBarManager1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.ItemClick
        Dim objItem As BaseItem = CType(sender, BaseItem)
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        Select Case objItem.Name
            ' File menu
        Case "bNew", "bNewWindow"
                CreateNewDocument()

            Case "bTaskNewDocument"
                CreateNewDocument()

            Case "bOpen"
                OpenDocument()

            Case "bTaskOpenDocument"
                OpenDocument()

            Case "bSave"
                SaveDocument()

            Case "bSaveAs"
                SaveDocumentAs()

            Case "bClose"
                If Not activedocument Is Nothing Then
                    activedocument.Close()
                End If

            Case "bPageSetup"
                MessageBox.Show("Not implemented yet.")

            Case "bPrintPreview"
                MessageBox.Show("Not implemented yet.")

            Case "bPrint"
                MessageBox.Show("Not implemented yet.")

            Case "bExit"
                Me.Close()

                ' Window menu
            Case "bArrangeAll"
                Me.LayoutMdi(MdiLayout.Cascade)

            Case "window_list"
                CType(objItem.Tag, Form).Activate()

                ' Style switching
            Case "bSwitchStyle"
                If objItem.Style = eDotNetBarStyle.Office2000 Then
                    dotNetBarManager1.Style = eDotNetBarStyle.OfficeXP
                Else
                    dotNetBarManager1.Style = eDotNetBarStyle.Office2000
                End If
            Case "bTaskNewFromExisting"
                MessageBox.Show("Not implemented.")

            Case "bTaskHelp"
                MessageBox.Show("Starts the help file.")

            Case "bTaskSampleDoc"
                MessageBox.Show("This is only a sample item that when clicked should open most recently used document.")
            Case "bThemes"
                EnableThemes(CType(objItem, ButtonItem))
            Case "bStyle2000"
                ChangeDotNetBarStyle(eDotNetBarStyle.Office2000)
            Case "bStyle2003"
                ChangeDotNetBarStyle(eDotNetBarStyle.Office2003)
            Case "bStyleXP"
                ChangeDotNetBarStyle(eDotNetBarStyle.OfficeXP)
            Case "bFind"
                If m_Search Is Nothing OrElse m_Search.IsDisposed Then
                    m_Search = New BalloonSearch()
                    m_Search.Owner = Me
                    m_Search.Show(objItem, True)
                End If
            Case Else
                ' Pass them to the active document
                If Not activedocument Is Nothing Then
                    activedocument.ExecuteCommand(objItem.Name, Nothing)
                End If
        End Select
    End Sub

    Private Sub CreateNewDocument()
        Dim doc As frmDocument = New frmDocument()
        doc.MdiParent = Me
        doc.WindowState = FormWindowState.Maximized
        doc.Show()
        doc.Update()
        doc.Text = "New Document " + Me.MdiChildren.Length.ToString()
    End Sub

    Private Sub EnableFileItems()
        ' Accessing items through the Items collection and setting the properties on them
        ' will propagate certain properties to all items with the same name...
        If Me.ActiveMdiChild Is Nothing Then
            dotNetBarManager1.Items("bSave").Enabled = False
            dotNetBarManager1.Items("bSaveAs").Enabled = False
            dotNetBarManager1.Items("bPrint").Enabled = False
            dotNetBarManager1.Items("bPrintPreview").Enabled = False
            dotNetBarManager1.Items("bPageSetup").Enabled = False
        Else
            dotNetBarManager1.Items("bSave").Enabled = True
            dotNetBarManager1.Items("bSaveAs").Enabled = True
            dotNetBarManager1.Items("bPrint").Enabled = True
            dotNetBarManager1.Items("bPrintPreview").Enabled = True
            dotNetBarManager1.Items("bPageSetup").Enabled = True
        End If
    End Sub


    Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        EnableFileItems()
    End Sub

    Private Sub OpenDocument()
        openFileDialog1.FileName = ""
        openFileDialog1.ShowDialog()
        If openFileDialog1.FileName = "" Then Exit Sub
        Dim doc As frmDocument = New frmDocument()
        doc.Text = openFileDialog1.FileName
        doc.MdiParent = Me
        doc.Show()
        doc.OpenFile(openFileDialog1.FileName)
    End Sub

    Public Sub SaveDocument()
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        Dim doc As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        If doc Is Nothing Then Exit Sub
        If Not doc.DocumentChanged Then Exit Sub
        SaveDocument(doc)
    End Sub

    Public Sub SaveDocument(ByVal doc As frmDocument)
        If doc.FileName = "" Then
            Dim dr As DialogResult = saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName = "" Then Exit Sub
            If dr = DialogResult.OK Then doc.FileName = saveFileDialog1.FileName
        End If
        If doc.FileName <> "" Then doc.SaveFile()
    End Sub

    Private Sub SaveDocumentAs()
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        Dim doc As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        If doc Is Nothing Then Exit Sub
        If Not doc.DocumentChanged Then Exit Sub
        If doc.FileName = "" Then
            SaveDocument(doc)
            Exit Sub
        End If

        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName = "" Then Exit Sub

        doc.FileName = saveFileDialog1.FileName
        doc.SaveFile()
    End Sub


    Private Sub dotNetBarManager1_ContainerLoadControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.ContainerLoadControl
        Dim containerItem As ControlContainerItem
        Dim checkbox As CheckBox
        Dim item As BaseItem = CType(sender, BaseItem)

        If item Is Nothing Then Exit Sub

        If item.Name = "bChangeStyle" Then
            containerItem = CType(item, ControlContainerItem)
            checkbox = New CheckBox()
            checkbox.Text = "OfficeXP Style"
            checkbox.FlatStyle = FlatStyle.Flat
            checkbox.Size = New System.Drawing.Size(95, 17)
            checkbox.TabStop = False
            checkbox.Checked = True
            m_CheckStyle = checkbox
            containerItem.Control = m_CheckStyle
        ElseIf item.Name = "cTaskShowatstartup" Then
            containerItem = CType(item, ControlContainerItem)
            checkbox = New CheckBox()
            checkbox.Text = "Show at startup"
            checkbox.FlatStyle = FlatStyle.Flat
            checkbox.Size = New System.Drawing.Size(95, 17)
            checkbox.TabStop = False
            checkbox.Checked = True
            m_CheckTaskShowStartup = checkbox
            containerItem.Control = m_CheckTaskShowStartup
        ElseIf item.Name = "dockTaskList" Then
            ' See DefinitionLoaded event handler for Customize menu assignment for the bar that is containing this dock item 
            Dim dockItem As DockContainerItem = CType(item, DockContainerItem)
            dockItem.Control = New TaskList()
            ' Setting Displayed property for DockContainerItem will make sure that its tab is displayed first
            dockItem.Displayed = True
        ElseIf item.Name = "dockSearchResults" Then
            ' Just add the list box as a example...
            Dim dockItem As DockContainerItem = CType(item, DockContainerItem)
            Dim listbox As ListBox = New ListBox()
            ' This will set the minimum size for the DockContainerItem
            listbox.Size = New Size(32, 32)
            ' Must let the DockContainerItem resize it at will...
            listbox.IntegralHeight = False
            dockItem.Control = listbox
        End If
    End Sub

    Private Sub m_CheckStyle_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_CheckStyle.CheckedChanged
        If m_CheckStyle.Checked Then
            dotNetBarManager1.Style = eDotNetBarStyle.OfficeXP
            If dotNetBarManager1.IsThemeActive Then
                Dim item As BaseItem = dotNetBarManager1.GetItem("bThemes")
                item.Visible = True
                CType(item.ContainerControl, Bar).RecalcLayout()
            End If
        Else
            dotNetBarManager1.Style = eDotNetBarStyle.Office2000
            If dotNetBarManager1.IsThemeActive Then
                dotNetBarManager1.GetItem("bThemes").Visible = False
            End If
        End If
    End Sub

    Private Sub m_CheckTaskShowStartup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_CheckTaskShowStartup.CheckedChanged
        MessageBox.Show("This item is here for demonstration purposes only and code should be added to save the state of it.")
    End Sub

    Private Sub dotNetBarManager1_DefinitionLoaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.DefinitionLoaded
        ' Assign optional "Customize" menu to the bar that contains this item
        dotNetBarManager1.Bars("barTaskList").CustomizeMenu = CType(dotNetBarManager1.ContextMenus("bTaskListMenu"), PopupItem)
    End Sub

    Private Sub dotNetBarManager1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.MouseEnter
        ' Sync Status-bar with the item tooltip...
        Dim item As BaseItem = CType(sender, BaseItem)
        If item Is Nothing Then Exit Sub

        dotNetBarManager1.Bars("barStatus").Items("lStatus").Text = item.Tooltip

        ' Disable timer...
        If item.Name = "bThemes" And Timer1.Enabled Then
            Timer1.Enabled = False
            CType(item, ButtonItem).ForeColor = Color.Empty
        End If
    End Sub

    Private Sub dotNetBarManager1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.MouseLeave
        dotNetBarManager1.Bars("barStatus").Items("lStatus").Text = ""
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChangeDotNetBarStyle(eDotNetBarStyle.Office2003)

        ' This makes sure that Theme support is enabled by the end-user as well as present on this OS
        If dotNetBarManager1.IsThemeActive Then
            dotNetBarManager1.GetItem("bThemes").Visible = True
            Timer1.Enabled = True
        End If
        ' Neccessary for Automatic Tab-Strip Mdi support
        tabStrip1.MdiForm = Me

        ' Setup Context menu for the barTaskList TabStrip...
        Dim barTask As Bar = dotNetBarManager1.Bars("barTaskList")
        dotNetBarManager1.SetContextMenuEx(barTask, "bDockContext")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Flash Item to attract attention...
        Dim item As ButtonItem = CType(dotNetBarManager1.GetItem("bThemes"), ButtonItem)
        If item.ForeColor.Equals(Color.Red) Then
            item.ForeColor = Color.Empty
        Else
            item.ForeColor = Color.Red
        End If
    End Sub

    Private Sub EnableThemes(ByVal item As ButtonItem)
        Dim bEnable As Boolean = Not item.Checked
        item.Checked = bEnable
        If bEnable Then
            item.Text = "Disable Themes"
        Else
            item.Text = "Enable Themes"
        End If

        dotNetBarManager1.ThemeAware = bEnable
        Me.Refresh()
    End Sub

    Private Sub dotNetBarManager1_PopupOpen(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.PopupOpenEventArgs) Handles dotNetBarManager1.PopupOpen
        Dim item As BaseItem = CType(sender, BaseItem)
        If item Is Nothing Then Exit Sub

        If item.Name = "bTabContext" Then
            ' Enable/Disable the document related menu items based on where user right-clicked...
            Dim tab As TabItem = TabItemFromPoint(tabStrip1.PointToClient(Control.MousePosition))
            ' If no tab is under the mouse disable document related items...
            If tab Is Nothing Then
                item.SubItems("bClose").Enabled = False
                item.SubItems("bSave").Enabled = False
            Else
                item.SubItems("bClose").Enabled = True
                item.SubItems("bSave").Enabled = True
                ' Make sure that tab under the mouse is active tab
                tabStrip1.SelectedTab = tab
            End If
        ElseIf item.Name = "bDockContext" Then
            Dim barTask As Bar = dotNetBarManager1.Bars("barTaskList")
            ' Display our context menu only if user clicks on the bar caption or tab strip control
            If Not barTask.GrabHandleRect.Contains(barTask.PointToClient(Control.MousePosition)) AndAlso Not barTask.DockTabControl Is Nothing AndAlso Not barTask.DockTabControl.Bounds.Contains(barTask.PointToClient(Control.MousePosition)) Then
                e.Cancel = True
                Exit Sub
            End If
            item.SubItems.Clear()
            Dim contextItem As ButtonItem
            Dim dockItem As BaseItem
            For Each dockItem In barTask.Items
                contextItem = New ButtonItem(dockItem.Name, dockItem.Text)
                contextItem.GlobalItem = False
                AddHandler contextItem.Click, AddressOf DockContextClick
                item.SubItems.Add(contextItem)
                contextItem.Checked = dockItem.Visible
            Next
            contextItem = New ButtonItem("bc_tabnavigation", "Tab Navigation")
            contextItem.Checked = barTask.TabNavigation
            contextItem.BeginGroup = True
            AddHandler contextItem.Click, AddressOf DockContextClick
            item.SubItems.Add(contextItem)
        End If
    End Sub

    Private Sub DockContextClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As ButtonItem = CType(sender, ButtonItem)
        If item Is Nothing Then Exit Sub

        Dim barTask As Bar = dotNetBarManager1.Bars("barTaskList")
        If item.Name = "bc_tabnavigation" Then
            barTask.TabNavigation = Not item.Checked
            barTask.DockTabControl.Refresh()
            Exit Sub
        End If

        If barTask.Items.Contains(item.Name) Then
            barTask.Items(item.Name).Visible = Not item.Checked
            barTask.RecalcLayout()
        End If
    End Sub

    Private Function TabItemFromPoint(ByVal pClient As Point) As TabItem
        TabItemFromPoint = Nothing
        If Not tabStrip1.ClientRectangle.Contains(pClient) Then Exit Function

        Dim tab As TabItem
        For Each tab In tabStrip1.Tabs
            If tab.Visible And tab.DisplayRectangle.Contains(pClient) Then
                TabItemFromPoint = tab
                Exit Function
            End If
        Next
    End Function

    Private Sub ChangeDotNetBarStyle(ByVal style As eDotNetBarStyle)
        CType(dotNetBarManager1.GetItem("bStyle2000"), ButtonItem).Checked = (style = eDotNetBarStyle.Office2000)
        CType(dotNetBarManager1.GetItem("bStyle2003"), ButtonItem).Checked = (style = eDotNetBarStyle.Office2003)
        CType(dotNetBarManager1.GetItem("bStyleXP"), ButtonItem).Checked = (style = eDotNetBarStyle.OfficeXP)

        dotNetBarManager1.Style = style
        If style = eDotNetBarStyle.Office2003 Or style = eDotNetBarStyle.OfficeXP Then
            If dotNetBarManager1.IsThemeActive Then
                Dim item As BaseItem = dotNetBarManager1.GetItem("bThemes")
                item.Visible = True
                CType(item.ContainerControl, Bar).RecalcLayout()
            End If
        ElseIf dotNetBarManager1.IsThemeActive Then
            dotNetBarManager1.GetItem("bThemes").Visible = False
        End If
        If style = eDotNetBarStyle.Office2003 Then
            tabStrip1.Style = eTabStripStyle.OneNote
            dotNetBarManager1.Bars("barTaskPane").BackColor = Color.Empty
            CType(dotNetBarManager1.GetItem("cTaskShowatstartup"), ControlContainerItem).Control.BackColor = dotNetBarManager1.Bars(0).ColorScheme.BarBackground2
        Else
            tabStrip1.Style = eTabStripStyle.Flat
            dotNetBarManager1.Bars("barTaskPane").BackColor = Color.FromArgb(245, 245, 245)
            CType(dotNetBarManager1.GetItem("cTaskShowatstartup"), ControlContainerItem).Control.BackColor = Color.FromArgb(245, 245, 245)
        End If
    End Sub

    Private Sub timerInfoBallon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerInfoBallon.Tick
        timerInfoBallon.Enabled = False
        m_InfoBalloon = New Balloon()
        m_InfoBalloon.CaptionImage = New Bitmap(GetType(frmMain), "Info.png")
        m_InfoBalloon.CaptionText = "New DotNetBar Feature Alert..."
        m_InfoBalloon.Text = "DotNetBar now includes Balloon control to help you convey your information effectively to the end-user.\nCheck out Find command implementation in this sample for an example of highly customized Balloon control."
        m_InfoBalloon.AutoResize()
        Dim item As BaseItem = dotNetBarManager1.Bars("edit").Items("bFind")
        m_InfoBalloon.AutoCloseTimeOut = 10
        m_InfoBalloon.Owner = Me
        m_InfoBalloon.Show(item, False)
    End Sub

    Private Sub frmMain_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
        CloseInfoBalloon()
        CloseSearch()
    End Sub

    Private Sub CloseInfoBalloon()
        If Not m_InfoBalloon Is Nothing Then
            m_InfoBalloon.Close()
            m_InfoBalloon.Dispose()
            m_InfoBalloon = Nothing
        End If
    End Sub

    Private Sub CloseSearch()
        If (Not m_Search Is Nothing) Then
            m_Search.Close()
            m_Search.Dispose()
            m_Search = Nothing
        End If
    End Sub

    Public Sub SearchActiveDocument(ByVal text As String)
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand("bFind", text)
        End If
    End Sub
End Class
