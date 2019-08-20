<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_review
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
        Me.dgv_review = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_review, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_review
        '
        Me.dgv_review.AllowUserToAddRows = False
        Me.dgv_review.AllowUserToDeleteRows = False
        Me.dgv_review.AllowUserToResizeColumns = False
        Me.dgv_review.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_review.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_review.Location = New System.Drawing.Point(38, 45)
        Me.dgv_review.Name = "dgv_review"
        Me.dgv_review.ReadOnly = True
        Me.dgv_review.RowHeadersVisible = False
        Me.dgv_review.Size = New System.Drawing.Size(859, 406)
        Me.dgv_review.TabIndex = 0
        '
        'frm_display_review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(944, 481)
        Me.Controls.Add(Me.dgv_review)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(960, 520)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(960, 520)
        Me.Name = "frm_display_review"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review"
        CType(Me.dgv_review, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_review As DataGridView
End Class
