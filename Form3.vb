Imports System.Drawing.Text
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Middle_Eastern_Pizza.Form6


Public Class Form3
    Dim Menu1(2, 13) As String
    Public Total As Decimal

    Dim Name1 As String = "Meat-Aholic"
    Dim Name2 As String = "Straight from the Sea"
    Dim Name3 As String = "Autumn Mush of Rooms"
    Dim Name4 As String = "Middle Eastern Pizza"
    Dim Name5 As String = "Honolulu Retreat"
    Dim Name6 As String = "Chocolate Suprise"
    Dim Name7 As String = "Classic"
    Dim Name8 As String = "Lahmacun"
    Dim Name9 As String = "Grass"
    Dim Name10 As String = "Hootie-Tootie"
    Dim Name11 As String = "Lots of Truffle"
    Dim Name12 As String = "Tropical Sunrise"
    Dim Name13 As String = "Algerian Pizza"
    Dim Name14 As String = "Za'atar"





    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        meataholic.Text = Name1
        sea.Text = Name2
        autumn.Text = Name3
        middlepizza.Text = Name4
        honolulu.Text = Name5
        chocolate.Text = Name6
        classic.Text = Name7
        lahmacun.Text = Name8
        vegan.Text = Name9
        rich.Text = Name10
        truffle.Text = Name11
        tropical.Text = Name12
        algeria.Text = Name13
        zaatar.Text = Name14





        'store names of pizzas as variables
        Menu1(0, 0) = "Meat-Aholic"
        Menu1(0, 1) = "Straight from the Sea"
        Menu1(0, 2) = "Autumn Mush of Rooms"
        Menu1(0, 3) = "Middle Eastern Pizza"
        Menu1(0, 4) = "Honolulu Retreat"
        Menu1(0, 5) = "Chocolate Suprise"
        Menu1(0, 6) = "Classic"
        Menu1(0, 7) = "Lahmacun"
        Menu1(0, 8) = "Grass"
        Menu1(0, 9) = "Hootie-Tootie"
        Menu1(0, 10) = "Lots of Truffle"
        Menu1(0, 11) = "Tropical Sunrise"
        Menu1(0, 12) = "Algerian Pizza"
        Menu1(0, 13) = "Za'atar"

        'make for loop to include cost in array
        For v = 0 To 13
            Menu1(1, v) = 8.5 'standard pizzas
        Next

        For v = 7 To 13
            Menu1(1, v) = 13.5 'premium pizzas
        Next


    End Sub

    Private Sub Totalnew()

        Total = 0
        For x = 0 To 13
            Total += Val(Menu1(1, x)) * Val(Menu1(2, x))

        Next

        Total += Receipt.Delivery

        totaltext.Text = Total.ToString("C") 'make grand total appear on label with currency


    End Sub



    Private Sub totaltext_Click(sender As Object, e As EventArgs) Handles totaltext.Click

        'make grand total value

        ' Total = (Menu1(1, 0) * Menu1(2, 0)) + (Menu1(1, 1) * Menu1(2, 1)) + (Menu1(1, 2) * Menu1(2, 2)) + (Menu1(1, 3) * Menu1(2, 3)) + (Menu1(1, 4) * Menu1(2, 4)) + (Menu1(1, 5) * Menu1(2, 5)) + (Menu1(1, 6) * Menu1(2, 6)) + (Menu1(1, 7) * Menu1(2, 7)) + (Menu1(1, 8) * Menu1(2, 8)) + (Menu1(1, 9) * Menu1(2, 9)) + (Menu1(1, 10) * Menu1(2, 10)) + (Menu1(1, 11) * Menu1(2, 11)) + (Menu1(1, 12) * Menu1(2, 12)) + (Menu1(1, 13) * Menu1(2, 13)) + Form2.Delivery

        Total = 0
        For x = 0 To 13
            Total += Val(Menu1(1, x)) * Val(Menu1(2, x))

        Next

        Total += Receipt.Delivery

        totaltext.Text = Total.ToString("C") 'make grand total appear on label with currency


    End Sub





    Private Sub complete_Click(sender As Object, e As EventArgs) Handles complete.Click
        If Receipt.Pizzas.Count = 0 Then 'If the pizza list is empty then do this:
            MsgBox("Must enter a pizza") 'Create message box displaying the text
        Else 'Otherwise
            Me.Hide() 'Hide the order menu
            Form4.Show() 'Show the final order menu
        End If 'End the if statement

    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menbutton.Click
        Me.Hide() 'Hide the order menu
        Form1.Show() 'Return to main menu
    End Sub
    Private Sub meatcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles meatcombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 0) = Val(meatcombobox.Text)
        Receipt.Pizzas.Add("Meat-Aholic")
        Receipt.PizzaQuanity.Add(Val(meatcombobox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 0) * Menu1(2, 0))
        Totalnew()

    End Sub
    Private Sub seacombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seacombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 1) = Val(seacombobox.Text)
        'Calculate and display line total
        Receipt.Pizzas.Add("Straight from the Sea")
        Receipt.PizzaQuanity.Add(Val(seacombobox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 1) * Menu1(2, 1))
        Totalnew()


    End Sub

    Private Sub autumncombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles autumncombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 2) = Val(autumncombobox.Text)
        Receipt.Pizzas.Add("Autumn Mush of Rooms")
        Receipt.PizzaQuanity.Add(Val(autumncombobox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 2) * Menu1(2, 2))
        Totalnew()


    End Sub

    Private Sub middlecombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles middlecombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 3) = Val(middlecombobox.Text)
        Receipt.Pizzas.Add("Middle Eastern Pizza")
        Receipt.PizzaQuanity.Add(Val(middlecombobox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 3) * Menu1(2, 3))
        Totalnew()

    End Sub

    Private Sub honolulucombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles honolulucombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 4) = Val(honolulucombobox.Text)
        Receipt.Pizzas.Add("Honolulu Retreat")
        Receipt.PizzaQuanity.Add(Val(honolulucombobox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 4) * Menu1(2, 4))
        Totalnew()

    End Sub

    Private Sub chocolatecombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chocolatecombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 5) = Val(chocolatecombobox.Text)
        Receipt.Pizzas.Add("Chocolate Suprise")
        Receipt.PizzaQuanity.Add(Val(chocolatecombobox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 5) * Menu1(2, 5))
        Totalnew()

    End Sub

    Private Sub classiccombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classiccombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 6) = Val(classiccombobox.Text)
        Receipt.Pizzas.Add("Classic")
        Receipt.PizzaQuanity.Add(Val(classiccombobox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 6) * Menu1(2, 6))
        Totalnew()

    End Sub

    Private Sub lahmacuncmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lahmacuncmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 7) = Val(lahmacuncmbox.Text)
        Receipt.Pizzas.Add("Lahmacun")
        Receipt.PizzaQuanity.Add(Val(lahmacuncmbox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 7) * Menu1(2, 7))
        Totalnew()

    End Sub

    Private Sub vegancmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vegancmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 8) = Val(vegancmbox.Text)
        Receipt.Pizzas.Add("Grass")
        Receipt.PizzaQuanity.Add(Val(vegancmbox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 8) * Menu1(2, 8))
        Totalnew()

    End Sub

    Private Sub hootiecmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hootiecmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 9) = Val(hootiecmbox.Text)
        Receipt.Pizzas.Add("Hootie Tootie")
        Receipt.PizzaQuanity.Add(Val(hootiecmbox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 9) * Menu1(2, 9))
        Totalnew()

    End Sub

    Private Sub trufflecmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles trufflecmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 10) = Val(trufflecmbox.Text)
        Receipt.Pizzas.Add("Lots of Truffle")
        Receipt.PizzaQuanity.Add(Val(trufflecmbox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 10) * Menu1(2, 10))
        Totalnew()

    End Sub

    Private Sub tropicalcmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tropicalcmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 11) = Val(tropicalcmbox.Text)
        Receipt.Pizzas.Add("Tropical Sunrise")
        Receipt.PizzaQuanity.Add(Val(tropicalcmbox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 11) * Menu1(2, 11))
        Totalnew()

    End Sub

    Private Sub algeriacmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles algeriacmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 12) = Val(algeriacmbox.Text)
        Receipt.Pizzas.Add("Algerian Pizza")
        Receipt.PizzaQuanity.Add(Val(algeriacmbox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 12) * Menu1(2, 12))
        Totalnew()

    End Sub

    Private Sub zaatarcmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zaatarcmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 13) = Val(zaatarcmbox.Text)
        Receipt.Pizzas.Add("Za'atar")
        Receipt.PizzaQuanity.Add(Val(zaatarcmbox.Text))
        Receipt.PizzaCost.Add(Menu1(1, 13) * Menu1(2, 13))
        Totalnew()

    End Sub
