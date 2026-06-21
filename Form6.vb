Imports System.Numerics
Imports System.Windows.Forms.VisualStyles

Public Class Receipt 'make a class for the summary



    Public Shared Address As String 'stores the entered address
    Public Shared Customername As String 'stores the entered name
    Public Shared Phone As String 'stores the entered phone number
    Public Shared Pizzas As New List(Of String) 'stores the pizzas ordered in a list
    Public Shared PizzaQuanity As New List(Of Integer) 'stores the quanities in a list
    Public Shared PizzaCost As New List(Of Decimal) 'stores the cost of each pizza in a list
    Public Shared Delivery As Decimal 'stores the delivery cost



End Class 'end the class
Public Class Form6




    Public Addressbox As Boolean


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        address.Visible = Addressbox
        addresstext.Visible = Addressbox
        MaskedTextBox1.Mask = "(000) 000-000099" 'set masked text box in this format

    End Sub
    Private Sub buttontomenu_Click(sender As Object, e As EventArgs) Handles buttontomenu.Click


        If Not MaskedTextBox1.MaskCompleted OrElse
        (Addressbox = True AndAlso String.IsNullOrEmpty(addresstext.Text)) OrElse
        String.IsNullOrEmpty(TextBox1.Text) Then

            MsgBox("must fill out information before progressing")

        End If

        If MaskedTextBox1.MaskCompleted And
       (Addressbox = False OrElse Not String.IsNullOrEmpty(addresstext.Text)) And
        Not String.IsNullOrEmpty(TextBox1.Text) Then

            Receipt.Address = addresstext.Text
            Receipt.Customername = TextBox1.Text
            Receipt.Phone = MaskedTextBox1.Text

            Me.Hide()
            Form3.Show()


        End If

    End Sub

    Private Sub menureturn_Click(sender As Object, e As EventArgs) Handles menureturn.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class