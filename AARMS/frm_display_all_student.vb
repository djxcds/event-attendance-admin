
Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_display_all_student
    Public list_id As String
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub btn_create_new_student_Click(sender As Object, e As EventArgs) Handles btn_create_new_student.Click
        frm_create_new_student.tb_student_Id.Text = ""
        frm_create_new_student.tb_student_first_name.Text = ""
        frm_create_new_student.tb_student_last_name.Text = ""
        frm_create_new_student.TopMost = True
        frm_create_new_student.ShowDialog()
    End Sub

    Sub loadAllStudent()
        dgv_show_all_student.ColumnCount = 3
        dgv_show_all_student.Columns(0).Name = "student_entry"
        dgv_show_all_student.Columns(0).Visible = False
        dgv_show_all_student.Columns(1).Name = "Student ID"
        dgv_show_all_student.Columns(1).Width = 80
        dgv_show_all_student.Columns(2).Name = "Name"
        dgv_show_all_student.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT student_entry, student_id, CONCAT(student_first_name, ' ', student_last_name)" &
            "as Name from tbl_student"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim row As String() = New String() {reader.GetString("student_entry"),
                reader.GetString("student_id"), WebUtility.HtmlDecode(reader.GetString("name"))}
            dgv_show_all_student.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Sub loadAllStudentModified(user_query)
        dgv_show_all_student.ColumnCount = 3
        dgv_show_all_student.Columns(0).Name = "student_entry"
        dgv_show_all_student.Columns(0).Visible = False
        dgv_show_all_student.Columns(1).Name = "Student ID"
        dgv_show_all_student.Columns(1).Width = 80
        dgv_show_all_student.Columns(2).Name = "Name"
        dgv_show_all_student.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT student_entry, student_id, CONCAT(student_first_name, ' ', student_last_name)" &
            "as Name from tbl_student WHERE (student_first_name LIKE '" & user_query & "%' OR " &
            "student_last_name LIKE '" & user_query & "%' OR student_id LIKE '" & user_query &
            "%')"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim row As String() = New String() {reader.GetString("student_entry"),
                reader.GetString("student_id"), WebUtility.HtmlDecode(reader.GetString("name"))}
            dgv_show_all_student.Rows.Add(row)
        End While
        Connection.conn.Close()
    End Sub

    Private Sub frm_show_all_student_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadAllStudent()
    End Sub

    Private Sub dgv_show_all_student_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgv_show_all_student.CellDoubleClick

    End Sub

    Private Sub btn_add_selected_id_Click(sender As Object, e As EventArgs) Handles btn_add_selected_id.Click
        Dim student_entry_id As String
        Dim sResult As String = ""

        For Each selectedItem As DataGridViewRow In dgv_show_all_student.SelectedRows
            ' Show ids of multiple selected rows.
            student_entry_id = selectedItem.Cells("student_entry").Value

            If Not isStudentExistInList(student_entry_id, list_id) Then
                Connection.conn.Open()
                query = "INSERT INTO tbl_student_assigned_to_list(student_entry_id, list_id) VALUES('" &
                    student_entry_id & "', '" & list_id & "')"
                cmd = New MySqlCommand(query, Connection.conn)
                cmd.ExecuteNonQuery()
                Connection.conn.Close()
            End If

        Next selectedItem

        frm_list_show_student.loadStudent()
        Close()
    End Sub

    Function isStudentExistInList(student_id, list_id)
        Connection.conn.Open()
        query = "SELECT COUNT(student_entry_id) as number_of_row FROM tbl_student_assigned_to_list " &
            "WHERE student_entry_id = '" & student_id & "' AND list_id = '" & list_id & "'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader

        If reader.Read Then
            If reader.GetInt16("number_of_row") = 0 Then
                reader.Close()
                Connection.conn.Close()
                Return False
            Else
                reader.Close()
                Connection.conn.Close()
                Return True
            End If
        Else
            reader.Close()
            Connection.conn.Close()
            Return False
        End If

    End Function

    Private Sub tb_search_student_TextChanged(sender As Object, e As EventArgs) Handles tb_search_student.TextChanged
        Dim user_query As String = WebUtility.HtmlEncode(tb_search_student.Text)

        If user_query <> "" Then
            loadAllStudentModified(user_query)
        Else
            loadAllStudent()
        End If

    End Sub
End Class