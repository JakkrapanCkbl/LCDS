﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProposalID = New System.Windows.Forms.TextBox()
        Me.cmdLC = New System.Windows.Forms.Button()
        Me.cmdKK = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpProposalDate = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboProposalCustomer = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboClientCustomer = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboReportCustomer = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboObjectiveID = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.chkNotFirstOpen = New System.Windows.Forms.CheckBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboAmphoeID = New System.Windows.Forms.ComboBox()
        Me.cboTumbonID = New System.Windows.Forms.ComboBox()
        Me.cboProvinceID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPropertyTypeDetailID = New System.Windows.Forms.ComboBox()
        Me.cboPropertyTypeID = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRai = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNgan = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSqWah = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSqMeter = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "รหัสใบเสนองาน"
        '
        'txtProposalID
        '
        Me.txtProposalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProposalID.Location = New System.Drawing.Point(155, 36)
        Me.txtProposalID.Name = "txtProposalID"
        Me.txtProposalID.Size = New System.Drawing.Size(207, 22)
        Me.txtProposalID.TabIndex = 5
        '
        'cmdLC
        '
        Me.cmdLC.Location = New System.Drawing.Point(155, 8)
        Me.cmdLC.Name = "cmdLC"
        Me.cmdLC.Size = New System.Drawing.Size(96, 24)
        Me.cmdLC.TabIndex = 6
        Me.cmdLC.Text = "Auto ID งาน LC"
        Me.cmdLC.UseVisualStyleBackColor = True
        '
        'cmdKK
        '
        Me.cmdKK.Location = New System.Drawing.Point(257, 8)
        Me.cmdKK.Name = "cmdKK"
        Me.cmdKK.Size = New System.Drawing.Size(105, 24)
        Me.cmdKK.TabIndex = 7
        Me.cmdKK.Text = "Auto ID งาน Bank"
        Me.cmdKK.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "วันที่เสนองาน"
        '
        'dtpProposalDate
        '
        Me.dtpProposalDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpProposalDate.Checked = False
        Me.dtpProposalDate.Location = New System.Drawing.Point(155, 64)
        Me.dtpProposalDate.Name = "dtpProposalDate"
        Me.dtpProposalDate.ShowCheckBox = True
        Me.dtpProposalDate.Size = New System.Drawing.Size(189, 20)
        Me.dtpProposalDate.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtID.Location = New System.Drawing.Point(392, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(112, 22)
        Me.txtID.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(365, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(55, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ส่ง Proposal แก่"
        '
        'cboProposalCustomer
        '
        Me.cboProposalCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboProposalCustomer.FormattingEnabled = True
        Me.cboProposalCustomer.Location = New System.Drawing.Point(155, 90)
        Me.cboProposalCustomer.Name = "cboProposalCustomer"
        Me.cboProposalCustomer.Size = New System.Drawing.Size(349, 24)
        Me.cboProposalCustomer.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Location = New System.Drawing.Point(510, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 24)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(537, 90)
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
        Me.Label10.Location = New System.Drawing.Point(32, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ส่งรายงานให้กับผู้ว่าจ้าง"
        '
        'cboClientCustomer
        '
        Me.cboClientCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboClientCustomer.FormattingEnabled = True
        Me.cboClientCustomer.Location = New System.Drawing.Point(155, 120)
        Me.cboClientCustomer.Name = "cboClientCustomer"
        Me.cboClientCustomer.Size = New System.Drawing.Size(349, 24)
        Me.cboClientCustomer.TabIndex = 23
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button6.Location = New System.Drawing.Point(537, 119)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(55, 24)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.Location = New System.Drawing.Point(510, 119)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 24)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button8.Location = New System.Drawing.Point(537, 149)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(55, 24)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "Refresh"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button9.Location = New System.Drawing.Point(510, 149)
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
        Me.Label19.Location = New System.Drawing.Point(100, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 16)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "ลูกค้าราย"
        '
        'cboReportCustomer
        '
        Me.cboReportCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboReportCustomer.FormattingEnabled = True
        Me.cboReportCustomer.Location = New System.Drawing.Point(155, 150)
        Me.cboReportCustomer.Name = "cboReportCustomer"
        Me.cboReportCustomer.Size = New System.Drawing.Size(349, 24)
        Me.cboReportCustomer.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(30, 183)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 16)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "วัตถุประสงค์การประเมิน"
        '
        'cboObjectiveID
        '
        Me.cboObjectiveID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboObjectiveID.FormattingEnabled = True
        Me.cboObjectiveID.Location = New System.Drawing.Point(155, 180)
        Me.cboObjectiveID.Name = "cboObjectiveID"
        Me.cboObjectiveID.Size = New System.Drawing.Size(437, 24)
        Me.cboObjectiveID.TabIndex = 47
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(94, 210)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 16)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "หมายเหตุ"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(155, 210)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(437, 50)
        Me.txtRemark.TabIndex = 56
        Me.txtRemark.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtSqMeter)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtSqWah)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtNgan)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtRai)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cboPropertyTypeDetailID)
        Me.Panel1.Controls.Add(Me.cboPropertyTypeID)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cboAmphoeID)
        Me.Panel1.Controls.Add(Me.cboTumbonID)
        Me.Panel1.Controls.Add(Me.cboProvinceID)
        Me.Panel1.Controls.Add(Me.txtRoad)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtSoi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Location = New System.Drawing.Point(616, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 300)
        Me.Panel1.TabIndex = 59
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
        Me.Button12.Location = New System.Drawing.Point(1128, 30)
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
        Me.chkNotFirstOpen.Location = New System.Drawing.Point(627, 8)
        Me.chkNotFirstOpen.Name = "chkNotFirstOpen"
        Me.chkNotFirstOpen.Size = New System.Drawing.Size(94, 17)
        Me.chkNotFirstOpen.TabIndex = 78
        Me.chkNotFirstOpen.Text = "Not First Open"
        Me.chkNotFirstOpen.UseVisualStyleBackColor = True
        Me.chkNotFirstOpen.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(143, 48)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(460, 22)
        Me.txtAddress.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "ชื่อโครงการ/บ้านเลขที่"
        '
        'txtSoi
        '
        Me.txtSoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSoi.Location = New System.Drawing.Point(143, 78)
        Me.txtSoi.Name = "txtSoi"
        Me.txtSoi.Size = New System.Drawing.Size(209, 22)
        Me.txtSoi.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "ซอย"
        '
        'txtRoad
        '
        Me.txtRoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRoad.Location = New System.Drawing.Point(394, 79)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(209, 22)
        Me.txtRoad.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "ถนน"
        '
        'cboAmphoeID
        '
        Me.cboAmphoeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboAmphoeID.FormattingEnabled = True
        Me.cboAmphoeID.Location = New System.Drawing.Point(143, 138)
        Me.cboAmphoeID.Name = "cboAmphoeID"
        Me.cboAmphoeID.Size = New System.Drawing.Size(209, 24)
        Me.cboAmphoeID.TabIndex = 84
        '
        'cboTumbonID
        '
        Me.cboTumbonID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboTumbonID.FormattingEnabled = True
        Me.cboTumbonID.Location = New System.Drawing.Point(394, 135)
        Me.cboTumbonID.Name = "cboTumbonID"
        Me.cboTumbonID.Size = New System.Drawing.Size(209, 24)
        Me.cboTumbonID.TabIndex = 83
        '
        'cboProvinceID
        '
        Me.cboProvinceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboProvinceID.FormattingEnabled = True
        Me.cboProvinceID.Location = New System.Drawing.Point(143, 108)
        Me.cboProvinceID.Name = "cboProvinceID"
        Me.cboProvinceID.Size = New System.Drawing.Size(209, 24)
        Me.cboProvinceID.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(102, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "อำเภอ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "จังหวัด"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(355, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 16)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "ตำบล"
        '
        'cboPropertyTypeDetailID
        '
        Me.cboPropertyTypeDetailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboPropertyTypeDetailID.FormattingEnabled = True
        Me.cboPropertyTypeDetailID.Location = New System.Drawing.Point(143, 198)
        Me.cboPropertyTypeDetailID.Name = "cboPropertyTypeDetailID"
        Me.cboPropertyTypeDetailID.Size = New System.Drawing.Size(460, 24)
        Me.cboPropertyTypeDetailID.TabIndex = 89
        '
        'cboPropertyTypeID
        '
        Me.cboPropertyTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboPropertyTypeID.FormattingEnabled = True
        Me.cboPropertyTypeID.Location = New System.Drawing.Point(143, 168)
        Me.cboPropertyTypeID.Name = "cboPropertyTypeID"
        Me.cboPropertyTypeID.Size = New System.Drawing.Size(460, 24)
        Me.cboPropertyTypeID.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "ประเภททรัพย์สิน"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(59, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "หมวดทรัพย์สิน"
        '
        'txtRai
        '
        Me.txtRai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRai.Location = New System.Drawing.Point(143, 228)
        Me.txtRai.Name = "txtRai"
        Me.txtRai.Size = New System.Drawing.Size(50, 22)
        Me.txtRai.TabIndex = 93
        Me.txtRai.Text = "0"
        Me.txtRai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(110, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 16)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "ไร่"
        '
        'txtNgan
        '
        Me.txtNgan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNgan.Location = New System.Drawing.Point(221, 228)
        Me.txtNgan.Name = "txtNgan"
        Me.txtNgan.Size = New System.Drawing.Size(50, 22)
        Me.txtNgan.TabIndex = 95
        Me.txtNgan.Text = "0"
        Me.txtNgan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(194, 230)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 16)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "งาน"
        '
        'txtSqWah
        '
        Me.txtSqWah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSqWah.Location = New System.Drawing.Point(324, 228)
        Me.txtSqWah.Name = "txtSqWah"
        Me.txtSqWah.Size = New System.Drawing.Size(50, 22)
        Me.txtSqWah.TabIndex = 97
        Me.txtSqWah.Text = "0"
        Me.txtSqWah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(277, 230)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "ตารางวา"
        '
        'txtSqMeter
        '
        Me.txtSqMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSqMeter.Location = New System.Drawing.Point(143, 256)
        Me.txtSqMeter.Name = "txtSqMeter"
        Me.txtSqMeter.Size = New System.Drawing.Size(50, 22)
        Me.txtSqMeter.TabIndex = 101
        Me.txtSqMeter.Text = "0"
        Me.txtSqMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(199, 259)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 16)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "ตารางเมตร"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 22)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "โหลด อำเภอ+ตำบล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(106, 259)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 16)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "พื้นที่"
        '
        'frmEditProposal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.chkNotFirstOpen)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboObjectiveID)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cboReportCustomer)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboClientCustomer)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboProposalCustomer)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpProposalDate)
        Me.Controls.Add(Me.cmdKK)
        Me.Controls.Add(Me.cmdLC)
        Me.Controls.Add(Me.txtProposalID)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmEditProposal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditProposal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProposalID As System.Windows.Forms.TextBox
    Friend WithEvents cmdLC As System.Windows.Forms.Button
    Friend WithEvents cmdKK As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpProposalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboProposalCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboClientCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboReportCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboObjectiveID As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents chkNotFirstOpen As System.Windows.Forms.CheckBox
    Friend WithEvents txtSqMeter As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSqWah As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNgan As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRai As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboPropertyTypeDetailID As ComboBox
    Friend WithEvents cboPropertyTypeID As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboAmphoeID As ComboBox
    Friend WithEvents cboTumbonID As ComboBox
    Friend WithEvents cboProvinceID As ComboBox
    Friend WithEvents txtRoad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label17 As Label
End Class
