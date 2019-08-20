<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_list_show_student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgv_student = New System.Windows.Forms.DataGridView()
        Me.btn_add_student = New System.Windows.Forms.Button()
        Me.lbl_list_title = New System.Windows.Forms.Label()
        CType(Me.dgv_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_student
        '
        Me.dgv_student.AllowUserToAddRows = False
        Me.dgv_student.AllowUserToDeleteRows = False
        Me.dgv_student.AllowUserToResizeColumns = False
        Me.dgv_student.AllowUserToResizeRows = False
        Me.dgv_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_student.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_student.Location = New System.Drawing.Point(26, 71)
        Me.dgv_student.Name = "dgv_student"
        Me.dgv_student.ReadOnly = True
        Me.dgv_student.RowHeadersVisible = False
        Me.dgv_student.Size = New System.Drawing.Size(358, 342)
        Me.dgv_student.TabIndex = 0
        '
        'btn_add_student
        '
        Me.btn_add_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_add_student.FlatAppearance.BorderSize = 0
        Me.btn_add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_student.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_student.ForeColor = System.Drawing.Color.White
        Me.btn_add_student.Location = New System.Drawing.Point(416, 71)
        Me.btn_add_student.Name = "btn_add_student"
        Me.btn_add_student.Size = New System.Drawing.Size(119, 43)
        Me.btn_add_student.TabIndex = 1
        Me.btn_add_student.Text = "Add Student"
        Me.btn_add_student.UseVisualStyleBackColor = False
        '
        'lbl_list_title
        '
        Me.lbl_list_title.AutoSize = True
        Me.lbl_list_title.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_list_title.ForeColor = System.Drawing.Color.White
        Me.lbl_list_title.Location = New System.Drawing.Point(23, 31)
        Me.lbl_list_title.Name = "lbl_list_title"
        Me.lbl_list_title.Size = New System.Drawing.Size(72, 17)
        Me.lbl_list_title.TabIndex = 2
        Me.lbl_list_title.Text = "LIST TITLE"
        '
        'frm_list_show_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(559, 438)
        Me.Controls.Add(Me.lbl_list_title)
        Me.Controls.Add(Me.btn_add_student)
        Me.Controls.Add(Me.dgv_student)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(575, 477)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(575, 477)
        Me.Name = "frm_list_show_student"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students under the list"
        CType(Me.dgv_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_student As DataGridView
    Friend WithEvents btn_add_student As Button
    Friend WithEvents lbl_list_title As Label
End Class
