Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO


Public Class frmEditInvoice

    Public v_FormMode As String
    Public v_InvoiceID As String
    Dim objDB As New clsDB

    Private Sub frmEditInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BindingcboBillCus()
        Call BindingcboReports()
        If v_FormMode = "Add" Then
            Call ClearField()
            Panel1.Visible = False
        Else
            Call BindingData()
            Call BindingData2()
            Call BindingGrid2("Where InvoiceID = '" & v_InvoiceID & "' ")
            Panel1.Visible = True
        End If
        cboBillCus.Text = ""
        chkNotFirstOpen.Checked = True
    End Sub

    Private Sub BindingData()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM Invoice WHERE InvoiceID='" & v_InvoiceID & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtInvoiceID.Text = dr.Item("InvoiceID").ToString
                    dtpInvoiceDate.Value = CDate(dr.Item("InvoiceDate_1").ToString)
                    txtJobNo.Text = dr.Item("JobNo").ToString
                    txtCollecTo.Text = dr.Item("CollecTo").ToString
                    txtAddress.Text = dr.Item("Address").ToString
                    txtItem1.Text = dr.Item("Item1").ToString
                    txtDes1.Text = dr.Item("Des1").ToString
                    txtQty1.Text = dr.Item("Qty1").ToString
                    txtAmt1.Text = dr.Item("Amt1").ToString
                    txtSum_Amt1.Text = dr.Item("Sum_Amt1").ToString
                    txtPay.Text = dr.Item("Pay").ToString
                    txtVat.Text = dr.Item("Vat").ToString
                    txtTotal_Amt.Text = dr.Item("Total_Amt").ToString
                    txtRemark.Text = dr.Item("Remark").ToString
                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingData2()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM InvoiceDetail WHERE InvoiceID='" & v_InvoiceID & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboReports.Text = dr.Item("P_ReportID").ToString
                    txtCodeID.Text = dr.Item("P_CodeID").ToString
                    txtHead.Text = ""
                    txtHead.Text = Strings.LTrim(MyFind(objDB.strConn, "vw_SelectReport", "Head", "P_ReportID = '" & cboReports.Text & "' and P_CodeID = '" & txtCodeID.Text & "' "))
                    txtValuer.Text = ""
                    txtValuer.Text = Strings.LTrim(MyFind(objDB.strConn, "vw_SelectReport", "Valuer", "P_ReportID = '" & cboReports.Text & "' and P_CodeID = '" & txtCodeID.Text & "' "))
                    txtFee_Cost.Text = dr.Item("Fee_Cost").ToString
                    txtOPE_Cost.Text = dr.Item("OPE_Cost").ToString
                    txtCheck_Cost.Text = dr.Item("Check_Cost").ToString
                    txtNetFee.Text = dr.Item("NetFee").ToString
                    txtHeadNetFee.Text = dr.Item("HeadNetFee").ToString
                    txtValuerNetFee.Text = dr.Item("ValuerNetFee").ToString
                    txtValuerType.Text = dr.Item("ValuerType").ToString
                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub BindingGrid2(Optional ByVal wc As String = "")

        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_InvoiceDetail2 "
        strsql += wc
        strsql += "Order by P_ReportID desc "
        Dim ColAll As Integer = 19
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
                            Case Else
                                fg2(.Rows.Count - 1, i) = dr.GetValue(i - 1)
                        End Select
                    Next i
                End While
            End If
            dr.Close()
            conStr.Close()


        End With


    End Sub

    Private Sub ClearField()
        Me.txtInvoiceID.Text = ""
        dtpInvoiceDate.Value = Today
        txtJobNo.Text = ""
        txtCollecTo.Text = ""
        txtAddress.Text = ""
        txtItem1.Text = "1"
        txtDes1.Text = ""
        txtQty1.Text = "1"
        txtAmt1.Text = "0"
        txtSum_Amt1.Text = "0"
        txtPay.Text = "0"
        txtVat.Text = "0"
        txtTotal_Amt.Text = "0"
        Me.txtRemark.Text = ""
    End Sub

    Private Sub BindingcboBillCus()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select * From BillCustomer "
            
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwBillCustomer")
            cboBillCus.DataSource = myDs.Tables("vwBillCustomer")
            cboBillCus.ValueMember = "Address"
            cboBillCus.DisplayMember = "CusName"

            'cboEmployeeID.SelectedIndex = 1
            conStr.Close()
            cboBillCus.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboReports()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select * From vw_SelectReport "

            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwSelectReport")
            cboReports.DataSource = myDs.Tables("vwSelectReport")
            cboReports.ValueMember = "P_CodeID"
            cboReports.DisplayMember = "P_ReportID"

            'cboEmployeeID.SelectedIndex = 1
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cboBillCus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBillCus.SelectedIndexChanged
        If chkNotFirstOpen.Checked Then
            txtCollecTo.Text = cboBillCus.Text
            txtAddress.Text = cboBillCus.SelectedValue
        End If
    End Sub

    Private Sub txtQty1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty1.TextChanged
        On Error Resume Next
        If (txtQty1.Text <> "") And (txtAmt1.Text <> "") Then
            Me.txtSum_Amt1.Text = Format(CSng(Val(CInt(txtQty1.Text)) * Val(CSng(txtAmt1.Text))), "0.00")
        End If
    End Sub

    Private Sub txtAmt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmt1.TextChanged
        On Error Resume Next
        If (txtQty1.Text <> "") And (txtAmt1.Text <> "") Then
            Me.txtSum_Amt1.Text = Format(CSng(Val(CInt(txtQty1.Text)) * Val(CSng(txtAmt1.Text))), "0.00")
        End If
    End Sub

    Private Sub txtSum_Amt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSum_Amt1.TextChanged
        On Error Resume Next
        If txtSum_Amt1.Text <> "" Then
            txtPay.Text = Format(CSng(txtSum_Amt1.Text), "0.00")
            txtVat.Text = Format(CSng(Val(CSng(txtPay.Text)) * V_Vat), "0.00")
            txtTotal_Amt.Text = Format(CSng(Val(CSng(txtPay.Text)) + Val(CSng(txtVat.Text))), "0.00")
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim strsql As String = ""

            If v_FormMode = "Add" Then
                strsql = "INSERT INTO Invoice "
                strsql = strsql & "(InvoiceID, InvoiceDate, InvoiceDate_1, JobNo, "
                strsql = strsql & " CollecTo, Address, Item1, Des1, QTY1, "
                strsql = strsql & "Amt1, Sum_Amt1, Pay, Vat, Total_Amt, "
                strsql = strsql & "InvoiceStatus, Remark, "
                strsql = strsql & " ModifiedBy,ModifiedDate) "
                strsql = strsql & "Values ('" & Me.txtInvoiceID.Text & "', "
                strsql = strsql & "'" & Format(dtpInvoiceDate.Value.Year, "0000") & Format(dtpInvoiceDate.Value.Month, "00") & Format(dtpInvoiceDate.Value.Day, "00") & "', "
                strsql = strsql & "'" & Format(dtpInvoiceDate.Value.Year, "0000") & Format(dtpInvoiceDate.Value.Month, "00") & Format(dtpInvoiceDate.Value.Day, "00") & "', "
                strsql = strsql & "'" & txtJobNo.Text & "', "
                strsql = strsql & "'" & txtCollecTo.Text & "', "
                strsql = strsql & "'" & txtAddress.Text & "', "
                strsql = strsql & CInt(Val(CInt(txtItem1.Text))) & ", "
                strsql = strsql & "'" & txtDes1.Text & "', "
                strsql = strsql & CInt(Val(CInt(txtQty1.Text))) & ", "
                strsql = strsql & CSng(Val(CSng(txtAmt1.Text))) & ", "
                strsql = strsql & CSng(Val(CSng(txtSum_Amt1.Text))) & ", "
                strsql = strsql & CSng(Val(CSng(txtPay.Text))) & ", "
                strsql = strsql & CSng(Val(CSng(txtVat.Text))) & ", "
                strsql = strsql & CSng(Val(CSng(txtTotal_Amt.Text))) & ", "
                strsql = strsql & "0, "
                strsql = strsql & "'" & Me.txtRemark.Text & "', "
                strsql = strsql & "'" & v_LogInName & "', "
                strsql = strsql & "'" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "') "
            Else
                strsql = "Update Invoice Set "
                strsql = strsql & "InvoiceID = '" & txtInvoiceID.Text & "', "
                strsql = strsql & "InvoiceDate = '" & Format(dtpInvoiceDate.Value.Year, "0000") & Format(dtpInvoiceDate.Value.Month, "00") & Format(dtpInvoiceDate.Value.Day, "00") & "', "
                strsql = strsql & "InvoiceDate_1 = '" & Format(dtpInvoiceDate.Value.Year, "0000") & Format(dtpInvoiceDate.Value.Month, "00") & Format(dtpInvoiceDate.Value.Day, "00") & "', "
                strsql = strsql & "JobNo = '" & txtJobNo.Text & "', "
                strsql = strsql & "CollecTo = '" & txtCollecTo.Text & "', "
                strsql = strsql & "Address = '" & txtAddress.Text & "', "
                strsql = strsql & "Item1 = " & CInt(Val(CInt(txtItem1.Text))) & ", "
                strsql = strsql & "Des1 = '" & txtDes1.Text & "', "
                strsql = strsql & "QTY1 = " & CInt(Val(CInt(txtQty1.Text))) & ", "
                strsql = strsql & "Amt1 = " & CSng(Val(CSng(txtAmt1.Text))) & ", "
                strsql = strsql & "Sum_Amt1 = " & CSng(Val(CSng(txtSum_Amt1.Text))) & ", "
                strsql = strsql & "Pay = " & CSng(Val(CSng(txtPay.Text))) & ", "
                strsql = strsql & "Vat = " & CSng(Val(CSng(txtVat.Text))) & ", "
                strsql = strsql & "Total_Amt = " & CSng(Val(CSng(txtTotal_Amt.Text))) & ", "
                strsql = strsql & "Remark = '" & txtRemark.Text & "', "
                strsql = strsql & "ModifiedBy = '" & v_LogInName & "', "
                strsql = strsql & "ModifiedDate = '" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "' "
                strsql = strsql & "WHERE "
                strsql = strsql & "InvoiceID = '" & v_InvoiceID & "'"
            End If
            If Not objDB.funExecuteNonQuery(strsql) Then
                MsgBox("ไม่สามารถทำการบันทึกรายการได้ กรุณาตรวจสอบข้อมูล", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            Dim strWc As String = ""
            strWc = "Where (InvoiceDate_1 BETWEEN '" & Format(frmInvoice.dtp1.Value.Year, "0000") + "-" + Format(frmInvoice.dtp1.Value.Month, "00") + "-" & Format(frmInvoice.dtp1.Value.Day, "00") & "' AND '" & Format(frmInvoice.dtp2.Value.Year, "0000") + "-" + Format(frmInvoice.dtp2.Value.Month, "00") + "-" & Format(frmInvoice.dtp2.Value.Day, "00") & "') "
            Call frmInvoice.ShowDataGrid(strWc)
            v_FormMode = "Edit"
            Panel1.Visible = True
            MsgBox("Save Completed")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cboReports_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReports.SelectedIndexChanged
        If chkNotFirstOpen.Checked Then
            txtCodeID.Text = cboReports.SelectedValue.ToString
            txtHead.Text = ""
            txtHead.Text = Strings.LTrim(MyFind(objDB.strConn, "vw_SelectReport", "Head", "P_ReportID = '" & cboReports.Text & "' and P_CodeID = '" & txtCodeID.Text & "' "))
            txtValuer.Text = ""
            txtValuer.Text = Strings.LTrim(MyFind(objDB.strConn, "vw_SelectReport", "Valuer", "P_ReportID = '" & cboReports.Text & "' and P_CodeID = '" & txtCodeID.Text & "' "))
            If (txtHead.Text = "") And (txtValuer.Text = "") Then
                txtValuerType.Text = "0"
            ElseIf (txtHead.Text <> "") And (txtValuer.Text = "") Then
                txtValuerType.Text = "1"
            ElseIf (txtHead.Text = "") And (txtValuer.Text <> "") Then
                txtValuerType.Text = "2"
            ElseIf (txtHead.Text <> "") And (txtValuer.Text <> "") Then
                txtValuerType.Text = "3"
            Else
                txtValuerType.Text = "0"
            End If
            txtFee_Cost.Text = "0"
            txtFee_Cost.Text = txtPay.Text
        End If
    End Sub

    Private Sub SumTotal()
        On Error Resume Next
        Dim SumPrice As Single
        SumPrice = (CSng(txtFee_Cost.Text) - (CSng(txtOPE_Cost.Text) + CSng(txtCheck_Cost.Text)))
        txtNetFee.Text = SumPrice
        If txtValuerType.Text = "0" Then
            txtValuerNetFee.Text = "0"
            txtHeadNetFee.Text = "0"
        ElseIf txtValuerType.Text = "1" Then
            txtValuerNetFee.Text = "0"
            txtHeadNetFee.Text = SumPrice
        ElseIf txtValuerType.Text = "2" Then
            txtValuerNetFee.Text = SumPrice
            txtHeadNetFee.Text = "0"
        ElseIf txtValuerType.Text = "3" Then
            txtValuerNetFee.Text = SumPrice * 0.7
            txtHeadNetFee.Text = SumPrice * 0.3
        End If
        
    End Sub

    Private Sub txtFee_Cost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFee_Cost.TextChanged
        On Error Resume Next
        If txtFee_Cost.Text <> "" Then
            Call SumTotal()
        End If
    End Sub

    Private Sub txtOPE_Cost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOPE_Cost.TextChanged
        On Error Resume Next
        If txtOPE_Cost.Text <> "" Then
            Call SumTotal()
        End If
    End Sub

    Private Sub txtCheck_Cost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCheck_Cost.TextChanged
        On Error Resume Next
        If txtCheck_Cost.Text <> "" Then
            Call SumTotal()
        End If
    End Sub

    
    Private Sub cmdAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd2.Click
        Dim HaveOldData As String = Strings.LTrim(MyFind(objDB.strConn, "InvoiceDetail", "InvoiceID", "InvoiceID = '" & v_InvoiceID & "' and P_ReportID = '" & cboReports.Text & "' and P_CodeID = '" & txtCodeID.Text & "' "))
        Dim strsql As String = ""
        If HaveOldData = "" Then 'add mode
            strsql = "Insert into InvoiceDetail (InvoiceID, P_ReportID, P_CodeID, Fee_Cost, "
            strsql += "OPE_Cost, Check_Cost, NetFee, ValuerNetFee, HeadNetFee, ValuerType) Values "
            strsql += "('" & v_InvoiceID & "', "
            strsql += "'" & cboReports.Text & "', "
            strsql += "'" & txtCodeID.Text & "', "
            strsql += txtFee_Cost.Text & ", "
            strsql += txtOPE_Cost.Text & ", "
            strsql += txtCheck_Cost.Text & ", "
            strsql += txtNetFee.Text & ", "
            strsql += txtValuerNetFee.Text & ", "
            strsql += txtHeadNetFee.Text & ", "
            strsql += txtValuerType.Text & ") "
        Else 'edit mode
            strsql = "Update InvoiceDetail Set "
            strsql += "Fee_Cost = " & txtFee_Cost.Text & ", "
            strsql += "OPE_Cost = " & txtOPE_Cost.Text & ", "
            strsql += "Check_Cost = " & txtCheck_Cost.Text & ", "
            strsql += "NetFee = " & txtNetFee.Text & ", "
            strsql += "ValuerNetFee = " & txtValuerNetFee.Text & ", "
            strsql += "HeadNetFee = " & txtHeadNetFee.Text & ", "
            strsql += "ValuerType = " & txtHeadNetFee.Text & " "
            strsql += "Where InvoiceID = '" & txtInvoiceID.Text & "' "
            strsql += "And P_ReportID = '" & cboReports.Text & "' "
            strsql += "And P_CodeID = '" & txtCodeID.Text & "' "
        End If
        If Not objDB.funExecuteNonQuery(strsql) Then
            MsgBox("ไม่สามารถทำการบันทึกรายการได้ กรุณาตรวจสอบข้อมูล", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        BindingGrid2("Where InvoiceID = '" & v_InvoiceID & "' ")
        MsgBox("Save completed")

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If fg2.Rows.Count > 1 Then
                Dim strsql As String
                If MsgBox("Do you want to delete Report = '" & fg2(fg2.Row, 1) & "' ", MsgBoxStyle.YesNo, "Confirm delete") = MsgBoxResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    'delete Drawing_Register
                    strsql = "Delete from InvoiceDetail "
                    strsql += "WHERE (InvoiceID = '" & v_InvoiceID & "') AND (P_ReportID = '" & cboReports.Text & "') "
                    objDB.ExecuteNonQuery(strsql)
                    'delete Drawing_Revision
                    BindingGrid2("Where InvoiceID = '" & v_InvoiceID & "' ")
                    Cursor = Cursors.Default
                    MsgBox("Delete completed")

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel2.Visible = True
        chkMode.Checked = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtCusName2.Text = cboBillCus.Text
        txtAddress2.Text = txtAddress.Text
        Panel2.Visible = True
        chkMode.Checked = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim strsql As String = ""

            If chkMode.Checked Then
                strsql = "INSERT INTO BillCustomer "
                strsql = strsql & "(CusName, Address) "
                strsql = strsql & "Values ('" & txtCusName2.Text & "', "
                strsql = strsql & "'" & txtAddress2.Text & "') "
            Else
                strsql = "Update BillCustomer Set "
                strsql = strsql & "CusName = '" & txtCusName2.Text & "', "
                strsql = strsql & "Address = '" & txtAddress2.Text & "' "
                strsql = strsql & "WHERE "
                strsql = strsql & "CusName = '" & cboBillCus.Text & "'"
            End If
            If Not objDB.funExecuteNonQuery(strsql) Then
                MsgBox("ไม่สามารถทำการบันทึกรายการได้ กรุณาตรวจสอบข้อมูล", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            Call BindingcboBillCus()
            MsgBox("Save Completed")
            Panel2.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class