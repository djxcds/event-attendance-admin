Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_create_attendance
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim event_id, list_id As String
    Dim uniqueID As String

    Private Sub frmrunattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_events()
        load_student_list()

        If cb_student_list.Items.Count <> 0 Then
            cb_student_list.SelectedIndex = 0
        End If

        cb_semester.SelectedIndex = 0
        cb_school_year.SelectedIndex = 0
        cb_session.SelectedIndex = 0
    End Sub

    Sub load_events()
        cb_events.Items.Clear()

        Connection.conn.Open()
        query = "SELECT event_title FROM tbl_event"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                cb_events.Items.Add(WebUtility.HtmlDecode(reader("event_title")))
            End While
        End If
        Connection.conn.Close()
    End Sub

    Sub load_student_list()
        cb_student_list.Items.Clear()

        Connection.conn.Open()
        query = "SELECT list_title FROM tbl_student_list"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                cb_student_list.Items.Add(WebUtility.HtmlDecode(reader("list_title")))
            End While
        End If
        Connection.conn.Close()
    End Sub

    Function isEventExist()
        Dim date_picked = dtp_date.Value.ToString("yyyy/MM/dd")
        Dim session As String = cb_session.Text
        Dim semester As String = cb_semester.Text
        Dim school_year As String = cb_school_year.Text

        Connection.conn.Open()
        query = "SELECT * FROM tbl_event_entry WHERE event_id = '" + event_id + "' AND event_date = '" _
            & date_picked & "' AND session = '" & session & "'AND school_year = '" & school_year & "' AND " &
            "semester = '" & semester & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader
        If reader.Read Then
            Connection.conn.Close()
            Return True
        Else
            Connection.conn.Close()
            Return False
        End If

    End Function

    Sub loadEventDetails()
        Dim event_title As String = WebUtility.HtmlEncode(cb_events.Text)

        Try
            Connection.conn.Open()
            query = "select event_description from tbl_event where event_title = '" + event_title + "'"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader

            If reader.Read Then
                tbdesc.Text = reader.GetString("event_description")
            End If

            Connection.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub loadListId()
        Dim list_title As String = WebUtility.HtmlEncode(cb_student_list.Text)

        Try
            Connection.conn.Open()
            query = "select list_id from tbl_student_list where list_title = '" + list_title + "'"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader

            If reader.Read Then
                list_id = reader.GetString("list_id")
            End If

            Connection.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub loadEventId()
        Dim event_title As String = WebUtility.HtmlEncode(cb_events.Text)

        Connection.conn.Open()
        Try
            query = "SELECT event_id FROM tbl_event WHERE event_title = '" + event_title + "'"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                event_id = reader.GetString("event_id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Connection.conn.Close()
    End Sub

    Function isEventSelectedExistInDatabase()
        Dim event_title As String = WebUtility.HtmlEncode(cb_events.Text)

        Try
            Connection.conn.Open()
            query = "SELECT * FROM tbl_event WHERE event_title = '" + event_title + "'"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                Connection.conn.Close()
                Return True
            Else
                Connection.conn.Close()
                Return False
            End If
        Catch ex As Exception
            Connection.conn.Close()
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim date_picked = dtp_date.Value.ToString("yyyy/MM/dd")
            Dim event_title As String = cb_events.Text
            Dim session As String = cb_session.Text

            If tb_penalty_full.Text = "" Or tb_penalty_half.Text = "" Then
                MsgBox("Fill up missing information", MsgBoxStyle.Exclamation)
            Else

                If isEventSelectedExistInDatabase() Then
                    loadEventId()               ' Do not remove.
                    generateUniqueId()         ' Do not remove.

                    If Not isEventExist() Then
                        createEventEntry()
                        loadListId()
                        insertStudentsIntoAttendance()
                        global_functions.loadEventDetailsAndRatingStatus(uniqueID)
                        global_functions.displayStudentsUnderEventEntry(uniqueID)

                        Close()

                        frm_display_attendance_monitoring.ShowDialog()
                    Else
                        MsgBox("Cannot create attendance. Opening the existing attendance.",
                               MsgBoxStyle.Information)

                        global_functions.displayStudentsUnderEventEntry(loadEventEntryID())
                        global_functions.loadEventDetailsAndRatingStatus(loadEventEntryID())

                        Close()

                        frm_display_attendance_monitoring.ShowDialog()
                    End If

                Else
                    MsgBox("Event you entered or choosed is not found.", MsgBoxStyle.Exclamation)
                End If

            End If

        Catch exMysql As MySqlException
            MsgBox("Error occured. Could not connect to server.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function loadEventEntryID()
        Dim date_picked = dtp_date.Value.ToString("yyyy/MM/dd")
        Dim session As String = cb_session.Text
        Dim semester As String = cb_semester.Text
        Dim school_year As String = cb_school_year.Text

        Connection.conn.Open()
        query = "SELECT * FROM tbl_event_entry WHERE event_id = '" + event_id + "' AND event_date = '" _
            & date_picked & "' AND session = '" & session & "'AND school_year = '" & school_year & "' AND " &
            "semester = '" & semester & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader

        If reader.Read Then
            Dim event_entry_id = reader.GetString("event_entry_id")

            Connection.conn.Close()

            Return event_entry_id
        Else
            Return 0
        End If

    End Function

    Sub generateUniqueId()
        uniqueID = dtp_date.Value.ToString("yyyyMMddhhmmss") & "-" & event_id
    End Sub

    Sub createEventEntry()
        Dim current_date As String = Date.Parse(global_functions.getCurrentDate).ToString("yyyy-MM-dd")
        Dim date_pick As String = dtp_date.Value.ToString("yyyy/MM/dd")
        Dim penalty_full As String = tb_penalty_full.Text
        Dim penalty_half As String = tb_penalty_half.Text
        Dim school_year As String = cb_school_year.Text
        Dim semester As String = cb_semester.Text

        If cb_review.Checked Then
            query = "INSERT INTO tbl_event_entry(event_entry_id, event_id, event_date, " &
                "event_entry_date_created, session, school_year, semester, event_rating_enabled, " &
                "event_status, penalty_full, penalty_half) VALUES('" & uniqueID & "','" & event_id &
                "','" & date_pick & "', '" & current_date & "','" & cb_session.Text & "','" & school_year &
                "','" & semester & "','Yes','PAUSE', '" & penalty_full & "', '" & penalty_half & "')"
        Else
            query = "INSERT INTO tbl_event_entry(event_entry_id, event_id, event_date, event_entry_date_created, " &
                "session, school_year, semester, event_rating_enabled, event_status, penalty_full, " &
                "penalty_half) VALUES('" & uniqueID & "','" & event_id & "','" & date_pick & "', '" & current_date &
                "', '" & cb_session.Text & " ', '" & school_year & "', '" & semester & "', 'No', 'PAUSE', '" &
                penalty_full & "', '" & penalty_half & "')"
        End If

        Connection.conn.Open()
        cmd = New MySqlCommand(query, Connection.conn)
        cmd.ExecuteNonQuery()
        Connection.conn.Close()

    End Sub

    Sub insertStudentsIntoAttendance()
        Dim penalty_full As String = tb_penalty_full.Text

        Connection.conn.Open()

        query = "insert into tbl_attendance(event_entry_id, student_assigned_to_list_id, " &
                "community_labor_minutes) select '" & uniqueID &
                "', student_assigned_to_list_id,'" + penalty_full + "' " &
                "FROM tbl_student_assigned_to_list a, tbl_student_list b WHERE b.list_id = " &
                "a.list_id And a.list_id = '" & list_id & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        cmd.ExecuteNonQuery()
        Connection.conn.Close()

        If cb_review.Checked Then       ' If checked then insert also on event assessment table.
            Connection.conn.Open()
            query = "insert into tbl_event_assessment(attendance_entry_id, event_rating, " &
                "event_remarks) select attendance_entry, '0','' FROM tbl_attendance WHERE " &
                "event_entry_id = '" + uniqueID + "'"
            cmd = New MySqlCommand(query, Connection.conn)
            cmd.ExecuteNonQuery()
            Connection.conn.Close()
        End If
    End Sub

    Private Sub cmbevents_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles cb_events.SelectionChangeCommitted

        loadEventDetails()
    End Sub

    Private Sub cmbevents_TextUpdate(sender As Object, e As EventArgs) Handles cb_events.TextUpdate
        loadEventDetails()
    End Sub

    Private Sub cmbevents_SelectedValueChanged(sender As Object, e As EventArgs) Handles _
        cb_events.SelectedValueChanged

        loadEventDetails()
    End Sub
End Class