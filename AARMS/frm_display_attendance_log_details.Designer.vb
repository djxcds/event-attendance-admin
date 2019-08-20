<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_display_attendance_log_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_attendance_log_details))
        Me.dgv_attendance_details = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlmenu = New System.Windows.Forms.Panel()
        Me.btn_modify_cl = New System.Windows.Forms.Button()
        Me.btn_open_cl_summary = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbdescription = New System.Windows.Forms.TextBox()
        Me.lbloverall = New System.Windows.Forms.TextBox()
        Me.lable = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_view_review = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblmessage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.TextBox()
        Me.lblfive = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblfour = New System.Windows.Forms.Label()
        Me.starrating = New Bunifu.Framework.UI.BunifuRating()
        Me.lblthree = New System.Windows.Forms.Label()
        Me.lblzero = New System.Windows.Forms.Label()
        Me.lbltwo = New System.Windows.Forms.Label()
        Me.lblone = New System.Windows.Forms.Label()
        Me.lbl_event_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_student_list = New System.Windows.Forms.TextBox()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbtitle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgv_attendance_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlmenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_attendance_details
        '
        Me.dgv_attendance_details.AllowUserToAddRows = False
        Me.dgv_attendance_details.AllowUserToDeleteRows = False
        Me.dgv_attendance_details.AllowUserToResizeColumns = False
        Me.dgv_attendance_details.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_attendance_details.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_attendance_details.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_attendance_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_attendance_details.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.dgv_attendance_details.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_attendance_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_attendance_details.Location = New System.Drawing.Point(34, 127)
        Me.dgv_attendance_details.MultiSelect = False
        Me.dgv_attendance_details.Name = "dgv_attendance_details"
        Me.dgv_attendance_details.ReadOnly = True
        Me.dgv_attendance_details.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_attendance_details.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_attendance_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_attendance_details.Size = New System.Drawing.Size(629, 395)
        Me.dgv_attendance_details.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlmenu)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lbl_event_id)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tb_search)
        Me.Panel1.Controls.Add(Me.dgv_attendance_details)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 561)
        Me.Panel1.TabIndex = 1
        '
        'pnlmenu
        '
        Me.pnlmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlmenu.BackColor = System.Drawing.Color.Gray
        Me.pnlmenu.Controls.Add(Me.btn_modify_cl)
        Me.pnlmenu.Controls.Add(Me.btn_open_cl_summary)
        Me.pnlmenu.Location = New System.Drawing.Point(869, 70)
        Me.pnlmenu.Name = "pnlmenu"
        Me.pnlmenu.Size = New System.Drawing.Size(117, 63)
        Me.pnlmenu.TabIndex = 55
        Me.pnlmenu.Visible = False
        '
        'btn_modify_cl
        '
        Me.btn_modify_cl.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_modify_cl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modify_cl.FlatAppearance.BorderSize = 0
        Me.btn_modify_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modify_cl.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify_cl.ForeColor = System.Drawing.Color.White
        Me.btn_modify_cl.Location = New System.Drawing.Point(0, 31)
        Me.btn_modify_cl.Name = "btn_modify_cl"
        Me.btn_modify_cl.Size = New System.Drawing.Size(117, 31)
        Me.btn_modify_cl.TabIndex = 6
        Me.btn_modify_cl.Text = "Modify CL Setting"
        Me.btn_modify_cl.UseVisualStyleBackColor = False
        '
        'btn_open_cl_summary
        '
        Me.btn_open_cl_summary.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_open_cl_summary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_open_cl_summary.FlatAppearance.BorderSize = 0
        Me.btn_open_cl_summary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_open_cl_summary.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_open_cl_summary.ForeColor = System.Drawing.Color.White
        Me.btn_open_cl_summary.Location = New System.Drawing.Point(0, 1)
        Me.btn_open_cl_summary.Name = "btn_open_cl_summary"
        Me.btn_open_cl_summary.Size = New System.Drawing.Size(117, 31)
        Me.btn_open_cl_summary.TabIndex = 5
        Me.btn_open_cl_summary.Text = "Open Summary Form"
        Me.btn_open_cl_summary.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.tbdescription)
        Me.Panel3.Controls.Add(Me.lbloverall)
        Me.Panel3.Controls.Add(Me.lable)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btn_view_review)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblmessage)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lbltotal)
        Me.Panel3.Controls.Add(Me.lblfive)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.lblfour)
        Me.Panel3.Controls.Add(Me.starrating)
        Me.Panel3.Controls.Add(Me.lblthree)
        Me.Panel3.Controls.Add(Me.lblzero)
        Me.Panel3.Controls.Add(Me.lbltwo)
        Me.Panel3.Controls.Add(Me.lblone)
        Me.Panel3.Location = New System.Drawing.Point(682, 127)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(303, 302)
        Me.Panel3.TabIndex = 57
        '
        'tbdescription
        '
        Me.tbdescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tbdescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbdescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdescription.ForeColor = System.Drawing.Color.White
        Me.tbdescription.Location = New System.Drawing.Point(54, 182)
        Me.tbdescription.Name = "tbdescription"
        Me.tbdescription.ReadOnly = True
        Me.tbdescription.Size = New System.Drawing.Size(200, 15)
        Me.tbdescription.TabIndex = 55
        Me.tbdescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbloverall
        '
        Me.lbloverall.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lbloverall.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbloverall.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloverall.ForeColor = System.Drawing.Color.White
        Me.lbloverall.Location = New System.Drawing.Point(37, 26)
        Me.lbloverall.Name = "lbloverall"
        Me.lbloverall.Size = New System.Drawing.Size(91, 86)
        Me.lbloverall.TabIndex = 51
        Me.lbloverall.Text = "0"
        Me.lbloverall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable.ForeColor = System.Drawing.Color.White
        Me.lable.Location = New System.Drawing.Point(167, 48)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(41, 13)
        Me.lable.TabIndex = 21
        Me.lable.Text = "5 Stars"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(167, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "4 Stars"
        '
        'btn_view_review
        '
        Me.btn_view_review.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btn_view_review.Enabled = False
        Me.btn_view_review.FlatAppearance.BorderSize = 0
        Me.btn_view_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_view_review.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view_review.ForeColor = System.Drawing.Color.White
        Me.btn_view_review.Location = New System.Drawing.Point(100, 261)
        Me.btn_view_review.Name = "btn_view_review"
        Me.btn_view_review.Size = New System.Drawing.Size(116, 31)
        Me.btn_view_review.TabIndex = 54
        Me.btn_view_review.Text = "View Reviews"
        Me.btn_view_review.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(167, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "3 Stars"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(167, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "2 Stars"
        '
        'lblmessage
        '
        Me.lblmessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblmessage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.Red
        Me.lblmessage.Location = New System.Drawing.Point(21, 8)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.ReadOnly = True
        Me.lblmessage.Size = New System.Drawing.Size(268, 18)
        Me.lblmessage.TabIndex = 52
        Me.lblmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(167, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "1 Star"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(51, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Number of Students that didn't Rate"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(21, 144)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(69, 22)
        Me.lbltotal.TabIndex = 50
        Me.lbltotal.Text = "0"
        Me.lbltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblfive
        '
        Me.lblfive.AutoSize = True
        Me.lblfive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfive.ForeColor = System.Drawing.Color.White
        Me.lblfive.Location = New System.Drawing.Point(276, 48)
        Me.lblfive.Name = "lblfive"
        Me.lblfive.Size = New System.Drawing.Size(13, 13)
        Me.lblfive.TabIndex = 39
        Me.lblfive.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(97, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 17)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = " "
        '
        'lblfour
        '
        Me.lblfour.AutoSize = True
        Me.lblfour.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfour.ForeColor = System.Drawing.Color.White
        Me.lblfour.Location = New System.Drawing.Point(276, 72)
        Me.lblfour.Name = "lblfour"
        Me.lblfour.Size = New System.Drawing.Size(13, 13)
        Me.lblfour.TabIndex = 40
        Me.lblfour.Text = "0"
        '
        'starrating
        '
        Me.starrating.BackColor = System.Drawing.Color.Transparent
        Me.starrating.Enabled = False
        Me.starrating.ForeColor = System.Drawing.Color.Gold
        Me.starrating.Location = New System.Drawing.Point(21, 117)
        Me.starrating.Name = "starrating"
        Me.starrating.Size = New System.Drawing.Size(120, 20)
        Me.starrating.TabIndex = 46
        Me.starrating.Value = 0
        '
        'lblthree
        '
        Me.lblthree.AutoSize = True
        Me.lblthree.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthree.ForeColor = System.Drawing.Color.White
        Me.lblthree.Location = New System.Drawing.Point(276, 97)
        Me.lblthree.Name = "lblthree"
        Me.lblthree.Size = New System.Drawing.Size(13, 13)
        Me.lblthree.TabIndex = 41
        Me.lblthree.Text = "0"
        '
        'lblzero
        '
        Me.lblzero.AutoSize = True
        Me.lblzero.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblzero.ForeColor = System.Drawing.Color.White
        Me.lblzero.Location = New System.Drawing.Point(263, 227)
        Me.lblzero.Name = "lblzero"
        Me.lblzero.Size = New System.Drawing.Size(15, 17)
        Me.lblzero.TabIndex = 44
        Me.lblzero.Text = "0"
        '
        'lbltwo
        '
        Me.lbltwo.AutoSize = True
        Me.lbltwo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltwo.ForeColor = System.Drawing.Color.White
        Me.lbltwo.Location = New System.Drawing.Point(276, 124)
        Me.lbltwo.Name = "lbltwo"
        Me.lbltwo.Size = New System.Drawing.Size(13, 13)
        Me.lbltwo.TabIndex = 42
        Me.lbltwo.Text = "0"
        '
        'lblone
        '
        Me.lblone.AutoSize = True
        Me.lblone.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblone.ForeColor = System.Drawing.Color.White
        Me.lblone.Location = New System.Drawing.Point(276, 148)
        Me.lblone.Name = "lblone"
        Me.lblone.Size = New System.Drawing.Size(13, 13)
        Me.lblone.TabIndex = 43
        Me.lblone.Text = "0"
        '
        'lbl_event_id
        '
        Me.lbl_event_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_event_id.AutoSize = True
        Me.lbl_event_id.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_event_id.ForeColor = System.Drawing.Color.White
        Me.lbl_event_id.Location = New System.Drawing.Point(828, 520)
        Me.lbl_event_id.Name = "lbl_event_id"
        Me.lbl_event_id.Size = New System.Drawing.Size(46, 13)
        Me.lbl_event_id.TabIndex = 53
        Me.lbl_event_id.Text = "eventid"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(393, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 12)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "SEARCH"
        '
        'tb_search
        '
        Me.tb_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_search.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.Location = New System.Drawing.Point(444, 95)
        Me.tb_search.MaxLength = 20
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(221, 22)
        Me.tb_search.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.tb_student_list)
        Me.Panel2.Controls.Add(Me.btnmenu)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.tbtitle)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 78)
        Me.Panel2.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(369, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 12)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "SELECTED LIST"
        '
        'tb_student_list
        '
        Me.tb_student_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.tb_student_list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_student_list.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_student_list.ForeColor = System.Drawing.Color.White
        Me.tb_student_list.Location = New System.Drawing.Point(371, 37)
        Me.tb_student_list.Name = "tb_student_list"
        Me.tb_student_list.ReadOnly = True
        Me.tb_student_list.Size = New System.Drawing.Size(373, 22)
        Me.tb_student_list.TabIndex = 60
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenu.FlatAppearance.BorderSize = 0
        Me.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmenu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.Location = New System.Drawing.Point(939, 18)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(46, 43)
        Me.btnmenu.TabIndex = 23
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(32, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 12)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "EVENT SELECTED"
        '
        'tbtitle
        '
        Me.tbtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.tbtitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtitle.ForeColor = System.Drawing.Color.White
        Me.tbtitle.Location = New System.Drawing.Point(34, 37)
        Me.tbtitle.Name = "tbtitle"
        Me.tbtitle.ReadOnly = True
        Me.tbtitle.Size = New System.Drawing.Size(320, 22)
        Me.tbtitle.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(780, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 12)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "EVENT PERFORMANCE"
        '
        'frm_display_attendance_log_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "frm_display_attendance_log_details"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Logs"
        CType(Me.dgv_attendance_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlmenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents dgv_attendance_details As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_search As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblzero As System.Windows.Forms.Label
    Friend WithEvents lblone As System.Windows.Forms.Label
    Friend WithEvents lbltwo As System.Windows.Forms.Label
    Friend WithEvents lblthree As System.Windows.Forms.Label
    Friend WithEvents lblfour As System.Windows.Forms.Label
    Friend WithEvents lblfive As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lable As System.Windows.Forms.Label
    Friend WithEvents starrating As Bunifu.Framework.UI.BunifuRating
    Friend WithEvents lbloverall As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblmessage As System.Windows.Forms.TextBox
    Friend WithEvents lbl_event_id As System.Windows.Forms.Label
    Friend WithEvents btn_view_review As System.Windows.Forms.Button
    Friend WithEvents pnlmenu As System.Windows.Forms.Panel
    Friend WithEvents btn_modify_cl As System.Windows.Forms.Button
    Friend WithEvents btn_open_cl_summary As System.Windows.Forms.Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents tbdescription As TextBox
    Friend WithEvents tbtitle As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tb_student_list As TextBox
End Class
