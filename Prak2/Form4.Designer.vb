<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        BaruToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        RchTeks = New RichTextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        RegularToolStripMenuItem = New ToolStripMenuItem()
        BoldToolStripMenuItem = New ToolStripMenuItem()
        kotak_dialog = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, BaruToolStripMenuItem, SimpanToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(46, 24)
        ToolStripMenuItem1.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(142, 26)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' BaruToolStripMenuItem
        ' 
        BaruToolStripMenuItem.Name = "BaruToolStripMenuItem"
        BaruToolStripMenuItem.Size = New Size(142, 26)
        BaruToolStripMenuItem.Text = "Baru"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(142, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' RchTeks
        ' 
        RchTeks.ContextMenuStrip = ContextMenuStrip1
        RchTeks.Location = New Point(12, 72)
        RchTeks.Name = "RchTeks"
        RchTeks.Size = New Size(265, 190)
        RchTeks.TabIndex = 1
        RchTeks.Text = ""
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {RegularToolStripMenuItem, BoldToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(130, 52)
        ' 
        ' RegularToolStripMenuItem
        ' 
        RegularToolStripMenuItem.Name = "RegularToolStripMenuItem"
        RegularToolStripMenuItem.Size = New Size(129, 24)
        RegularToolStripMenuItem.Text = "Regular"
        ' 
        ' BoldToolStripMenuItem
        ' 
        BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        BoldToolStripMenuItem.Size = New Size(129, 24)
        BoldToolStripMenuItem.Text = "Bold"
        ' 
        ' kotak_dialog
        ' 
        kotak_dialog.FileName = "OpenFileDialog1"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RchTeks)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NotePad"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RchTeks As RichTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents kotak_dialog As OpenFileDialog
    Friend WithEvents RegularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoldToolStripMenuItem As ToolStripMenuItem
End Class
