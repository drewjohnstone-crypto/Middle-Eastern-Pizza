Imports System.Numerics

Public Class Form2

    Public Delivery As Decimal

    Private Sub buttontomenu_Click(sender As Object, e As EventArgs) Handles buttontomenu.Click

        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub menureturn_Click(sender As Object, e As EventArgs) Handles menureturn.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class