Imports MySql.Data.MySqlClient
Imports System.Net
Public Class global_functions

    Public Shared Function getCurrentDate()
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Connection.conn.Open()
        query = "SELECT NOW() as 'current_date'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            Dim date_time As Date = reader.GetMySqlDateTime("current_date")

            Connection.conn.Close()
            Return date_time
        Else
            Connection.conn.Close()
            Return Nothing
        End If
    End Function

    Public Shared Sub displayStudentsUnderEventEntry(event_entry_id)
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        frm_display_attendance_monitoring.dgv_student.ColumnCount = 5
        frm_display_attendance_monitoring.dgv_student.Columns(0).Name = "attendance_entry"
        frm_display_attendance_monitoring.dgv_student.Columns(0).Visible = False
        frm_display_attendance_monitoring.dgv_student.Columns(1).Name = "Student ID"
        frm_display_attendance_monitoring.dgv_student.Columns(2).Name = "Name"
        frm_display_attendance_monitoring.dgv_student.Columns(3).Name = "Sign IN"
        frm_display_attendance_monitoring.dgv_student.Columns(4).Name = "Sign OUT"
        frm_display_attendance_monitoring.dgv_student.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT attendance_entry, student_id, CONCAT(student_first_name, ' ', student_last_name)" &
            "AS 'Name', log_in_time, log_out_time FROM tbl_attendance a, tbl_student_assigned_to_list b, " &
            "tbl_student c, tbl_event_entry d WHERE b.student_assigned_to_list_id = " &
            "a.student_assigned_to_list_id And c.student_entry = b.student_entry_id And d.event_entry_id " &
            "= a.event_entry_id And a.event_entry_id = '" & event_entry_id & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim converted_log_in As String
            Dim converted_log_out As String

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


            Dim attendance_id As String = reader.GetString("attendance_entry")
            Dim student_id As String = reader.GetString("student_id")
            Dim name As String = WebUtility.HtmlDecode(reader.GetString("Name"))


            Dim row As String() = New String() {attendance_id, student_id, name, converted_log_in,
                converted_log_out}
            frm_display_attendance_monitoring.dgv_student.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Public Shared Sub loadEventDetailsAndRatingStatus(uniqueID)
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Connection.conn.Open()
        query = "select event_title, session, event_status, event_rating_enabled, event_date from " &
            "tbl_event_entry a, tbl_event b WHERE b.event_id = a.event_id And event_entry_id ='" & uniqueID & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader

        If reader.Read Then
            Dim event_status As String = reader.GetString("event_status")
            Dim event_title As String = WebUtility.HtmlDecode(reader.GetString("event_title"))
            Dim session As String = reader.GetString("session")
            Dim date_created As String = reader.GetMySqlDateTime("event_date")

            frm_display_attendance_monitoring.lbl_attendance_status.Text = reader.GetString("event_status")
            frm_display_attendance_monitoring.lblevent.Text = event_title
            frm_display_attendance_monitoring.lblsession.Text = session
            frm_display_attendance_monitoring.lbldate.Text = date_created
            frm_display_attendance_monitoring.lbl_event_id.Text = uniqueID

            If reader.GetString("event_rating_enabled") = "Yes" Then
                frm_display_attendance_monitoring.lblreviewstatus.Text = "REVIEW ENABLED"
                frm_display_attendance_monitoring.event_rating_enabled = "Yes"
            Else
                frm_display_attendance_monitoring.lblreviewstatus.Text = "REVIEW DISABLED"
                frm_display_attendance_monitoring.event_rating_enabled = "No"
            End If

        End If
        Connection.conn.Close()

    End Sub
End Class
