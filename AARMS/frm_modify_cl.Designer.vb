<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modify_cl
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
        Me.tbfull = New System.Windows.Forms.TextBox()
        Me.tbhalf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnreview = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbfull
        '
        Me.tbfull.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbfull.Location = New System.Drawing.Point(140, 27)
        Me.tbfull.MaxLength = 2
        Me.tbfull.Name = "tbfull"
        Me.tbfull.Size = New System.Drawing.Size(76, 22)
        Me.tbfull.TabIndex = 1
        Me.tbfull.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbhalf
        '
        Me.tbhalf.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbhalf.Location = New System.Drawing.Point(140, 60)
        Me.tbhalf.MaxLength = 2
        Me.tbhalf.Name = "tbhalf"
        Me.tbhalf.Size = New System.Drawing.Size(76, 22)
        Me.tbhalf.TabIndex = 2
        Me.tbhalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "HALF PENALTY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FULL PENALTY"
        '
        'btnreview
        '
        Me.btnreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnreview.FlatAppearance.BorderSize = 0
        Me.btnreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreview.ForeColor = System.Drawing.Color.White
        Me.btnreview.Location = New System.Drawing.Point(103, 101)
        Me.btnreview.Name = "btnreview"
        Me.btnreview.Size = New System.Drawing.Size(73, 31)
        Me.btnreview.TabIndex = 3
        Me.btnreview.Text = "SAVE"
        Me.btnreview.UseVisualStyleBackColor = False
        '
        'frm_modify_cl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 147)
        Me.Controls.Add(Me.btnreview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbhalf)
        Me.Controls.Add(Me.tbfull)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 186)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 186)
        Me.Name = "frm_modify_cl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify CL Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbfull As TextBox
    Friend WithEvents tbhalf As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnreview As Button
End Class
