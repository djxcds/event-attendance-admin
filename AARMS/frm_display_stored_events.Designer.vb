<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_display_stored_events
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_events = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_event_description = New System.Windows.Forms.TextBox()
        Me.btn_update_event = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_event_title = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_create_new_event = New System.Windows.Forms.Button()
        CType(Me.dgv_events, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_events
        '
        Me.dgv_events.AllowUserToAddRows = False
        Me.dgv_events.AllowUserToDeleteRows = False
        Me.dgv_events.AllowUserToResizeColumns = False
        Me.dgv_events.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_events.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_events.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgv_events.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_events.Location = New System.Drawing.Point(30, 60)
        Me.dgv_events.MultiSelect = False
        Me.dgv_events.Name = "dgv_events"
        Me.dgv_events.ReadOnly = True
        Me.dgv_events.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_events.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_events.Size = New System.Drawing.Size(408, 420)
        Me.dgv_events.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(473, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 12)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Maximum input is 100 characters"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(473, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 12)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Maximum input is 250 characters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(517, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "DESCRIPTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(470, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "EVENT"
        '
        'tb_event_description
        '
        Me.tb_event_description.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tb_event_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_event_description.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_event_description.Location = New System.Drawing.Point(472, 331)
        Me.tb_event_description.MaxLength = 250
        Me.tb_event_description.Multiline = True
        Me.tb_event_description.Name = "tb_event_description"
        Me.tb_event_description.Size = New System.Drawing.Size(287, 53)
        Me.tb_event_description.TabIndex = 3
        '
        'btn_update_event
        '
        Me.btn_update_event.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_update_event.FlatAppearance.BorderSize = 0
        Me.btn_update_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update_event.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_event.ForeColor = System.Drawing.Color.White
        Me.btn_update_event.Location = New System.Drawing.Point(556, 425)
        Me.btn_update_event.Name = "btn_update_event"
        Me.btn_update_event.Size = New System.Drawing.Size(115, 46)
        Me.btn_update_event.TabIndex = 5
        Me.btn_update_event.Text = "UPDATE"
        Me.btn_update_event.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(470, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "EVENT NAME"
        '
        'tb_event_title
        '
        Me.tb_event_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tb_event_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_event_title.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_event_title.Location = New System.Drawing.Point(472, 258)
        Me.tb_event_title.MaxLength = 100
        Me.tb_event_title.Name = "tb_event_title"
        Me.tb_event_title.Size = New System.Drawing.Size(287, 22)
        Me.tb_event_title.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(329, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 12)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Select An Event to Edit"
        '
        'btn_create_new_event
        '
        Me.btn_create_new_event.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_create_new_event.FlatAppearance.BorderSize = 0
        Me.btn_create_new_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create_new_event.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_new_event.ForeColor = System.Drawing.Color.White
        Me.btn_create_new_event.Location = New System.Drawing.Point(556, 101)
        Me.btn_create_new_event.Name = "btn_create_new_event"
        Me.btn_create_new_event.Size = New System.Drawing.Size(115, 46)
        Me.btn_create_new_event.TabIndex = 57
        Me.btn_create_new_event.Text = "CREATE NEW EVENT"
        Me.btn_create_new_event.UseVisualStyleBackColor = False
        '
        'frm_display_stored_events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btn_create_new_event)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_event_description)
        Me.Controls.Add(Me.btn_update_event)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_event_title)
        Me.Controls.Add(Me.dgv_events)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_display_stored_events"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Events"
        CType(Me.dgv_events, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_events As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_event_description As System.Windows.Forms.TextBox
    Friend WithEvents btn_update_event As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_event_title As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_create_new_event As Button
End Class
