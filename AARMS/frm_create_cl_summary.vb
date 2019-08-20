Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_create_cl_summary
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim summary_name, summaryquery, summaryquerytotal As String
    Dim event_id_array(15) As String
    Dim event_name_array(15) As String

    Sub loadDate()
        Try
            Dim school_year As String = cmb_school_year.Text
            Dim semester As String = cmb_semester.Text
            Dim list_title As String = cmb_list.Text

            cmb_date_range_one.Items.Clear()
            cmb_date_range_two.Items.Clear()

            Connection.conn.Open()
            query = "SELECT DISTINCT event_date FROM tbl_event_entry a, tbl_attendance b, " &
                "tbl_student_assigned_to_list c, tbl_student_list d WHERE b.event_entry_id = " &
                "a.event_entry_id And c.student_assigned_to_list_id = b.student_assigned_to_list_id " &
                "And d.list_id = c.list_id  And school_year = '" & school_year & "' AND semester = '" & semester &
                "' AND event_status = 'FINISH' AND d.list_title = '" & list_title & "' order by event_date"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim format_date As String = Format(reader.GetDateTime("event_date"), "yyyy-MM-dd").ToString

                    cmb_date_range_one.Items.Add(format_date)
                    cmb_date_range_two.Items.Add(format_date)
                End While
            End If
            Connection.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub loadList()
        Try
            cmb_list.Items.Clear()

            Connection.conn.Open()
            query = "SELECT list_title FROM tbl_student_list"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim list_title As String = WebUtility.HtmlDecode(reader("list_title"))

                    cmb_list.Items.Add(list_title)
                End While
            End If
            Connection.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function returnListID()
        Dim list_title As String = cmb_list.Text

        Connection.conn.Open()
        query = "SELECT list_id FROM tbl_student_list WHERE list_title = '" & list_title & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            Dim list_id As String = reader("list_id")

            Connection.conn.Close()

            Return list_id
        Else
            Return "0"
        End If
    End Function

    Private Sub Frmcreatesummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_school_year.SelectedIndex = 0
            cmb_semester.SelectedIndex = 0
            loadList()
            cmb_list.SelectedIndex = 0
            loadDate()

            cmb_date_range_one.SelectedIndex = 0
            cmb_date_range_two.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_query_Click(sender As Object, e As EventArgs) Handles btn_query.Click
        Dim school_year As String = cmb_school_year.Text
        Dim semester As String = cmb_semester.Text
        Dim list_title As String = cmb_list.Text
        Dim date_range_one As String = cmb_date_range_one.Text
        Dim date_range_two As String = cmb_date_range_two.Text

        clearEvents()

        Try
            Connection.conn.Open()
            query = "SELECT DISTINCT event_date, event_title, session, a.event_entry_id from tbl_event_entry a, " &
                "tbl_attendance b, tbl_student_assigned_to_list c, tbl_student_list d, tbl_event e WHERE " &
                "b.event_entry_id = a.event_entry_id And c.student_assigned_to_list_id = " &
                "b.student_assigned_to_list_id And d.list_id = c.list_id And e.event_id = a.event_id And semester = " &
                "'" & semester & "' AND school_year = '" & school_year & "' AND d.list_title = '" & list_title & "' AND " &
                "(event_date between '" & date_range_one & "' AND '" & date_range_two & "') and event_status = 'FINISH' " &
                "order by event_date"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim event_title As String = WebUtility.HtmlDecode(reader("event_title"))
                    Dim event_date As String = reader("event_date")
                    Dim event_session As String = reader("session")
                    Dim event_entry_id As String = reader("event_entry_id")

                    cmbevent1.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent2.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent3.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent4.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent5.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent6.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent7.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent8.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent9.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent10.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent11.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent12.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent13.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent14.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbevent15.Items.Add(event_date & " " & event_title & " " & event_session)
                    cmbeid1.Items.Add(event_entry_id)
                    cmbeid2.Items.Add(event_entry_id)
                    cmbeid3.Items.Add(event_entry_id)
                    cmbeid4.Items.Add(event_entry_id)
                    cmbeid5.Items.Add(event_entry_id)
                    cmbeid6.Items.Add(event_entry_id)
                    cmbeid7.Items.Add(event_entry_id)
                    cmbeid8.Items.Add(event_entry_id)
                    cmbeid9.Items.Add(event_entry_id)
                    cmbeid10.Items.Add(event_entry_id)
                    cmbeid11.Items.Add(event_entry_id)
                    cmbeid12.Items.Add(event_entry_id)
                    cmbeid13.Items.Add(event_entry_id)
                    cmbeid14.Items.Add(event_entry_id)
                    cmbeid15.Items.Add(event_entry_id)
                End While
            End If
            Connection.conn.Close()

            If cmbevent1.Items.Count <> 0 Then
                cb1.Enabled = True
            Else
                cb1.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub clearEvents()
        cmbevent1.Items.Clear()
        cmbevent2.Items.Clear()
        cmbevent3.Items.Clear()
        cmbevent4.Items.Clear()
        cmbevent5.Items.Clear()
        cmbevent6.Items.Clear()
        cmbevent7.Items.Clear()
        cmbevent8.Items.Clear()
        cmbevent9.Items.Clear()
        cmbevent10.Items.Clear()
        cmbevent11.Items.Clear()
        cmbevent12.Items.Clear()
        cmbevent13.Items.Clear()
        cmbevent14.Items.Clear()
        cmbevent15.Items.Clear()
        cmbeid1.Items.Clear()
        cmbeid2.Items.Clear()
        cmbeid3.Items.Clear()
        cmbeid4.Items.Clear()
        cmbeid5.Items.Clear()
        cmbeid6.Items.Clear()
        cmbeid7.Items.Clear()
        cmbeid8.Items.Clear()
        cmbeid9.Items.Clear()
        cmbeid10.Items.Clear()
        cmbeid11.Items.Clear()
        cmbeid12.Items.Clear()
        cmbeid13.Items.Clear()
        cmbeid14.Items.Clear()
        cmbeid15.Items.Clear()
        cb1.Enabled = False
        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        cb4.Checked = False
        cb5.Checked = False
        cb6.Checked = False
        cb7.Checked = False
        cb8.Checked = False
        cb9.Checked = False
        cb10.Checked = False
        cb11.Checked = False
        cb12.Checked = False
        cb13.Checked = False
        cb14.Checked = False
        cb15.Checked = False

    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked Then
            cmbevent1.Enabled = True
            cmbevent1.SelectedIndex = 0
            cmbeid1.SelectedIndex = cmbevent1.SelectedIndex
            cb2.Enabled = True
        Else
            cmbevent1.Enabled = False
            cmbevent1.SelectedIndex = -1
            cmbeid1.SelectedIndex = -1

            eventreset2()
            eventreset3()
            eventreset4()
            eventreset5()
            eventreset6()
            eventreset7()
            eventreset8()
            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked Then
            cmbevent2.Enabled = True
            cmbevent2.SelectedIndex = 0
            cmbeid2.SelectedIndex = cmbevent2.SelectedIndex
            cb3.Enabled = True
        Else
            cmbevent2.Enabled = False
            cmbevent2.SelectedIndex = -1
            cmbeid2.SelectedIndex = -1

            eventreset3()
            eventreset4()
            eventreset5()
            eventreset6()
            eventreset7()
            eventreset8()
            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked Then
            cmbevent3.Enabled = True
            cmbevent3.SelectedIndex = 0
            cmbeid3.SelectedIndex = cmbevent3.SelectedIndex
            cb4.Enabled = True
        Else
            cmbevent3.Enabled = False
            cmbevent3.SelectedIndex = -1
            cmbeid3.SelectedIndex = -1

            eventreset4()
            eventreset5()
            eventreset6()
            eventreset7()
            eventreset8()
            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked Then
            cmbevent4.Enabled = True
            cmbevent4.SelectedIndex = 0
            cmbeid4.SelectedIndex = cmbevent4.SelectedIndex
            cb5.Enabled = True
        Else
            cmbevent4.Enabled = False
            cmbevent4.SelectedIndex = -1
            cmbeid4.SelectedIndex = -1

            eventreset5()
            eventreset6()
            eventreset7()
            eventreset8()
            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb5_CheckedChanged(sender As Object, e As EventArgs) Handles cb5.CheckedChanged
        If cb5.Checked Then
            cmbevent5.Enabled = True
            cmbevent5.SelectedIndex = 0
            cmbeid5.SelectedIndex = cmbevent5.SelectedIndex
            cb6.Enabled = True
        Else
            cmbevent5.Enabled = False
            cmbevent5.SelectedIndex = -1
            cmbeid5.SelectedIndex = -1

            eventreset6()
            eventreset7()
            eventreset8()
            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb6_CheckedChanged(sender As Object, e As EventArgs) Handles cb6.CheckedChanged
        If cb6.Checked Then
            cmbevent6.Enabled = True
            cmbevent6.SelectedIndex = 0
            cmbeid6.SelectedIndex = cmbevent6.SelectedIndex
            cb7.Enabled = True
        Else
            cmbevent6.Enabled = False
            cmbevent6.SelectedIndex = -1
            cmbeid6.SelectedIndex = -1

            eventreset7()
            eventreset8()
            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb7_CheckedChanged(sender As Object, e As EventArgs) Handles cb7.CheckedChanged
        If cb7.Checked Then
            cmbevent7.Enabled = True
            cmbevent7.SelectedIndex = 0
            cmbeid7.SelectedIndex = cmbevent7.SelectedIndex
            cb8.Enabled = True
        Else
            cmbevent7.Enabled = False
            cmbevent7.SelectedIndex = -1
            cmbeid7.SelectedIndex = -1

            eventreset8()
            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb8_CheckedChanged(sender As Object, e As EventArgs) Handles cb8.CheckedChanged
        If cb8.Checked Then
            cmbevent8.Enabled = True
            cmbevent8.SelectedIndex = 0
            cmbeid8.SelectedIndex = cmbevent8.SelectedIndex
            cb9.Enabled = True
        Else
            cmbevent8.Enabled = False
            cmbevent8.SelectedIndex = -1
            cmbeid8.SelectedIndex = -1

            eventreset9()
            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb9_CheckedChanged(sender As Object, e As EventArgs) Handles cb9.CheckedChanged
        If cb9.Checked Then
            cmbevent9.Enabled = True
            cmbevent9.SelectedIndex = 0
            cmbeid9.SelectedIndex = cmbevent9.SelectedIndex
            cb10.Enabled = True
        Else
            cmbevent9.Enabled = False
            cmbevent9.SelectedIndex = -1
            cmbeid9.SelectedIndex = -1

            eventreset10()
            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb10_CheckedChanged(sender As Object, e As EventArgs) Handles cb10.CheckedChanged
        If cb10.Checked Then
            cmbevent10.Enabled = True
            cmbevent10.SelectedIndex = 0
            cmbeid10.SelectedIndex = cmbevent10.SelectedIndex
            cb11.Enabled = True
        Else
            cmbevent10.Enabled = False
            cmbevent10.SelectedIndex = -1
            cmbeid10.SelectedIndex = -1

            eventreset11()
            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb11_CheckedChanged(sender As Object, e As EventArgs) Handles cb11.CheckedChanged
        If cb11.Checked Then
            cmbevent11.Enabled = True
            cmbevent11.SelectedIndex = 0
            cmbeid11.SelectedIndex = cmbevent11.SelectedIndex
            cb12.Enabled = True
        Else
            cmbevent11.Enabled = False
            cmbevent11.SelectedIndex = -1
            cmbeid11.SelectedIndex = -1

            eventreset12()
            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb12_CheckedChanged(sender As Object, e As EventArgs) Handles cb12.CheckedChanged
        If cb12.Checked Then
            cmbevent12.Enabled = True
            cmbevent12.SelectedIndex = 0
            cmbeid12.SelectedIndex = cmbevent12.SelectedIndex
            cb13.Enabled = True
        Else
            cmbevent12.Enabled = False
            cmbevent12.SelectedIndex = -1
            cmbeid12.SelectedIndex = -1

            eventreset13()
            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb13_CheckedChanged(sender As Object, e As EventArgs) Handles cb13.CheckedChanged
        If cb13.Checked Then
            cmbevent13.Enabled = True
            cmbevent13.SelectedIndex = 0
            cmbeid13.SelectedIndex = cmbevent13.SelectedIndex
            cb14.Enabled = True
        Else
            cmbevent13.Enabled = False
            cmbevent13.SelectedIndex = -1
            cmbeid13.SelectedIndex = -1


            eventreset14()
            eventreset15()
        End If
    End Sub

    Private Sub cb14_CheckedChanged(sender As Object, e As EventArgs) Handles cb14.CheckedChanged
        If cb14.Checked Then
            cmbevent14.Enabled = True
            cmbevent14.SelectedIndex = 0
            cmbeid14.SelectedIndex = cmbevent14.SelectedIndex
            cb15.Enabled = True
        Else
            cmbevent14.Enabled = False
            cmbevent14.SelectedIndex = -1
            cmbeid14.SelectedIndex = -1

            eventreset15()
        End If
    End Sub

    Private Sub cb15_CheckedChanged(sender As Object, e As EventArgs) Handles cb15.CheckedChanged
        If cb15.Checked Then
            cmbevent15.Enabled = True
            cmbevent15.SelectedIndex = 0
            cmbeid15.SelectedIndex = cmbevent15.SelectedIndex
        Else
            cmbevent15.Enabled = False
            cmbevent15.SelectedIndex = -1
            cmbeid15.SelectedIndex = -1
        End If
    End Sub
    Sub assignEventsToArray(summary_id)
        Try
            Array.Clear(event_name_array, 0, 15)
            Array.Clear(event_id_array, 0, 15)

            Dim event_number_array() As String = {"event_one", "event_two", "event_three", "event_four",
                "event_five", "event_six", "event_seven", "event_eight", "event_nine", "event_ten", "event_eleven",
                "event_twelve", "event_thirteen", "event_fourteen", "event_fifteen"}

            Connection.conn.Open()
            query = "select * from tbl_community_labor_summary where summary_entry = '" & summary_id & "'"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader()

            If reader.Read Then
                For event_number_counter = 0 To 14
                    If reader(event_number_array(event_number_counter)) <> "" Then
                        event_id_array(event_number_counter) = reader(event_number_array(event_number_counter))
                    End If
                Next

                summary_name = reader("summary_title")
            End If
            Connection.conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub getEventTitle()
        Try
            For counter = 0 To 14
                Connection.conn.Open()
                query = "SELECT event_title FROM tbl_event_entry a, tbl_event b WHERE b.event_id = " &
                    "a.event_id And event_entry_id = '" & event_id_array(counter) & "'"
                cmd = New MySqlCommand(query, Connection.conn)
                reader = cmd.ExecuteReader()

                If reader.Read Then
                    Dim event_title As String = WebUtility.HtmlDecode(reader("event_title"))

                    event_name_array(counter) = event_title
                End If
                Connection.conn.Close()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub makeCLQuery(list_id)
        summaryquery = ""
        summaryquerytotal = ""
        summaryquery = "SELECT CONCAT(student_last_name, ', ', student_first_name) AS 'Student'"
        summaryquerytotal = ", (SELECT "

        If event_id_array(0) <> "" Then
            summaryquery = summaryquery + ", SUM(IF(a.event_entry_id = '" & event_id_array(0) & "', " &
                "a.community_labor_minutes, ' ')) as '" + event_name_array(0) + "'"
            summaryquerytotal = summaryquerytotal + "SUM(IF(a.event_entry_id = '" & event_id_array(0) &
                "', a.community_labor_minutes, ' '))"
        End If

        For counter = 1 To 14
            If event_id_array(counter) <> "" Then
                summaryquery = summaryquery + ", SUM(IF(a.event_entry_id = '" & event_id_array(counter) &
                    "', a.community_labor_minutes, ' ')) as '" + event_name_array(counter) + "'"
                summaryquerytotal = summaryquerytotal + "+SUM(IF(a.event_entry_id = '" & event_id_array(counter) _
                & "', a.community_labor_minutes, ' '))"
            End If

        Next

        summaryquery = summaryquery + summaryquerytotal + ") AS Total from tbl_attendance a, tbl_student_assigned_to_list b, " &
            "tbl_student c, tbl_student_list d WHERE b.student_assigned_to_list_id = a.student_assigned_to_list_id And " &
            "c.student_entry = b.student_entry_id And d.list_id = b.list_id And d.list_id = '" & list_id & "' group by " &
            "c.student_id order by c.student_last_name"

    End Sub

    Sub eventreset2()
        cmbevent2.Enabled = False
        cmbevent2.SelectedIndex = -1
        cmbeid2.SelectedIndex = -1
        cb2.Enabled = False
        cb2.Checked = False
    End Sub

    Sub eventreset3()
        cmbevent3.Enabled = False
        cmbevent3.SelectedIndex = -1
        cmbeid3.SelectedIndex = -1
        cb3.Enabled = False
        cb3.Checked = False
    End Sub

    Sub eventreset4()
        cmbevent4.Enabled = False
        cmbevent4.SelectedIndex = -1
        cmbeid4.SelectedIndex = -1
        cb4.Enabled = False
        cb4.Checked = False
    End Sub

    Sub eventreset5()
        cmbevent5.Enabled = False
        cmbevent5.SelectedIndex = -1
        cmbeid5.SelectedIndex = -1
        cb5.Enabled = False
        cb5.Checked = False
    End Sub

    Sub eventreset6()
        cmbevent6.Enabled = False
        cmbevent6.SelectedIndex = -1
        cmbeid6.SelectedIndex = -1
        cb6.Enabled = False
        cb6.Checked = False
    End Sub

    Sub eventreset7()
        cmbevent7.Enabled = False
        cmbevent7.SelectedIndex = -1
        cmbeid7.SelectedIndex = -1
        cb7.Enabled = False
        cb7.Checked = False
    End Sub

    Sub eventreset8()
        cmbevent8.Enabled = False
        cmbevent8.SelectedIndex = -1
        cmbeid8.SelectedIndex = -1
        cb8.Enabled = False
        cb8.Checked = False
    End Sub

    Sub eventreset9()
        cmbevent9.Enabled = False
        cmbevent9.SelectedIndex = -1
        cmbeid9.SelectedIndex = -1
        cb9.Enabled = False
        cb9.Checked = False
    End Sub

    Sub eventreset10()
        cmbevent10.Enabled = False
        cmbevent10.SelectedIndex = -1
        cmbeid10.SelectedIndex = -1
        cb10.Enabled = False
        cb10.Checked = False
    End Sub

    Sub eventreset11()
        cmbevent11.Enabled = False
        cmbevent11.SelectedIndex = -1
        cmbeid11.SelectedIndex = -1
        cb11.Enabled = False
        cb11.Checked = False
    End Sub

    Sub eventreset12()
        cmbevent12.Enabled = False
        cmbevent12.SelectedIndex = -1
        cmbeid12.SelectedIndex = -1
        cb12.Enabled = False
        cb12.Checked = False
    End Sub

    Sub eventreset13()
        cmbevent13.Enabled = False
        cmbevent13.SelectedIndex = -1
        cmbeid13.SelectedIndex = -1
        cb13.Enabled = False
        cb13.Checked = False
    End Sub

    Sub eventreset14()
        cmbevent14.Enabled = False
        cmbevent14.SelectedIndex = -1
        cmbeid14.SelectedIndex = -1
        cb14.Enabled = False
        cb14.Checked = False
    End Sub

    Sub eventreset15()
        cmbevent15.Enabled = False
        cmbevent15.SelectedIndex = -1
        cmbeid15.SelectedIndex = -1
        cb15.Enabled = False
        cb15.Checked = False
    End Sub

    Private Sub cmbevent1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent1.SelectionChangeCommitted

        cmbeid1.SelectedIndex = cmbevent1.SelectedIndex
    End Sub

    Private Sub cmbevent2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent2.SelectionChangeCommitted

        cmbeid2.SelectedIndex = cmbevent2.SelectedIndex
    End Sub

    Private Sub cmbevent3_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent3.SelectionChangeCommitted

        cmbeid3.SelectedIndex = cmbevent3.SelectedIndex
    End Sub

    Private Sub cmbevent4_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent4.SelectionChangeCommitted

        cmbeid4.SelectedIndex = cmbevent4.SelectedIndex
    End Sub

    Private Sub cmbevent5_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent5.SelectionChangeCommitted

        cmbeid5.SelectedIndex = cmbevent5.SelectedIndex
    End Sub

    Private Sub cmbevent6_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent6.SelectionChangeCommitted

        cmbeid6.SelectedIndex = cmbevent6.SelectedIndex
    End Sub

    Private Sub cmbevent7_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent7.SelectionChangeCommitted

        cmbeid7.SelectedIndex = cmbevent7.SelectedIndex
    End Sub

    Private Sub cmbevent8_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent8.SelectionChangeCommitted

        cmbeid8.SelectedIndex = cmbevent8.SelectedIndex
    End Sub

    Private Sub cmbevent9_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent9.SelectionChangeCommitted

        cmbeid9.SelectedIndex = cmbevent9.SelectedIndex
    End Sub

    Private Sub cmbevent10_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent10.SelectionChangeCommitted

        cmbeid10.SelectedIndex = cmbevent10.SelectedIndex
    End Sub

    Private Sub cmbevent11_SelectedValueChanged(sender As Object, e As EventArgs) Handles _
        cmbevent11.SelectedValueChanged

        cmbeid11.SelectedIndex = cmbevent11.SelectedIndex
    End Sub

    Private Sub cmbevent12_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent12.SelectionChangeCommitted

        cmbeid12.SelectedIndex = cmbevent12.SelectedIndex
    End Sub

    Private Sub cmbevent13_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent13.SelectionChangeCommitted

        cmbeid13.SelectedIndex = cmbevent13.SelectedIndex
    End Sub

    Private Sub cmbevent14_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent14.SelectionChangeCommitted

        cmbeid14.SelectedIndex = cmbevent14.SelectedIndex
    End Sub

    Private Sub cmbevent15_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmbevent15.SelectionChangeCommitted

        cmbeid15.SelectedIndex = cmbevent15.SelectedIndex
    End Sub

    Private Sub cmb_list_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmb_list.SelectionChangeCommitted

        clearEvents()
        loadDate()
    End Sub

    Private Sub cmb_school_year_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmb_school_year.SelectionChangeCommitted

        clearEvents()
        loadDate()
    End Sub

    Private Sub cmb_semester_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles _
        cmb_semester.SelectionChangeCommitted

        clearEvents()
        loadDate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncreate.Click

        If tb_summary_title.Text = "" Then
            MsgBox("Fill summary name for this process", MsgBoxStyle.Exclamation)
        Else
            Dim summary_title As String = WebUtility.HtmlEncode(tb_summary_title.Text)
            Dim list_id As String = returnListID()
            Dim summary_id As String

            If Not isSummaryTitleExist(summary_title) Then
                Connection.conn.Open()
                query = "INSERT INTO tbl_community_labor_summary(summary_title, list_id, event_one, " &
                "event_two, event_three, event_four, event_five, event_six, event_seven, event_eight, " &
                "event_nine, event_ten, event_eleven, event_twelve, event_thirteen, event_fourteen, " &
                "event_fifteen, activate) VALUES('" & summary_title & "','" & list_id & "','" &
                cmbeid1.Text & "','" & cmbeid2.Text & "','" & cmbeid3.Text & "','" & cmbeid4.Text &
                "','" & cmbeid5.Text & "','" & cmbeid6.Text & "','" & cmbeid7.Text & "','" & cmbeid8.Text &
                "','" & cmbeid9.Text & "','" & cmbeid10.Text & "','" & cmbeid11.Text & "','" & cmbeid12.Text &
                "','" & cmbeid13.Text & "','" + cmbeid14.Text & "','" & cmbeid15.Text & "','n'); " &
                "SELECT LAST_INSERT_ID()"
                cmd = New MySqlCommand(query, Connection.conn)
                summary_id = CInt(cmd.ExecuteScalar()).ToString
                Connection.conn.Close()

                MsgBox("New community labor summary Is created successfully!")

                assignEventsToArray(summary_id)
                getEventTitle()
                makeCLQuery(list_id)
                loadCLSummary(summary_id)
            Else
                MsgBox("Could not create summary. Summary title already exist.", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub

    Function isSummaryTitleExist(summary_title)
        Connection.conn.Open()
        query = "SELECT summary_title FROM tbl_community_labor_summary WHERE summary_title = '" & summary_title & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            Connection.conn.Close()
            Return True
        Else
            Connection.conn.Close()
            Return False
        End If
    End Function

    Sub loadCLSummary(summary_id)
        ' Added two more columns for Name and Total.
        Dim number_of_columns = returnNumberOfColumnsUsed(summary_id) + 2

        ' Clear datagridview values before creating new ones.
        frm_display_cl_summary.dgv_cl_summary.ColumnCount = 0
        frm_display_cl_summary.dgv_cl_summary.Rows.Clear()
        frm_display_cl_summary.dgv_cl_summary.Columns.Clear()
        frm_display_cl_summary.dgv_cl_summary.ColumnCount = number_of_columns
        frm_display_cl_summary.dgv_cl_summary.Columns(0).Name = "Name"

        For counter = 1 To (number_of_columns - 2)
            ' Event names are gathered in getEventTitle Function and assigned in their corresponding
            ' column.
            frm_display_cl_summary.dgv_cl_summary.Columns(counter).Name = event_name_array(counter - 1)
        Next

        frm_display_cl_summary.dgv_cl_summary.Columns(number_of_columns - 1).Name = "Total"
        frm_display_cl_summary.dgv_cl_summary.Rows.Clear()

        Connection.conn.Open()
        cmd = New MySqlCommand(summaryquery, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim column_data_array(number_of_columns) As String
            For counter = 0 To number_of_columns - 1
                Dim column_data As String = reader(counter)
                column_data_array(counter) = (column_data)
            Next

            frm_display_cl_summary.dgv_cl_summary.Rows.Add(column_data_array)
        End While
        Connection.conn.Close()

        frm_display_cl_summary.tb_summary_title.Text = tb_summary_title.Text
        frm_display_cl_summary.BringToFront()
        Close()
    End Sub

    Function returnNumberOfColumnsUsed(summary_id)
        Dim number_of_columns As Integer = 0
        Connection.conn.Open()
        query = "SELECT event_one, event_two, event_three, event_four, event_five, event_six, event_seven, " &
            "event_eight, event_nine, event_ten, event_eleven, event_twelve, event_thirteen, event_fourteen, " &
            "event_fifteen FROM tbl_community_labor_summary WHERE summary_entry = '" & summary_id & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            For counter = 0 To 14
                If reader(counter) <> "" Then
                    number_of_columns += 1
                End If
            Next
        End If
        Connection.conn.Close()

        Return number_of_columns
    End Function
End Class