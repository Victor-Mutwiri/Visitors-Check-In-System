Imports MySql.Data.MySqlClient

Public Class Form5

    Private connectionString As String = "Server=localhost; Database=estate_visitor_system; Uid=root; Pwd=@Mutwiri77;"
    Private mainForm As Form1

    ' Constructor to accept the main form instance
    Public Sub New(mainForm As Form1)
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize the mainForm field
        Me.mainForm = mainForm
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO security_personnel (username, password) VALUES (@username, @password)", conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Signup successful!")
                    Me.Close()
                    ' Show Form1 after closing Form5
                    mainForm.Show()
                Else
                    MsgBox("Signup failed. Please try again.")
                End If
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed
    End Sub

End Class
