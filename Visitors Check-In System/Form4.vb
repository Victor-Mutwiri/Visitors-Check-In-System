Imports MySql.Data.MySqlClient

Public Class Form4
    Private connectionString As String = "Server=localhost; Database=estate_visitor_system; Uid=root; Pwd=@Mutwiri77;"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActiveVisitors()
    End Sub

    Private Sub LoadActiveVisitors()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT id, visit_type, names, house_no, id_no, phone_no, multi_day_visit, visit_date FROM visitors WHERE status='Active'", conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dgvVisitors.DataSource = dataTable
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If dgvVisitors.SelectedRows.Count > 0 Then
            Dim visitorId As Integer = Convert.ToInt32(dgvVisitors.SelectedRows(0).Cells("id").Value)
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim cmd As New MySqlCommand("UPDATE visitors SET check_out_time=NOW(), status='Checked Out' WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", visitorId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Check-out successful!")
                        LoadActiveVisitors() ' Refresh the list
                    Else
                        MsgBox("Check-out failed. Please try again.")
                    End If
                End Using
            Catch ex As MySqlException
                MsgBox("Database error: " & ex.Message)
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            End Try
        Else
            MsgBox("Please select a visitor to check out.")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
