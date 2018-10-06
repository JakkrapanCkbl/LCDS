<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayoutLaw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLayoutLaw))
        Me.cboProvince = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.chkNotFirstOpen = New System.Windows.Forms.CheckBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtTempID = New System.Windows.Forms.TextBox
        Me.cmdClose1 = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdImg1 = New System.Windows.Forms.Button
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.txtDescription2 = New System.Windows.Forms.RichTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAreaColerID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboProvince1 = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtAreaColor = New System.Windows.Forms.TextBox
        Me.chkAddMode = New System.Windows.Forms.CheckBox
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProvince
        '
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(98, 25)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(162, 21)
        Me.cboProvince.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เลือกจังหวัด"
        '
        'fg
        '
        Me.fg.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.AutoGenerateColumns = False
        Me.fg.AutoResize = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fg.Location = New System.Drawing.Point(3, 67)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1280, 677)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 11
        '
        'chkNotFirstOpen
        '
        Me.chkNotFirstOpen.AutoSize = True
        Me.chkNotFirstOpen.ForeColor = System.Drawing.Color.Red
        Me.chkNotFirstOpen.Location = New System.Drawing.Point(316, 24)
        Me.chkNotFirstOpen.Name = "chkNotFirstOpen"
        Me.chkNotFirstOpen.Size = New System.Drawing.Size(94, 17)
        Me.chkNotFirstOpen.TabIndex = 34
        Me.chkNotFirstOpen.Text = "Not First Open"
        Me.chkNotFirstOpen.UseVisualStyleBackColor = True
        Me.chkNotFirstOpen.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(1094, 18)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(86, 32)
        Me.cmdAdd.TabIndex = 35
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(1186, 18)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(86, 32)
        Me.cmdClose.TabIndex = 36
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.txtTempID)
        Me.Panel1.Controls.Add(Me.cmdClose1)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.cmdImg1)
        Me.Panel1.Controls.Add(Me.txtFilename)
        Me.Panel1.Controls.Add(Me.txtDescription2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAreaColerID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboProvince1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtAreaColor)
        Me.Panel1.Controls.Add(Me.chkAddMode)
        Me.Panel1.Location = New System.Drawing.Point(71, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 615)
        Me.Panel1.TabIndex = 37
        Me.Panel1.Visible = False
        '
        'txtTempID
        '
        Me.txtTempID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTempID.Location = New System.Drawing.Point(491, 61)
        Me.txtTempID.Name = "txtTempID"
        Me.txtTempID.Size = New System.Drawing.Size(190, 24)
        Me.txtTempID.TabIndex = 106
        Me.txtTempID.Visible = False
        '
        'cmdClose1
        '
        Me.cmdClose1.Location = New System.Drawing.Point(573, 567)
        Me.cmdClose1.Name = "cmdClose1"
        Me.cmdClose1.Size = New System.Drawing.Size(86, 32)
        Me.cmdClose1.TabIndex = 105
        Me.cmdClose1.Text = "Close"
        Me.cmdClose1.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(387, 567)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(86, 32)
        Me.cmdSave.TabIndex = 104
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdImg1
        '
        Me.cmdImg1.Location = New System.Drawing.Point(200, 495)
        Me.cmdImg1.Name = "cmdImg1"
        Me.cmdImg1.Size = New System.Drawing.Size(30, 32)
        Me.cmdImg1.TabIndex = 103
        Me.cmdImg1.Text = "..."
        Me.cmdImg1.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.Enabled = False
        Me.txtFilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFilename.Location = New System.Drawing.Point(236, 495)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(818, 24)
        Me.txtFilename.TabIndex = 102
        '
        'txtDescription2
        '
        Me.txtDescription2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDescription2.Location = New System.Drawing.Point(236, 151)
        Me.txtDescription2.Name = "txtDescription2"
        Me.txtDescription2.Size = New System.Drawing.Size(818, 338)
        Me.txtDescription2.TabIndex = 100
        Me.txtDescription2.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(152, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "ข้อกฏหมาย"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "เรื่อง"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(234, 121)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(820, 24)
        Me.txtDescription.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAreaColerID
        '
        Me.txtAreaColerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAreaColerID.Location = New System.Drawing.Point(234, 91)
        Me.txtAreaColerID.Name = "txtAreaColerID"
        Me.txtAreaColerID.Size = New System.Drawing.Size(251, 24)
        Me.txtAreaColerID.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "จังหวัด"
        '
        'cboProvince1
        '
        Me.cboProvince1.Enabled = False
        Me.cboProvince1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboProvince1.FormattingEnabled = True
        Me.cboProvince1.Location = New System.Drawing.Point(234, 31)
        Me.cboProvince1.Name = "cboProvince1"
        Me.cboProvince1.Size = New System.Drawing.Size(251, 24)
        Me.cboProvince1.TabIndex = 94
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(209, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 18)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "สี"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAreaColor
        '
        Me.txtAreaColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAreaColor.Location = New System.Drawing.Point(234, 61)
        Me.txtAreaColor.Name = "txtAreaColor"
        Me.txtAreaColor.Size = New System.Drawing.Size(251, 24)
        Me.txtAreaColor.TabIndex = 92
        '
        'chkAddMode
        '
        Me.chkAddMode.AutoSize = True
        Me.chkAddMode.ForeColor = System.Drawing.Color.Red
        Me.chkAddMode.Location = New System.Drawing.Point(73, 38)
        Me.chkAddMode.Name = "chkAddMode"
        Me.chkAddMode.Size = New System.Drawing.Size(72, 17)
        Me.chkAddMode.TabIndex = 91
        Me.chkAddMode.Text = "AddMode"
        Me.chkAddMode.UseVisualStyleBackColor = True
        Me.chkAddMode.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(1002, 18)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(86, 32)
        Me.cmdDelete.TabIndex = 38
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmLayoutLaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.chkNotFirstOpen)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboProvince)
        Me.Name = "frmLayoutLaw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLayoutLaw"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents chkNotFirstOpen As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAreaColor As System.Windows.Forms.TextBox
    Friend WithEvents chkAddMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAreaColerID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboProvince1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdImg1 As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose1 As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtTempID As System.Windows.Forms.TextBox
End Class
