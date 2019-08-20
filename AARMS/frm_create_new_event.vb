Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_create_new_event
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub btn_create_event_Click(sender As Object, e As EventArgs) Handles btn_create_event.Click
        If tb_event_title.Text = "" Or tb_event_description.Text = "" Then
            MsgBox("Fill up required information", MsgBoxStyle.Exclamation)
        Else
            Dim event_title As String = WebUtility.HtmlEncode(tb_event_title.Text)
            Dim event_desc As String = WebUtility.HtmlEncode(tb_event_description.Text)

            If Not isEventTitleExist(event_title) Then
                Connection.conn.Open()
                query = "INSERT INTO tbl_event(event_title, event_description) VALUES('" & event_title &
                "','" & event_desc & "')"
                cmd = New MySqlCommand(query, Connection.conn)
                cmd.ExecuteNonQuery()
                Connection.conn.Close()

                MsgBox("Event created successfully!", MsgBoxStyle.Information)

                tb_event_title.Text = ""
                tb_event_description.Text = ""
                Close()
            Else
                MsgBox("Could not create event. Event title already exist.", MsgBoxStyle.Exclamation)
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

End Class