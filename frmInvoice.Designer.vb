﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.chkMode = New System.Windows.Forms.CheckBox
        Me.lblSample = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.fg3 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.fg.Location = New System.Drawing.Point(-2, 104)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1285, 684)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "ถึงวันที่"
        '
        'dtp2
        '
        Me.dtp2.Location = New System.Drawing.Point(250, 12)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(143, 20)
        Me.dtp2.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "วันที่"
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(54, 12)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(143, 20)
        Me.dtp1.TabIndex = 64
        '
        'chkMode
        '
        Me.chkMode.AutoSize = True
        Me.chkMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkMode.Location = New System.Drawing.Point(415, 14)
        Me.chkMode.Name = "chkMode"
        Me.chkMode.Size = New System.Drawing.Size(73, 20)
        Me.chkMode.TabIndex = 63
        Me.chkMode.Text = "View all"
        Me.chkMode.UseVisualStyleBackColor = True
        '
        'lblSample
        '
        Me.lblSample.AutoSize = True
        Me.lblSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSample.Location = New System.Drawing.Point(19, 47)
        Me.lblSample.Name = "lblSample"
        Me.lblSample.Size = New System.Drawing.Size(82, 16)
        Me.lblSample.TabIndex = 68
        Me.lblSample.Text = "Example : xx"
        Me.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(513, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 30)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Performance List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'fg3
        '
        Me.fg3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fg3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg3.AutoGenerateColumns = False
        Me.fg3.AutoResize = False
        Me.fg3.ColumnInfo = resources.GetString("fg3.ColumnInfo")
        Me.fg3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fg3.Location = New System.Drawing.Point(18, 665)
        Me.fg3.Name = "fg3"
        Me.fg3.Rows.Count = 1
        Me.fg3.Rows.DefaultSize = 19
        Me.fg3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg3.Size = New System.Drawing.Size(1265, 70)
        Me.fg3.StyleInfo = resources.GetString("fg3.StyleInfo")
        Me.fg3.TabIndex = 72
        Me.fg3.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(1070, 10)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(76, 38)
        Me.cmdAdd.TabIndex = 73
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.ForeColor = System.Drawing.Color.Red
        Me.cmdDelete.Location = New System.Drawing.Point(988, 10)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(76, 38)
        Me.cmdDelete.TabIndex = 76
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(631, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 30)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Performance by Valuer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.fg3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblSample)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.chkMode)
        Me.Controls.Add(Me.fg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkMode As System.Windows.Forms.CheckBox
    Friend WithEvents lblSample As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg3 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class