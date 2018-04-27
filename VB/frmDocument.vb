Public Class frmDocument
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents rtfText As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rtfText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtfText
        '
        Me.rtfText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfText.HideSelection = False
        Me.rtfText.Name = "rtfText"
        Me.rtfText.Size = New System.Drawing.Size(217, 154)
        Me.rtfText.TabIndex = 0
        Me.rtfText.Text = ""
        '
        'frmDocument
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(217, 154)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rtfText})
        Me.Name = "frmDocument"
        Me.Text = "frmDocument"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public DocumentChanged As Boolean = False
    Public FileName As String = ""

    Public Sub ExecuteCommand(ByVal cmd As String, ByVal data As Object)
        Select Case cmd
            ' Edit Menu
        Case "bUndo"
                rtfText.Undo()
            Case "bCut"
                rtfText.Cut()
            Case "bCopy"
                rtfText.Copy()
            Case "bPaste"
                rtfText.Paste()
            Case "bDelete"
                rtfText.SelectedText = ""
            Case "bSelectAll"
                rtfText.SelectAll()
            Case "bFind"
                If Not data Is Nothing Then
                    Dim searchText As String = data.ToString()
                    rtfText.Find(searchText, rtfText.SelectionStart + rtfText.SelectionLength, RichTextBoxFinds.None)
                End If
            Case "bFindNext"
                    MessageBox.Show("Not implemented yet.")
            Case "bReplace"
                    MessageBox.Show("Not implemented yet.")
                    ' Format menu
            Case "bBold"
                    If rtfText.SelectionFont.Bold Then
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Bold)))
                    Else
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Bold))
                    End If
            Case "bItalic"
                    If rtfText.SelectionFont.Italic Then
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Italic)))
                    Else
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Italic))
                    End If
            Case "bUnderline"
                    If rtfText.SelectionFont.Underline Then
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Underline)))
                    Else
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Underline))
                    End If
            Case "bStrikethrough"
                    If rtfText.SelectionFont.Strikeout Then
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Strikeout)))
                    Else
                        rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Strikeout))
                    End If
            Case "bAlignLeft"
                    rtfText.SelectionAlignment = HorizontalAlignment.Left
            Case "bAlignCenter"
                    rtfText.SelectionAlignment = HorizontalAlignment.Center
            Case "bAlignRight"
                    rtfText.SelectionAlignment = HorizontalAlignment.Right
            Case "bTextColor"
                    If Not data Is Nothing And TypeOf (data) Is Color Then
                        rtfText.SelectionColor = CType(data, Color)
                    End If
			end select
        DocumentChanged = True
        EnableSelectionItems()
    End Sub

    Private Sub frmDocument_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim mdi As frmMain = CType(Me.ParentForm, frmMain)
        Dim m As DevComponents.DotNetBar.DotNetBarManager = mdi.dotNetBarManager1
        m.Bars("barStatus").Items("lPosition").Text = ""
        DisableDocMenuItems()
    End Sub

    Private Sub frmDocument_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.DocumentChanged Then
            Dim dlg As DialogResult = MessageBox.Show(Me, "Document '" + Me.FileName + "' has changed. Save changes?", "Notepad", MessageBoxButtons.YesNoCancel)
            If dlg = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf dlg = DialogResult.Yes Then
                If Me.FileName = "" Then CType(Me.MdiParent, frmMain).SaveDocument(Me)
                If Me.FileName <> "" Then SaveFile()
            End If
        End If
    End Sub

    Private Sub frmDocument_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnableDocMenuItems()
        UpdateStatusBar()
    End Sub

    Private Sub frmDocument_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        DisableDocMenuItems()
    End Sub

    Private Sub frmDocument_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            EnableDocMenuItems()
        Else
            DisableDocMenuItems()
        End If
    End Sub

    Private Sub rtfText_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtfText.SelectionChanged
        EnableSelectionItems()
    End Sub

    Private Sub rtfText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtfText.TextChanged
        DocumentChanged = True
    End Sub

    Private Sub rtfText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtfText.MouseDown
        If e.Button <> MouseButtons.Right Then Exit Sub

        Dim mdi As frmMain = CType(Me.ParentForm, frmMain)
        mdi.EditContextMenu()
    End Sub

    Private Sub UpdateStatusBar()
        Dim mdi As frmMain = CType(Me.ParentForm, frmMain)
        Dim m As DevComponents.DotNetBar.DotNetBarManager = mdi.dotNetBarManager1
        m.Bars("barStatus").Items("lPosition").Text = "Ln " + (rtfText.GetLineFromCharIndex(rtfText.SelectionStart) + 1).ToString() + Chr(9) + "Ch " + rtfText.SelectionStart.ToString()
    End Sub

    Private Sub EnableSelectionItems()
        Dim mdi As frmMain = CType(Me.ParentForm, frmMain)
        Dim m As DevComponents.DotNetBar.DotNetBarManager = mdi.dotNetBarManager1

        UpdateStatusBar()

        If rtfText.SelectionLength = 0 Then
            m.Items("bCut").Enabled = False
            m.Items("bCopy").Enabled = False
            m.Items("bDelete").Enabled = False
        Else
            m.Items("bCut").Enabled = True
            m.Items("bCopy").Enabled = True
            m.Items("bDelete").Enabled = True
        End If

        CType(m.Items("bBold"), DevComponents.DotNetBar.ButtonItem).Checked = rtfText.SelectionFont.Bold
        CType(m.Items("bItalic"), DevComponents.DotNetBar.ButtonItem).Checked = rtfText.SelectionFont.Italic
        CType(m.Items("bUnderline"), DevComponents.DotNetBar.ButtonItem).Checked = rtfText.SelectionFont.Underline
        CType(m.Items("bStrikethrough"), DevComponents.DotNetBar.ButtonItem).Checked = rtfText.SelectionFont.Strikeout
        CType(m.Items("bAlignLeft"), DevComponents.DotNetBar.ButtonItem).Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Left)
        CType(m.Items("bAlignRight"), DevComponents.DotNetBar.ButtonItem).Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Right)
        CType(m.Items("bAlignCenter"), DevComponents.DotNetBar.ButtonItem).Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Center)
    End Sub

    Private Sub EnableDocMenuItems()
        If Not Me.Visible Then Exit Sub

        Dim mdi As frmMain = CType(Me.ParentForm, frmMain)
        Dim m As DevComponents.DotNetBar.DotNetBarManager = mdi.dotNetBarManager1

        ' Disabled Edit items
        m.Items("bPaste").Enabled = True
        m.Items("bSelectAll").Enabled = True
        m.Items("bFind").Enabled = True
        m.Items("bFindNext").Enabled = True
        m.Items("bReplace").Enabled = True

        ' Disable Format items
        m.Items("bAlignLeft").Enabled = True
        m.Items("bAlignRight").Enabled = True
        m.Items("bAlignCenter").Enabled = True

        m.Items("bBold").Enabled = True
        m.Items("bItalic").Enabled = True
        m.Items("bUnderline").Enabled = True
        m.Items("bStrikethrough").Enabled = True

        m.Items("bTextColor").Enabled = True

        EnableSelectionItems()
    End Sub

    Private Sub DisableDocMenuItems()
        Dim mdi As frmMain = CType(Me.ParentForm, frmMain)
        Dim m As DevComponents.DotNetBar.DotNetBarManager = mdi.dotNetBarManager1

        ' Disabled Edit items
        m.Items("bCut").Enabled = False
        m.Items("bCopy").Enabled = False
        m.Items("bPaste").Enabled = False
        m.Items("bDelete").Enabled = False
        m.Items("bSelectAll").Enabled = False
        m.Items("bFind").Enabled = False
        m.Items("bFindNext").Enabled = False
        m.Items("bReplace").Enabled = False

        ' Disable Format items
        m.Items("bBold").Enabled = False
        m.Items("bItalic").Enabled = False
        m.Items("bUnderline").Enabled = False
        m.Items("bStrikethrough").Enabled = False
        m.Items("bAlignLeft").Enabled = False
        m.Items("bAlignRight").Enabled = False
        m.Items("bAlignCenter").Enabled = False
        m.Items("bTextColor").Enabled = False
    End Sub

    Public Sub OpenFile(ByVal filename As String)
        If filename.Substring(filename.Length - 4, 4).ToLower() = ".txt" Then
            rtfText.LoadFile(filename, RichTextBoxStreamType.PlainText)
        Else
            rtfText.LoadFile(filename, RichTextBoxStreamType.RichText)
        End If
        Me.FileName = filename
        DocumentChanged = False
    End Sub
    Public Sub SaveFile()
        If Me.FileName.Substring(Me.FileName.Length - 4, 4).ToLower() = ".txt" Then
            rtfText.SaveFile(Me.FileName, RichTextBoxStreamType.PlainText)
        Else
            rtfText.LoadFile(Me.FileName, RichTextBoxStreamType.RichText)
        End If
        DocumentChanged = False
    End Sub

End Class
