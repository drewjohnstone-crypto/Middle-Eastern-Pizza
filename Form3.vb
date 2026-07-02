Imports System.Drawing.Text
Imports System.Net.Mail
Imports Middle_Eastern_Pizza.Form6


Public Class Form3 'Class for form3. 
    'storing this into a public form means that the variables can be used across the program

    Dim Menu1(2, 13) As String 'Create the array as a string
    Public Total As Decimal 'Have total as a public decimal variable

    'Store pizza names as independent variables, which can be easily edited by changing quotes:
    Dim Name1 As String = "Meat-Aholic" 'store the name: meat-aholic
    Dim Name2 As String = "Straight from the Sea" 'store the name: straight from the sea
    Dim Name3 As String = "Autumn Mush of Rooms" 'store the name: autumn mush of rooms
    Dim Name4 As String = "Middle Eastern Pizza" 'store the name: middle eastern pizza
    Dim Name5 As String = "Honolulu Retreat" 'store the name: honolulu retreat
    Dim Name6 As String = "Chocolate Suprise" 'store the name: chocolate suprise
    Dim Name7 As String = "Classic" 'store the name: classic
    Dim Name8 As String = "Lahmacun" 'store the name: lahmacun
    Dim Name9 As String = "Grass" 'store the name: grass
    Dim Name10 As String = "Hootie-Tootie" 'store the name: hootie-tootie
    Dim Name11 As String = "Lots of Truffle" 'store the name: lots of truffle
    Dim Name12 As String = "Tropical Sunrise" 'store the name: tropical sunrise
    Dim Name13 As String = "Algerian Pizza" 'store the name: Algerian Pizza
    Dim Name14 As String = "Za'atar" 'store the name: Za'atar





    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads, the pizza labels which show the names equal the pizza name variables above
        'Enables it so they can be easily changed if the menu is adapted
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

        'Assinging a tag to every pizza's combo box to represent their position in the menu1 array. Used later on with placeholder d to calculate total cost and quantity

        meatcombobox.Tag = 0
        seacombobox.Tag = 1
        autumncombobox.Tag = 2
        middlecombobox.Tag = 3
        honolulucombobox.Tag = 4
        chocolatecombobox.Tag = 5
        classiccombobox.Tag = 6
        lahmacuncmbox.Tag = 7
        vegancmbox.Tag = 8
        hootiecmbox.Tag = 9
        trufflecmbox.Tag = 10
        tropicalcmbox.Tag = 11
        algeriacmbox.Tag = 12
        zaatarcmbox.Tag = 13


        'store names of pizzas as variables in the Menu1 array
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

        For v = 7 To 13 'between pizza 7-13 in the array
            Menu1(1, v) = 13.5 'premium pizzas
        Next


    End Sub

    Private Sub Totalnew()

        Total = 0 'The base total cost is equivalent to 0
        For x = 0 To 13
            Total += Val(Menu1(1, x)) * Val(Menu1(2, x))
            'calculates the total cost by multiplying the quanity by the given pizza's cost

        Next

        Total += Receipt.Delivery 'The total is the calculated amount + delivery charge if applicable

        totaltext.Text = Total.ToString("C") 'make grand total appear on label with dollar currency symbol


    End Sub




    Private Sub complete_Click(sender As Object, e As EventArgs) Handles complete.Click
        If Total = 0 Or Total = 3 Then 'If the total is 3 or 0 dollars then do this:
            MsgBox("Must enter a pizza") 'Create message box displaying the text in the quotes
        Else 'Otherwise
            Receipt.Pizzas.Clear() 'clears the receipt pizzas entered values so it doesn't include old details
            Receipt.PizzaQuanity.Clear() 'clears the receipt pizza quanities values so it doesn't include old details
            Receipt.PizzaCost.Clear() 'clears the receipt pizza cost values so it doesn't include old details
            For q = 0 To 13 'the value q represents the pizzas in the array
                If Val(Menu1(2, q)) > 0 Then 'if the value is greater than 0
                    Receipt.Pizzas.Add(Menu1(0, q)) 'add the pizzas to the receipt variable
                    Receipt.PizzaQuanity.Add(Menu1(2, q)) 'add the pizza quanities to the receipt variable
                    Receipt.PizzaCost.Add(Menu1(1, q) * Menu1(2, q)) 'add the pizza cost to the receipt variable
                End If 'end the if statement
            Next 'after, do this:
            Me.Hide() 'Hide the order menu
            Form4.Show() 'Show the final order menu
        End If 'End the if statement

    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menbutton.Click
        Me.Hide() 'Hide the order menu
        Form1.Show() 'Return to main menu
    End Sub

    'Handles the selected index for every single pizza's combo box

    Private Sub combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
            meatcombobox.SelectedIndexChanged, '
            seacombobox.SelectedIndexChanged,
            autumncombobox.SelectedIndexChanged,
           middlecombobox.SelectedIndexChanged,
           honolulucombobox.SelectedIndexChanged,
           chocolatecombobox.SelectedIndexChanged,
           classiccombobox.SelectedIndexChanged,
           lahmacuncmbox.SelectedIndexChanged,
           vegancmbox.SelectedIndexChanged,
           hootiecmbox.SelectedIndexChanged,
           trufflecmbox.SelectedIndexChanged,
           tropicalcmbox.SelectedIndexChanged,
           algeriacmbox.SelectedIndexChanged,
           zaatarcmbox.SelectedIndexChanged


        'Locates which combo box did the event and stores it under 'box'
        Dim box = DirectCast(sender, ComboBox)

        'Uses the tag value to find out what the combo box's value position is in Menu1 array
        Dim d As Integer = CInt(box.Tag)

        'Stores the quantity numeral from the combo box under the quantity position in the Menu1 array. Saves this

        Menu1(2, d) = box.SelectedIndex

        Totalnew() 'updates the total cost everytime the combo boxes are changed

    End Sub

End Class

