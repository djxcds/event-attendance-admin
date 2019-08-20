Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_list_show_student
    Public list_id As String
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Public Sub loadStudent()
        dgv_student.ColumnCount = 3
        dgv_student.Columns(0).Name = "student_entry"
        dgv_student.Columns(0).Visible = False
        dgv_student.Columns(1).Name = "Student ID"
        dgv_student.Columns(1).Width = 80
        dgv_student.Columns(2).Name = "Name"
        dgv_student.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT b.student_entry, b.student_id, CONCAT(b.student_first_name, ' '," &
            "b.student_last_name) AS name from tbl_student_assigned_to_list a, tbl_student b, " &
            "tbl_student_list c where b.student_entry = a.student_entry_id And " &
            "c.list_id = a.list_id And a.list_id = '" & list_id & "' "
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim row As String() = New String() {reader.GetString("student_entry"),
                reader.GetString("student_id"), WebUtility.HtmlDecode(reader.GetString("name"))}
            dgv_student.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Private Sub frm_list_show_student_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadStudent()
    End Sub

    Private Sub btn_add_student_Click(sender As Object, e As EventArgs) Handles btn_add_student.Click
        frm_display_all_student.list_id = list_id
        frm_display_all_student.TopMost = True
        frm_display_all_student.ShowDialog()
    End Sub
End Class