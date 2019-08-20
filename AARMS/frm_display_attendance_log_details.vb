Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_display_attendance_log_details
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Sub loadStudentsModified(event_entry_id, user_query)
        dgv_attendance_details.ColumnCount = 6
        dgv_attendance_details.Columns(0).Name = "attendance_entry"
        dgv_attendance_details.Columns(0).Visible = False
        dgv_attendance_details.Columns(1).Name = "Student ID"
        dgv_attendance_details.Columns(2).Name = "Name"
        dgv_attendance_details.Columns(3).Name = "Sign IN"
        dgv_attendance_details.Columns(4).Name = "Sign OUT"
        dgv_attendance_details.Columns(5).Name = "Comm. Labor"
        dgv_attendance_details.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT attendance_entry, student_id, CONCAT(student_first_name, ' ', student_last_name)" &
            "AS 'Name', log_in_time, log_out_time, community_labor_minutes as 'cl' FROM tbl_attendance a, " &
            "tbl_student_assigned_to_list b, tbl_student c, tbl_event_entry d WHERE " &
            "b.student_assigned_to_list_id = a.student_assigned_to_list_id And c.student_entry = " &
            "b.student_entry_id And d.event_entry_id = a.event_entry_id And a.event_entry_id = '" &
            event_entry_id & "' AND (student_first_name LIKE '" & user_query & "%' OR student_last_name " &
            "LIKE '" & user_query & "%' OR student_id LIKE '" & user_query & "%')"
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
            Dim cl As String = reader.GetString("cl")

            Dim row As String() = New String() {attendance_id, student_id, name, converted_log_in,
                converted_log_out, cl}

            dgv_attendance_details.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Dim user_query As String = WebUtility.HtmlEncode(tb_search.Text)
        Dim event_entry_id As String = lbl_event_id.Text

        If user_query <> "" Then
            loadStudentsModified(event_entry_id, user_query)
        Else
            frm_display_attendance_logs.loadStudents(event_entry_id)
        End If

    End Sub

    Private Sub btn_modify_cl_Click(sender As Object, e As EventArgs) Handles btn_modify_cl.Click
        pnlmenu.Visible = False
        frm_modify_cl.event_entry_id = lbl_event_id.Text
        frm_modify_cl.ShowDialog()
    End Sub

    Private Sub btn_view_review_Click(sender As Object, e As EventArgs) Handles btn_view_review.Click
        frm_display_review.dgv_review.ColumnCount = 1
        frm_display_review.dgv_review.Columns(0).Name = "Reviews"
        frm_display_review.dgv_review.Rows.Clear()
        Dim event_entry_id As String = lbl_event_id.Text

        Connection.conn.Open()
        query = "SELECT event_remarks FROM tbl_event_assessment a, tbl_attendance b WHERE b.attendance_entry = " &
            "a.attendance_entry_id And event_entry_id = '" & event_entry_id & "' ORDER BY RAND()"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim event_remarks As String = reader.GetString("event_remarks")

            If event_remarks <> "" Then
                Dim row As String() = New String() {event_remarks}
                frm_display_review.dgv_review.Rows.Add(row)
            End If
        End While
        Connection.conn.Close()

        frm_display_review.ShowDialog()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btn_open_cl_summary.Click
        frm_display_cl_summary.dgv_cl_summary.Rows.Clear()
        frm_display_cl_summary.dgv_cl_summary.Columns.Clear()
        frm_display_cl_summary.tb_summary_title.Text = ""
        frm_display_cl_summary.ShowDialog()
        pnlmenu.Visible = False
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If pnlmenu.Visible = False Then
            pnlmenu.Visible = True
        ElseIf pnlmenu.Visible Then
            pnlmenu.Visible = False
        End If
    End Sub
End Class