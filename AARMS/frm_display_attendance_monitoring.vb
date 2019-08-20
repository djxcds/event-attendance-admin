Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_display_attendance_monitoring
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public event_rating_enabled As String

    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        Connection.conn.Open()
        query = "Update tbl_event_entry SET event_status = 'SIGN IN' WHERE event_entry_id = '" +
            lbl_event_id.Text + "'"
        cmd = New MySqlCommand(query, Connection.conn)
        cmd.ExecuteNonQuery()
        Connection.conn.Close()

        refresheventstatus()
    End Sub

    Sub refresheventstatus()
        Connection.conn.Open()
        query = "select event_status from tbl_event_entry where event_entry_id = '" + lbl_event_id.Text + "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader

        If reader.Read Then
            lbl_attendance_status.Text = reader.GetString("event_status")
        End If

        Connection.conn.Close()
    End Sub

    Private Sub btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        Connection.conn.Open()
        query = "Update tbl_event_entry SET event_status = 'SIGN OUT' WHERE event_entry_id = '" +
            lbl_event_id.Text + "'"
        cmd = New MySqlCommand(query, Connection.conn)
        cmd.ExecuteNonQuery()
        Connection.conn.Close()

        refresheventstatus()
    End Sub

    Private Sub btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        Connection.conn.Open()
        query = "Update tbl_event_entry SET event_status = 'PAUSE' WHERE event_entry_id = '" +
            lbl_event_id.Text + "'"
        cmd = New MySqlCommand(query, Connection.conn)
        cmd.ExecuteNonQuery()
        Connection.conn.Close()

        refresheventstatus()
    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        Connection.conn.Open()
        query = "Update tbl_event_entry SET event_status = 'FINISH' WHERE event_entry_id = '" +
            lbl_event_id.Text + "'"
        cmd = New MySqlCommand(query, Connection.conn)
        cmd.ExecuteNonQuery()
        Connection.conn.Close()

        refresheventstatus()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        global_functions.displayStudentsUnderEventEntry(lbl_event_id.Text)
    End Sub

    Function isListLoadedWithStudents()
        Connection.conn.Open()
        query = "SELECT COUNT(*) as number from tbl_attendance where event_entry_id = '" + lbl_event_id.Text + "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader

        If reader.Read Then
            If reader.GetInt16("number") > 0 Then
                Connection.conn.Close()
                Return True
            Else
                Connection.conn.Close()
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim event_entry_id As String = lbl_event_id.Text
        Dim result As Integer = MessageBox.Show("Are you sure to cancel the attendance for this event?",
            "Cancel Attendance", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            pnlmenu.Visible = False
        ElseIf result = DialogResult.Yes Then

            If event_rating_enabled = "Yes" Then
                query = "DELETE a, b, c from tbl_event_entry a inner join tbl_attendance b on a.event_entry_id " &
                    "= b.event_entry_id inner join tbl_event_assessment c on b.attendance_entry = " &
                    "c.attendance_entry_id WHERE a.event_entry_id = '" + event_entry_id + "'"
            Else
                If Not isListLoadedWithStudents() Then
                    query = "DELETE from tbl_event_entry WHERE event_entry_id = '" + event_entry_id + "'"
                Else
                    query = "DELETE a, b from tbl_event_entry a inner join tbl_attendance b on a.event_entry_id " &
                    "= b.event_entry_id WHERE a.event_entry_id = '" + event_entry_id + "'"
                End If
            End If

            Connection.conn.Open()
            cmd = New MySqlCommand(query, Connection.conn)
            cmd.ExecuteNonQuery()
            Connection.conn.Close()

            Close()
        End If

    End Sub

    Private Sub tbsearch_TextChanged(sender As Object, e As EventArgs) Handles tbsearch.TextChanged
        Dim user_query As String = tbsearch.Text
        Dim event_entry_id As String = lbl_event_id.Text

        If user_query <> "" Then
            displayStudentsUnderEventEntryModified(event_entry_id, user_query)
        Else
            global_functions.displayStudentsUnderEventEntry(event_entry_id)
        End If
    End Sub

    Sub displayStudentsUnderEventEntryModified(event_entry_id, user_query)
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        dgv_student.ColumnCount = 5
        dgv_student.Columns(0).Name = "attendance_entry"
        dgv_student.Columns(0).Visible = False
        dgv_student.Columns(1).Name = "Student ID"
        dgv_student.Columns(2).Name = "Name"
        dgv_student.Columns(3).Name = "Sign IN"
        dgv_student.Columns(4).Name = "Sign OUT"
        dgv_student.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT attendance_entry, student_id, CONCAT(student_first_name, ' ', student_last_name)" &
            "AS 'Name', log_in_time, log_out_time FROM tbl_attendance a, tbl_student_assigned_to_list b, " &
            "tbl_student c, tbl_event_entry d WHERE b.student_assigned_to_list_id = " &
            "a.student_assigned_to_list_id And c.student_entry = b.student_entry_id And d.event_entry_id " &
            "= a.event_entry_id And a.event_entry_id = '" & event_entry_id & "' AND (student_first_name LIKE '" &
            user_query & "%' OR student_last_name LIKE '" & user_query & "%' OR student_id LIKE '" & user_query &
            "%')"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim converted_log_in As String
            Dim converted_log_out As String
            Dim attendance_id As String = reader.GetString("attendance_entry")
            Dim student_id As String = reader.GetString("student_id")
            Dim name As String = WebUtility.HtmlDecode(reader.GetString("Name"))

            If Not reader.IsDBNull(3) Then
                Dim log_in As Date = reader.GetString("log_in_time")
                Dim log_in_time_string As Date = Date.Parse(log_in).ToString("HH:mm tt")
                converted_log_in = log_in_time_string.ToString("hh:mm tt")
            Else
                converted_log_in = ""
            End If

            If Not reader.IsDBNull(4) Then
                Dim log_out As Date = reader.GetString("log_out_time")
                Dim log_out_time_string As Date = Date.Parse(log_out).ToString("HH:mm tt")
                converted_log_out = log_out_time_string.ToString("hh:mm tt")
            Else
                converted_log_out = ""
            End If

            Dim row As String() = New String() {attendance_id, student_id, name, converted_log_in,
                converted_log_out}

            dgv_student.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If pnlmenu.Visible = False Then
            pnlmenu.Visible = True
        ElseIf pnlmenu.Visible Then
            pnlmenu.Visible = False
        End If
    End Sub
End Class