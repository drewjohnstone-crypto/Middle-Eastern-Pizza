

Public Class Form4 'creates the class
    'storing this into a public form means that the variables can be used across the program

    Private Sub backmenu_Click(sender As Object, e As EventArgs) Handles backmenu.Click
        Application.Restart() 'the application is completly reset when the butoon is pressed
        Form1.Show() 'the main menu is shown
    End Sub

    Private Sub receipt_Click(sender As Object, e As EventArgs) Handles summary.Click
        Me.Hide() 'hides form 4 when the button is pressed
        Form5.Show() 'form 5 (menu summary) is shown
    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menubutton.Click

        Me.Close() 'fully closes form 4 when the button is pressed
        Form3.Show() 'Re-opens the menu page (form 3)
    End Sub
End Class 'ends the class