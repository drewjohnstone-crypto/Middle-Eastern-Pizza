Public Class Form4
    Private Sub backmenu_Click(sender As Object, e As EventArgs) Handles backmenu.Click
        Application.Restart()
        Form1.Show()
    End Sub

    Private Sub receipt_Click(sender As Object, e As EventArgs) Handles receipt.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class