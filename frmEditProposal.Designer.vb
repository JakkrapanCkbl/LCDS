<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditProposal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditProposal))
        Me.cboProcessSubID = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpContactDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtProposalID = New System.Windows.Forms.TextBox
        Me.cmdLC = New System.Windows.Forms.Button
        Me.cmdKK = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpProposalDate = New System.Windows.Forms.DateTimePicker
        Me.txtProposalContact = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtProposalName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtProposalDescription = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboBR = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboProposalCustomer = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboClientCustomer = New System.Windows.Forms.ComboBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.txtContactName = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtFax1 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTel1 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTitle1 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtContactName1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.cboReportCustomer = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cboObjectiveID = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtPropertyDescription = New System.Windows.Forms.RichTextBox
        Me.txtJobPeriod = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cboEmployeeID = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.RichTextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.fg3 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label26 = New System.Windows.Forms.Label
        Me.Button12 = New System.Windows.Forms.Button
        Me.chkNotFirstOpen = New System.Windows.Forms.CheckBox
        Me.txtTemp = New System.Windows.Forms.RichTextBox
        Me.Panel1.SuspendLayout()
        CType(Me.fg3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProcessSubID
        '
        Me.cboProcessSubID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboProcessSubID.FormattingEnabled = True
        Me.cboProcessSubID.Location = New System.Drawing.Point(124, 22)
        Me.cboProcessSubID.Name = "cboProcessSubID"
        Me.cboProcessSubID.Size = New System.Drawing.Size(189, 24)
        Me.cboProcessSubID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "สถานะงาน"
        '
        'dtpContactDate
        '
        Me.dtpContactDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpContactDate.Checked = False
        Me.dtpContactDate.Location = New System.Drawing.Point(429, 26)
        Me.dtpContactDate.Name = "dtpContactDate"
        Me.dtpContactDate.ShowCheckBox = True
        Me.dtpContactDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpContactDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(319, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "วันที่ลูกค้าตอบรับงาน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "รหัสใบเสนองาน"
        '
        'txtProposalID
        '
        Me.txtProposalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProposalID.Location = New System.Drawing.Point(124, 52)
        Me.txtProposalID.Name = "txtProposalID"
        Me.txtProposalID.Size = New System.Drawing.Size(189, 22)
        Me.txtProposalID.TabIndex = 5
        '
        'cmdLC
        '
        Me.cmdLC.Location = New System.Drawing.Point(322, 52)
        Me.cmdLC.Name = "cmdLC"
        Me.cmdLC.Size = New System.Drawing.Size(101, 24)
        Me.cmdLC.TabIndex = 6
        Me.cmdLC.Text = "Auto ID งาน LC"
        Me.cmdLC.UseVisualStyleBackColor = True
        '
        'cmdKK
        '
        Me.cmdKK.Location = New System.Drawing.Point(429, 52)
        Me.cmdKK.Name = "cmdKK"
        Me.cmdKK.Size = New System.Drawing.Size(101, 24)
        Me.cmdKK.TabIndex = 7
        Me.cmdKK.Text = "Auto ID งาน Bank"
        Me.cmdKK.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "วันที่เสนองาน"
        '
        'dtpProposalDate
        '
        Me.dtpProposalDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpProposalDate.Checked = False
        Me.dtpProposalDate.Location = New System.Drawing.Point(156, 119)
        Me.dtpProposalDate.Name = "dtpProposalDate"
        Me.dtpProposalDate.ShowCheckBox = True
        Me.dtpProposalDate.Size = New System.Drawing.Size(189, 20)
        Me.dtpProposalDate.TabIndex = 8
        '
        'txtProposalContact
        '
        Me.txtProposalContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProposalContact.Location = New System.Drawing.Point(393, 117)
        Me.txtProposalContact.Name = "txtProposalContact"
        Me.txtProposalContact.Size = New System.Drawing.Size(200, 22)
        Me.txtProposalContact.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(357, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "เรียน"
        '
        'txtProposalName
        '
        Me.txtProposalName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProposalName.Location = New System.Drawing.Point(156, 145)
        Me.txtProposalName.Name = "txtProposalName"
        Me.txtProposalName.Size = New System.Drawing.Size(437, 22)
        Me.txtProposalName.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "เรื่อง (จดหมาย)"
        '
        'txtProposalDescription
        '
        Me.txtProposalDescription.Location = New System.Drawing.Point(156, 173)
        Me.txtProposalDescription.Name = "txtProposalDescription"
        Me.txtProposalDescription.Size = New System.Drawing.Size(437, 65)
        Me.txtProposalDescription.TabIndex = 14
        Me.txtProposalDescription.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "รายละเอียด (จดหมาย)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(99, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "เลือก BR"
        '
        'cboBR
        '
        Me.cboBR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboBR.FormattingEnabled = True
        Me.cboBR.Location = New System.Drawing.Point(158, 90)
        Me.cboBR.Name = "cboBR"
        Me.cboBR.Size = New System.Drawing.Size(59, 24)
        Me.cboBR.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(15, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 24)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "เลือกฟอร์มมาตรฐาน >"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(56, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ส่ง Proposal แก่"
        '
        'cboProposalCustomer
        '
        Me.cboProposalCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboProposalCustomer.FormattingEnabled = True
        Me.cboProposalCustomer.Location = New System.Drawing.Point(156, 244)
        Me.cboProposalCustomer.Name = "cboProposalCustomer"
        Me.cboProposalCustomer.Size = New System.Drawing.Size(349, 24)
        Me.cboProposalCustomer.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Location = New System.Drawing.Point(511, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 24)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(538, 244)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(55, 24)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(33, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ส่งรายงานให้กับผู้ว่าจ้าง"
        '
        'cboClientCustomer
        '
        Me.cboClientCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboClientCustomer.FormattingEnabled = True
        Me.cboClientCustomer.Location = New System.Drawing.Point(156, 290)
        Me.cboClientCustomer.Name = "cboClientCustomer"
        Me.cboClientCustomer.Size = New System.Drawing.Size(349, 24)
        Me.cboClientCustomer.TabIndex = 23
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button6.Location = New System.Drawing.Point(538, 289)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(55, 24)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.Location = New System.Drawing.Point(511, 289)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 24)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtContactName
        '
        Me.txtContactName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtContactName.Location = New System.Drawing.Point(156, 320)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(200, 22)
        Me.txtContactName.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(120, 324)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "เรียน"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(410, 320)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(183, 22)
        Me.txtTitle.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(357, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "ตำแหน่ง"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(156, 348)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(437, 22)
        Me.txtTel.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(120, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "โทร"
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFax.Location = New System.Drawing.Point(156, 376)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(437, 22)
        Me.txtFax.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(112, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "แฟ็กซ์"
        '
        'txtFax1
        '
        Me.txtFax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFax1.Location = New System.Drawing.Point(156, 503)
        Me.txtFax1.Name = "txtFax1"
        Me.txtFax1.Size = New System.Drawing.Size(437, 22)
        Me.txtFax1.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(112, 506)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 16)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "แฟ็กซ์"
        '
        'txtTel1
        '
        Me.txtTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel1.Location = New System.Drawing.Point(156, 475)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(437, 22)
        Me.txtTel1.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(120, 479)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 16)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "โทร"
        '
        'txtTitle1
        '
        Me.txtTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTitle1.Location = New System.Drawing.Point(410, 448)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.Size = New System.Drawing.Size(183, 22)
        Me.txtTitle1.TabIndex = 42
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(357, 451)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 16)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "ตำแหน่ง"
        '
        'txtContactName1
        '
        Me.txtContactName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtContactName1.Location = New System.Drawing.Point(156, 447)
        Me.txtContactName1.Name = "txtContactName1"
        Me.txtContactName1.Size = New System.Drawing.Size(200, 22)
        Me.txtContactName1.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(120, 451)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 16)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "เรียน"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button8.Location = New System.Drawing.Point(538, 416)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(55, 24)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "Refresh"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button9.Location = New System.Drawing.Point(511, 416)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(25, 24)
        Me.Button9.TabIndex = 37
        Me.Button9.Text = "..."
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(101, 420)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 16)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "ลูกค้าราย"
        '
        'cboReportCustomer
        '
        Me.cboReportCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboReportCustomer.FormattingEnabled = True
        Me.cboReportCustomer.Location = New System.Drawing.Point(156, 417)
        Me.cboReportCustomer.Name = "cboReportCustomer"
        Me.cboReportCustomer.Size = New System.Drawing.Size(349, 24)
        Me.cboReportCustomer.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(31, 556)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 16)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "วัตถุประสงค์การประเมิน"
        '
        'cboObjectiveID
        '
        Me.cboObjectiveID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboObjectiveID.FormattingEnabled = True
        Me.cboObjectiveID.Location = New System.Drawing.Point(156, 553)
        Me.cboObjectiveID.Name = "cboObjectiveID"
        Me.cboObjectiveID.Size = New System.Drawing.Size(437, 24)
        Me.cboObjectiveID.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(-1, 584)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(151, 16)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "สรุปรายการทรัพย์สิน/ทำเลที่ตั้ง"
        '
        'txtPropertyDescription
        '
        Me.txtPropertyDescription.Location = New System.Drawing.Point(156, 583)
        Me.txtPropertyDescription.Name = "txtPropertyDescription"
        Me.txtPropertyDescription.Size = New System.Drawing.Size(437, 50)
        Me.txtPropertyDescription.TabIndex = 49
        Me.txtPropertyDescription.Text = ""
        '
        'txtJobPeriod
        '
        Me.txtJobPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtJobPeriod.Location = New System.Drawing.Point(156, 639)
        Me.txtJobPeriod.Name = "txtJobPeriod"
        Me.txtJobPeriod.Size = New System.Drawing.Size(41, 22)
        Me.txtJobPeriod.TabIndex = 52
        Me.txtJobPeriod.Text = "0"
        Me.txtJobPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(50, 642)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 16)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "ระยะเวลาการทำงาน"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(203, 642)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 16)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "วัน"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(230, 642)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 16)
        Me.Label24.TabIndex = 55
        Me.Label24.Text = "ผู้จัดทำ Proposal"
        '
        'cboEmployeeID
        '
        Me.cboEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboEmployeeID.FormattingEnabled = True
        Me.cboEmployeeID.Location = New System.Drawing.Point(335, 637)
        Me.cboEmployeeID.Name = "cboEmployeeID"
        Me.cboEmployeeID.Size = New System.Drawing.Size(258, 24)
        Me.cboEmployeeID.TabIndex = 54
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(95, 667)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 16)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "หมายเหตุ"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(156, 667)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(437, 50)
        Me.txtRemark.TabIndex = 56
        Me.txtRemark.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.fg3)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Location = New System.Drawing.Point(640, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 169)
        Me.Panel1.TabIndex = 59
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(526, 8)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(92, 34)
        Me.Button11.TabIndex = 75
        Me.Button11.Text = "เพิ่มทรพัย์สิน"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(419, 8)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(92, 34)
        Me.Button10.TabIndex = 74
        Me.Button10.Text = "ลบทรพัย์สิน"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'fg3
        '
        Me.fg3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fg3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fg3.AutoGenerateColumns = False
        Me.fg3.AutoResize = False
        Me.fg3.ColumnInfo = resources.GetString("fg3.ColumnInfo")
        Me.fg3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fg3.Location = New System.Drawing.Point(-1, 56)
        Me.fg3.Name = "fg3"
        Me.fg3.Rows.Count = 1
        Me.fg3.Rows.DefaultSize = 19
        Me.fg3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg3.Size = New System.Drawing.Size(624, 101)
        Me.fg3.StyleInfo = resources.GetString("fg3.StyleInfo")
        Me.fg3.TabIndex = 73
        Me.fg3.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(217, 25)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "รายการทรัพย์สินที่ประเมิน"
        '
        'Button12
        '
        Me.Button12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(1167, 26)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(92, 34)
        Me.Button12.TabIndex = 77
        Me.Button12.Text = "Save"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'chkNotFirstOpen
        '
        Me.chkNotFirstOpen.AutoSize = True
        Me.chkNotFirstOpen.ForeColor = System.Drawing.Color.Red
        Me.chkNotFirstOpen.Location = New System.Drawing.Point(127, 2)
        Me.chkNotFirstOpen.Name = "chkNotFirstOpen"
        Me.chkNotFirstOpen.Size = New System.Drawing.Size(94, 17)
        Me.chkNotFirstOpen.TabIndex = 78
        Me.chkNotFirstOpen.Text = "Not First Open"
        Me.chkNotFirstOpen.UseVisualStyleBackColor = True
        Me.chkNotFirstOpen.Visible = False
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(636, 290)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(325, 146)
        Me.txtTemp.TabIndex = 79
        Me.txtTemp.Text = ""
        Me.txtTemp.Visible = False
        '
        'frmEditProposal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.chkNotFirstOpen)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cboEmployeeID)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtJobPeriod)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPropertyDescription)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboObjectiveID)
        Me.Controls.Add(Me.txtFax1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTitle1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtContactName1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cboReportCustomer)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtContactName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboClientCustomer)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboProposalCustomer)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboBR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProposalDescription)
        Me.Controls.Add(Me.txtProposalName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProposalContact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpProposalDate)
        Me.Controls.Add(Me.cmdKK)
        Me.Controls.Add(Me.cmdLC)
        Me.Controls.Add(Me.txtProposalID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpContactDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboProcessSubID)
        Me.Name = "frmEditProposal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditProposal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fg3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboProcessSubID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpContactDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProposalID As System.Windows.Forms.TextBox
    Friend WithEvents cmdLC As System.Windows.Forms.Button
    Friend WithEvents cmdKK As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpProposalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProposalContact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProposalName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProposalDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboBR As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboProposalCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboClientCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFax1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTitle1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtContactName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboReportCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboObjectiveID As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPropertyDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents txtJobPeriod As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents fg3 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents chkNotFirstOpen As System.Windows.Forms.CheckBox
    Friend WithEvents txtTemp As System.Windows.Forms.RichTextBox
End Class