End Class





'Public Class Form1
'define array to dtore values
'Dim Shopping(2, 2) As String

'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
''Store names of items to buy
'S 'hopping(0, 0) = "Bread"
'Shopping(0, 1) = "Milk"
'Shopping(0, 2) = "Eggs"
'store prices
'Shopping(1, 0) = 2.5
'Shopping(1, 1) = 4.5
'Shopping(1, 2) = 9.0
''put items on th form
'L 'abel6.Text = Shopping(0, 0)
'Label7.Text = Shopping(0, 1)
'Label8.Text = Shopping(0, 2)
''update price 1,0 lblbreadprice.text
'lblBreadPrice.Text = Val(Shopping(1, 0)).ToString("C2")
'lblMilkPrice.Text = Val(Shopping(1, 1)).ToString("C2")
'lblEggsPrice.Text = Val(Shopping(1, 2)).ToString("C2")

'End Sub

'Private Sub cboBread_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBread.SelectedIndexChanged
'get quanity and store in array
'Shopping(2, 0) = Val(cboBread.Text)
'calculate and display line total
'lblBreadTotal.Text = (Shopping(1, 0) * Shopping(2, 0)).ToString("C")
'End Sub

'Private Sub cboMilk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMilk.SelectedIndexChanged
'get quanity and store in array
'Shopping(2, 1) = Val(cboMilk.Text)
'calculate and display line total
'lblMilkTotal.Text = (Shopping(1, 1) * Shopping(2, 1)).ToString("C")
'End Sub



'hint: I am not going yo say maybe this is on your assesment it is on the assesmenet. THIS METHOD:



'total'
' Dim Total As Decimal
'  Total = (Shopping(1, 0) * Shopping(2, 0)) + (Shopping(1, 1) * Shopping(2, 1)) + (Shopping(1, 2) * Shopping(2, 2))
'   lblTotal.Text = Total.ToString("C")


'need array, loop and conditionals (else, if) think I have them all after incoporating the loop



