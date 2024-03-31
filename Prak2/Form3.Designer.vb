<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Lbl12jam = New Label()
        Lbl24jam = New Label()
        DTtanggal = New DateTimePicker()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Lbl12jam
        ' 
        Lbl12jam.AutoSize = True
        Lbl12jam.Location = New Point(55, 131)
        Lbl12jam.Name = "Lbl12jam"
        Lbl12jam.Size = New Size(53, 20)
        Lbl12jam.TabIndex = 0
        Lbl12jam.Text = "Label1"
        ' 
        ' Lbl24jam
        ' 
        Lbl24jam.AutoSize = True
        Lbl24jam.Location = New Point(55, 188)
        Lbl24jam.Name = "Lbl24jam"
        Lbl24jam.Size = New Size(53, 20)
        Lbl24jam.TabIndex = 1
        Lbl24jam.Text = "Label2"
        ' 
        ' DTtanggal
        ' 
        DTtanggal.Location = New Point(55, 240)
        DTtanggal.Name = "DTtanggal"
        DTtanggal.Size = New Size(250, 27)
        DTtanggal.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DTtanggal)
        Controls.Add(Lbl24jam)
        Controls.Add(Lbl12jam)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Timer dan DateTimePicker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl12jam As Label
    Friend WithEvents Lbl24jam As Label
    Friend WithEvents DTtanggal As DateTimePicker
    Friend WithEvents Timer1 As Timer
End Class
