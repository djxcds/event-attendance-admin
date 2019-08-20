<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_display_all_student
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
        Me.dgv_show_all_student = New System.Windows.Forms.DataGridView()
        Me.btn_create_new_student = New System.Windows.Forms.Button()
        Me.tb_search_student = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add_selected_id = New System.Windows.Forms.Button()
        CType(Me.dgv_show_all_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_show_all_student
        '
        Me.dgv_show_all_student.AllowUserToAddRows = False
        Me.dgv_show_all_student.AllowUserToDeleteRows = False
        Me.dgv_show_all_student.AllowUserToResizeColumns = False
        Me.dgv_show_all_student.AllowUserToResizeRows = False
        Me.dgv_show_all_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_show_all_student.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_show_all_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_show_all_student.Location = New System.Drawing.Point(24, 63)
        Me.dgv_show_all_student.Name = "dgv_show_all_student"
        Me.dgv_show_all_student.ReadOnly = True
        Me.dgv_show_all_student.RowHeadersVisible = False
        Me.dgv_show_all_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_show_all_student.Size = New System.Drawing.Size(466, 296)
        Me.dgv_show_all_student.TabIndex = 0
        '
        'btn_create_new_student
        '
        Me.btn_create_new_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_create_new_student.FlatAppearance.BorderSize = 0
        Me.btn_create_new_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create_new_student.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_new_student.ForeColor = System.Drawing.Color.White
        Me.btn_create_new_student.Location = New System.Drawing.Point(512, 63)
        Me.btn_create_new_student.Name = "btn_create_new_student"
        Me.btn_create_new_student.Size = New System.Drawing.Size(102, 46)
        Me.btn_create_new_student.TabIndex = 1
        Me.btn_create_new_student.Text = "Create New Student"
        Me.btn_create_new_student.UseVisualStyleBackColor = False
        '
        'tb_search_student
        '
        Me.tb_search_student.Location = New System.Drawing.Point(222, 28)
        Me.tb_search_student.Name = "tb_search_student"
        Me.tb_search_student.Size = New System.Drawing.Size(268, 20)
        Me.tb_search_student.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(152, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SEARCH"
        '
        'btn_add_selected_id
        '
        Me.btn_add_selected_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_add_selected_id.FlatAppearance.BorderSize = 0
        Me.btn_add_selected_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_selected_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_selected_id.ForeColor = System.Drawing.Color.White
        Me.btn_add_selected_id.Location = New System.Drawing.Point(512, 235)
        Me.btn_add_selected_id.Name = "btn_add_selected_id"
        Me.btn_add_selected_id.Size = New System.Drawing.Size(102, 52)
        Me.btn_add_selected_id.TabIndex = 4
        Me.btn_add_selected_id.Text = "Add Selected Student"
        Me.btn_add_selected_id.UseVisualStyleBackColor = False
        '
        'frm_show_all_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 381)
        Me.Controls.Add(Me.btn_add_selected_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_search_student)
        Me.Controls.Add(Me.btn_create_new_student)
        Me.Controls.Add(Me.dgv_show_all_student)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 420)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 420)
        Me.Name = "frm_show_all_student"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Records"
        CType(Me.dgv_show_all_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_show_all_student As DataGridView
    Friend WithEvents btn_create_new_student As Button
    Friend WithEvents tb_search_student As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add_selected_id As Button
End Class
