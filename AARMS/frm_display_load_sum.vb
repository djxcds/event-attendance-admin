Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_display_load_sum
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim row As DataGridViewRow
    Dim summary_name, summaryquery, summaryquerytotal As String
    Dim event_id_array(15) As String
    Dim event_name_array(15) As String

    Sub loadSavedCLSummaries()
        dgv_cl_summaries.ColumnCount = 3
        dgv_cl_summaries.Columns(0).Name = "summary_entry"
        dgv_cl_summaries.Columns(0).Visible = False
        dgv_cl_summaries.Columns(1).Name = "CL Summary"
        dgv_cl_summaries.Columns(2).Name = "list_id"
        dgv_cl_summaries.Columns(2).Visible = False
        dgv_cl_summaries.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT summary_entry, summary_title, list_id FROM tbl_community_labor_summary"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim summary_entry As String = reader.GetString("summary_entry")
            Dim summary_title As String = WebUtility.HtmlDecode(reader.GetString("summary_title"))
            Dim list_id As String = reader.GetString("list_id")

            Dim row As String() = New String() {summary_entry, summary_title, list_id}
            dgv_cl_summaries.Rows.Add(row)
        End While
        Connection.conn.Close()
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

    Private Sub frmloadsummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSavedCLSummaries()
    End Sub

    Private Sub dgv_cl_summaries_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles _
        dgv_cl_summaries.CellDoubleClick

        If e.RowIndex >= 0 Then
            row = dgv_cl_summaries.Rows(e.RowIndex)

            Dim rowValue As DataGridViewRow = dgv_cl_summaries.Rows(e.RowIndex)
            Dim summary_id As String = rowValue.Cells("summary_entry").Value.ToString
            Dim list_id As String = rowValue.Cells("list_id").Value.ToString
            Dim summary_title As String = rowValue.Cells("CL Summary").Value.ToString

            assignEventsToArray(summary_id)
            getEventTitle()
            makeCLQuery(list_id)
            loadCLSummary(summary_id, summary_title)

        End If
    End Sub

    Sub loadCLSummary(summary_id, summary_title)
        ' Added two more columns for Name and Total.
        Dim number_of_columns = returnNumberOfColumnsUsed(summary_id) + 2

        frm_display_cl_summary.dgv_cl_summary.ColumnCount = 0
        frm_display_cl_summary.dgv_cl_summary.Rows.Clear()
        frm_display_cl_summary.dgv_cl_summary.Columns.Clear()
        frm_display_cl_summary.dgv_cl_summary.ColumnCount = number_of_columns
        frm_display_cl_summary.dgv_cl_summary.Columns(0).Name = "Name"

        For counter = 1 To (number_of_columns - 2)
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

        frm_display_cl_summary.tb_summary_title.Text = summary_title
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