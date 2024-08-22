Imports MySql.Data.MySqlClient
Public Class Form8
    Private connectionString As String = "Server=localhost; Database=estate_visitor_system; Uid=root; Pwd=@Mutwiri77;"

    Private Sub chkResidents_CheckedChanged(sender As Object, e As EventArgs) Handles chkResidents.CheckedChanged
        If chkResidents.Checked Then
            chkVisitor.Checked = False
            chkWorker.Checked = False
        End If
    End Sub

    Private Sub chkWorker_CheckedChanged(sender As Object, e As EventArgs) Handles chkWorker.CheckedChanged
        If chkVisitor.Checked Then
            chkResidents.Checked = False
            chkWorker.Checked = False
        End If
    End Sub
    Private Sub chkVisitor_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisitor.CheckedChanged
        If chkWorker.Checked Then
            chkResidents.Checked = False
            chkVisitor.Checked = False
        End If
    End Sub
    Private Sub chkMultiDayYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiDayYes.CheckedChanged
        If chkMultiDayYes.Checked Then
            chkMultiDayNo.Checked = False
        End If
    End Sub

    Private Sub chkMultiDayNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiDayNo.CheckedChanged
        If chkMultiDayNo.Checked Then
            chkMultiDayYes.Checked = False
        End If
    End Sub

    Private Sub chkCheckedIn_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheckedIn.CheckedChanged
        If chkCheckedIn.Checked Then
            chkCheckedOut.Checked = False
        End If
    End Sub

    Private Sub chkCheckedOut_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheckedOut.CheckedChanged
        If chkCheckedOut.Checked Then
            chkCheckedIn.Checked = False
        End If
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM visitors WHERE 1=1"

                ' Visit Type filter
                If chkResidents.Checked Then
                    query &= " AND visit_type = 'Resident'"
                ElseIf chkVisitor.Checked Then
                    query &= " AND visit_type = 'Visitor'"
                ElseIf chkWorker.Checked Then
                    query &= " AND visit_type = 'Worker'"
                End If

                ' Multi-Day Visit filter
                If chkMultiDayYes.Checked Then
                    query &= " AND multi_day_visit = 'Yes'"
                ElseIf chkMultiDayNo.Checked Then
                    query &= " AND multi_day_visit = 'No'"
                End If

                ' Status filter
                If chkCheckedIn.Checked Then
                    query &= " AND status = 'Active'"
                ElseIf chkCheckedOut.Checked Then
                    query &= " AND status = 'Checked Out'"
                End If

                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Display results in DataGridView
                dgvReportResults.DataSource = table
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form7.Show()
        Me.Hide()
    End Sub



End Class