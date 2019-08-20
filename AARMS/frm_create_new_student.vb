Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_create_new_student
    Dim cmd As MySqlCommand
    Dim query As String
    Dim reader As MySqlDataReader

    Private Sub frm_create_new_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_create_new_student_Click(sender As Object, e As EventArgs) Handles _
        btn_create_new_student.Click

        Dim student_id As String = WebUtility.HtmlEncode(tb_student_Id.Text)
        Dim first_name As String = WebUtility.HtmlEncode(tb_student_first_name.Text)
        Dim last_name As String = WebUtility.HtmlEncode(tb_student_last_name.Text)

        If student_id <> "" And first_name <> "" And last_name <> "" Then
            Connection.conn.Open()
            query = "INSERT INTO tbl_student(student_id, student_first_name, student_last_name) VALUES('" &
                student_id & "', '" & first_name & "', '" & last_name & "')"
            cmd = New MySqlCommand(query, Connection.conn)
            cmd.ExecuteNonQuery()
            Connection.conn.Close()
        Else
            MsgBox("Fill up the required information.", MsgBoxStyle.Exclamation, "CyberAttendance")
        End If

        frm_display_all_student.loadAllStudent()
        Close()
    End Sub
End Class