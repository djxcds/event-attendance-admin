Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_display_stored_events
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim event_id As String

    Sub loadEvents()
        dgv_events.ColumnCount = 2
        dgv_events.Columns(0).Name = "event_id"
        dgv_events.Columns(0).Visible = False
        dgv_events.Columns(1).Name = "Event"
        dgv_events.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT event_id, event_title FROM tbl_event"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim event_id As String = reader.GetString("event_id")
            Dim event_title As String = WebUtility.HtmlDecode(reader.GetString("event_title"))
            Dim row As String() = New String() {event_id, event_title}

            dgv_events.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles _
        dgv_events.CellClick

        loadEventDetails(e)
    End Sub

    Sub loadEventDetails(e)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            Dim event_name As String
            row = dgv_events.Rows(e.RowIndex)
            event_name = row.Cells("Event").Value.ToString
            event_id = row.Cells("event_id").Value.ToString

            Connection.conn.Open()
            query = "SELECT event_description FROM tbl_event WHERE event_id = '" & event_id & "'"
            cmd = New MySqlCommand(query, Connection.conn)
            reader = cmd.ExecuteReader()

            If reader.Read Then
                tb_event_title.Text = event_name
                tb_event_description.Text = reader.GetString("event_description")
            End If
            Connection.conn.Close()
        End If
    End Sub

    Private Sub btn_update_event_Click(sender As Object, e As EventArgs) Handles btn_update_event.Click
        If tb_event_title.Text = "" Or tb_event_description.Text = "" Then
            MsgBox("Select an event and fill up required information.14", MsgBoxStyle.Exclamation)
        Else
            Dim event_title As String = WebUtility.HtmlEncode(tb_event_title.Text)
            Dim event_desc As String = WebUtility.HtmlEncode(tb_event_description.Text)

            If Not isEventTitleExist(event_title) And event_id <> "" Then
                Connection.conn.Open()
                query = "Update tbl_event SET event_title = '" & event_title & "', event_description = '" &
                    event_desc & "' WHERE event_id='" + event_id + "'"
                cmd = New MySqlCommand(query, Connection.conn)
                cmd.ExecuteNonQuery()
                Connection.conn.Close()

                MsgBox("Event details updated successfully!", MsgBoxStyle.Information)

                loadEvents()
            ElseIf Not isEventTitleExist(event_title) And event_id = "" Then
                MsgBox("Could not update event details. Select an event and fill up required information.", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Could not update event details. Event title already exist.", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub

    Function isEventTitleExist(event_title)
        Connection.conn.Open()
        query = "SELECT event_title FROM tbl_event WHERE event_title = '" & event_title & "'"
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

    Private Sub frm_display_stored_events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEvents()
    End Sub

    Private Sub btn_create_new_event_Click(sender As Object, e As EventArgs) Handles btn_create_new_event.Click
        frm_create_new_event.tb_event_title.Text = ""
        frm_create_new_event.tb_event_description.Text = ""
        frm_create_new_event.ShowDialog()
    End Sub

    Private Sub frm_display_stored_events_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        loadEvents()
    End Sub
End Class