Imports Middle_Eastern_Pizza.Form6
'Imports System.Drawing.Imaging.Effects
Imports System.Drawing.Printing 'imports the printing part on visual studio

Public Class Form5 'declares the class for form 5
    'storing this into a public form means that the variables can be used across the program

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'makes the text on this label to be the same as the stored information on this public variable. Adds new line for each part in the list
        Pizzas.Text = String.Join(Environment.NewLine, Receipt.Pizzas)
        'makes the details label text equal to all of the stored delivery detials from form6 and the receipt class, with a new line for each part in the list
        Deliverydetail.Text = Receipt.Customername & vbCrLf &
       Receipt.Phone & vbCrLf &
       Receipt.Address


        'makes the cost of each pizza text equal to the stored pizza cost on the receipt class, with the dollar currency symbol and a new line
        Costseachpizza.Text = String.Join(Environment.NewLine, Receipt.PizzaCost.Select(Function(пицца) пицца.ToString("C")))
        'makes the quanities text equal to the pizza quanity on the receipt class, with a new line for each part in the list
        Quanities.Text = String.Join(Environment.NewLine, Receipt.PizzaQuanity)
        'makes the total cost text equal to the calculated total cost on form 3, with the dollar currency symbol
        Totalcost.Text = Form3.Total.ToString("C")



    End Sub


    Private Sub Backtomenu_Click(sender As Object, e As EventArgs) Handles Backtomenu.Click
        Me.Close() 'fully closes the summary page when pressed
        Form3.Show() 'shows the menu page

    End Sub

    Private Sub Reset1_Click(sender As Object, e As EventArgs) Handles Reset1.Click
        Application.Restart() 'fully restarts the application when pressed

    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        PrintDocument.Print() 'the print document prints when the print button is clicked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Printpreview.Click
        PrintPreviewDialog.Document = PrintDocument 'the preview equals the print document, showing the emulated printing result
        PrintPreviewDialog.ShowDialog() 'Display the print preview, and wait for the user to shut it
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim Heading As New Font("Times New Roman", 25, FontStyle.Bold) 'creates headings variable as a font, and declares it as bold Times New Roman in size 25
        Dim Details As New Font("Times New Roman", 15, FontStyle.Bold) 'creates details variable as a font, and delcares it as bold Times New Roman in size 15
        'e graphics draws label1's text as a  heading with black ink, on the coordinates 50,50 on the printing document
        e.Graphics.DrawString(Label1.Text, Heading, Brushes.Black, New Point(50, 50))
        'e graphics draws the cost title text as a heading with black ink, on the coordinates 750,100 on the printing document
        e.Graphics.DrawString(costtitle.Text, Heading, Brushes.Black, New Point(750, 100))
        'e graphics draws the quanities title text as a heading with black ink, on the coordinates 550, 100 on the printing document
        e.Graphics.DrawString(quanitiestitle.Text, Heading, Brushes.Black, New Point(550, 100))
        'e graphics draws the pizza title text as a heading with black ink, on the coordinates 300, 100 on the printing document
        e.Graphics.DrawString(pizzatitle.Text, Heading, Brushes.Black, New Point(300, 100))
        'e graphics draws the custtomer details title text as a heading with black ink, on the coordinates 50, 100 on the printing document
        e.Graphics.DrawString(Customerdetailstitle.Text, Heading, Brushes.Black, New Point(50, 100))
        'e graphics draws the logo image with adjusted size of 400 by 400, on the coordinates 450, 600 on the printing document
        e.Graphics.DrawImage(Logo.Image, 450, 700, 400, 400)
        'e graphics draws the delivery details text as details with black ink, on the coordinates 50, 200 on the printing document
        e.Graphics.DrawString(Deliverydetail.Text, Details, Brushes.Black, New Point(50, 200))
        'e graphics draws the pizzas text as details with black ink, on the coordinates 300, 200 on the printing document
        e.Graphics.DrawString(Pizzas.Text, Details, Brushes.Black, New Point(300, 200))
        'e graphics draws the quanities details text as details with black ink, on the coordinates 550, 200 on the printing document
        e.Graphics.DrawString(Quanities.Text, Details, Brushes.Black, New Point(550, 200))
        'e graphics draws the cost for each pizza details text as details with black ink, on the coordinates 750, 200 on the printing document
        e.Graphics.DrawString(Costseachpizza.Text, Details, Brushes.Black, New Point(750, 200))
        'e graphics draws the title cost title text as a heading with black ink, on the coordinates 100, 850 on the printing document
        e.Graphics.DrawString(totalcosttitle.Text, Heading, Brushes.Black, New Point(100, 850))
        'e graphics draws the total cost text as details with black ink, on the coordinates 100, 950 on the printing document
        e.Graphics.DrawString(Totalcost.Text, Details, Brushes.Black, New Point(100, 950))


    End Sub


End Class 'ends the class
