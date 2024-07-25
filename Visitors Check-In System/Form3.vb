Public Class Form3
    Private Sub btnVisitors_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class