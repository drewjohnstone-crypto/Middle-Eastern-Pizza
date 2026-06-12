Imports System.Numerics
Imports System.Windows.Forms.VisualStyles

Public Class Form2

    Public Delivery As Decimal
    Public Class Receipt



        Public Shared Address As String
        Public Shared Customername As String
        Public Shared Phone As String
        Public Shared Pizzas As New List(Of String)
        Public Shared PizzaQuanity As New List(Of Integer)
        Public Shared PizzaCost As New List(Of Decimal)



    End Class
    Private Sub buttontomenu_Click(sender As Object, e As EventArgs) Handles buttontomenu.Click


        If Not MaskedTextBox1.MaskCompleted OrElse
            String.IsNullOrEmpty(addresstext.Text) OrElse
            String.IsNullOrEmpty(TextBox1.Text) Then

            MsgBox("must fill out information before progressing")

        End If

        If MaskedTextBox1.MaskCompleted And
            Not String.IsNullOrEmpty(addresstext.Text) And
            Not String.IsNullOrEmpty(TextBox1.Text) Then

            Me.Hide()
            Form3.Show()


        End If
        Receipt.Address = addresstext.Text
        Receipt.Customername = TextBox1.Text
        Receipt.Phone = MaskedTextBox1.Text

    End Sub

    Private Sub menureturn_Click(sender As Object, e As EventArgs) Handles menureturn.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class