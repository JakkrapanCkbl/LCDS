<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditInvoice
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditInvoice))
        Me.txtInvoiceID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtJobNo = New System.Windows.Forms.TextBox
        Me.cboBillCus = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtItem1 = New System.Windows.Forms.TextBox
        Me.txtQty1 = New System.Windows.Forms.TextBox
        Me.txtAmt1 = New System.Windows.Forms.TextBox
        Me.txtSum_Amt1 = New System.Windows.Forms.TextBox
        Me.txtDes1 = New System.Windows.Forms.RichTextBox
        Me.txtRemark = New System.Windows.Forms.RichTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPay = New System.Windows.Forms.TextBox
        Me.txtVat = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotal_Amt = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.chkNotFirstOpen = New System.Windows.Forms.CheckBox
        Me.txtCollecTo = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label24 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtValuerNetFee = New System.Windows.Forms.TextBox
        Me.txtHeadNetFee = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtNetFee = New System.Windows.Forms.TextBox
        Me.txtCheck_Cost = New System.Windows.Forms.TextBox
        Me.txtOPE_Cost = New System.Windows.Forms.TextBox
        Me.txtFee_Cost = New System.Windows.Forms.TextBox
        Me.txtValuerType = New System.Windows.Forms.TextBox
        Me.txtValuer = New System.Windows.Forms.TextBox
        Me.txtHead = New System.Windows.Forms.TextBox
        Me.txtCodeID = New System.Windows.Forms.TextBox
        Me.cmdAdd2 = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboReports = New System.Windows.Forms.ComboBox
        Me.fg2 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtCusName2 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.RichTextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.chkMode = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInvoiceID
        '
        Me.txtInvoiceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInvoiceID.Location = New System.Drawing.Point(118, 33)
        Me.txtInvoiceID.Name = "txtInvoiceID"
        Me.txtInvoiceID.Size = New System.Drawing.Size(255, 22)
        Me.txtInvoiceID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เลขที่ใบแจ้งหนี้"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "วันที่ใบแจ้งหนี้"
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(118, 61)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(255, 20)
        Me.dtpInvoiceDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "JobNo"
        '
        'txtJobNo
        '
        Me.txtJobNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtJobNo.Location = New System.Drawing.Point(118, 87)
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(547, 22)
        Me.txtJobNo.TabIndex = 4
        '
        'cboBillCus
        '
        Me.cboBillCus.FormattingEnabled = True
        Me.cboBillCus.Location = New System.Drawing.Point(118, 116)
        Me.cboBillCus.Name = "cboBillCus"
        Me.cboBillCus.Size = New System.Drawing.Size(255, 21)
        Me.cboBillCus.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "เลือกลูกค้า"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(118, 163)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(547, 22)
        Me.txtAddress.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(442, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(535, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Amount/Job (Baht)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(686, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Amount (Baht)"
        '
        'txtItem1
        '
        Me.txtItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtItem1.Location = New System.Drawing.Point(73, 238)
        Me.txtItem1.Name = "txtItem1"
        Me.txtItem1.Size = New System.Drawing.Size(30, 22)
        Me.txtItem1.TabIndex = 15
        Me.txtItem1.Text = "1"
        Me.txtItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQty1
        '
        Me.txtQty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQty1.Location = New System.Drawing.Point(456, 238)
        Me.txtQty1.Name = "txtQty1"
        Me.txtQty1.Size = New System.Drawing.Size(30, 22)
        Me.txtQty1.TabIndex = 16
        Me.txtQty1.Text = "1"
        Me.txtQty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmt1
        '
        Me.txtAmt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAmt1.Location = New System.Drawing.Point(538, 238)
        Me.txtAmt1.Name = "txtAmt1"
        Me.txtAmt1.Size = New System.Drawing.Size(115, 22)
        Me.txtAmt1.TabIndex = 18
        Me.txtAmt1.Text = "0"
        Me.txtAmt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSum_Amt1
        '
        Me.txtSum_Amt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSum_Amt1.Location = New System.Drawing.Point(672, 238)
        Me.txtSum_Amt1.Name = "txtSum_Amt1"
        Me.txtSum_Amt1.Size = New System.Drawing.Size(115, 22)
        Me.txtSum_Amt1.TabIndex = 19
        Me.txtSum_Amt1.Text = "0"
        Me.txtSum_Amt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDes1
        '
        Me.txtDes1.Location = New System.Drawing.Point(118, 238)
        Me.txtDes1.Name = "txtDes1"
        Me.txtDes1.Size = New System.Drawing.Size(314, 89)
        Me.txtDes1.TabIndex = 20
        Me.txtDes1.Text = ""
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(118, 333)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(314, 38)
        Me.txtRemark.TabIndex = 21
        Me.txtRemark.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "หมายเหตุ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(510, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Total (ไม่รวมภาษีมูลค่าเพิ่ม)"
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPay.Location = New System.Drawing.Point(672, 274)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(115, 22)
        Me.txtPay.TabIndex = 24
        Me.txtPay.Text = "0"
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVat
        '
        Me.txtVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVat.Location = New System.Drawing.Point(672, 307)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(115, 22)
        Me.txtVat.TabIndex = 25
        Me.txtVat.Text = "0"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(603, 310)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Vat 7%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(566, 342)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Total Amount"
        '
        'txtTotal_Amt
        '
        Me.txtTotal_Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal_Amt.Location = New System.Drawing.Point(672, 336)
        Me.txtTotal_Amt.Name = "txtTotal_Amt"
        Me.txtTotal_Amt.Size = New System.Drawing.Size(115, 22)
        Me.txtTotal_Amt.TabIndex = 27
        Me.txtTotal_Amt.Text = "0"
        Me.txtTotal_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(379, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 22)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "เพิ่มชื่อลูกค้า"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(474, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 22)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "แก้ไขชื่อลูกค้า"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(353, 388)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 32)
        Me.cmdSave.TabIndex = 31
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(506, 388)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(90, 32)
        Me.cmdClose.TabIndex = 32
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'chkNotFirstOpen
        '
        Me.chkNotFirstOpen.AutoSize = True
        Me.chkNotFirstOpen.ForeColor = System.Drawing.Color.Red
        Me.chkNotFirstOpen.Location = New System.Drawing.Point(118, 10)
        Me.chkNotFirstOpen.Name = "chkNotFirstOpen"
        Me.chkNotFirstOpen.Size = New System.Drawing.Size(94, 17)
        Me.chkNotFirstOpen.TabIndex = 33
        Me.chkNotFirstOpen.Text = "Not First Open"
        Me.chkNotFirstOpen.UseVisualStyleBackColor = True
        Me.chkNotFirstOpen.Visible = False
        '
        'txtCollecTo
        '
        Me.txtCollecTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCollecTo.Location = New System.Drawing.Point(118, 141)
        Me.txtCollecTo.Name = "txtCollecTo"
        Me.txtCollecTo.Size = New System.Drawing.Size(547, 22)
        Me.txtCollecTo.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtValuerNetFee)
        Me.Panel1.Controls.Add(Me.txtHeadNetFee)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtNetFee)
        Me.Panel1.Controls.Add(Me.txtCheck_Cost)
        Me.Panel1.Controls.Add(Me.txtOPE_Cost)
        Me.Panel1.Controls.Add(Me.txtFee_Cost)
        Me.Panel1.Controls.Add(Me.txtValuerType)
        Me.Panel1.Controls.Add(Me.txtValuer)
        Me.Panel1.Controls.Add(Me.txtHead)
        Me.Panel1.Controls.Add(Me.txtCodeID)
        Me.Panel1.Controls.Add(Me.cmdAdd2)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cboReports)
        Me.Panel1.Controls.Add(Me.fg2)
        Me.Panel1.Location = New System.Drawing.Point(2, 440)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 179)
        Me.Panel1.TabIndex = 35
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(231, 3)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 16)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "Code"
        '
        'Button3
        '
        Me.Button3.Image = Global.LCDS.My.Resources.Resources.remove
        Me.Button3.Location = New System.Drawing.Point(3, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 26)
        Me.Button3.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.Button3, "Remove")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(421, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 16)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Valuer"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(320, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 16)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Head"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(276, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 16)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Fee"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(389, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 16)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "Fee"
        '
        'txtValuerNetFee
        '
        Me.txtValuerNetFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtValuerNetFee.Location = New System.Drawing.Point(424, 50)
        Me.txtValuerNetFee.Name = "txtValuerNetFee"
        Me.txtValuerNetFee.Size = New System.Drawing.Size(76, 22)
        Me.txtValuerNetFee.TabIndex = 69
        Me.txtValuerNetFee.Text = "0"
        Me.txtValuerNetFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHeadNetFee
        '
        Me.txtHeadNetFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHeadNetFee.Location = New System.Drawing.Point(311, 50)
        Me.txtHeadNetFee.Name = "txtHeadNetFee"
        Me.txtHeadNetFee.Size = New System.Drawing.Size(76, 22)
        Me.txtHeadNetFee.TabIndex = 68
        Me.txtHeadNetFee.Text = "0"
        Me.txtHeadNetFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(12, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 16)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Performance"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(719, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "ค่าเช็คโฉนด"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(821, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Net Fee"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(646, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 16)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "OPE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(521, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 16)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Fee (Exc. VAT)"
        '
        'txtNetFee
        '
        Me.txtNetFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNetFee.Location = New System.Drawing.Point(789, 22)
        Me.txtNetFee.Name = "txtNetFee"
        Me.txtNetFee.Size = New System.Drawing.Size(115, 22)
        Me.txtNetFee.TabIndex = 62
        Me.txtNetFee.Text = "0"
        Me.txtNetFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCheck_Cost
        '
        Me.txtCheck_Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCheck_Cost.Location = New System.Drawing.Point(707, 22)
        Me.txtCheck_Cost.Name = "txtCheck_Cost"
        Me.txtCheck_Cost.Size = New System.Drawing.Size(76, 22)
        Me.txtCheck_Cost.TabIndex = 61
        Me.txtCheck_Cost.Text = "0"
        Me.txtCheck_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOPE_Cost
        '
        Me.txtOPE_Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOPE_Cost.Location = New System.Drawing.Point(625, 22)
        Me.txtOPE_Cost.Name = "txtOPE_Cost"
        Me.txtOPE_Cost.Size = New System.Drawing.Size(76, 22)
        Me.txtOPE_Cost.TabIndex = 60
        Me.txtOPE_Cost.Text = "0"
        Me.txtOPE_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFee_Cost
        '
        Me.txtFee_Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFee_Cost.Location = New System.Drawing.Point(504, 22)
        Me.txtFee_Cost.Name = "txtFee_Cost"
        Me.txtFee_Cost.Size = New System.Drawing.Size(115, 22)
        Me.txtFee_Cost.TabIndex = 59
        Me.txtFee_Cost.Text = "0"
        Me.txtFee_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValuerType
        '
        Me.txtValuerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtValuerType.Location = New System.Drawing.Point(506, 49)
        Me.txtValuerType.Name = "txtValuerType"
        Me.txtValuerType.Size = New System.Drawing.Size(25, 22)
        Me.txtValuerType.TabIndex = 58
        Me.txtValuerType.Visible = False
        '
        'txtValuer
        '
        Me.txtValuer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtValuer.Location = New System.Drawing.Point(391, 22)
        Me.txtValuer.Name = "txtValuer"
        Me.txtValuer.Size = New System.Drawing.Size(109, 22)
        Me.txtValuer.TabIndex = 57
        '
        'txtHead
        '
        Me.txtHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHead.Location = New System.Drawing.Point(278, 22)
        Me.txtHead.Name = "txtHead"
        Me.txtHead.Size = New System.Drawing.Size(109, 22)
        Me.txtHead.TabIndex = 56
        '
        'txtCodeID
        '
        Me.txtCodeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCodeID.Location = New System.Drawing.Point(231, 22)
        Me.txtCodeID.Name = "txtCodeID"
        Me.txtCodeID.Size = New System.Drawing.Size(41, 22)
        Me.txtCodeID.TabIndex = 55
        '
        'cmdAdd2
        '
        Me.cmdAdd2.Image = Global.LCDS.My.Resources.Resources.ARW08DN
        Me.cmdAdd2.Location = New System.Drawing.Point(911, 50)
        Me.cmdAdd2.Name = "cmdAdd2"
        Me.cmdAdd2.Size = New System.Drawing.Size(30, 26)
        Me.cmdAdd2.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.cmdAdd2, "Add")
        Me.cmdAdd2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "เลือกเลขที่รายงาน"
        '
        'cboReports
        '
        Me.cboReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboReports.FormattingEnabled = True
        Me.cboReports.Location = New System.Drawing.Point(106, 20)
        Me.cboReports.Name = "cboReports"
        Me.cboReports.Size = New System.Drawing.Size(119, 24)
        Me.cboReports.TabIndex = 51
        '
        'fg2
        '
        Me.fg2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg2.AutoGenerateColumns = False
        Me.fg2.AutoResize = False
        Me.fg2.ColumnInfo = resources.GetString("fg2.ColumnInfo")
        Me.fg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fg2.Location = New System.Drawing.Point(0, 81)
        Me.fg2.Name = "fg2"
        Me.fg2.Rows.Count = 1
        Me.fg2.Rows.DefaultSize = 19
        Me.fg2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg2.Size = New System.Drawing.Size(950, 93)
        Me.fg2.StyleInfo = resources.GetString("fg2.StyleInfo")
        Me.fg2.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.chkMode)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.txtAddress2)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.txtCusName2)
        Me.Panel2.Location = New System.Drawing.Point(18, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(743, 135)
        Me.Panel2.TabIndex = 36
        Me.Panel2.Visible = False
        '
        'txtCusName2
        '
        Me.txtCusName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName2.Location = New System.Drawing.Point(73, 20)
        Me.txtCusName2.Name = "txtCusName2"
        Me.txtCusName2.Size = New System.Drawing.Size(653, 22)
        Me.txtCusName2.TabIndex = 35
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(22, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 16)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "ชื่อลูกค้า"
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(73, 44)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(653, 47)
        Me.txtAddress2.TabIndex = 37
        Me.txtAddress2.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.Location = New System.Drawing.Point(39, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 16)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "ที่อยู่"
        '
        'chkMode
        '
        Me.chkMode.AutoSize = True
        Me.chkMode.Location = New System.Drawing.Point(130, 97)
        Me.chkMode.Name = "chkMode"
        Me.chkMode.Size = New System.Drawing.Size(72, 17)
        Me.chkMode.TabIndex = 39
        Me.chkMode.Text = "ModeAdd"
        Me.chkMode.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(277, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 22)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(387, 97)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 22)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmEditInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 631)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtItem1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCollecTo)
        Me.Controls.Add(Me.chkNotFirstOpen)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal_Amt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.txtDes1)
        Me.Controls.Add(Me.txtSum_Amt1)
        Me.Controls.Add(Me.txtAmt1)
        Me.Controls.Add(Me.txtQty1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboBillCus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJobNo)
        Me.Controls.Add(Me.dtpInvoiceDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvoiceID)
        Me.Name = "frmEditInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditInvoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInvoiceID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJobNo As System.Windows.Forms.TextBox
    Friend WithEvents cboBillCus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItem1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQty1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAmt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSum_Amt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDes1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtRemark As System.Windows.Forms.RichTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_Amt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents chkNotFirstOpen As System.Windows.Forms.CheckBox
    Friend WithEvents txtCollecTo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents fg2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboReports As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAdd2 As System.Windows.Forms.Button
    Friend WithEvents txtValuer As System.Windows.Forms.TextBox
    Friend WithEvents txtHead As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeID As System.Windows.Forms.TextBox
    Friend WithEvents txtValuerType As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck_Cost As System.Windows.Forms.TextBox
    Friend WithEvents txtOPE_Cost As System.Windows.Forms.TextBox
    Friend WithEvents txtFee_Cost As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNetFee As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtValuerNetFee As System.Windows.Forms.TextBox
    Friend WithEvents txtHeadNetFee As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCusName2 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
