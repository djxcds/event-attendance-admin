Imports System.Net
Imports MySql.Data.MySqlClient
Public Class frm_display_student_list
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_create_new_list.ShowDialog()
    End Sub

    Public Sub loadList()
        dgv_student_list.ColumnCount = 2
        dgv_student_list.Columns(0).Name = "list_id"
        dgv_student_list.Columns(0).Visible = False
        dgv_student_list.Columns(1).Name = "List Title"
        dgv_student_list.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT list_id, list_title from tbl_student_list"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim list_id As String = reader.GetString("list_id")
            Dim list_title As String = WebUtility.HtmlDecode(reader.GetString("list_title"))
            Dim row As String() = New String() {list_id, list_title}

            dgv_student_list.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Private Sub frm_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadList()
    End Sub

    Private Sub frm_list_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadList()
    End Sub

    Private Sub dgv_student_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgv_student_list.CellDoubleClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            Dim list_id, list_title As String

            row = dgv_student_list.Rows(e.RowIndex)
            list_id = row.Cells("list_id").Value.ToString
            list_title = row.Cells("List Title").Value.ToString

            frm_list_show_student.lbl_list_title.Text = list_title
            frm_list_show_student.list_id = list_id
            frm_list_show_student.Show()
        End If
    End Sub
End Class