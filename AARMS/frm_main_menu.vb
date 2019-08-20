Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_main_menu
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim current_date As Date = global_functions.getCurrentDate

    Private Sub frmmainmenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadCurrentMonthsUpcomingEvents()
        finishExpiredEvent()
    End Sub

    Private Sub frmmainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_month_number As Integer = Date.Parse(current_date).Month

        dgv_upcoming_events.DefaultCellStyle.SelectionBackColor =
            dgv_upcoming_events.DefaultCellStyle.BackColor
        dgv_upcoming_events.DefaultCellStyle.SelectionForeColor =
            dgv_upcoming_events.DefaultCellStyle.ForeColor

        finishExpiredEvent()
        loadCurrentMonthsUpcomingEvents()
        lblmonth.Text = "Calendar of Activities for " + MonthName(current_month_number)
    End Sub

    Sub loadCurrentMonthsUpcomingEvents()
        Dim current_day As Integer = Date.Parse(current_date).Day

        dgv_upcoming_events.ColumnCount = 4
        dgv_upcoming_events.Columns(0).Name = "event_entry_id"
        dgv_upcoming_events.Columns(0).Visible = False
        dgv_upcoming_events.Columns(1).Name = "Event"
        dgv_upcoming_events.Columns(2).Name = "Day"
        dgv_upcoming_events.Columns(3).Name = "Session"
        dgv_upcoming_events.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT event_entry_id, event_title AS 'Event', event_date AS 'Date', " &
            "session AS 'Session' FROM tbl_event_entry a, tbl_event b WHERE b.event_id " &
            "= a.event_id And event_status <> 'FINISH' ORDER BY a.event_date"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim day As Integer = Date.Parse(reader.GetMySqlDateTime("Date")).Day
            Dim month As Integer = Date.Parse(reader.GetMySqlDateTime("Date")).Month
            Dim current_month As Integer = Date.Parse(current_date).Month.ToString

            If day >= current_day And month = current_month Then
                Dim event_entry_id As String = reader.GetString("event_entry_id")
                Dim event_title As String = WebUtility.HtmlDecode(reader.GetString("Event"))
                Dim event_day As String = day.ToString
                Dim session As String = reader.GetString("Session")

                Dim row As String() = New String() {event_entry_id, event_title, event_day, session}
                dgv_upcoming_events.Rows.Add(row)
            End If

        End While
        Connection.conn.Close()
    End Sub

    Sub finishExpiredEvent()
        Dim current_date As String = Date.Parse(global_functions.getCurrentDate).ToString("yyyy-MM-dd")

        Connection.conn.Open()
        query = "UPDATE tbl_event_entry SET event_status = 'FINISH' WHERE event_date < '" &
            current_date & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        cmd.ExecuteNonQuery()
        Connection.conn.Close()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        frm_create_attendance.ShowDialog()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        frm_display_upcoming_events.ShowDialog()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        frm_display_attendance_logs.ShowDialog()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        frm_display_student_list.ShowDialog()
    End Sub

    Private Sub dgv_upcoming_events_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgv_upcoming_events.CellDoubleClick

        If e.RowIndex >= 0 Then
            Dim row = dgv_upcoming_events.Rows(e.RowIndex)
            Dim event_entry_id As String = row.Cells("event_entry_id").Value.ToString

            global_functions.displayStudentsUnderEventEntry(event_entry_id)
            global_functions.loadEventDetailsAndRatingStatus(event_entry_id)

            frm_display_attendance_monitoring.ShowDialog()
        End If
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        frm_display_stored_events.tb_event_title.Text = ""
        frm_display_stored_events.tb_event_description.Text = ""
        frm_display_stored_events.ShowDialog()
    End Sub

    Private Sub lbl_clickable_Click(sender As Object, e As EventArgs) Handles lbl_clickable.Click
        frm_about_me.ShowDialog()
    End Sub
End Class