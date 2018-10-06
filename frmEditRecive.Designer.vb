<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditRecive
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
        Me.chkNotFirstOpen = New System.Windows.Forms.CheckBox
        Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtReceiveID = New System.Windows.Forms.TextBox
        Me.cboInvoiceID = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCollecTo = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtJobNo = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotal_Amt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtVat = New System.Windows.Forms.TextBox
        Me.txtPay = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.RichTextBox
        Me.txtDes1 = New System.Windows.Forms.RichTextBox
        Me.txtSum_Amt1 = New System.Windows.Forms.TextBox
        Me.txtAmt1 = New System.Windows.Forms.TextBox
        Me.txtQty1 = New System.Windows.Forms.TextBox
        Me.txtItem1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkNotFirstOpen
        '
        Me.chkNotFirstOpen.AutoSize = True
        Me.chkNotFirstOpen.ForeColor = System.Drawing.Color.Red
        Me.chkNotFirstOpen.Location = New System.Drawing.Point(136, 27)
        Me.chkNotFirstOpen.Name = "chkNotFirstOpen"
        Me.chkNotFirstOpen.Size = New System.Drawing.Size(94, 17)
        Me.chkNotFirstOpen.TabIndex = 40
        Me.chkNotFirstOpen.Text = "Not First Open"
        Me.chkNotFirstOpen.UseVisualStyleBackColor = True
        Me.chkNotFirstOpen.Visible = False
        '
        'dtpReceiveDate
        '
        Me.dtpReceiveDate.Location = New System.Drawing.Point(136, 78)
        Me.dtpReceiveDate.Name = "dtpReceiveDate"
        Me.dtpReceiveDate.Size = New System.Drawing.Size(255, 20)
        Me.dtpReceiveDate.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "วันที่ใบเสร็จ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "เลขที่ใบเสร็จ"
        '
        'txtReceiveID
        '
        Me.txtReceiveID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReceiveID.Location = New System.Drawing.Point(136, 50)
        Me.txtReceiveID.Name = "txtReceiveID"
        Me.txtReceiveID.Size = New System.Drawing.Size(255, 22)
        Me.txtReceiveID.TabIndex = 34
        '
        'cboInvoiceID
        '
        Me.cboInvoiceID.FormattingEnabled = True
        Me.cboInvoiceID.Location = New System.Drawing.Point(136, 104)
        Me.cboInvoiceID.Name = "cboInvoiceID"
        Me.cboInvoiceID.Size = New System.Drawing.Size(255, 21)
        Me.cboInvoiceID.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "เลือกเลขที่ใบแจ้งหนี้"
        '
        'txtCollecTo
        '
        Me.txtCollecTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCollecTo.Location = New System.Drawing.Point(136, 131)
        Me.txtCollecTo.Name = "txtCollecTo"
        Me.txtCollecTo.Size = New System.Drawing.Size(547, 22)
        Me.txtCollecTo.TabIndex = 44
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(136, 153)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(547, 22)
        Me.txtAddress.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "ลูกค้า"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "JobNo"
        '
        'txtJobNo
        '
        Me.txtJobNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtJobNo.Location = New System.Drawing.Point(136, 180)
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(547, 22)
        Me.txtJobNo.TabIndex = 46
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(454, 408)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(90, 32)
        Me.cmdClose.TabIndex = 67
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(301, 408)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 32)
        Me.cmdSave.TabIndex = 66
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(584, 363)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 16)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Total Amount"
        '
        'txtTotal_Amt
        '
        Me.txtTotal_Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal_Amt.Location = New System.Drawing.Point(690, 357)
        Me.txtTotal_Amt.Name = "txtTotal_Amt"
        Me.txtTotal_Amt.Size = New System.Drawing.Size(115, 22)
        Me.txtTotal_Amt.TabIndex = 64
        Me.txtTotal_Amt.Text = "0"
        Me.txtTotal_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(621, 331)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 16)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Vat 7%"
        '
        'txtVat
        '
        Me.txtVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVat.Location = New System.Drawing.Point(690, 328)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(115, 22)
        Me.txtVat.TabIndex = 62
        Me.txtVat.Text = "0"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPay.Location = New System.Drawing.Point(690, 295)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(115, 22)
        Me.txtPay.TabIndex = 61
        Me.txtPay.Text = "0"
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(528, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 16)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Total (ไม่รวมภาษีมูลค่าเพิ่ม)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(85, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "หมายเหตุ"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(136, 354)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(314, 38)
        Me.txtRemark.TabIndex = 58
        Me.txtRemark.Text = ""
        '
        'txtDes1
        '
        Me.txtDes1.Location = New System.Drawing.Point(136, 259)
        Me.txtDes1.Name = "txtDes1"
        Me.txtDes1.Size = New System.Drawing.Size(314, 89)
        Me.txtDes1.TabIndex = 57
        Me.txtDes1.Text = ""
        '
        'txtSum_Amt1
        '
        Me.txtSum_Amt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSum_Amt1.Location = New System.Drawing.Point(690, 259)
        Me.txtSum_Amt1.Name = "txtSum_Amt1"
        Me.txtSum_Amt1.Size = New System.Drawing.Size(115, 22)
        Me.txtSum_Amt1.TabIndex = 56
        Me.txtSum_Amt1.Text = "0"
        Me.txtSum_Amt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmt1
        '
        Me.txtAmt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAmt1.Location = New System.Drawing.Point(556, 259)
        Me.txtAmt1.Name = "txtAmt1"
        Me.txtAmt1.Size = New System.Drawing.Size(115, 22)
        Me.txtAmt1.TabIndex = 55
        Me.txtAmt1.Text = "0"
        Me.txtAmt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty1
        '
        Me.txtQty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQty1.Location = New System.Drawing.Point(474, 259)
        Me.txtQty1.Name = "txtQty1"
        Me.txtQty1.Size = New System.Drawing.Size(30, 22)
        Me.txtQty1.TabIndex = 54
        Me.txtQty1.Text = "1"
        Me.txtQty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItem1
        '
        Me.txtItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtItem1.Location = New System.Drawing.Point(88, 259)
        Me.txtItem1.Name = "txtItem1"
        Me.txtItem1.Size = New System.Drawing.Size(30, 22)
        Me.txtItem1.TabIndex = 53
        Me.txtItem1.Text = "1"
        Me.txtItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(704, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Amount (Baht)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(553, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Amount/Job (Baht)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(460, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Quantity"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(226, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 16)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Description"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(85, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 16)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Item"
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(397, 104)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(131, 21)
        Me.cmdLoad.TabIndex = 68
        Me.cmdLoad.Text = "ดึงข้อมูลจากใบแจ้งหนี้"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'frmEditRecive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 452)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
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
        Me.Controls.Add(Me.txtItem1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJobNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCollecTo)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboInvoiceID)
        Me.Controls.Add(Me.chkNotFirstOpen)
        Me.Controls.Add(Me.dtpReceiveDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReceiveID)
        Me.Name = "frmEditRecive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditRecive"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkNotFirstOpen As System.Windows.Forms.CheckBox
    Friend WithEvents dtpReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReceiveID As System.Windows.Forms.TextBox
    Friend WithEvents cboInvoiceID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCollecTo As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJobNo As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_Amt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDes1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSum_Amt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAmt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQty1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
End Class
