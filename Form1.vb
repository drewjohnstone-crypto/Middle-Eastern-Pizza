Imports System.Reflection.Emit

Public Class Form1

    Private Sub pickup_Click(sender As Object, e As EventArgs) Handles pickup.Click
        Form2.Delivery = 0 'makes it so that if selected pick up, the delivery cost = 0
        Me.Hide() 'hides form 1
        Form3.Show() 'shows form 3


    End Sub

    Private Sub delivery_Click(sender As Object, e As EventArgs) Handles delivery.Click
        Form2.Delivery = 3 'makes delivery = 3, which will add to total cost
        Me.Hide() 'hides form 1
        Form2.Show() 'show form 2
    End Sub
End Class

