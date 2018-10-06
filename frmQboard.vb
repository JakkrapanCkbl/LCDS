Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmQboard

    Dim objDB As New clsDB
    Dim objTools As New clsTools


    Private Sub frmQboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Me.BackColor = Color.FromArgb(95, 95, 95)
        Me.BackColor = Color.FromArgb(0, 128, 255)
        TextBox1.BackColor = Color.FromArgb(0, 128, 255)
        TextBox2.BackColor = Color.FromArgb(0, 128, 255)
        TextBox3.BackColor = Color.FromArgb(0, 128, 255)
        txtShowRecord.BackColor = Color.FromArgb(0, 128, 255)
        'Dim WC As String = "WHERE P_ReportID = 'LC/61BF-595' or P_ReportID = 'LC/61BF-603' or P_ReportID = 'LC/61BF-604' or P_ReportID = 'LC/61BF-613' "
        'Dim WC As String = "WHERE P_ReportID = 'LC/61BF-1123' "
        Dim WC As String = ""
        'If Val(Format(Now(), "YYYY")) = Year(Now) Then
        '    'MessageBox.Show("Regional Setting = English, Year type is A.D.(Anno Domini) or คริสต์ศักราช(ค.ศ.)")
        '    WC = "where P_ReportDate_1 between '" & Today.AddDays(-60) & "' and '" & Today & "' "
        'Else
        '    'MessageBox.Show("Regional Setting = Thai, Year type is B.E.(Buddhist Era) or พุทธศักราช(พ.ศ.)")
        '    WC = "where P_ReportDate_1 between '" & (Today.AddDays(-60).Year) & "-" & Format(Today.AddDays(-60), "MM") & "-" & Format(Today.AddDays(-60), "dd") & "' and '" & (Today.AddDays(-60).Year) & "-" & Format(Today, "MM") & "-" & Format(Today, "dd") & "' "
        'End If
        If Val(Format(Now(), "YYYY")) = Year(Now) Then
            WC = "where P_ReportDate between '" & (Today.AddDays(-60).Year) & Format(Today.AddDays(-60), "MM") & Format(Today.AddDays(-60), "dd") & "' and '" & (Today.AddDays(-60).Year) & Format(Today, "MM") & Format(Today, "dd") & "' "
        Else
            WC = "where P_ReportDate between '" & (Today.AddDays(-60).Year) & Format(Today.AddDays(-60), "MM") & Format(Today.AddDays(-60), "dd") & "' and '" & (Today.AddDays(-60).Year) & Format(Today, "MM") & Format(Today, "dd") & "' "
        End If
        ShowDataGrid(WC)
        Me.fg.Cols(7).Sort = C1.Win.C1FlexGrid.SortFlags.Descending
        Me.fg.Sort(C1.Win.C1FlexGrid.SortFlags.UseColSort, 7, 7)
    End Sub

    Private Sub frmQboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        TextBox1.Location = New Size(5, 8)
        TextBox2.Location = New Size(Me.Width - 170, 8)
        TextBox3.Location = New Size((Me.Width / 2) - 290, 8)
        fg.Height = (Me.Height - Line2.Y2) - 50
        fg.Width = Me.Width - 5
    End Sub

    Public Sub ShowDataGrid(ByVal wc As String)
        Try
            Dim conStr As New SqlClient.SqlConnection
            conStr.ConnectionString = objDB.strConn
            Dim strsql As String = ""
            strsql = "Select * from vwDayExcelReport3 "
            strsql += wc
            strsql += "Order by P_ReportDate_1 desc "
            Dim ColAll As Integer = 18
            Dim xtime As Single
            Dim cday As Single = 0
            'Dim j As Integer = 1
            With fg
                .Cols(0).Visible = False
                .Cols(13).Visible = False
                .Cols(14).Visible = False
                .Cols(15).Visible = False
                .Cols(16).Visible = False
                .Cols(17).Visible = False
                .Rows.Count = 1
                .Cols.Count = ColAll
                'set format
                fg.Rows.Fixed = 1
                fg.Styles.Alternate.BackColor = Color.Black
                'write data
                conStr.Open()
                Dim comm As New SqlCommand(strsql, conStr)
                Dim dr As SqlDataReader = comm.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        fg.Rows.Count = fg.Rows.Count + 1
                        'If j = 79 Then
                        '    MessageBox.Show("xx")
                        'End If
                        For i = 0 To ColAll - 1
                            Select Case i
                                Case 0
                                    fg(.Rows.Count - 1, i) = fg.Rows.Count - 1
                                Case 6
                                    fg(.Rows.Count - 1, i) = GetReportPropertyAddress3(dr.Item("ProposalID").ToString)
                                Case 7
                                    'fg(.Rows.Count - 1, i) = " วัน"
                                Case 9
                                    'Valuer Time
                                    'InspectionDate_1 = Valuer วันที่สำรวจ
                                    'SendProofDate = Checker รับเข้า

                                    If IsDBNull(dr.Item("SendProofDate")) Then
                                        'Valuer Time
                                        xtime = GetWorkingTimeSpan(dr.Item("InspectionDate_1"), Now)
                                        fg(.Rows.Count - 1, i) = Nearest((xtime / 3600), 0.5) & " ชม."
                                        'วันที่ใช้
                                        fg(.Rows.Count - 1, 7) = Nearest((xtime / 28800), 0.5)
                                    Else
                                        'Valuer Time
                                        xtime = GetWorkingTimeSpan(dr.Item("InspectionDate_1"), dr.Item("SendProofDate"))
                                        fg(.Rows.Count - 1, i) = Nearest((xtime / 3600), 0.5) & " ชม."
                                        'วันที่ใช้                                        
                                        fg(.Rows.Count - 1, 7) = Nearest((xtime / 28800), 0.5)
                                    End If
                                Case 11
                                    'Checker Time
                                    'SendProofDate = Checker stamp วันที่รับเข้า
                                    'SendDate_1 = Apprvoer stamp วันรับเข้า

                                    If IsDBNull(dr.Item("SendDate_1")) Then
                                        'เคส  Valuer ยังไม่ได้รับเข้า
                                        'Checker Time
                                        If IsDBNull(dr.Item("SendProofDate")) Then
                                            'nothing
                                        Else
                                            xtime = GetWorkingTimeSpan(dr.Item("SendProofDate"), Now)
                                            fg(.Rows.Count - 1, i) = Nearest((xtime / 3600), 0.5) & " ชม."
                                            'วันที่ใช้
                                            fg(.Rows.Count - 1, 7) = Nearest((xtime / 28800), 0.5)
                                        End If
                                    Else
                                        'เคส Valuer รับเข้าแล้ว
                                        'Checker Time
                                        If IsDBNull(dr.Item("SendProofDate")) Then
                                            'nothing
                                        Else
                                            xtime = GetWorkingTimeSpan(dr.Item("SendProofDate"), dr.Item("SendDate_1"))
                                            fg(.Rows.Count - 1, i) = Nearest((xtime / 3600), 0.5) & " ชม."
                                            'เวลาที่ใช้
                                            fg(.Rows.Count - 1, 7) = Nearest((xtime / 28800), 0.5)
                                        End If
                                    End If

                                Case 12
                                    'Approver Time
                                    'SendDate_1 = Approver รับเข้า
                                    'ApproveDate = Approver อนุมัติ
                                    If IsDBNull(dr.Item("ApproveDate")) Then
                                        'เคส ยังไม่ อนุมัติ
                                        If Not IsDBNull(dr.Item("SendDate_1")) Then
                                            'Approver Time
                                            xtime = GetWorkingTimeSpan(dr.Item("SendDate_1"), Now)
                                            fg(.Rows.Count - 1, i) = Nearest((xtime / 3600), 0.5) & " ชม."
                                            'วันที่ใช้
                                            fg(.Rows.Count - 1, 7) = Nearest((xtime / 28800), 0.5)
                                        End If
                                    Else
                                        'เคส อนุมัติ แล้ว
                                        If Not IsDBNull(dr.Item("SendDate_1")) Then  'มีข้อมูลวัทที่ Approver รับเข้า
                                            'Approver Time
                                            xtime = GetWorkingTimeSpan(dr.Item("SendDate_1"), dr.Item("ApproveDate"))
                                            fg(.Rows.Count - 1, i) = Nearest((xtime / 3600), 0.5) & " ชม."
                                            'วันที่ใช้
                                            fg(.Rows.Count - 1, 7) = Nearest((xtime / 28800), 0.5)
                                        Else  'ไม่มีข้อมูลวันที่ Approver รับเข้า 
                                            'nothing
                                        End If
                                    End If
                                Case Else
                                    fg(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                            End Select

                        Next i
                        'Me.Text = j
                        ' j += 1
                    End While
                End If
                dr.Close()
                conStr.Close()
            End With
            txtShowRecord.Text = "จำนวน " & fg.Rows.Count - 1 & " รายการ"
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub RefreshGrid()
        'Dim x As Single
        'x = GetWorkingTimeSpan("2561-06-04 09:00:00", "2561-06-04 14:00:00")
        'MessageBox.Show("start date : " & "2561-06-04 09:00:00" & " end date : " & "2561-06-04 14:00:00" & " Result is " & CStr(x))
        Dim WC As String = ""
        'If Val(Format(Now(), "YYYY")) = Year(Now) Then
        '    'MessageBox.Show("Regional Setting = English, Year type is A.D.(Anno Domini) or คริสต์ศักราช(ค.ศ.)")
        '    WC = "where P_ReportDate_1 between '" & Today.AddDays(-60) & "' and '" & Today & "' "
        'Else
        '    'MessageBox.Show("Regional Setting = Thai, Year type is B.E.(Buddhist Era) or พุทธศักราช(พ.ศ.)")
        '    WC = "where P_ReportDate_1 between '" & (Today.AddDays(-60).Year) & "-" & Format(Today.AddDays(-60), "MM") & "-" & Format(Today.AddDays(-60), "dd") & "' and '" & (Today.AddDays(-60).Year) & "-" & Format(Today, "MM") & "-" & Format(Today, "dd") & "' "
        'End If
        If Val(Format(Now(), "YYYY")) = Year(Now) Then
            WC = "where P_ReportDate between '" & (Today.AddDays(-60).Year) & Format(Today.AddDays(-60), "MM") & Format(Today.AddDays(-60), "dd") & "' and '" & (Today.AddDays(-60).Year) & Format(Today, "MM") & Format(Today, "dd") & "' "
        Else
            WC = "where P_ReportDate between '" & (Today.AddDays(-60).Year) & Format(Today.AddDays(-60), "MM") & Format(Today.AddDays(-60), "dd") & "' and '" & (Today.AddDays(-60).Year) & Format(Today, "MM") & Format(Today, "dd") & "' "
        End If
        Me.Cursor = Cursors.WaitCursor

        ShowDataGrid(WC)
        Me.fg.Cols(7).Sort = C1.Win.C1FlexGrid.SortFlags.Descending
        Me.fg.Sort(C1.Win.C1FlexGrid.SortFlags.UseColSort, 7, 7)

        Me.Cursor = Cursors.Default
    End Sub


    Public Function GetReportPropertyAddress3(ByVal ReportID As String) As String
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        Dim TempString As String = ""

        strsql = "SELECT P_ReportDetail.P_ReportID, P_ReportDetail.ItemNo, "
        strsql = strsql & "P_ReportDetail.ProposalID, ProposalDetail.Address, "
        strsql = strsql & "ProposalDetail.Soi, ProposalDetail.Road , "
        strsql = strsql & "Tumbon.TumbonName, Amphoe.AmphoeName, "
        strsql = strsql & "Province.ProvinceName, Province.ProvinceID "
        strsql = strsql & "FROM Tumbon INNER JOIN ProposalDetail ON "
        strsql = strsql & "Tumbon.TumbonID = ProposalDetail.TumbonID "
        strsql = strsql & "INNER JOIN Amphoe ON Tumbon.AmphoeID = "
        strsql = strsql & "Amphoe.AmphoeID INNER JOIN "
        strsql = strsql & "Province ON Amphoe.ProvinceID = Province.ProvinceID "
        strsql = strsql & "RIGHT OUTER JOIN P_ReportDetail ON "
        strsql = strsql & "ProposalDetail.PropertyNo = P_ReportDetail.ItemNo AND "
        strsql = strsql & "ProposalDetail.ProposalID = P_ReportDetail.ProposalID "
        strsql = strsql & "GROUP BY P_ReportDetail.P_ReportID, "
        strsql = strsql & "P_ReportDetail.ItemNo, P_ReportDetail.ProposalID, "
        strsql = strsql & "ProposalDetail.Address, Tumbon.TumbonName, "
        strsql = strsql & "Amphoe.AmphoeName, Province.ProvinceName, "
        strsql = strsql & "ProposalDetail.Road, ProposalDetail.Soi, Province.ProvinceID "
        strsql = strsql & "HAVING (P_ReportDetail.P_ReportID = '" & ReportID & "') "
        strsql = strsql & "OR (P_ReportDetail.ProposalID = '" & ReportID & "') "

        conStr.Open()
        Dim comm As New SqlCommand(strsql, conStr)
        Dim dr As SqlDataReader = comm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                'Result = dr.GetValue(i - 1)
                'Result = dr.Item("Address")
                TempString = dr.Item("Address") & " "
                If Not dr.Item("soi") & "" = "" Then
                    TempString = TempString & "ซ." & dr.Item("soi") & " "
                End If
                If Not dr.Item("Road") & "" = "" Then
                    TempString = TempString & "ถ." & dr.Item("Road") & " "
                End If
                If dr.Item("ProvinceID") = "10" Then
                    TempString = TempString & dr.Item("AmphoeName") & " "
                Else
                    TempString = TempString & "อ." & dr.Item("AmphoeName") & " "
                End If
            End While
        End If
        dr.Close()
        conStr.Close()
        GetReportPropertyAddress3 = TempString
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Today.ToString("dddd") & " " & Format(Today, "dd-MMM-yyyy")
        TextBox2.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Call RefreshGrid()
    End Sub

    Private Sub frmQboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Show()
    End Sub
End Class