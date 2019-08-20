Imports MySql.Data.MySqlClient
Public Class frm_modify_cl
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public event_entry_id As String
    Dim previous_penalty_full, previous_penalty_half As String
    Private Sub frmmodifycl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.conn.Open()
        query = "select penalty_full, penalty_half from tbl_event_entry where event_entry_id = '" +
            event_entry_id + "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader

        If reader.Read Then
            tbfull.Text = reader("penalty_full")
            tbhalf.Text = reader("penalty_half")
            previous_penalty_full = reader("penalty_full")
            previous_penalty_half = reader("penalty_half")
        End If
        Connection.conn.Close()
    End Sub

    Private Sub btnreview_Click(sender As Object, e As EventArgs) Handles btnreview.Click
        Dim penalty_full As Integer = tbfull.Text
        Dim penalty_half As Integer = tbhalf.Text

        If penalty_full <> penalty_half And penalty_full <> previous_penalty_half And penalty_half <>
            previous_penalty_full And penalty_full > penalty_half Then

            Connection.conn.Open()
            query = "UPDATE tbl_event_entry SET penalty_full = '" & penalty_full & "', penalty_half = '" &
                penalty_half & "' WHERE event_entry_id = '" & event_entry_id & "'"
            cmd = New MySqlCommand(query, Connection.conn)
            cmd.ExecuteNonQuery()
            Connection.conn.Close()

            Connection.conn.Open()
            query = "UPDATE tbl_attendance SET community_labor_minutes = '" & penalty_full &
                "' where event_entry_id='" & event_entry_id & "' and community_labor_minutes = '" &
                previous_penalty_full & "'"
            cmd = New MySqlCommand(query, Connection.conn)
            cmd.ExecuteNonQuery()
            Connection.conn.Close()

            Connection.conn.Open()
            query = "UPDATE tbl_attendance SET community_labor_minutes = '" & penalty_half &
                "' WHERE event_entry_id='" & event_entry_id & "' and community_labor_minutes = '" &
                previous_penalty_half & "'"
            cmd = New MySqlCommand(query, Connection.conn)
            cmd.ExecuteNonQuery()
            Connection.conn.Close()

            frm_display_attendance_logs.loadStudents(event_entry_id)
            frm_display_attendance_logs.loadRatingsAndRemarks(event_entry_id)

            tbfull.Text = ""
            tbhalf.Text = ""
            previous_penalty_full = ""
            previous_penalty_half = ""

            Close()
        Else
            MsgBox("CL should be the same value, .")
        End If
    End Sub
End Class