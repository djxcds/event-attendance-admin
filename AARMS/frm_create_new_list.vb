Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_create_new_list
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub btn_add_list_Click(sender As Object, e As EventArgs) Handles btn_add_list.Click
        If tb_list_title.Text = "" Then
            MsgBox("Fill up missing information", MsgBoxStyle.Exclamation)
        Else
            Dim list_title As String = WebUtility.HtmlEncode(tb_list_title.Text)
            Dim list_Id As String

            If Not isListTitleExist(list_title) Then
                Connection.conn.Open()
                query = "INSERT INTO tbl_student_list(list_title) VALUES('" + list_title + "'); SELECT LAST_INSERT_ID()"
                cmd = New MySqlCommand(query, Connection.conn)
                list_Id = CInt(cmd.ExecuteScalar())
                Connection.conn.Close()

                Close()
                frm_list_show_student.list_id = list_Id
                frm_list_show_student.Show()
                frm_list_show_student.TopMost = True
            Else
                MsgBox("Could not create list. List title already existed.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Function isListTitleExist(list_title)
        Connection.conn.Open()
        query = "SELECT list_title FROM tbl_student_list WHERE list_title = '" & list_title & "'"
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

End Class