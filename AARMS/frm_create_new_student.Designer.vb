<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_create_new_student
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
        Me.tb_student_Id = New System.Windows.Forms.TextBox()
        Me.tb_student_first_name = New System.Windows.Forms.TextBox()
        Me.tb_student_last_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_create_new_student = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_student_Id
        '
        Me.tb_student_Id.Location = New System.Drawing.Point(37, 45)
        Me.tb_student_Id.Name = "tb_student_Id"
        Me.tb_student_Id.Size = New System.Drawing.Size(307, 20)
        Me.tb_student_Id.TabIndex = 0
        '
        'tb_student_first_name
        '
        Me.tb_student_first_name.Location = New System.Drawing.Point(37, 96)
        Me.tb_student_first_name.Name = "tb_student_first_name"
        Me.tb_student_first_name.Size = New System.Drawing.Size(307, 20)
        Me.tb_student_first_name.TabIndex = 1
        '
        'tb_student_last_name
        '
        Me.tb_student_last_name.Location = New System.Drawing.Point(37, 147)
        Me.tb_student_last_name.Name = "tb_student_last_name"
        Me.tb_student_last_name.Size = New System.Drawing.Size(307, 20)
        Me.tb_student_last_name.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "STUDENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LAST NAME"
        '
        'btn_create_new_student
        '
        Me.btn_create_new_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_create_new_student.FlatAppearance.BorderSize = 0
        Me.btn_create_new_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create_new_student.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_new_student.ForeColor = System.Drawing.Color.White
        Me.btn_create_new_student.Location = New System.Drawing.Point(149, 191)
        Me.btn_create_new_student.Name = "btn_create_new_student"
        Me.btn_create_new_student.Size = New System.Drawing.Size(87, 42)
        Me.btn_create_new_student.TabIndex = 6
        Me.btn_create_new_student.Text = "CREATE"
        Me.btn_create_new_student.UseVisualStyleBackColor = False
        '
        'frm_create_new_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.btn_create_new_student)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_student_last_name)
        Me.Controls.Add(Me.tb_student_first_name)
        Me.Controls.Add(Me.tb_student_Id)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "frm_create_new_student"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_student_Id As TextBox
    Friend WithEvents tb_student_first_name As TextBox
    Friend WithEvents tb_student_last_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_create_new_student As Button
End Class
