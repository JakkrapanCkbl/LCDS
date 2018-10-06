
Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO



Public Class frmMain

    Dim objDB As New clsDB
    Dim objTools As New clsTools
    Dim WC As String = ""

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        Me.Text = v_UserName
        dtp1.Value = Today.AddDays(-40)
        dtp2.Value = Today
        txtSort.Text = ""
        BindingcboEmployeeID()
        If (v_UserLevel = 1) Or (v_UserLevel = 2) Then
            SetCriteria2Grid()
        Else
            WC = "Where (P_ReportDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            If cboType.Text <> "ALL" Then
                WC += "And (ProjectType = '" & cboType.Text & "') "
            End If

            WC += "And (LandStaff = '" & v_UserName & "' "
            WC += "OR Appraisor1 = '" & v_UserName & "') "

            If (cboStatus.Text = "Cancel") Or (cboStatus.Text = "Hold") Then
                If cboStatus.Text = "Cancel" Then
                    WC += "AND (JobStatus  = 'Cancel') "
                End If
                If cboStatus.Text = "Hold" Then
                    WC += "AND (JobStatus = 'Hold') "
                End If
            Else
                WC += "AND (JobStatus  = '') "
            End If
            Select Case cboStatus.Text
                Case "งานที่ยังไม่เสร็จ"
                    WC += "AND (PercentCompletion < 100) "
                    'vsfGrid.ColHidden(8) = True
                Case ""
                    WC += "AND (PercentCompletion < 100) "
                    'vsfGrid.ColHidden(8) = True
                Case "งานที่เสร็จแล้ว"
                    WC += " AND (PercentCompletion >= 100) "
                    'vsfGrid.ColHidden(8) = False
                Case "งานเสร็จสมบูรณ์"
                    WC += "AND (Approve_Status = 1) "
            End Select

            ShowGrid(WC)
        End If

        chkFirstOpen.Checked = False
    End Sub

    Private Sub SetCriteria2Grid()
        Try
            If ComboBox1.SelectedIndex = 3 Then
                Dim TempYearMont As String = dtp2.Value.Year & Format(dtp2.Value.Month, "00")
                Dim TempYearMont2 As String
                TempYearMont2 = dtp2.Value.Year & Format((dtp2.Value.Month + (1)), "00")
                'WC = "Where (FinishDay = '" & TempYearMont & "') "
                WC = "Where (FinishDay Between '" & TempYearMont & "' and '" & TempYearMont2 & "') "
            Else
                WC = "Where (P_ReportDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            End If
            'WC = "Where (P_ReportDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            If cboType.Text <> "ALL" Then
                WC += "And (ProjectType = '" & cboType.Text & "') "
            End If
            If cboEmployeeID.Text = "" Then
                'nothing
            ElseIf cboEmployeeID.Text = " " Then
                'nothing
            ElseIf cboEmployeeID.Text = "  " Then
                'nothing
            ElseIf cboEmployeeID.Text = "All" Then
                'nothing
            Else
                WC += "And (LandStaff = '" & cboEmployeeID.Text & "' "
                WC += "OR Appraisor1 = '" & cboEmployeeID.Text & "') "
            End If
            If ComboBox1.SelectedIndex = 2 Then
                WC += "AND (JobStatus  = '') "
            ElseIf ComboBox1.SelectedIndex = 4 Then
                WC += "AND (JobStatus  = '') "
            Else
                If (cboStatus.Text = "Cancel") Or (cboStatus.Text = "Hold") Then
                    If cboStatus.Text = "Cancel" Then
                        WC += "AND (JobStatus  = 'Cancel') "
                    End If
                    If cboStatus.Text = "Hold" Then
                        WC += "AND (JobStatus = 'Hold') "
                    End If
                Else
                    WC += "AND (JobStatus  = '') "
                End If
            End If

            If ComboBox1.SelectedIndex = 2 Then
                WC += "AND (PercentCompletion >= 100) "
                WC += "AND (WaitCheck =  1) "
            ElseIf ComboBox1.SelectedIndex = 4 Then
                WC += "AND ((PercentCompletion < 100) or (WaitCheck = 1)) "
            Else
                Select Case cboStatus.Text
                    Case "งานที่ยังไม่เสร็จ"
                        WC += "AND (PercentCompletion < 100) "
                        'vsfGrid.ColHidden(8) = True
                    Case ""
                        WC += "AND (PercentCompletion < 100) "
                        'vsfGrid.ColHidden(8) = True
                    Case "งานที่เสร็จแล้ว"
                        WC += " AND (PercentCompletion >= 100) "
                        'vsfGrid.ColHidden(8) = False
                    Case "งานเสร็จสมบูรณ์"
                        WC += "AND (Approve_Status = 1) "
                End Select
            End If

            If chkAdvance.Checked Then
                If cboPropType.Text <> "" Then
                    WC += "AND (ShowPropType like '%" & cboPropType.Text & "%') "
                End If
                If cboReportCus.Text <> "" Then
                    WC += "AND (ReportCus like '%" & cboReportCus.Text & "%') "
                End If

            End If

            ShowGrid(WC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub


    Private Sub BindingcboEmployeeID()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            'strsql = "Select * From vwUserAccount "
            'strsql += "Where DivisionID = 1 "
            'strsql += "Order by ShowName "
            strsql = "Select EmployeeID,ShowName from  vwShowEmpName where DivisionID = 1 Order by EmployeeID "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwEmpID")
            cboEmployeeID.DataSource = myDs.Tables("vwEmpID")
            cboEmployeeID.ValueMember = "EmployeeID"
            cboEmployeeID.DisplayMember = "ShowName"
            cboEmployeeID.SelectedIndex = 0
            cboEmployeeID.Text = "All"
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboReportCus()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select * From vwShowReportCus "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwReportCus")
            cboReportCus.DataSource = myDs.Tables("vwReportCus")
            cboReportCus.ValueMember = "ReportCus"
            cboReportCus.DisplayMember = "ReportCus"
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboPropType()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select * From vwShowPropType "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwPropType")
            cboPropType.DataSource = myDs.Tables("vwPropType")
            cboPropType.ValueMember = "ShowPropType"
            cboPropType.DisplayMember = "ShowPropType"
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ShowDataGrid(ByVal wc As String)

        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_TaskList "
        strsql += wc
        strsql += "Order by P_ReportID desc "
        Dim ColAll As Integer = 19
        Dim DayCount As Integer
        With fg
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fg.Rows.Fixed = 1
            fg.Styles.Alternate.BackColor = Color.LightSteelBlue
            'fg.Styles.Alternate.BackColor = Color.BurlyWood
            Dim cs As C1.Win.C1FlexGrid.CellStyle
            cs = fg.Styles.Add("Red")
            cs.ForeColor = Color.Red
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("Green")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("SuperGreen")
            cs.ForeColor = Color.Lime
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("Blue")
            cs.ForeColor = Color.Blue
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("Yellow")
            cs.ForeColor = Color.Yellow
            cs = fg.Styles.Add("Bold")
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs.ForeColor = Color.Orange
            cs = fg.Styles.Add("Pre_Re")
            cs.ForeColor = Color.Maroon
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("PreOnly")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            'fg.Cols(0).DataType = GetType(Image)

            'write data
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    fg.Rows.Count = fg.Rows.Count + 1
                    For i = 0 To ColAll - 1
                        Select Case i
                            Case 0
                                fg(.Rows.Count - 1, i) = fg.Rows.Count - 1
                            Case 1
                                fg(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                If CInt(dr.Item("PercentCompletion").ToString) < 100 Then
                                    If Today > CDate(dr.Item("DueDate_1")) Then 'เกินกำหนดส่ง LC
                                        fg.SetCellStyle(.Rows.Count - 1, i, "Red")
                                    Else
                                        For DayCount = 0 To 4
                                            If Today > CDate(dr.Item("DueDate_1")).AddDays(-DayCount) Then 'เกินกำหนดส่ง LC
                                                fg.SetCellStyle(.Rows.Count - 1, i, "Bold")
                                            End If
                                        Next
                                    End If
                                End If
                                If CInt(dr.Item("PercentCompletion").ToString) = 100 Then
                                    If CBool(dr.Item("Approve_Status")) Then
                                        fg.SetCellStyle(.Rows.Count - 1, i, "green")
                                    Else
                                        fg.SetCellStyle(.Rows.Count - 1, i, "SuperGreen")
                                    End If
                                End If
                            Case 4
                                fg(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                Select Case dr.Item("Present").ToString
                                    Case "Pre + Re"
                                        fg.SetCellStyle(.Rows.Count - 1, i, "Pre_Re")
                                    Case "Pre Only"
                                        fg.SetCellStyle(.Rows.Count - 1, i, "PreOnly")
                                    Case "Report"
                                        fg.SetCellStyle(.Rows.Count - 1, i, "Blue")
                                End Select
                            Case 11, 12, 15 'LC Duedate
                                fg(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg.SetCellStyle(.Rows.Count - 1, i, "Blue")
                            Case 18 'duedate
                                fg(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg.SetCellStyle(.Rows.Count - 1, i, "Red")
                            Case Else
                                fg(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End Select
                        
                    Next i
                End While
            End If
            dr.Close()
            conStr.Close()
            lblSample.Text = "Total : " & fg.Rows.Count - 1 & " Records"

        End With


    End Sub

    Private Sub ExportToExcel()
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
            wksReport.Cells.Font.Size = 15
            For i = 1 To 17
                wksReport.Cells(1, i).Font.Bold = True
                wksReport.Cells(1, i).Font.Color = RGB(0, 64, 128)
                wksReport.Cells(1, i).Interior.Color = RGB(0, 128, 255)
                wksReport.Cells(1, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                wksReport.Cells(1, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                wksReport.Cells(1, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                Select Case i
                    Case 1
                        wksReport.Cells(1, i).ColumnWidth = 5
                        wksReport.Cells(1, i).Value = "ลำดับ"
                    Case 2
                        wksReport.Cells(1, i).ColumnWidth = 13
                        wksReport.Cells(1, i).Value = "รหัสรายงาน"
                    Case 3
                        wksReport.Cells(1, i).ColumnWidth = 8
                        wksReport.Cells(1, i).Value = "ID"
                    Case 4
                        wksReport.Cells(1, i).ColumnWidth = 10
                        wksReport.Cells(1, i).Value = "Type"
                    Case 5
                        wksReport.Cells(1, i).ColumnWidth = 15
                        wksReport.Cells(1, i).Value = "Head"
                    Case 6
                        wksReport.Cells(1, i).ColumnWidth = 15
                        wksReport.Cells(1, i).Value = "Valuer"
                    Case 7
                        wksReport.Cells(1, i).ColumnWidth = 25
                        wksReport.Cells(1, i).Value = "ผู้ว่าจ้าง"
                    Case 8
                        wksReport.Cells(1, i).ColumnWidth = 25
                        wksReport.Cells(1, i).Value = "ชื่อลูกค้า"
                    Case 9
                        wksReport.Cells(1, i).ColumnWidth = 25
                        wksReport.Cells(1, i).Value = "ประเภททรัพย์สิน"
                    Case 10
                        wksReport.Cells(1, i).ColumnWidth = 90
                        wksReport.Cells(1, i).Value = "ทำเลที่ตั้ง"
                    Case 11
                        wksReport.Cells(1, i).ColumnWidth = 10
                        wksReport.Cells(1, i).Value = "%งานเสร็จ"
                    Case 12
                        wksReport.Cells(1, i).ColumnWidth = 22
                        wksReport.Cells(1, i).Value = "วันที่รับงาน"
                    Case 13
                        wksReport.Cells(1, i).ColumnWidth = 22
                        wksReport.Cells(1, i).Value = "วันที่สำรวจ"
                    Case 14
                        wksReport.Cells(1, i).ColumnWidth = 22
                        wksReport.Cells(1, i).Value = "วันที่กำหนดส่งรายงาน"
                    Case 15
                        wksReport.Cells(1, i).ColumnWidth = 22
                        wksReport.Cells(1, i).Value = "วันที่คาดว่าจะแล้วเสร็จ"
                    Case 16
                        wksReport.Cells(1, i).ColumnWidth = 22
                        wksReport.Cells(1, i).Value = "วันที่กำหนดส่ง LC"
                    Case 17
                        wksReport.Cells(1, i).ColumnWidth = 25
                        wksReport.Cells(1, i).Value = "หมายเหตุ"
                        'Case 18
                        '    wksReport.Cells(1, i).ColumnWidth = 25
                        '    wksReport.Cells(1, i).Value = "ผู้ว่าจ้าง"
                End Select
            Next
            strsql = "Select * from vwDayExcelReport2 "
            strsql += "Where (P_ReportDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            'strsql = strsql & "Where P_ReportDate Between " & StartDate & " AND " & EndDate & " "
            'If Status = 1 Then
            strsql += "AND (PercentCompletion <100) "
            strsql += "AND (JobStatus  = '') "
            'ElseIf Status = 2 Then
            '    strsql = strsql & "AND PercentCompletion >=100 "
            'End If
            Select Case txtSort.Text
                Case "5A"
                    strsql = strsql & "Order by SendReportTo "
                Case "5D"
                    strsql = strsql & "Order by SendReportTo Desc "
                Case "11A"
                    strsql = strsql & "Order by DueDate1_1 "
                Case "11D"
                    strsql = strsql & "Order by DueDate1_1 Desc "
                Case "18A"
                    strsql = strsql & "Order by DueDate_1 "
                Case "18D"
                    strsql = strsql & "Order by DueDate_1 Desc "
                Case "13A"
                    strsql = strsql & "Order by LandStaff "
                Case "13D"
                    strsql = strsql & "Order by LandStaff Desc "
                Case "14A"
                    strsql = strsql & "Order by Appraisor1 "
                Case "14D"
                    strsql = strsql & "Order by Appraisor1 Desc "
            End Select
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                j = 2
                While dr.Read
                    For i = 1 To 17 'collumn
                        Select Case i
                            Case 1
                                wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                wksReport.Cells(j, i).Value = j - 1
                            Case 2, 3
                                wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                            Case 4
                                wksReport.Cells(j, i).Font.Bold = True
                                Select Case dr.Item(i - 2) & ""
                                    Case "Report"
                                        wksReport.Cells(j, i).Font.Color = RGB(0, 64, 128)
                                    Case "Pre + Re"
                                        wksReport.Cells(j, i).Font.Color = RGB(150, 0, 0)
                                    Case "Pre Only"
                                        wksReport.Cells(j, i).Font.Color = RGB(0, 150, 0)
                                    Case Else
                                        wksReport.Cells(j, i).Font.Color = RGB(0, 0, 0)
                                End Select
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                            Case 5
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                'wksReport.Cells(j, i).Value = GetEmployee(rs.Fields("LandStaff") & "")
                                'wksReport.Cells(j, i).Value = rs.Fields("Head") & ""
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                            Case 6
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                'wksReport.Cells(j, i).Value = GetEmployee(rs.Fields("Appraisor1") & "")
                                'wksReport.Cells(j, i).Value = rs.Fields("Appraisor") & ""
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                            Case 8
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                'wksReport.Cells(j, i).Value = GetReportPropertyType(rs.Fields("ProposalID") & "")
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                            Case 9
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                'wksReport.Cells(j, i).Value = GetReportPropertyAddress(rs.Fields("ProposalID") & "")
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                            Case 10
                                'wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                'wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                            Case 11
                                wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                'wksReport.Cells(j, i).Value = GetReportPropertyAddress(rs.Fields("ProposalID") & "")
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString & " (%)"
                            Case 12, 13, 14, 15, 16
                                wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                wksReport.Cells(j, i).Value = Format(CDate(dr.Item(i - 2).ToString), "dd-MMM-yy")
                            Case Else
                                wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                                wksReport.Cells(j, i).Value = dr.Item(i - 2).ToString
                        End Select
                    Next i
                    j = j + 1
                End While
            End If
            dr.Close()
            conStr.Close()

           
            Dim fn As String
            Dim objFC As New clsFileControl
            'Check folder
            '    MkDirExist(FolderSave)
            objFC.MkDirExist(FolderSave)
            fn = "WorkInProgress" & Today.Day & "_" & Today.Month & "_" & Today.Year
            If File.Exists(FolderSave & fn & ".xls") Then
                'del file
                Kill(FolderSave & fn & ".xls")
            End If
            appExcel.ActiveWorkbook.SaveAs(FolderSave & fn)
            appExcel.Visible = True
            wksReport = Nothing
            appExcel = Nothing


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub ExportToExcel(ByVal StartDate As String, ByVal EndDate As String, ByVal Status As Byte)
    '    Dim objDB As New clsDB
    '    Dim rs As New ADODB.Recordset
    '    Dim strsql As String
    '    Dim i As Integer, j As Integer
    '    Dim appExcel As Excel.Application
    '    Dim wbkReport As Excel.Workbook
    '    Dim wksReport As Excel.Worksheet
    '    appExcel = New Excel.Application
    '    appExcel.Visible = False
    '    wbkReport = appExcel.Workbooks.Add
    '    wksReport = wbkReport.Worksheets(1)

    '    'set header
    '    wksReport.Cells.Font.Name = "Angsana New"
    '    wksReport.Cells.Font.Size = 15
    '    For i = 1 To 17
    '        wksReport.Cells(1, i).Font.Bold = True
    '        wksReport.Cells(1, i).Font.Color = RGB(0, 64, 128)
    '        wksReport.Cells(1, i).Interior.Color = RGB(0, 128, 255)
    '        wksReport.Cells(1, i).HorizontalAlignment()
    '        wksReport.Cells(1, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
    '        wksReport.Cells(1, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '        Select Case i
    '            Case 1
    '                wksReport.Cells(1, i).ColumnWidth = 5
    '                wksReport.Cells(1, i).Value = "ลำดับ"
    '            Case 2
    '                wksReport.Cells(1, i).ColumnWidth = 13
    '                wksReport.Cells(1, i).Value = "รหัสรายงาน"
    '            Case 3
    '                wksReport.Cells(1, i).ColumnWidth = 8
    '                wksReport.Cells(1, i).Value = "ID"
    '            Case 4
    '                wksReport.Cells(1, i).ColumnWidth = 10
    '                wksReport.Cells(1, i).Value = "Type"
    '            Case 5
    '                wksReport.Cells(1, i).ColumnWidth = 15
    '                wksReport.Cells(1, i).Value = "Head"
    '            Case 6
    '                wksReport.Cells(1, i).ColumnWidth = 15
    '                wksReport.Cells(1, i).Value = "Valuer"
    '            Case 7
    '                wksReport.Cells(1, i).ColumnWidth = 25
    '                wksReport.Cells(1, i).Value = "ชื่อลูกค้า"
    '            Case 8
    '                wksReport.Cells(1, i).ColumnWidth = 25
    '                wksReport.Cells(1, i).Value = "ประเภททรัพย์สิน"
    '            Case 9
    '                wksReport.Cells(1, i).ColumnWidth = 90
    '                wksReport.Cells(1, i).Value = "ทำเลที่ตั้ง"
    '            Case 10
    '                wksReport.Cells(1, i).ColumnWidth = 10
    '                wksReport.Cells(1, i).Value = "%งานเสร็จ"
    '            Case 11
    '                wksReport.Cells(1, i).ColumnWidth = 22
    '                wksReport.Cells(1, i).Value = "วันที่รับงาน"
    '            Case 12
    '                wksReport.Cells(1, i).ColumnWidth = 22
    '                wksReport.Cells(1, i).Value = "วันที่สำรวจ"
    '            Case 13
    '                wksReport.Cells(1, i).ColumnWidth = 22
    '                wksReport.Cells(1, i).Value = "วันที่กำหนดส่งรายงาน"
    '            Case 14
    '                wksReport.Cells(1, i).ColumnWidth = 22
    '                wksReport.Cells(1, i).Value = "วันที่คาดว่าจะแล้วเสร็จ"
    '            Case 15
    '                wksReport.Cells(1, i).ColumnWidth = 22
    '                wksReport.Cells(1, i).Value = "วันที่กำหนดส่ง LC"
    '            Case 16
    '                wksReport.Cells(1, i).ColumnWidth = 25
    '                wksReport.Cells(1, i).Value = "หมายเหตุ"
    '            Case 17
    '                wksReport.Cells(1, i).ColumnWidth = 25
    '                wksReport.Cells(1, i).Value = "ผู้ว่าจ้าง"
    '        End Select
    '    Next

    '    strsql = "Select * from vwDayExcelReport "
    '    strsql = strsql & "Where P_ReportDate Between " & StartDate & " AND " & EndDate & " "
    '    If Status = 1 Then
    '        strsql = strsql & "AND PercentCompletion <100 "
    '    ElseIf Status = 2 Then
    '        strsql = strsql & "AND PercentCompletion >=100 "
    '    End If
    '    'Select Case Text1.Text
    '    '    Case "6A"
    '    '        strsql = strsql & "Order by CustomerT "
    '    '    Case "6D"
    '    '        strsql = strsql & "Order by CustomerT Desc "
    '    '    Case "14A"
    '    '        strsql = strsql & "Order by DueDate1 "
    '    '    Case "14D"
    '    '        strsql = strsql & "Order by DueDate1 Desc "
    '    '    Case "22A"
    '    '        strsql = strsql & "Order by DueDate "
    '    '    Case "22D"
    '    '        strsql = strsql & "Order by DueDate Desc "
    '    '    Case "16A"
    '    '        strsql = strsql & "Order by Head "
    '    '    Case "16D"
    '    '        strsql = strsql & "Order by Head Desc "
    '    '    Case "17A"
    '    '        strsql = strsql & "Order by Appraisor "
    '    '    Case "17D"
    '    '        strsql = strsql & "Order by Appraisor Desc "
    '    'End Select

    '    rs.Open(strsql, objDB.strConn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
    '    If Not rs.EOF Then
    '        j = 2 'Row
    '        rs.MoveFirst()
    '        While Not rs.EOF
    '            For i = 1 To 17 'collumn
    '                Select Case i
    '                    Case 1
    '                        wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = j - 1
    '                    Case 2, 3
    '                        wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = rs.Fields(i - 2).ToString
    '                    Case 4
    '                        wksReport.Cells(j, i).Font.Bold = True
    '                        Select Case rs.Fields(i - 2).ToString
    '                            Case "Report"
    '                                wksReport.Cells(j, i).Font.Color = RGB(0, 64, 128)
    '                            Case "Pre + Re"
    '                                wksReport.Cells(j, i).Font.Color = RGB(150, 0, 0)
    '                            Case "Pre Only"
    '                                wksReport.Cells(j, i).Font.Color = RGB(0, 150, 0)
    '                            Case Else
    '                                wksReport.Cells(j, i).Font.Color = RGB(0, 0, 0)
    '                        End Select
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = rs.Fields(i - 2).ToString
    '                    Case 5
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        'wksReport.Cells(j, i).Value = GetEmployee(rs.Fields("LandStaff") & "")
    '                        wksReport.Cells(j, i).Value = rs.Fields(i - 2).ToString
    '                    Case 6
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        'wksReport.Cells(j, i).Value = GetEmployee(rs.Fields("Appraisor1") & "")
    '                        wksReport.Cells(j, i).Value = rs.Fields(i - 2).ToString
    '                    Case 8
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = GetReportPropertyType(rs.Fields("ProposalID") & "")
    '                    Case 9
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = GetReportPropertyAddress(rs.Fields("ProposalID") & "")
    '                    Case 10
    '                        wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = rs.Fields(i - 2).ToString & " (%)"
    '                    Case 11, 12, 13, 14, 15
    '                        wksReport.Cells(j, i).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = ChangeToViewDate(rs.Fields(i - 2)) & ""
    '                    Case Else
    '                        wksReport.Cells(j, i).BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
    '                        wksReport.Cells(j, i).Value = rs.Fields(i - 2).ToString & ""
    '                End Select
    '            Next
    '            j = j + 1
    '            rs.MoveNext()
    '        End While

    '    End If
    '    rs.Close()
    '    rs = Nothing
    '    Dim fn As String
    '    'Check folder
    '    MkDirExist(FolderSave)
    '    fn = "WorkInProgress" & Day(Of Date)() & "_" & Month(Of Date)() & "_" & Year(Of Date)()
    '    If FileExistX(FolderSave & fn & ".xls") Then
    '        'del file
    '        Kill(FolderSave & fn & ".xls")
    '    End If
    '    appExcel.ActiveWorkbook.SaveAs(FolderSave & fn)
    '    appExcel.Visible = True
    '    wksReport = Nothing
    '    appExcel = Nothing
    'End Sub

    Public Sub ShowDataGrid2(ByVal wc As String)

        Dim conStr As New SqlClient.SqlConnection
        Dim TargetDay As Integer
        Dim WorkDay As Integer
        Dim CountDay As Integer = 0
        Dim OverDay As Integer = 0

        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_Popup2 "
        strsql += wc
        strsql += "Order by P_ReportID "
        Dim ColAll As Integer = 21
        Dim DayCount As Integer
        With fg2
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fg2.Rows.Fixed = 1
            fg2.Styles.Alternate.BackColor = Color.LightSteelBlue
            'fg2.Styles.Alternate.BackColor = Color.BurlyWood
            Dim cs As C1.Win.C1FlexGrid.CellStyle
            cs = fg2.Styles.Add("Red")
            cs.ForeColor = Color.Red
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg2.Styles.Add("Orange")
            cs.ForeColor = Color.Orange
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg2.Styles.Add("Green")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg2.Styles.Add("SuperGreen")
            cs.ForeColor = Color.Lime
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg2.Styles.Add("Blue")
            cs.ForeColor = Color.Blue
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg2.Styles.Add("Yellow")
            cs.ForeColor = Color.Yellow
            cs = fg2.Styles.Add("Bold")
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs.ForeColor = Color.Orange
            cs = fg2.Styles.Add("Pre_Re")
            cs.ForeColor = Color.Maroon
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg2.Styles.Add("PreOnly")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            'fg2.Cols(0).DataType = GetType(Image)

            'write data
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    fg2.Rows.Count = fg2.Rows.Count + 1
                    TargetDay = (DateDiff(DateInterval.Day, CDate(dr.Item("StartDate_1").ToString), CDate(dr.Item("DueDate_1").ToString)))
                    WorkDay = (DateDiff(DateInterval.Day, CDate(dr.Item("StartDate_1").ToString), Today))
                    If TargetDay > WorkDay Then
                        CountDay = TargetDay - WorkDay
                        OverDay = 0
                    Else
                        CountDay = 0
                        OverDay = WorkDay - TargetDay
                    End If
                    'CountDay = DateDiff(DateInterval.Day, CDate(dr.Item("DueDate_1").ToString), Today)
                    For i = 0 To ColAll - 1
                        Select Case i
                            Case 0
                                fg2(.Rows.Count - 1, i) = fg2.Rows.Count - 1
                            Case 1
                                fg2(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                If CInt(dr.Item("PercentCompletion").ToString) < 100 Then
                                    If Today > CDate(dr.Item("DueDate_1")) Then 'เกินกำหนดส่ง LC
                                        fg2.SetCellStyle(.Rows.Count - 1, i, "Red")
                                    Else
                                        For DayCount = 0 To 4
                                            If Today > CDate(dr.Item("DueDate_1")).AddDays(-DayCount) Then 'เกินกำหนดส่ง LC
                                                fg2.SetCellStyle(.Rows.Count - 1, i, "Bold")
                                            End If
                                        Next
                                    End If
                                End If
                                If CInt(dr.Item("PercentCompletion").ToString) = 100 Then
                                    If CBool(dr.Item("Approve_Status")) Then
                                        fg2.SetCellStyle(.Rows.Count - 1, i, "green")
                                    Else
                                        fg2.SetCellStyle(.Rows.Count - 1, i, "SuperGreen")
                                    End If
                                End If
                            Case 4
                                fg2(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                Select Case dr.Item("Present").ToString
                                    Case "Pre + Re"
                                        fg2.SetCellStyle(.Rows.Count - 1, i, "Pre_Re")
                                    Case "Pre Only"
                                        fg2.SetCellStyle(.Rows.Count - 1, i, "PreOnly")
                                    Case "Report"
                                        fg2.SetCellStyle(.Rows.Count - 1, i, "Blue")
                                End Select
                            Case 11, 12, 13, 14 'LC Duedate
                                fg2(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg2.SetCellStyle(.Rows.Count - 1, i, "Blue")
                            Case 15 'duedate
                                fg2(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg2.SetCellStyle(.Rows.Count - 1, i, "Red")
                            Case 18
                                fg2(.Rows.Count - 1, i) = WorkDay
                            Case 19
                                fg2(.Rows.Count - 1, i) = CountDay
                                If CountDay < 5 Then
                                    fg2.SetCellStyle(.Rows.Count - 1, i, "Orange")
                                End If
                            Case 20
                                fg2(.Rows.Count - 1, i) = OverDay
                                If OverDay > 0 Then
                                    fg2.SetCellStyle(.Rows.Count - 1, i, "Red")
                                End If
                            Case Else
                                fg2(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End Select

                    Next i
                End While
            End If
            dr.Close()
            conStr.Close()
            lblSample.Text = "Total : " & fg2.Rows.Count - 1 & " Records"
        End With
    End Sub

    Public Sub ShowDataGrid3(ByVal wc As String)

        Dim conStr As New SqlClient.SqlConnection

        Dim WaitCheckDay As Integer
        Dim WorkDay As Integer
        Dim CountDay As Integer = 0
        Dim OverDay As Integer = 0

        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_Popup3 "
        strsql += wc
        strsql += "Order by P_ReportID desc "
        Dim ColAll As Integer = 21
        Dim DayCount As Integer
        With fg3
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fg3.Rows.Fixed = 1
            fg3.Styles.Alternate.BackColor = Color.LightSteelBlue
            'fg3.Styles.Alternate.BackColor = Color.BurlyWood
            Dim cs As C1.Win.C1FlexGrid.CellStyle
            cs = fg3.Styles.Add("Red")
            cs.ForeColor = Color.Red
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("Orange")
            cs.ForeColor = Color.Orange
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("Green")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("SuperGreen")
            cs.ForeColor = Color.Lime
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg3.Styles.Add("Orange")
            cs.ForeColor = Color.Orange
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
                While dr.Read
                    fg3.Rows.Count = fg3.Rows.Count + 1
                    If dr.Item("ReceiveReportDate").ToString = "" Then
                        WaitCheckDay = 0
                    Else
                        WaitCheckDay = (DateDiff(DateInterval.Day, CDate(dr.Item("ReceiveReportDate").ToString), Today))
                        WorkDay = (DateDiff(DateInterval.Day, CDate(dr.Item("ReceiveReportDate").ToString), CDate(dr.Item("DueDate1_1").ToString)))
                    End If
                    OverDay = (DateDiff(DateInterval.Day, CDate(dr.Item("DueDate_1").ToString), Today))

                    For i = 0 To ColAll - 1
                        Select Case i
                            Case 0
                                fg3(.Rows.Count - 1, i) = fg3.Rows.Count - 1
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
                            Case 11, 12, 13, 14 'LC Duedate
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg3.SetCellStyle(.Rows.Count - 1, i, "Blue")
                            Case 15 'duedate
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg3.SetCellStyle(.Rows.Count - 1, i, "Red")
                            Case 18
                                fg3(.Rows.Count - 1, i) = WaitCheckDay
                            Case 19
                                fg3(.Rows.Count - 1, i) = WorkDay
                                If WorkDay > 4 Then
                                    fg3.SetCellStyle(.Rows.Count - 1, i, "Orange")
                                End If
                            Case 20
                                If OverDay < 0 Then
                                    fg3(.Rows.Count - 1, i) = 0
                                Else
                                    fg3(.Rows.Count - 1, i) = OverDay
                                    fg3.SetCellStyle(.Rows.Count - 1, i, "Red")
                                End If

                            Case Else
                                fg3(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End Select

                    Next i
                End While
            End If
            dr.Close()
            conStr.Close()
            lblSample.Text = "Total : " & fg3.Rows.Count - 1 & " Records"
        End With
    End Sub

    Public Sub ShowDataGrid4(ByVal wc As String)

        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_Popup2 "
        strsql += wc
        strsql += "Order by DueDate_1 "
        Dim ColAll As Integer = 80
        Dim DayCount As Integer
        Dim TempYearMont As String = dtp2.Value.Year & Format(dtp2.Value.Month, "00")
        Dim TempYearMont2 As String
        TempYearMont2 = dtp2.Value.Year & Format((dtp2.Value.Month) + 1, "00")
        Dim StartCol As Integer = 17
        Dim StartCol2 As Integer = 48
        Dim FillCol As Integer = 0
        Dim FillCurDay As Integer = 0


        With fg4
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fg4.Rows.Fixed = 1
            fg4.Styles.Alternate.BackColor = Color.LightSteelBlue
            'fg4.Styles.Alternate.BackColor = Color.BurlyWood
            Dim cs As C1.Win.C1FlexGrid.CellStyle
            cs = fg4.Styles.Add("Red")
            cs.ForeColor = Color.Red
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg4.Styles.Add("Redx")
            cs.BackColor = Color.Red
            cs = fg4.Styles.Add("Orangex")
            cs.BackColor = Color.Orange
            cs = fg4.Styles.Add("Green")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg4.Styles.Add("SuperGreen")
            cs.ForeColor = Color.Lime
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg4.Styles.Add("Blue")
            cs.ForeColor = Color.Blue
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg4.Styles.Add("Yellow")
            cs.ForeColor = Color.Yellow
            cs = fg4.Styles.Add("Bold")
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs.ForeColor = Color.Orange
            cs = fg4.Styles.Add("Pre_Re")
            cs.ForeColor = Color.Maroon
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg4.Styles.Add("PreOnly")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg4.Styles.Add("CurDay")
            cs.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Double
            cs.Border.Color = Color.Black
            cs.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Vertical

            'write data
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    fg4.Rows.Count = fg4.Rows.Count + 1
                    If CDate(dr.Item("DueDate_1")).Month = dtp2.Value.Month Then
                        FillCol = StartCol + CDate(dr.Item("DueDate_1")).Day
                    Else
                        FillCol = StartCol2 + CDate(dr.Item("DueDate_1")).Day
                    End If
                    If Today.Month = dtp2.Value.Month Then
                        FillCurDay = StartCol + Today.Day
                    ElseIf Today.Month = ((dtp2.Value.Month) + 1) Then
                        FillCurDay = StartCol2 + Today.Day
                    End If

                    For i = 0 To 17
                        Select Case i
                            Case 0
                                fg4(.Rows.Count - 1, i) = fg4.Rows.Count - 1
                            Case 1
                                fg4(.Rows.Count - 1, i) = dr.GetValue(i - 1)

                                If CInt(dr.Item("PercentCompletion").ToString) < 100 Then
                                    If Today > CDate(dr.Item("DueDate_1")) Then 'เกินกำหนดส่ง LC
                                        fg4.SetCellStyle(.Rows.Count - 1, i, "Red")
                                    Else
                                        For DayCount = 0 To 4
                                            If Today > CDate(dr.Item("DueDate_1")).AddDays(-DayCount) Then 'เกินกำหนดส่ง LC
                                                fg4.SetCellStyle(.Rows.Count - 1, i, "Bold")
                                            End If
                                        Next
                                    End If
                                End If
                                If CInt(dr.Item("PercentCompletion").ToString) = 100 Then
                                    If CBool(dr.Item("Approve_Status")) Then
                                        fg4.SetCellStyle(.Rows.Count - 1, i, "green")
                                    Else
                                        fg4.SetCellStyle(.Rows.Count - 1, i, "SuperGreen")
                                    End If
                                End If
                            Case 4
                                fg4(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                Select Case dr.Item("Present").ToString
                                    Case "Pre + Re"
                                        fg4.SetCellStyle(.Rows.Count - 1, i, "Pre_Re")
                                    Case "Pre Only"
                                        fg4.SetCellStyle(.Rows.Count - 1, i, "PreOnly")
                                    Case "Report"
                                        fg4.SetCellStyle(.Rows.Count - 1, i, "Blue")
                                End Select
                            Case 11, 12, 13, 14 'LC Duedate
                                fg4(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg4.SetCellStyle(.Rows.Count - 1, i, "Blue")
                            Case 15 'duedate
                                fg4(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                fg4.SetCellStyle(.Rows.Count - 1, i, "Red")
                                'Case 18
                                '    fg4.SetCellStyle(.Rows.Count - 1, i, "Redx")
                            Case 17
                                fg4(.Rows.Count - 1, i) = dr.GetValue(i - 1)

                            Case Else
                                fg4(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End Select

                    Next i
                    'FillCol = StartCol + CInt(drx.Item("ShowFinishDay").ToString)
                    'set red to duedate
                    fg4.SetCellStyle(fg4.Rows.Count - 1, FillCol, "Redx")
                    fg4.SetCellStyle(.Rows.Count - 1, FillCurDay, "Curday")
                    'add graph current month
                    Call AddGraph(dr.Item("P_ReportID").ToString, dr.Item("P_CodeID").ToString, TempYearMont)
                    'add graph next month
                    Call AddGraph2(dr.Item("P_ReportID").ToString, dr.Item("P_CodeID").ToString, TempYearMont2)
                End While
            End If
            dr.Close()
            conStr.Close()
            lblSample.Text = "Total : " & fg4.Rows.Count - 1 & " Records"
            'Add graph

        End With
    End Sub

    Private Sub AddGraph(ByVal PeportID As String, ByVal P_CodeID As String, ByVal v_YM As String)
        Dim conStrx As New SqlClient.SqlConnection
        conStrx.ConnectionString = objDB.strConn

        Dim cs As C1.Win.C1FlexGrid.CellStyle
        cs = fg4.Styles.Add("Redx")
        cs.BackColor = Color.Red
        'cs = fg4.Styles.Add("CurDay")
        'cs.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Double
        'cs.Border.Color = Color.Red
        'cs.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Vertical

        Dim strsql As String = ""
        Dim StartCol As Integer = 17
        Dim ProgressCol As Integer = 0
        'If PeportID = "LC/56BF-002" Then
        '    MsgBox("OK")
        'End If
        strsql = "Select * from vwProgressGraph "
        strsql += "Where P_ReportID = '" & PeportID & "' "
        strsql += "And P_CodeID = '" & P_CodeID & "' "
        'strsql += "And FinishDate = '" & v_YM & "' "
        strsql += "And ShowMonth = '" & CInt(Strings.Right(v_YM, 2)) & "' "
        strsql += "and CheckPercent > 0 "
        'write data
        conStrx.Open()
        Dim commx As New SqlCommand(strsql, conStrx)
        Dim drx As SqlDataReader = commx.ExecuteReader
        If drx.HasRows Then
            While drx.Read
                ProgressCol = StartCol + CInt(drx.Item("ShowDay").ToString)
                fg4(fg4.Rows.Count - 1, ProgressCol) = drx.Item("CheckPercent").ToString & "%"
            End While
        End If
        drx.Close()
        conStrx.Close()
    End Sub

    Private Sub AddGraph2(ByVal PeportID As String, ByVal P_CodeID As String, ByVal v_YM As String)
        Dim conStrx As New SqlClient.SqlConnection
        conStrx.ConnectionString = objDB.strConn

        Dim cs As C1.Win.C1FlexGrid.CellStyle
        cs = fg4.Styles.Add("Redx")
        cs.BackColor = Color.Red
        'cs = fg4.Styles.Add("CurDay")
        'cs.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Double
        'cs.Border.Color = Color.Red
        'cs.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Vertical

        Dim strsql As String = ""
        Dim StartCol As Integer = 48
        Dim ProgressCol As Integer = 0

        strsql = "Select * from vwProgressGraph "
        strsql += "Where P_ReportID = '" & PeportID & "' "
        strsql += "And P_CodeID = '" & P_CodeID & "' "
        'strsql += "And FinishDate = '" & v_YM & "' "
        strsql += "And ShowMonth = '" & CInt(Strings.Right(v_YM, 2)) & "' "
        strsql += "and CheckPercent > 0 "
        'write data
        conStrx.Open()
        Dim commx As New SqlCommand(strsql, conStrx)
        Dim drx As SqlDataReader = commx.ExecuteReader
        If drx.HasRows Then
            While drx.Read
                ProgressCol = StartCol + CInt(drx.Item("ShowDay").ToString)
                fg4(fg4.Rows.Count - 1, ProgressCol) = drx.Item("CheckPercent").ToString & "%"
            End While
        End If
        drx.Close()
        conStrx.Close()
    End Sub

    Private Sub chkMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMode.CheckedChanged
        Cursor = Cursors.WaitCursor
        If chkMode.Checked Then
            Call ShowDataGrid("")
        Else
            SetCriteria2Grid()
        End If
        Cursor = Cursors.Default
    End Sub


    Private Sub QADocumentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QADocumentsToolStripMenuItem.Click
        Me.Hide()
        frmInvoice.Show()
    End Sub


    Private Sub ProjectPlanningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectPlanningToolStripMenuItem.Click
        Me.Hide()
        frmRecive.Show()
    End Sub

    Private Sub dtp2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp2.ValueChanged
        If chkFirstOpen.Checked = False Then
            SetCriteria2Grid()
        End If
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        fg.Location = New Size(Line1.X2, Line2.Y2)
        fg.Height = (Me.Height - Line2.Y2) - 75
        fg.Width = (Me.Width - Line1.X2) - 15
        fg2.Location = New Size(Line1.X2, Line2.Y2)
        fg2.Height = (Me.Height - Line2.Y2) - 75
        fg2.Width = (Me.Width - Line1.X2) - 100
        fg3.Location = New Size(Line1.X2, Line2.Y2)
        fg3.Height = (Me.Height - Line2.Y2) - 75
        fg3.Width = (Me.Width - Line1.X2) - 100
        fg4.Location = New Size(Line1.X2, Line2.Y2)
        fg4.Height = (Me.Height - Line2.Y2) - 75
        fg4.Width = (Me.Width - Line1.X2) - 100
        'NotifyIcon1.Visible = True
        'If Me.WindowState = FormWindowState.Minimized Then
        '    Me.Hide()
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex = 0) Then
            chkMode.Visible = True
            Label7.Visible = True
            txtSearch.Visible = True
            cmdSearch.Visible = True
            chkAdvance.Visible = True
            cmdExcel.Visible = True
            '----
            Label1.Visible = True
            dtp1.Visible = True
            Label4.Visible = True
            cboType.Visible = True
            Label5.Visible = True
            cboEmployeeID.Visible = True
            Label6.Visible = True
            cboStatus.Visible = True
        ElseIf (ComboBox1.SelectedIndex = 3) Then
            chkMode.Visible = False
            Label7.Visible = False
            txtSearch.Visible = False
            cmdSearch.Visible = False
            chkAdvance.Visible = False
            cmdExcel.Visible = False
            '----
            Label1.Visible = False
            dtp1.Visible = False
            Label4.Visible = False
            cboType.Visible = False
            Label5.Visible = False
            cboEmployeeID.Visible = False
            Label6.Visible = False
            cboStatus.Visible = False

        Else
            chkMode.Visible = False
            Label7.Visible = False
            txtSearch.Visible = False
            cmdSearch.Visible = False
            chkAdvance.Visible = False
            cmdExcel.Visible = False
            '----
            Label1.Visible = True
            dtp1.Visible = True
            Label4.Visible = True
            cboType.Visible = True
            Label5.Visible = True
            cboEmployeeID.Visible = True
            Label6.Visible = True
            cboStatus.Visible = True
        End If
        If chkFirstOpen.Checked = False Then
            SetCriteria2Grid()
        End If
    End Sub

    Private Sub ShowGrid(Optional ByVal strWc As String = "")

        Select Case ComboBox1.SelectedIndex
            Case 0
                fg.Visible = True
                fg2.Visible = False
                fg3.Visible = False
                fg4.Visible = False
                Call ShowDataGrid(strWc)
            Case 1
                fg.Visible = False
                fg2.Visible = True
                fg3.Visible = False
                fg4.Visible = False
                Call ShowDataGrid2(strWc)
            Case 2
                fg.Visible = False
                fg2.Visible = False
                fg3.Visible = True
                fg4.Visible = False
                Call ShowDataGrid3(strWc)
            Case 3
                fg.Visible = False
                fg2.Visible = False
                fg3.Visible = False
                fg4.Visible = True
                Call ShowDataGrid4(strWc)
            Case 4
                fg.Visible = True
                fg2.Visible = False
                fg3.Visible = False
                fg4.Visible = False
                Call ShowDataGrid(strWc)
        End Select
    End Sub



    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        If ComboBox1.SelectedIndex = 0 Then
            frmEditPercent.v_Pkey = fg(fg.Row, 1).ToString
            frmEditPercent.v_Code = fg(fg.Row, 2).ToString
            frmEditPercent.Show()
            Me.Hide()
        ElseIf ComboBox1.SelectedIndex = 4 Then
            frmCheckList.v_Pkey = fg(fg.Row, 1).ToString
            frmCheckList.Show()
            Me.Hide()
        End If
        
    End Sub

    Private Sub dtp1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp1.ValueChanged
        If chkFirstOpen.Checked = False Then
            SetCriteria2Grid()
        End If

    End Sub

    Private Sub fg2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg2.DoubleClick
        frmEditPercent.v_Pkey = fg(fg.Row, 1).ToString
        frmEditPercent.v_Code = fg(fg.Row, 2).ToString
        frmEditPercent.Show()
        Me.Hide()
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        'MsgBox(fg.Col)
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        ExportToExcel()
    End Sub

    Private Sub fg_BeforeMouseDown(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.BeforeMouseDownEventArgs) Handles fg.BeforeMouseDown
        If fg.Rows.Count > 1 Then
            Dim temp As String
            If txtSort.Text = "" Then
                txtSort.Text = fg.HitTest.Column.ToString & "A"
                temp = fg.HitTest.Column.ToString
            Else
                temp = fg.HitTest.Column.ToString
                If temp <> Strings.Left(txtSort.Text, 1) Then
                    txtSort.Text = fg.HitTest.Column.ToString & "A"
                Else
                    If Strings.Right(txtSort.Text, 1) = "A" Then
                        txtSort.Text = fg.HitTest.Column.ToString & "D"
                    Else
                        If Strings.Right(txtSort.Text, 1) = "D" Then
                            txtSort.Text = fg.HitTest.Column.ToString & "A"
                        Else
                            txtSort.Text = fg.HitTest.Column.ToString & "D"
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    'Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
    '    Try
    '        If Me.Visible Then
    '            Me.Hide()
    '        Else
    '            Me.Show()
    '            Me.WindowState = FormWindowState.Maximized
    '            Me.StartPosition = FormStartPosition.CenterScreen
    '        End If
    '    Catch ex As Exception
    '        Exit Try
    '    End Try
    'End Sub

   

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If chkFirstOpen.Checked = False Then
            SetCriteria2Grid()
        End If
    End Sub

    Private Sub cboEmployeeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmployeeID.SelectedIndexChanged
        If chkFirstOpen.Checked = False Then
            SetCriteria2Grid()
        End If
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged
        If chkFirstOpen.Checked = False Then
            SetCriteria2Grid()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        If txtSearch.Text = "" Then
            SetCriteria2Grid()
        Else
            Dim WCx As String
            WCx = "Where ShowLocation Like '%" & txtSearch.Text & "%' "
            WCx += "Or P_ReportID like '%" & txtSearch.Text & "%' "
            WCx += "Or P_CodeID like '%" & txtSearch.Text & "%' "
            WCx += "Or SendReportTo like '%" & txtSearch.Text & "%' "
            WCx += "Or ReportCus like '%" & txtSearch.Text & "%' "
            Cursor = Cursors.WaitCursor
            ShowDataGrid(WCx)
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdExcel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel2.Click
        Select ComboBox1.SelectedIndex
            Case 0
                Exportfg("Grid", fg)
            Case 1
                Exportfg("Grid", fg2)
            Case 2
                Exportfg("Grid", fg3)
            Case 3
                Exportfg("Grid", fg4)
            Case 4
                Exportfg("Grid", fg)
        End Select
    End Sub


    Private Sub chkAdvance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdvance.CheckedChanged
        If chkAdvance.Checked Then
            Panel1.Visible = True
            If chkBindingCbo.Checked = False Then
                Cursor = Cursors.WaitCursor
                'BindingcboReportCus()
                BindingcboPropType()
                chkBindingCbo.Checked = True
                Cursor = Cursors.Default
            End If
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (v_LogInName = "MK") Or (v_LogInName = "DO") Then
            If cboEmployeeID.Text = " " Then
                BindingfgReport()
            Else
                BindingfgReport("Where (LandStaff = '" & cboEmployeeID.Text & "') OR (Appraisor1 = '" & cboEmployeeID.Text & "') ")
            End If
        Else
            BindingfgReport("Where (LandStaff = '" & v_UserName & "') OR (Appraisor1 = '" & v_UserName & "') ")
        End If

        Exportfg("Performance", fgReport)
    End Sub

    Public Sub BindingfgReport(Optional ByVal wc As String = "")

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
        With fgReport
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fgReport.Rows.Fixed = 1
            'fgReport.Styles.Alternate.BackColor = Color.LightSteelBlue
            'fgReport.Styles.Alternate.BackColor = Color.BurlyWood
            Dim cs As C1.Win.C1FlexGrid.CellStyle
            cs = fgReport.Styles.Add("Red")
            cs.ForeColor = Color.Red
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fgReport.Styles.Add("Green")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fgReport.Styles.Add("SuperGreen")
            cs.ForeColor = Color.Lime
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fgReport.Styles.Add("Blue")
            cs.ForeColor = Color.Blue
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fgReport.Styles.Add("Yellow")
            cs.ForeColor = Color.Yellow
            cs = fgReport.Styles.Add("Bold")
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs.ForeColor = Color.Orange
            cs = fgReport.Styles.Add("Pre_Re")
            cs.ForeColor = Color.Maroon
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fgReport.Styles.Add("PreOnly")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            'fgReport.Cols(0).DataType = GetType(Image)

            'write data
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                v_Fee = 0
                While dr.Read
                    fgReport.Rows.Count = fgReport.Rows.Count + 1
                    For i = 0 To ColAll - 1
                        Select Case i
                            Case 0
                                fgReport(.Rows.Count - 1, i) = fgReport.Rows.Count - 1
                                v_Max = fgReport.Rows.Count - 1
                            Case 1
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                If CInt(dr.Item("PercentCompletion").ToString) < 100 Then
                                    If Today > CDate(dr.Item("DueDate_1")) Then 'เกินกำหนดส่ง LC
                                        fgReport.SetCellStyle(.Rows.Count - 1, i, "Red")
                                    Else
                                        For DayCount = 0 To 4
                                            If Today > CDate(dr.Item("DueDate_1")).AddDays(-DayCount) Then 'เกินกำหนดส่ง LC
                                                fgReport.SetCellStyle(.Rows.Count - 1, i, "Bold")
                                            End If
                                        Next
                                    End If
                                End If
                                If CInt(dr.Item("PercentCompletion").ToString) = 100 Then
                                    If CBool(dr.Item("Approve_Status")) Then
                                        fgReport.SetCellStyle(.Rows.Count - 1, i, "green")
                                    Else
                                        fgReport.SetCellStyle(.Rows.Count - 1, i, "SuperGreen")
                                    End If
                                End If
                            Case 4
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                Select Case dr.Item("Present").ToString
                                    Case "Pre + Re"
                                        fgReport.SetCellStyle(.Rows.Count - 1, i, "Pre_Re")
                                    Case "Pre Only"
                                        fgReport.SetCellStyle(.Rows.Count - 1, i, "PreOnly")
                                    Case "Report"
                                        fgReport.SetCellStyle(.Rows.Count - 1, i, "Blue")
                                End Select
                            Case 11
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_Fee = v_Fee + CInt(dr.GetValue(i - 1))
                            Case 12
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_OPE = v_OPE + CInt(dr.GetValue(i - 1))
                            Case 13
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_CHECK = v_CHECK + CInt(dr.GetValue(i - 1))
                            Case 14
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_Net = v_Net + CInt(dr.GetValue(i - 1))
                            Case 16
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_HeadNet = v_HeadNet + CInt(dr.GetValue(i - 1))
                            Case 18
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                                v_ValuerNet = v_ValuerNet + CInt(dr.GetValue(i - 1))

                            Case Else
                                fgReport(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End Select
                    Next i
                End While
                fgReport.Rows.Count = fgReport.Rows.Count + 1
                fgReport(.Rows.Count - 1, 9) = "Sum"
                fgReport(.Rows.Count - 1, 11) = v_Fee
                fgReport(.Rows.Count - 1, 12) = v_OPE
                fgReport(.Rows.Count - 1, 13) = v_CHECK
                fgReport(.Rows.Count - 1, 14) = v_Net
                fgReport(.Rows.Count - 1, 16) = v_HeadNet
                fgReport(.Rows.Count - 1, 18) = v_ValuerNet

                fgReport.Rows.Count = fgReport.Rows.Count + 1
                fgReport(.Rows.Count - 1, 9) = "AVG"
                fgReport(.Rows.Count - 1, 11) = v_Fee / v_Max
                fgReport(.Rows.Count - 1, 12) = v_OPE / v_Max
                fgReport(.Rows.Count - 1, 13) = v_CHECK / v_Max
                fgReport(.Rows.Count - 1, 14) = v_Net / v_Max
                fgReport(.Rows.Count - 1, 16) = v_HeadNet / v_Max
                fgReport(.Rows.Count - 1, 18) = v_ValuerNet / v_Max

            End If
            dr.Close()
            conStr.Close()
            lblSample.Text = "Total : " & fgReport.Rows.Count - 1 & " Records"

        End With

    End Sub

   
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        frmProposal.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Hide()
        frmAssignJob.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.Hide()
        frmURL.Show()
    End Sub

    Private Sub ขอกำหนดกฎหมายToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ขอกำหนดกฎหมายToolStripMenuItem.Click
        Me.Hide()
        frmLayoutLaw.Show()
    End Sub

    Private Sub QueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueToolStripMenuItem.Click
        Me.Hide()
        frmQboard.Show()
    End Sub

    Private Sub fgReport_Click(sender As Object, e As EventArgs) Handles fgReport.Click

    End Sub
End Class
