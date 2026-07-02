Imports System.Numerics
Imports System.Windows.Forms.VisualStyles

Public Class Receipt 'make a class for the summary
    'storing this into a public form means that the variables can be used across the program




    Public Shared Address As String 'stores the entered address
    Public Shared Customername As String 'stores the entered name
    Public Shared Phone As String 'stores the entered phone number
    Public Shared Pizzas As New List(Of String) 'stores the pizzas ordered in a list
    Public Shared PizzaQuanity As New List(Of Integer) 'stores the quanities in a list
    Public Shared PizzaCost As New List(Of Decimal) 'stores the cost of each pizza in a list
    Public Shared Delivery As Decimal 'stores the delivery cost



End Class 'end the class
Public Class Form6 'starts the class for form 6
    'storing this into a public form means that the variables can be used across the program





    Public Addressbox As Boolean 'declare addressbox as a true/false


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        address.Visible = Addressbox 'the text box is visible if Addressbox is true
        addresstext.Visible = Addressbox 'the text in the box is visible if Addressbox is true
        MaskedTextBox1.Mask = "(000) 000-000099" 'set masked text box in this format, with 2 opitonal digits

    End Sub
    Private Sub buttontomenu_Click(sender As Object, e As EventArgs) Handles buttontomenu.Click


        If Not MaskedTextBox1.MaskCompleted OrElse 'If the phone text box is completed (fully)
        (Addressbox = True AndAlso String.IsNullOrEmpty(addresstext.Text)) OrElse 'Or address box which is true is empty
        String.IsNullOrEmpty(TextBox1.Text) Then 'Or name text box is empty

            MsgBox("must fill out information before progressing") 'Then this message box appears showing the quoted text

        End If 'Ends the if statement

        If MaskedTextBox1.MaskCompleted And 'If the phone number text box is fully completed
       (Addressbox = False OrElse Not String.IsNullOrEmpty(addresstext.Text)) And 'Or Addressbox is false or empty
        Not String.IsNullOrEmpty(TextBox1.Text) Then 'Or the name text is empty, then

            Receipt.Address = addresstext.Text 'The text added is stored under the receipt class
            Receipt.Customername = TextBox1.Text 'The name text added is stored under the receipt class
            Receipt.Phone = MaskedTextBox1.Text 'The phone number added is stored under the receipt class

            Me.Hide() 'Hides form 6 (not fully closed)
            Form3.Show() 'Shows the menu form


        End If 'Ends the if statement

    End Sub

    Private Sub menureturn_Click(sender As Object, e As EventArgs) Handles menureturn.Click
        Me.Hide() 'When button is clicked hide form6
        Form1.Show() 'When button is clicked show the main menu
    End Sub


End Class 'End the class for form6