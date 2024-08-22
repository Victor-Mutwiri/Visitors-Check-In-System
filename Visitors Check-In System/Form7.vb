Public Class Form7
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Form8.Show()
        Me.Hide()
    End Sub
    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub ExitPicture_Click(sender As Object, e As EventArgs) Handles ExitPicture.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub btnAddPersonnel_Click(sender As Object, e As EventArgs) Handles btnAddPersonnel.Click
        Dim form5 As New Form5(Form1) ' Pass the instance of Form1 to the Form5 constructor
        form5.Show()
        Me.Hide()
    End Sub

End Class