﻿Public Class Form3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl12jam.Text = Format(Now, "h:mm:ss tt")
        Lbl24jam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTtanggal.Format = DateTimePickerFormat.Custom
        DTtanggal.CustomFormat = "dddd,dd/MM/yyyy"
        DTtanggal.Value = Format(Now)
    End Sub
End Class