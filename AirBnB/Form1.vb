Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim intNumNights As Integer
        Dim decCostTotal As Double
        Dim strNumNights As String
        Dim cdecCostPerNight As Decimal = 79D


        strNumNights = TextBox1.Text
        Convert.ToInt32(strNumNights)

        decCostTotal = cdecCostPerNight * strNumNights
        Label5.Text = decCostTotal.ToString("C")








    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
