Imports Middle_Eastern_Pizza.Form6
Imports System.Drawing.Printing

Public Class Form5

    Private printer As Bitmap



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pizzas.Text = String.Join(Environment.NewLine, Receipt.Pizzas)

        Deliverydetail.Text = Receipt.Address & vbCrLf &
       Receipt.Phone & vbCrLf &
       Receipt.Customername


        Costseachpizza.Text = String.Join(Environment.NewLine, Receipt.PizzaCost.Select(Function(пицца) пицца.ToString("C")))

        Quanities.Text = String.Join(Environment.NewLine, Receipt.PizzaQuanity)

        Totalcost.Text = Form3.Total.ToString("C")

        printer = New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(printer, New Rectangle(0, 0, Me.Width, Me.Height))




    End Sub


    Private Sub Backtomenu_Click(sender As Object, e As EventArgs) Handles Backtomenu.Click
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub Reset1_Click(sender As Object, e As EventArgs) Handles Reset1.Click
        Application.Restart()

    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        PrintDocument.Print()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Printpreview.Click
        PrintPreviewDialog.Document = PrintDocument
        PrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim Heading As New Font("Times New Roman", 20, FontStyle.Bold)
        Dim Details As New Font("Times New Roman", 10, FontStyle.Bold)
        e.Graphics.DrawString(Label1.Text, Heading, 5, 5)
        e.Graphics.DrawString(costtitle, Heading)
        e.Graphics.DrawString(quanitiestitle, Heading, )
        e.Graphics.DrawString(pizzatitle, Heading)
        e.Graphics.DrawString(Customerdetailstitle, Heading)

        e.Graphics.DrawImage(printer, 0, 0)


    End Sub


End Class
