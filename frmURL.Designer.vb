<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmURL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmURL))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.chkNotFirstOpen = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line0 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.AutoResize = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fg.Location = New System.Drawing.Point(-4, 63)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1285, 297)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 43
        '
        'Check1
        '
        Me.Check1.AutoSize = True
        Me.Check1.Checked = True
        Me.Check1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check1.Location = New System.Drawing.Point(296, 30)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(128, 17)
        Me.Check1.TabIndex = 44
        Me.Check1.Text = "Fillter 30 รายการล่าสุด"
        Me.Check1.UseVisualStyleBackColor = True
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Location = New System.Drawing.Point(12, 30)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(106, 17)
        Me.Option1.TabIndex = 46
        Me.Option1.TabStop = True
        Me.Option1.Text = "ดู URL ที่ Internet"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Checked = True
        Me.Option2.Location = New System.Drawing.Point(145, 30)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(130, 17)
        Me.Option2.TabIndex = 47
        Me.Option2.TabStop = True
        Me.Option2.Text = "ดู URL ที่ Local Server"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'cboAddress
        '
        Me.cboAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(2, 373)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(1112, 24)
        Me.cboAddress.TabIndex = 48
        '
        'chkNotFirstOpen
        '
        Me.chkNotFirstOpen.AutoSize = True
        Me.chkNotFirstOpen.ForeColor = System.Drawing.Color.Red
        Me.chkNotFirstOpen.Location = New System.Drawing.Point(145, 3)
        Me.chkNotFirstOpen.Name = "chkNotFirstOpen"
        Me.chkNotFirstOpen.Size = New System.Drawing.Size(94, 17)
        Me.chkNotFirstOpen.TabIndex = 49
        Me.chkNotFirstOpen.Text = "Not First Open"
        Me.chkNotFirstOpen.UseVisualStyleBackColor = True
        Me.chkNotFirstOpen.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1120, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 30)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1167, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 30)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Go"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(1176, 17)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(84, 33)
        Me.cmdAdd.TabIndex = 52
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line0, Me.Line2, Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1284, 746)
        Me.ShapeContainer1.TabIndex = 53
        Me.ShapeContainer1.TabStop = False
        '
        'Line0
        '
        Me.Line0.Name = "Line0"
        Me.Line0.Visible = False
        Me.Line0.X1 = 724
        Me.Line0.X2 = 724
        Me.Line0.Y1 = -1
        Me.Line0.Y2 = 65
        '
        'Line2
        '
        Me.Line2.Name = "Line2"
        Me.Line2.Visible = False
        Me.Line2.X1 = 782
        Me.Line2.X2 = 782
        Me.Line2.Y1 = -2
        Me.Line2.Y2 = 406
        '
        'Line1
        '
        Me.Line1.Name = "Line1"
        Me.Line1.Visible = False
        Me.Line1.X1 = 757
        Me.Line1.X2 = 757
        Me.Line1.Y1 = 0
        Me.Line1.Y2 = 371
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(486, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(488, 20)
        Me.txtSearch.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "ค้นหา"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(980, 22)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(60, 28)
        Me.cmdSearch.TabIndex = 80
        Me.cmdSearch.Text = "ค้นหา"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 403)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1037, 250)
        Me.WebBrowser1.TabIndex = 81
        '
        'frmURL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkNotFirstOpen)
        Me.Controls.Add(Me.cboAddress)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.Option1)
        Me.Controls.Add(Me.Check1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmURL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmURL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Check1 As System.Windows.Forms.CheckBox
    Friend WithEvents Option1 As System.Windows.Forms.RadioButton
    Friend WithEvents Option2 As System.Windows.Forms.RadioButton
    Friend WithEvents cboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents chkNotFirstOpen As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line0 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
