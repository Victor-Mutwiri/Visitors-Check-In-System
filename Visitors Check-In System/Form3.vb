Imports MySql.Data.MySqlClient

Public Class Form3

    Private connectionString As String = "Server=localhost; Database=estate_visitor_system; Uid=root; Pwd=@Mutwiri77;"

    Private Sub btnVisitors_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO visitors (visit_type, names, house_no, id_no, phone_no, multi_day_visit, visit_date, check_in_time, status) VALUES (@visit_type, @names, @house_no, @id_no, @phone_no, @multi_day_visit, @visit_date, NOW(), 'Active')", conn)
                cmd.Parameters.AddWithValue("@visit_type", cmbVisitType.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@names", txtNames.Text.Trim())
                cmd.Parameters.AddWithValue("@house_no", cmbHouseNo.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@id_no", txtIDNo.Text.Trim())
                cmd.Parameters.AddWithValue("@phone_no", txtPhoneNo.Text.Trim())
                cmd.Parameters.AddWithValue("@multi_day_visit", cmbMultiDayVisit.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@visit_date", dtpVisitDate.Value.Date)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Check-in successful!")
                    ' Show Form2 and close Form3
                    Form2.Show()
                    Me.Close()
                Else
                    MsgBox("Check-in failed. Please try again.")
                End If
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all TextBox controls
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next

        ' Reset all ComboBox controls to their default state
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1 ' Set to no selection
            End If
        Next

        ' Reset the DateTimePicker to today's date or a default date
        dtpVisitDate.Value = DateTime.Now

        ' Optionally, you can also reset other controls like RadioButtons or CheckBoxes if any
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBoxes with values
        ' Populate ComboBoxes according to your needs
        'cmbVisitType.Items.AddRange(New String() {"Business", "Personal", "Other"})
        'cmbHouseNo.Items.AddRange(New String() {"House 1", "House 2", "House 3"})
        'cmbMultiDayVisit.Items.AddRange(New String() {"Yes", "No"})
    End Sub

End Class
