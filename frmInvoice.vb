Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmInvoice
    Dim objSecurity As New clsSecurity
    Const ZoneNo = 6
    Dim v_InvoiceID As String
    Dim objDB As New clsDB

    Private Sub frmInvoice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetSecurity()
        dtp1.Value = Today.AddDays(-90)
        dtp2.Value = Today
        'BindingCboReport()
        'chkMode2.Checked = False
        Dim strWc As String
        strWc = "Where (InvoiceDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
        Call ShowDataGrid(strWc)
    End Sub

    Private Sub SetSecurity()
        objSecurity.GetAttribute(ZoneNo)
        If objSecurity.AllowView = False Then
            MsgBox("No Authorization. Please contact database administrator", MsgBoxStyle.Exclamation)
            Application.Exit()
        End If
        If objSecurity.AllowAdd Then
            cmdAdd.Enabled = True
        Else
            cmdAdd.Enabled = False
        End If
        If objSecurity.AllowEdit Then

        Else

        End If
        If objSecurity.AllowPrint Then
            
        Else
            
        End If
        If objSecurity.AllowDelete Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If
    End Sub

    'Private Sub BindingcboReport()
    '    Dim conStr As New SqlClient.SqlConnection
    '    conStr.ConnectionString = objDB.strConn
    '    Dim strsql As String
    '    Try
    '        strsql = "Select * From vwUserAccount "
    '        strsql += "Where DivisionID = 1 "
    '        strsql += "Order by ShowName "
    '        conStr.Open()
    '        Dim myDa As New SqlDataAdapter(strsql, conStr)
    '        Dim myDs As New DataSet
    '        myDa.Fill(myDs, "vwEmpID")
    '        cboReports.DataSource = myDs.Tables("vwEmpID")
    '        cboReports.ValueMember = "UserLoginID"
    '        cboReports.DisplayMember = "ShowName"
    '        'cboEmployeeID.SelectedIndex = 1
    '        conStr.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub ShowDataGrid(ByVal wc As String)
        Dim objDB As New clsDB
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_InvoiceList "
        strsql += wc
        strsql += "Order by InvoiceDate_1 desc "
        Dim ColAll As Integer = 11
        With fg
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fg.Rows.Fixed = 1
            'fg.Styles.Alternate.BackColor = Color.LightSteelBlue
            fg.Styles.Alternate.BackColor = Color.BurlyWood
            'fg.Cols(0).DataType = GetType(Image)

            'write data
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    fg.Rows.Count = fg.Rows.Count + 1
                    For i = 0 To ColAll - 1
                        If i = 0 Then
                            fg(.Rows.Count - 1, i) = fg.Rows.Count - 1
                        Else
                            fg(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End If
                    Next i
                End While
            End If
            dr.Close()
            conStr.Close()
            lblSample.Text = "Total : " & fg.Rows.Count - 1 & " Records"

        End With


    End Sub

    

    Public Sub BindingGrid3(Optional ByVal wc As String = "")

        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_InvoiceDetail2 "
        strsql += wc
        strsql += "Order by P_ReportID desc "
        Dim ColAll As Integer = 19
        Dim DayCount As Integer
        Dim v_Max As Integer = 0
        Dim v_Fee As Integer = 0
        Dim v_OPE As Integer = 0
        Dim v_CHECK As Integer = 0
        Dim v_Net As Integer = 0
        Dim v_HeadNet As Integer = 0
        Dim v_ValuerNet As Integer = 0
        With fg3
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fg3.Rows.Fixed = 1
            'fg3.Styles.Alternate.BackColor = Color.LightSteelBlue
            'fg3.Styles.Alternate.BackColor = Color.BurlyWood
            Dim cs As C1.Win.C1FlexGrid.CellStyle
            cs = fg3.Styles.Add("Red")
            cs.ForeColor = Color.Red
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("Green")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("SuperGreen")
            cs.ForeColor = Color.Lime
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("Blue")
            cs.ForeColor = Color.Blue
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("Yellow")
            cs.ForeColor = Color.Yellow
            cs = fg3.Styles.Add("Bold")
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs.ForeColor = Color.Orange
            cs = fg3.Styles.Add("Pre_Re")
            cs.ForeColor = Color.Maroon
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("PreOnly")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            'fg3.Cols(0).DataType = GetType(Image)

            'write data
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                v_Fee = 0
                While dr.Read
                    fg3.Rows.Count = fg3.Rows.Count + 1
                    For i = 0 To ColAll - 1
                        Select Case i
                            Case 0
                                fg3(.Rows.Count - 1, i) = fg3.Rows.Count - 1
                                v_Max = fg3.Rows.Count - 1
                            Case 1
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                If CInt(dr.Item("PercentCompletion").ToString) < 100 Then
                                    If Today > CDate(dr.Item("DueDate_1")) Then 'เกินกำหนดส่ง LC
                                        fg3.SetCellStyle(.Rows.Count - 1, i, "Red")
                                    Else
                                        For DayCount = 0 To 4
                                            If Today > CDate(dr.Item("DueDate_1")).AddDays(-DayCount) Then 'เกินกำหนดส่ง LC
                                                fg3.SetCellStyle(.Rows.Count - 1, i, "Bold")
                                            End If
                                        Next
                                    End If
                                End If
                                If CInt(dr.Item("PercentCompletion").ToString) = 100 Then
                                    If CBool(dr.Item("Approve_Status")) Then
                                        fg3.SetCellStyle(.Rows.Count - 1, i, "green")
                                    Else
                                        fg3.SetCellStyle(.Rows.Count - 1, i, "SuperGreen")
                                    End If
                                End If
                            Case 4
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                Select Case dr.Item("Present").ToString
                                    Case "Pre + Re"
                                        fg3.SetCellStyle(.Rows.Count - 1, i, "Pre_Re")
                                    Case "Pre Only"
                                        fg3.SetCellStyle(.Rows.Count - 1, i, "PreOnly")
                                    Case "Report"
                                        fg3.SetCellStyle(.Rows.Count - 1, i, "Blue")
                                End Select
                            Case 11
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_Fee = v_Fee + CInt(dr.GetValue(i - 1))
                            Case 12
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_OPE = v_OPE + CInt(dr.GetValue(i - 1))
                            Case 13
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_CHECK = v_CHECK + CInt(dr.GetValue(i - 1))
                            Case 14
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_Net = v_Net + CInt(dr.GetValue(i - 1))
                            Case 16
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_HeadNet = v_HeadNet + CInt(dr.GetValue(i - 1))
                            Case 18
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_ValuerNet = v_ValuerNet + CInt(dr.GetValue(i - 1))
                            Case Else
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End Select
                    Next i
                End While
                fg3.Rows.Count = fg3.Rows.Count + 1
                fg3(.Rows.Count - 1, 9) = "Sum"
                fg3(.Rows.Count - 1, 11) = v_Fee
                fg3(.Rows.Count - 1, 12) = v_OPE
                fg3(.Rows.Count - 1, 13) = v_CHECK
                fg3(.Rows.Count - 1, 14) = v_Net
                fg3(.Rows.Count - 1, 16) = v_HeadNet
                fg3(.Rows.Count - 1, 18) = v_ValuerNet

                fg3.Rows.Count = fg3.Rows.Count + 1
                fg3(.Rows.Count - 1, 9) = "AVG"
                fg3(.Rows.Count - 1, 11) = v_Fee / v_Max
                fg3(.Rows.Count - 1, 12) = v_OPE / v_Max
                fg3(.Rows.Count - 1, 13) = v_CHECK / v_Max
                fg3(.Rows.Count - 1, 14) = v_Net / v_Max
                fg3(.Rows.Count - 1, 16) = v_HeadNet / v_Max
                fg3(.Rows.Count - 1, 18) = v_ValuerNet / v_Max

            End If
            dr.Close()
            conStr.Close()
            lblSample.Text = "Total : " & fg3.Rows.Count - 1 & " Records"

        End With


    End Sub

    Private Sub chkMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMode.CheckedChanged
        If chkMode.Checked Then
            Call ShowDataGrid("")
        Else
            Dim strWc As String
            strWc = "Where (InvoiceDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            Call ShowDataGrid(strWc)
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        If fg.Rows.Count > 1 Then
            v_InvoiceID = fg(fg.Row, 1).ToString
        Else
            v_InvoiceID = ""
        End If
    End Sub

 

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingGrid3()
        Exportfg("Performance", fg3)
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmEditInvoice.v_FormMode = "Add"
        frmEditInvoice.ShowDialog()
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        If fg.Rows.Count > 1 Then
            v_InvoiceID = fg(fg.Row, 1).ToString
            frmEditInvoice.v_InvoiceID = v_InvoiceID
            frmEditInvoice.v_FormMode = "Edit"
            frmEditInvoice.ShowDialog()
        End If
    End Sub

    Private Sub fg_RowColChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.RowColChange
       
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If fg.Rows.Count > 1 Then
                Dim strsql As String
                If MsgBox("Do you want to delete Report = '" & fg(fg.Row, 1) & "' ", MsgBoxStyle.YesNo, "Confirm delete") = MsgBoxResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    strsql = "Delete from Invoice "
                    strsql += "WHERE (InvoiceID = '" & v_InvoiceID & "') "
                    objDB.ExecuteNonQuery(strsql)
                    strsql = "Delete from InvoiceDetail "
                    strsql += "WHERE (InvoiceID = '" & v_InvoiceID & "') "
                    objDB.ExecuteNonQuery(strsql)
                    Dim strWc As String
                    strWc = "Where (InvoiceDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
                    Call ShowDataGrid(strWc)
                    Cursor = Cursors.Default
                    MsgBox("Delete completed")

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Performance2ToExcel()
        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Dim conStr As New SqlClient.SqlConnection
            conStr.ConnectionString = objDB.strConn
            Dim strsql As String
            Dim i, j As Integer

            Dim appExcel As Excel.Application
            Dim wbkReport As Excel.Workbook
            Dim wksReport As Excel.Worksheet
            appExcel = New Excel.Application
            appExcel.Visible = False
            wbkReport = appExcel.Workbooks.Add
            wksReport = wbkReport.Worksheets(1)
            'set header
            wksReport.Cells.Font.Name = "Angsana New"
            wksReport.Cells.Font.Size = 16
            wksReport.Cells(1, 1).Font.Bold = True
            wksReport.Cells(1, 1).Value = "Summary of Performance as of " & Format(Today, "dd-MMM-yy")
            For i = 1 To 7
                wksReport.Cells(2, i).Font.Bold = True
                'wksReport.Cells(2, i).Font.Color = RGB(0, 64, 128)
                'wksReport.Cells(2, i).Interior.Color = RGB(0, 128, 255)
                wksReport.Cells(2, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                wksReport.Cells(2, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                wksReport.Cells(2, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                Select Case i
                    Case 1
                        wksReport.Cells(2, i).ColumnWidth = 25
                        wksReport.Cells(2, i).Value = "Valuer"
                    Case 2
                        wksReport.Cells(2, i).ColumnWidth = 10
                        wksReport.Cells(2, i).Value = "S"
                    Case 3
                        wksReport.Cells(2, i).ColumnWidth = 10
                        wksReport.Cells(2, i).Value = "M"
                    Case 4
                        wksReport.Cells(2, i).ColumnWidth = 10
                        wksReport.Cells(2, i).Value = "L"
                    Case 5
                        wksReport.Cells(2, i).ColumnWidth = 10
                        wksReport.Cells(2, i).Value = "XL"
                    Case 6
                        wksReport.Cells(2, i).ColumnWidth = 10
                        wksReport.Cells(2, i).Value = "Total Job"
                    Case 7
                        wksReport.Cells(2, i).ColumnWidth = 20
                        wksReport.Cells(2, i).Value = "Performance (Baht)"
                End Select
            Next
            strsql = "Select * from vwCountPerformance "
            'strsql += "Where (P_ReportDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            Dim Valuer As String = ""
            Dim SumS As Integer = 0
            Dim SumM As Integer = 0
            Dim SumL As Integer = 0
            Dim SumXL As Integer = 0

            If dr.HasRows Then
                j = 2
                While dr.Read
                    If Valuer <> dr.Item("Valuer").ToString Then
                        Valuer = dr.Item("Valuer").ToString
                        SumS = 0
                        SumM = 0
                        SumL = 0
                        SumXL = 0
                        j = j + 1
                    End If
                    'put valuer
                    wksReport.Cells(j, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    wksReport.Cells(j, 1).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                    wksReport.Cells(j, 1).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                    wksReport.Cells(j, 1).Value = dr.Item("Valuer").ToString
                    'put price
                    wksReport.Cells(j, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    wksReport.Cells(j, 7).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                    wksReport.Cells(j, 7).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                    wksReport.Cells(j, 7).Value = Format(CInt(dr.Item("SumPrice").ToString), "#,##0")
                    'put job size
                    For i = 2 To 5
                        wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                    Next i
                    
                    Select Case dr.Item("JobSize").ToString
                        Case "S"
                            wksReport.Cells(j, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 2).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 2).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                            wksReport.Cells(j, 2).Value = dr.Item("CountSize").ToString
                            SumS = CInt(dr.Item("CountSize").ToString)
                        Case "M"
                            wksReport.Cells(j, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 3).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 3).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                            wksReport.Cells(j, 3).Value = dr.Item("CountSize").ToString
                            SumM = CInt(dr.Item("CountSize").ToString)
                        Case "L"
                            wksReport.Cells(j, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 4).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 4).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                            wksReport.Cells(j, 4).Value = dr.Item("CountSize").ToString
                            SumL = CInt(dr.Item("CountSize").ToString)
                        Case "XL"
                            wksReport.Cells(j, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 5).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                            wksReport.Cells(j, 5).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                            wksReport.Cells(j, 5).Value = dr.Item("CountSize").ToString
                            SumXL = CInt(dr.Item("CountSize").ToString)
                    End Select
                    'put sum count
                    wksReport.Cells(j, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    wksReport.Cells(j, 6).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                    wksReport.Cells(j, 6).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                    wksReport.Cells(j, 6).Value = Format(SumS + SumM + SumL + SumXL, "#,##0")
                End While
            End If
            dr.Close()
            conStr.Close()


            Dim fn As String
            Dim objFC As New clsFileControl
            'Check folder
            '    MkDirExist(FolderSave)
            objFC.MkDirExist(FolderSave)
            fn = "PerformanceByValuer" & Today.Day & "_" & Today.Month & "_" & Today.Year
            If File.Exists(FolderSave & fn & ".xlsx") Then
                'del file
                Kill(FolderSave & fn & ".xlsx")
            End If
            appExcel.ActiveWorkbook.SaveAs(FolderSave & fn)
            appExcel.Visible = True
            wksReport = Nothing
            wbkReport = Nothing
            appExcel = Nothing

            'Dim proc As System.Diagnostics.Process
            'For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            '    proc.Kill()
            'Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Performance2ToExcel()
    End Sub

End Class