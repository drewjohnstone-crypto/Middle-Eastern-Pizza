Imports System.Net.Mail

Public Class Form3
    Dim Menu1(2, 13) As String
    Dim Total As Decimal


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'store prices of pizzas

        Menu1(1, 0) = 8.5
        Menu1(1, 1) = 8.5
        Menu1(1, 2) = 8.5
        Menu1(1, 3) = 8.5
        Menu1(1, 4) = 8.5
        Menu1(1, 5) = 8.5
        Menu1(1, 6) = 8.5
        Menu1(1, 7) = 13.5
        Menu1(1, 8) = 13.5
        Menu1(1, 9) = 13.5
        Menu1(1, 10) = 13.5
        Menu1(1, 11) = 13.5
        Menu1(1, 12) = 13.5
        Menu1(1, 13) = 13.5





    End Sub



    'total = 0
    'for x = 0 to 13
    'total = total + (val(menu(1,x)) * val(menu(2,x))
    'next
    'total = total + delivery



    Private Sub totaltext_Click(sender As Object, e As EventArgs) Handles totaltext.Click

        'make grand total value

        ' Total = (Menu1(1, 0) * Menu1(2, 0)) + (Menu1(1, 1) * Menu1(2, 1)) + (Menu1(1, 2) * Menu1(2, 2)) + (Menu1(1, 3) * Menu1(2, 3)) + (Menu1(1, 4) * Menu1(2, 4)) + (Menu1(1, 5) * Menu1(2, 5)) + (Menu1(1, 6) * Menu1(2, 6)) + (Menu1(1, 7) * Menu1(2, 7)) + (Menu1(1, 8) * Menu1(2, 8)) + (Menu1(1, 9) * Menu1(2, 9)) + (Menu1(1, 10) * Menu1(2, 10)) + (Menu1(1, 11) * Menu1(2, 11)) + (Menu1(1, 12) * Menu1(2, 12)) + (Menu1(1, 13) * Menu1(2, 13)) + Form2.Delivery

        Total = 0
        For x = 0 To 13
            Total += Val(Menu1(1, x)) * Val(Menu1(2, x))

        Next

        Total += Form2.Delivery

        totaltext.Text = Total.ToString("C") 'make grand total appear on label with currency


    End Sub



    Private Sub complete_Click(sender As Object, e As EventArgs) Handles complete.Click
        Me.Hide() 'Hide the order menu
        Form4.Show() 'Show the final order menu
    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menbutton.Click
        Me.Hide() 'Hide the order menu
        Form1.Show() 'Return to main menu
    End Sub
    Private Sub meatcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles meatcombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 0) = Val(meatcombobox.Text)
    End Sub
    Private Sub seacombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seacombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 1) = Val(seacombobox.Text)
        'Calculate and display line total


    End Sub

    Private Sub autumncombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles autumncombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 2) = Val(autumncombobox.Text)

    End Sub

    Private Sub middlecombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles middlecombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 3) = Val(middlecombobox.Text)
    End Sub

    Private Sub honolulucombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles honolulucombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 4) = Val(honolulucombobox.Text)
    End Sub

    Private Sub chocolatecombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chocolatecombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 5) = Val(chocolatecombobox.Text)
    End Sub

    Private Sub classiccombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classiccombobox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 6) = Val(classiccombobox.Text)
    End Sub

    Private Sub lahmacuncmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lahmacuncmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 7) = Val(lahmacuncmbox.Text)
    End Sub

    Private Sub vegancmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vegancmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 8) = Val(vegancmbox.Text)
    End Sub

    Private Sub hootiecmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hootiecmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 9) = Val(hootiecmbox.Text)
    End Sub

    Private Sub trufflecmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles trufflecmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 10) = Val(trufflecmbox.Text)
    End Sub

    Private Sub tropicalcmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tropicalcmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 11) = Val(tropicalcmbox.Text)
    End Sub

    Private Sub algeriacmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles algeriacmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 12) = Val(algeriacmbox.Text)
    End Sub

    Private Sub zaatarcmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zaatarcmbox.SelectedIndexChanged
        'get quanity and store in array
        Menu1(2, 13) = Val(zaatarcmbox.Text)
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

'Private Sub cboEggs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEggs.SelectedIndexChanged
'get quanity and store in array
'Shopping(2, 2) = Val(cboEggs.Text)
'calculate and display line total
'lblEggsTotal.Text = (Shopping(1, 2) * Shopping(2, 2)).ToString("C")
'cornelioustotal()
'End Sub

'Private Sub cornelioustotal()
'total'
' Dim Total As Decimal
'  Total = (Shopping(1, 0) * Shopping(2, 0)) + (Shopping(1, 1) * Shopping(2, 1)) + (Shopping(1, 2) * Shopping(2, 2))
'   lblTotal.Text = Total.ToString("C")


'End Sub
'End Class



'hint: I am not going yo say maybe this is on your assesment it is on the assesmenet. THIS METHOD:



'total'
' Dim Total As Decimal
'  Total = (Shopping(1, 0) * Shopping(2, 0)) + (Shopping(1, 1) * Shopping(2, 1)) + (Shopping(1, 2) * Shopping(2, 2))
'   lblTotal.Text = Total.ToString("C")


'need array, loop and conditionals (else, if) think I have them all after incoporating the loop