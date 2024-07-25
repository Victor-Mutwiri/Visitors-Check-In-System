Public Class Form2
    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub ExitPicture_Click(sender As Object, e As EventArgs) Handles ExitPicture.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class