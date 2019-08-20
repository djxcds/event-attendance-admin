<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_student_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_student_list = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_student_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_student_list
        '
        Me.dgv_student_list.AllowUserToAddRows = False
        Me.dgv_student_list.AllowUserToDeleteRows = False
        Me.dgv_student_list.AllowUserToResizeColumns = False
        Me.dgv_student_list.AllowUserToResizeRows = False
        Me.dgv_student_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_student_list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_student_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_student_list.Location = New System.Drawing.Point(26, 24)
        Me.dgv_student_list.MultiSelect = False
        Me.dgv_student_list.Name = "dgv_student_list"
        Me.dgv_student_list.ReadOnly = True
        Me.dgv_student_list.RowHeadersVisible = False
        Me.dgv_student_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_student_list.Size = New System.Drawing.Size(261, 339)
        Me.dgv_student_list.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(325, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add New List"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_display_student_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 381)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_student_list)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 420)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 420)
        Me.Name = "frm_display_student_list"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student List"
        CType(Me.dgv_student_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_student_list As DataGridView
    Friend WithEvents Button1 As Button
End Class
