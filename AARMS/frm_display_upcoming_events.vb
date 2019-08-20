Imports MySql.Data.MySqlClient
Imports System.Net

Public Class frm_display_upcoming_events
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim row As DataGridViewRow

    Sub displayUpcomingEvents()
        Dim current_month As Integer = Date.Parse(global_functions.getCurrentDate).Month
        Dim current_day As Integer = Date.Parse(global_functions.getCurrentDate).Day
        Dim selected_month As Integer = returnMonthValueFromMonthSelected()

        dgv_upcoming_events.ColumnCount = 5
        dgv_upcoming_events.Columns(0).Name = "event_entry_id"
        dgv_upcoming_events.Columns(0).Visible = False
        dgv_upcoming_events.Columns(1).Name = "Event"
        dgv_upcoming_events.Columns(2).Name = "Day"
        dgv_upcoming_events.Columns(3).Name = "Session"
        dgv_upcoming_events.Columns(4).Name = "Attendance Status"
        dgv_upcoming_events.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT event_entry_id, event_title AS 'Event', event_date AS 'Date', " &
            "session AS 'Session', event_status FROM tbl_event_entry a, tbl_event b " &
            "WHERE b.event_id = a.event_id AND event_status <> 'FINISH' ORDER BY a.event_date"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim day As Integer = Date.Parse(reader.GetMySqlDateTime("Date")).Day
            Dim month As Integer = Date.Parse(reader.GetMySqlDateTime("Date")).Month

            If selected_month = current_month Then
                If day >= current_day And month = selected_month Then
                    Dim event_entry_id As String = reader.GetString("event_entry_id")
                    Dim event_title As String = WebUtility.HtmlDecode(reader.GetString("Event"))
                    Dim event_day As String = Date.Parse(reader.GetMySqlDateTime("Date")).Day.ToString
                    Dim session As String = reader.GetString("Session")
                    Dim attendance_status As String = reader.GetString("event_status")

                    Dim row As String() = New String() {event_entry_id, event_title, event_day, session,
                        attendance_status}
                    dgv_upcoming_events.Rows.Add(row)
                End If

            Else
                Dim event_entry_id As String = reader.GetString("event_entry_id")
                Dim event_title As String = WebUtility.HtmlDecode(reader.GetString("Event"))
                Dim event_day As String = Date.Parse(reader.GetMySqlDateTime("Date")).Day.ToString
                Dim session As String = reader.GetString("Session")
                Dim attendance_status As String = reader.GetString("event_status")
                Dim row As String() = New String() {event_entry_id, event_title, event_day, session,
                    attendance_status}

                dgv_upcoming_events.Rows.Add(row)
            End If

        End While
        Connection.conn.Close()
    End Sub

    Function returnMonthValueFromMonthSelected()
        Dim month As String = cmb_month_selected.Text

        Select Case month
            Case "January"
                Return 1
            Case "February"
                Return 2
            Case "March"
                Return 3
            Case "April"
                Return 4
            Case "May"
                Return 5
            Case "June"
                Return 6
            Case "July"
                Return 7
            Case "August"
                Return 8
            Case "September"
                Return 9
            Case "October"
                Return 10
            Case "November"
                Return 11
            Case Else
                Return 12
        End Select
    End Function

    Private Sub cmb_month_selected_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles cmb_month_selected.SelectionChangeCommitted

        displayUpcomingEvents()
    End Sub


    Private Sub Frmdisplayevents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_month_selected.Text = Format(Today.Date, "MMMM")
        displayUpcomingEvents()

    End Sub

    Private Sub dgv_upcoming_events_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgv_upcoming_events.CellDoubleClick

        If e.RowIndex >= 0 Then
            row = dgv_upcoming_events.Rows(e.RowIndex)
            Dim event_entry_id As String = row.Cells("event_entry_id").Value.ToString

            global_functions.displayStudentsUnderEventEntry(event_entry_id)
            global_functions.loadEventDetailsAndRatingStatus(event_entry_id)

            frm_display_attendance_monitoring.pnlmenu.Visible = False
            frm_display_attendance_monitoring.ShowDialog()
        End If
    End Sub

End Class