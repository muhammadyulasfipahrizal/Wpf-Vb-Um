<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GroupBox1 As GroupBox
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        FontDialog1 = New FontDialog()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox2 = New GroupBox()
        Lbl_Font = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Location = New Point(115, 111)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(185, 268)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Efek"
        GroupBox1.UseWaitCursor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(19, 87)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(98, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "UnderLine"
        CheckBox2.UseVisualStyleBackColor = True
        CheckBox2.UseWaitCursor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(19, 45)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(92, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "StrikeOut"
        CheckBox1.TextAlign = ContentAlignment.MiddleRight
        CheckBox1.UseVisualStyleBackColor = True
        CheckBox1.UseWaitCursor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(18, 35)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(81, 24)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Regular"
        RadioButton1.UseVisualStyleBackColor = True
        RadioButton1.UseWaitCursor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(18, 87)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(62, 24)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "Italic"
        RadioButton2.UseVisualStyleBackColor = True
        RadioButton2.UseWaitCursor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(18, 142)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(61, 24)
        RadioButton3.TabIndex = 5
        RadioButton3.TabStop = True
        RadioButton3.Text = "Bold"
        RadioButton3.UseVisualStyleBackColor = True
        RadioButton3.UseWaitCursor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(18, 190)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(93, 24)
        RadioButton4.TabIndex = 6
        RadioButton4.TabStop = True
        RadioButton4.Text = "BoldItalic"
        RadioButton4.UseVisualStyleBackColor = True
        RadioButton4.UseWaitCursor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Location = New Point(421, 111)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(170, 247)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "FontStyle"
        GroupBox2.UseWaitCursor = True
        ' 
        ' Lbl_Font
        ' 
        Lbl_Font.BorderStyle = BorderStyle.Fixed3D
        Lbl_Font.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Font.Location = New Point(198, 9)
        Lbl_Font.Name = "Lbl_Font"
        Lbl_Font.Size = New Size(303, 70)
        Lbl_Font.TabIndex = 9
        Lbl_Font.Text = "CheckBox dan RadioButton "
        Lbl_Font.TextAlign = ContentAlignment.MiddleCenter
        Lbl_Font.UseWaitCursor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(539, 370)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Form2"
        Button1.UseVisualStyleBackColor = True
        Button1.UseWaitCursor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(660, 370)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 10
        Button2.Text = "Form3"
        Button2.UseVisualStyleBackColor = True
        Button2.UseWaitCursor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(539, 408)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 11
        Button3.Text = "Form4"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Lbl_Font)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "CheckBox Dan RadioButton"
        UseWaitCursor = True
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_Font As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
