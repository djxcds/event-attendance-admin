Public Class frm_display_cl_summary

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_create_cl_summary.tb_summary_title.Text = ""
        frm_create_cl_summary.clearEvents()
        frm_create_cl_summary.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_display_load_sum.ShowDialog()
    End Sub

End Class