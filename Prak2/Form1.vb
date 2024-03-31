Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
        Lbl_Font.Font.Style Xor FontStyle.Regular)
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
        Lbl_Font.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif",
        Lbl_Font.Font.Size, Lbl_Font.Font.Style Xor FontStyle.Bold)
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif",
        Lbl_Font.Font.Size, Lbl_Font.Font.Style Xor FontStyle.Bold Xor FontStyle.Italic)
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
        Lbl_Font.Font.Style Xor FontStyle.Strikeout)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
        Lbl_Font.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
End Class
