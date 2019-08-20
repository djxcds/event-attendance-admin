Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_display_attendance_logs
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim overall As Decimal

    Sub loadSchoolYear()
        Try
            Connection.conn.Open()
            query = "SELECT DISTINCT school_year FROM tbl_event_entry ORDER BY school_year ASC"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    cmb_school_year.Items.Add(reader("school_year"))
                End While
            End If
            Connection.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub loadStudentList()
        Connection.conn.Open()

        query = "SELECT list_title FROM tbl_student_list"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read()
                cmb_student_list.Items.Add(WebUtility.HtmlDecode(reader("list_title")))
            End While
        End If

        Connection.conn.Close()
    End Sub

    Sub displayEvents()
        Dim school_year As String = cmb_school_year.Text
        Dim semester As String = cmb_semester.Text
        Dim list_title As String = WebUtility.HtmlEncode(cmb_student_list.Text)

        dgv_events.ColumnCount = 5
        dgv_events.Columns(0).Name = "event_entry_id"
        dgv_events.Columns(0).Visible = False
        dgv_events.Columns(1).Name = "Event"
        dgv_events.Columns(2).Name = "Date"
        dgv_events.Columns(3).Name = "Session"
        dgv_events.Columns(4).Name = "Rating Enabled"
        dgv_events.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT DISTINCT a.event_entry_id, event_title, event_date, session, " &
            "event_rating_enabled from tbl_event_entry a, tbl_event b, tbl_attendance c, " &
            "tbl_student_assigned_to_list d, tbl_student_list e WHERE b.event_id = " &
            "a.event_id And c.event_entry_id = a.event_entry_id And d.student_assigned_to_list_id " &
            "= c.student_assigned_to_list_id And e.list_id = d.list_id And school_year = " &
            "'" & school_year & "' AND semester = '" & semester & "' and list_title = '" & list_title &
            "' AND event_status = 'FINISH'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim event_entry_id As String = reader.GetString("event_entry_id")
            Dim event_title As String = WebUtility.HtmlDecode(reader.GetString("event_title"))
            Dim event_date As String = reader.GetMySqlDateTime("event_date")
            Dim session As String = reader.GetString("session")
            Dim rating_enabled As String = reader.GetString("event_rating_enabled")

            Dim row As String() = New String() {event_entry_id, event_title, event_date, session, rating_enabled}
            dgv_events.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Private Sub frmdisplayattendancelogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_school_year.Items.Clear()
        cmb_student_list.Items.Clear()

        loadStudentList()

        If cmb_student_list.Items.Count <> 0 Then
            cmb_student_list.SelectedIndex = 0
        End If

        loadSchoolYear()

        If cmb_school_year.Items.Count Then
            cmb_school_year.SelectedIndex = 0
        End If

        cmb_semester.SelectedIndex = 0
        displayEvents()
    End Sub

    Private Sub cmb_school_year_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmb_school_year.SelectionChangeCommitted

        displayEvents()
    End Sub

    Private Sub cmb_semester_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmb_semester.SelectionChangeCommitted

        displayEvents()
    End Sub

    Private Sub cmb_student_list_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmb_student_list.SelectionChangeCommitted

        displayEvents()
    End Sub

    Private Sub dgv_events_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles _
        dgv_events.CellDoubleClick

        Try
            If e.RowIndex >= 0 Then
                Dim rowValue As DataGridViewRow = dgv_events.Rows(e.RowIndex)
                Dim event_entry_id As String = rowValue.Cells("event_entry_id").Value.ToString
                Dim list_title As String = cmb_student_list.Text

                loadStudents(event_entry_id)
                loadRatingsAndRemarks(event_entry_id)

                frm_display_attendance_log_details.tbtitle.Text = rowValue.Cells("Event").Value.ToString
                frm_display_attendance_log_details.tb_student_list.Text = list_title
                frm_display_attendance_log_details.lbl_event_id.Text = event_entry_id
                frm_display_attendance_log_details.pnlmenu.Visible = False
                frm_display_attendance_log_details.Show()

            End If
        Catch ex As MySqlException
            MsgBox("Could not connect to server.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub loadStudents(event_entry_id)
        frm_display_attendance_log_details.dgv_attendance_details.ColumnCount = 6
        frm_display_attendance_log_details.dgv_attendance_details.Columns(0).Name = "attendance_entry"
        frm_display_attendance_log_details.dgv_attendance_details.Columns(0).Visible = False
        frm_display_attendance_log_details.dgv_attendance_details.Columns(1).Name = "Student ID"
        frm_display_attendance_log_details.dgv_attendance_details.Columns(2).Name = "Name"
        frm_display_attendance_log_details.dgv_attendance_details.Columns(3).Name = "Sign IN"
        frm_display_attendance_log_details.dgv_attendance_details.Columns(4).Name = "Sign OUT"
        frm_display_attendance_log_details.dgv_attendance_details.Columns(5).Name = "Comm. Labor"
        frm_display_attendance_log_details.dgv_attendance_details.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT attendance_entry, student_id, CONCAT(student_first_name, ' ', student_last_name)" &
            "AS 'Name', log_in_time, log_out_time, community_labor_minutes as 'cl' FROM tbl_attendance a, " &
            "tbl_student_assigned_to_list b, tbl_student c, tbl_event_entry d WHERE " &
            "b.student_assigned_to_list_id = a.student_assigned_to_list_id And c.student_entry = " &
            "b.student_entry_id And d.event_entry_id = a.event_entry_id And a.event_entry_id = '" &
            event_entry_id & "'"
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
            frm_display_attendance_log_details.dgv_attendance_details.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Sub loadRatingsAndRemarks(event_entry_id)
        setRatingsAndRemarksToDefault()

        If returnEventEnabledValue(event_entry_id) = "Yes" Then
            retrieveStarRatings(event_entry_id)
        End If
    End Sub

    Function returnEventEnabledValue(event_entry_id)
        Connection.conn.Open()
        query = "SELECT event_rating_enabled FROM tbl_event_entry WHERE event_entry_id = '" & event_entry_id & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            Dim event_enabled_value As String = reader.GetString("event_rating_enabled")

            Connection.conn.Close()

            Return event_enabled_value
        Else
            Connection.conn.Close()
            Return "No"
        End If

    End Function

    Sub setRatingsAndRemarksToDefault()
        frm_display_attendance_log_details.btn_view_review.Enabled = False
        frm_display_attendance_log_details.lbloverall.Text = "0"
        frm_display_attendance_log_details.starrating.Value = 0
        frm_display_attendance_log_details.lblfive.Text = "0"
        frm_display_attendance_log_details.lblfour.Text = "0"
        frm_display_attendance_log_details.lblthree.Text = "0"
        frm_display_attendance_log_details.lbltwo.Text = "0"
        frm_display_attendance_log_details.lblone.Text = "0"
        frm_display_attendance_log_details.lblzero.Text = "0"
        frm_display_attendance_log_details.lbltotal.Text = "0"
        frm_display_attendance_log_details.lblmessage.Text = "RATINGS & REMARKS NOT AVAILABLE"
    End Sub

    Sub retrieveStarRatings(event_entry_id)
        Dim total, fivestar, fourstar, threestar, twostar, onestar, zerostar As Decimal

        Connection.conn.Open()
        query = "select SUM(CASE WHEN event_rating <> '0' THEN 1 ELSE 0 END) as 'total', " &
            "SUM(CASE WHEN event_rating = '5' THEN 1 ELSE 0 END) AS fivestar, " &
            "SUM(CASE WHEN event_rating = '4' THEN 1 ELSE 0 END) AS fourstar, " &
            "SUM(CASE WHEN event_rating = '3' THEN 1 ELSE 0 END) AS threestar, " &
            "SUM(CASE WHEN event_rating = '2' THEN 1 ELSE 0 END) AS twostar, " &
            "SUM(CASE WHEN event_rating = '1' THEN 1 ELSE 0 END) AS onestar, " &
            "SUM(CASE WHEN event_rating = '0' THEN 1 ELSE 0 END) AS zerostar from " &
            "tbl_event_assessment a, tbl_attendance b WHERE b.attendance_entry = " &
            "a.attendance_entry_id And b.event_entry_id = '" & event_entry_id & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            total = reader.GetString("total")
            fivestar = reader.GetString("fivestar")
            fourstar = reader.GetString("fourstar")
            threestar = reader.GetString("threestar")
            twostar = reader.GetString("twostar")
            onestar = reader.GetString("onestar")
            zerostar = reader.GetString("zerostar")
        End If

        Connection.conn.Close()

        Try
            overall = (((5 * fivestar) + (4 * fourstar) + (3 * threestar) + (2 * twostar) +
                (1 * onestar)) / total)
        Catch ex As DivideByZeroException
            overall = 0
        End Try

        Select Case overall
            Case 4.5 To 5
                frm_display_attendance_log_details.starrating.Value = 5
            Case 3.5 To 4.4
                frm_display_attendance_log_details.starrating.Value = 4
            Case 2.5 To 3.4
                frm_display_attendance_log_details.starrating.Value = 3
            Case 1.5 To 2.4
                frm_display_attendance_log_details.starrating.Value = 2
            Case Else
                frm_display_attendance_log_details.starrating.Value = 1
        End Select

        frm_display_attendance_log_details.lbloverall.Text = Math.Round(overall, 1,
            MidpointRounding.AwayFromZero).ToString
        frm_display_attendance_log_details.lblfive.Text = fivestar.ToString
        frm_display_attendance_log_details.lblfour.Text = fourstar.ToString
        frm_display_attendance_log_details.lblthree.Text = threestar.ToString
        frm_display_attendance_log_details.lbltwo.Text = twostar.ToString
        frm_display_attendance_log_details.lblone.Text = onestar.ToString
        frm_display_attendance_log_details.lbltotal.Text = total.ToString
        frm_display_attendance_log_details.lblmessage.Text = ""
        frm_display_attendance_log_details.btn_view_review.Enabled = True
        frm_display_attendance_log_details.lblzero.Text = zerostar.ToString
    End Sub

End Class