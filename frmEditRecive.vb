Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmEditRecive

    Public v_FormMode As String
    Public v_ReceiveID As String
    Dim objDB As New clsDB


    Private Sub frmEditRecive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BindingcboInvoiceID()
        If v_FormMode = "Add" Then
            Call ClearField()
            'Panel1.Visible = False
        Else
            Call BindingData()
            'Call BindingData2()
            'Call BindingGrid2("Where InvoiceID = '" & v_InvoiceID & "' ")
            'Panel1.Visible = True
        End If
        chkNotFirstOpen.Checked = True
    End Sub

    Private Sub ClearField()
        Me.txtReceiveID.Text = ""
        dtpReceiveDate.Value = Today
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

    Private Sub BindingcboInvoiceID()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select * From Invoice "

            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwInvoice")
            cboInvoiceID.DataSource = myDs.Tables("vwInvoice")
            cboInvoiceID.ValueMember = "InvoiceID"
            cboInvoiceID.DisplayMember = "InvoiceID"

            'cboEmployeeID.SelectedIndex = 1
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim strsql As String = ""

            If v_FormMode = "Add" Then
                strsql = "INSERT INTO Receive "
                strsql = strsql & "(ReceiveID, ReceiveDate, ReceiveDate_1, "
                strsql = strsql & "InvoiceID, JobNo, CollecTo, Address, Item1, "
                strsql = strsql & "Des1, QTY1, Amt1, Sum_Amt1, "
                strsql = strsql & "Pay, Vat, Total_Amt, Remark, "
                strsql = strsql & "ModifiedBy, ModifiedDate) "
                strsql = strsql & "Values ('" & Me.txtReceiveID.Text & "', "
                strsql = strsql & "'" & Format(dtpReceiveDate.Value.Year, "0000") & Format(dtpReceiveDate.Value.Month, "00") & Format(dtpReceiveDate.Value.Day, "00") & "', "
                strsql = strsql & "'" & Format(dtpReceiveDate.Value.Year, "0000") & Format(dtpReceiveDate.Value.Month, "00") & Format(dtpReceiveDate.Value.Day, "00") & "', "
                strsql = strsql & "'" & cboInvoiceID.Text & "', "
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
                strsql = strsql & "'" & Me.txtRemark.Text & "', "
                strsql = strsql & "'" & v_LogInName & "', "
                strsql = strsql & "'" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "') "
            Else
                strsql = "Update Receive Set "
                strsql = strsql & "ReceiveID = '" & txtReceiveID.Text & "', "
                strsql = strsql & "ReceiveDate = '" & Format(dtpReceiveDate.Value.Year, "0000") & Format(dtpReceiveDate.Value.Month, "00") & Format(dtpReceiveDate.Value.Day, "00") & "', "
                strsql = strsql & "ReceiveDate_1 = '" & Format(dtpReceiveDate.Value.Year, "0000") & Format(dtpReceiveDate.Value.Month, "00") & Format(dtpReceiveDate.Value.Day, "00") & "', "
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
                strsql = strsql & "ReceiveID = '" & v_ReceiveID & "'"
            End If
            If Not objDB.funExecuteNonQuery(strsql) Then
                MsgBox("ไม่สามารถทำการบันทึกรายการได้ กรุณาตรวจสอบข้อมูล", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            Dim strWc As String = ""
            strWc = "Where (ReceiveDate_1 BETWEEN '" & Format(frmRecive.dtp1.Value.Year, "0000") + "-" + Format(frmRecive.dtp1.Value.Month, "00") + "-" & Format(frmRecive.dtp1.Value.Day, "00") & "' AND '" & Format(frmRecive.dtp2.Value.Year, "0000") + "-" + Format(frmRecive.dtp2.Value.Month, "00") + "-" & Format(frmRecive.dtp2.Value.Day, "00") & "') "
            Call frmRecive.ShowDataGrid(strWc)
            v_FormMode = "Edit"
            'Panel1.Visible = True
            MsgBox("Save Completed")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cboInvoiceID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInvoiceID.SelectedIndexChanged
       
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Call BindingDetail(cboInvoiceID.Text)
    End Sub

    Private Sub BindingData()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM Receive WHERE ReceiveID='" & v_ReceiveID & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtReceiveID.Text = dr.Item("ReceiveID").ToString
                    dtpReceiveDate.Value = CDate(dr.Item("ReceiveDate_1").ToString)
                    cboInvoiceID.SelectedValue = dr.Item("InvoiceID").ToString
                    txtJobNo.Text = dr.Item("JobNo").ToString
                    txtCollecTo.Text = dr.Item("CollecTo").ToString
                    txtAddress.Text = dr.Item("Address").ToString
                    txtItem1.Text = dr.Item("Item1").ToString
                    txtDes1.Text = dr.Item("Des1").ToString
                    txtQty1.Text = dr.Item("Qty1").ToString
                    txtAmt1.Text = Format(CSng(dr.Item("Amt1").ToString), "0.00")
                    txtSum_Amt1.Text = Format(CSng(dr.Item("Sum_Amt1").ToString), "0.00")
                    txtPay.Text = Format(CSng(dr.Item("Pay").ToString), "0.00")
                    txtVat.Text = Format(CSng(dr.Item("Vat").ToString), "0.00")
                    txtTotal_Amt.Text = Format(CSng(dr.Item("Total_Amt").ToString), "0.00")
                    txtRemark.Text = dr.Item("Remark").ToString
                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingDetail(ByVal IvID As String)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * From Invoice "
            strsql = strsql & "WHERE (Invoice.InvoiceID = '" & IvID & "') "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    'txtReceiveID.Text = dr.Item("ReceiveID").ToString
                    'dtpReceiveDate.Value = CDate(dr.Item("ReceiveDate_1").ToString)
                    'cboInvoiceID.SelectedValue = dr.Item("InvoiceID").ToString
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

    Private Sub txtAmt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmt1.TextChanged
        On Error Resume Next
        If (txtQty1.Text <> "") And (txtAmt1.Text <> "") Then
            Me.txtSum_Amt1.Text = Format(CSng(Val(CInt(txtQty1.Text)) * Val(CSng(txtAmt1.Text))), "0.00")
        End If
    End Sub

    Private Sub txtQty1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty1.TextChanged
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

  
End Class