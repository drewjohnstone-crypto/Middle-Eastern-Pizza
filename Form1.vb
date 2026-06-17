Imports System.Reflection.Emit
Imports Middle_Eastern_Pizza.Form2

Public Class Form1

    Private Sub pickup_Click(sender As Object, e As EventArgs) Handles pickup.Click
        Dim Shrimpcocktail As New Form2
        Shrimpcocktail.Addressbox = False
        Receipt.Delivery = 0 'makes it so that if selected pick up, the delivery cost = 0
        Me.Hide() 'hides form 1
        Shrimpcocktail.Show() 'shows new form2


    End Sub

    Private Sub delivery_Click(sender As Object, e As EventArgs) Handles delivery.Click
        Dim Shrimpcocktail As New Form2
        Shrimpcocktail.Addressbox = True
        Receipt.Delivery = 3 'makes delivery = 3, which will add to total cost
        Me.Hide() 'hides form 1
        Shrimpcocktail.Show() 'show form 2
    End Sub


End Class

