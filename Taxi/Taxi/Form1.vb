Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declares a variable called distance to store the distance entered
        Dim distance As Integer = txtDistance.Text
        'declares a variable called passengers to store the number of passengers entered
        Dim passengers As Integer = txtPassengers.Text
        'declares a variable called cost and then uses a calculation to work out the cost
        Dim cost As Decimal = 3 + ((distance - 1) * 2)
        'checks to see if the number of passengers is more than 5 so that the additional 50% cost can be added
        If passengers > 5 Then
            'calculates the extra cost if the condition is true
            cost = cost * 1.5
        End If
        'a message box to display the total cost of the journey
        MessageBox.Show("The cost of the journey is: " & FormatCurrency(cost).ToString)
    End Sub
End Class
