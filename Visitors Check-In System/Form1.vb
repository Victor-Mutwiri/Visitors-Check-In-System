Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost; Database=estate_visitor_system; Uid=root; Pwd=@Mutwiri77;"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM security_personnel WHERE username=@username AND password=@password", conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Form2.Show()
                        Me.Hide()
                        ClearTextBoxes()
                    Else
                        MsgBox("Incorrect Username or Password")
                        ClearTextBoxes()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearTextBoxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Create a new instance of Form5 and pass the current instance of Form1
        Dim signupForm As New Form5(Me)
        signupForm.ShowDialog() ' Use ShowDialog to ensure it behaves as a modal dialog
    End Sub

End Class
