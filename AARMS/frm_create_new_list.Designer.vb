<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_create_new_list
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_list_title = New System.Windows.Forms.TextBox()
        Me.btn_add_list = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LIST TITLE"
        '
        'tb_list_title
        '
        Me.tb_list_title.Location = New System.Drawing.Point(20, 41)
        Me.tb_list_title.Name = "tb_list_title"
        Me.tb_list_title.Size = New System.Drawing.Size(306, 20)
        Me.tb_list_title.TabIndex = 1
        '
        'btn_add_list
        '
        Me.btn_add_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_add_list.FlatAppearance.BorderSize = 0
        Me.btn_add_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_list.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_list.ForeColor = System.Drawing.Color.White
        Me.btn_add_list.Location = New System.Drawing.Point(131, 85)
        Me.btn_add_list.Name = "btn_add_list"
        Me.btn_add_list.Size = New System.Drawing.Size(85, 35)
        Me.btn_add_list.TabIndex = 2
        Me.btn_add_list.Text = "ADD"
        Me.btn_add_list.UseVisualStyleBackColor = False
        '
        'frm_create_new_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 141)
        Me.Controls.Add(Me.btn_add_list)
        Me.Controls.Add(Me.tb_list_title)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 180)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 180)
        Me.Name = "frm_create_new_list"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_list_title As TextBox
    Friend WithEvents btn_add_list As Button
End Class
