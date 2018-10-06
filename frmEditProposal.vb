Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditProposal

    Public v_frmMode As String
    Dim objDB As New clsDB

    Private Sub frmEditProposal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BindingcboBR()
        Call BindingcboProposalCustomer()
        Call BindingcbocboReportCustomer()
        Call BindingcboClientCustomer()
        Call BindingcboObjectiveID()
        Call BindingcboProcessSubID()
        Call BindingcboEmployeeID()
        chkNotFirstOpen.Checked = True
        If v_frmMode = "Add" Then
            Me.Text = "ทำใบเสนองาน (Add New Proposal)"
            txtProposalID.Text = "LC/L0000/56"
            cboProcessSubID.SelectedValue = 2
            Me.txtJobPeriod.Text = 0
            txtProposalName.Text = "-"
            txtProposalContact.Text = "คุณสุมาลี จินดารักษ์ / คุณอำไพ หู้เต็ม"
            txtTel.Text = "(02)-625-5175"
            txtFax.Text = "(02)-664-1425"
            txtTitle.Text = "ผู้จัดการฝ่ายจัดการภายใน / ผู้ติดต่อประสานงาน"
            txtContactName1.Text = "คุณสุมาลี จินดารักษ์ / คุณอำไพ หู้เต็ม"
            txtTel1.Text = "(02)-625-5175"
            txtFax1.Text = "(02)-664-1425"
            txtTitle1.Text = "ผู้จัดการฝ่ายจัดการภายใน / ผู้ติดต่อประสานงาน"
            txtPropertyDescription.Text = ""
            txtContactName.Text = ""
            txtTitle.Text = ""
        End If
    End Sub

    Private Sub BindingcboBR()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboBR.Items.Clear()
            strsql = "Select * From vwBranch "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwBranch")
            cboBR.DataSource = myDs.Tables("vwBranch")
            cboBR.ValueMember = "CustomerID"
            cboBR.DisplayMember = "BranchID"
            conStr.Close()
            cboBR.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboProposalCustomer()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboProposalCustomer.Items.Clear()
            strsql = "Select * From vwShowCustomer "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwShowCustomer")
            cboProposalCustomer.DataSource = myDs.Tables("vwShowCustomer")
            cboProposalCustomer.ValueMember = "CustomerID"
            cboProposalCustomer.DisplayMember = "ShowCustomer"
            conStr.Close()
            'cboProposalCustomer.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcbocboReportCustomer()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboReportCustomer.Items.Clear()
            strsql = "Select * From vwShowCustomer "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwShowCustomer")
            cboReportCustomer.DataSource = myDs.Tables("vwShowCustomer")
            cboReportCustomer.ValueMember = "CustomerID"
            cboReportCustomer.DisplayMember = "ShowCustomer"
            conStr.Close()
            'cboReportCustomer.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboClientCustomer()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboClientCustomer.Items.Clear()
            strsql = "Select * From vwShowCustomer "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwShowCustomer")
            cboClientCustomer.DataSource = myDs.Tables("vwShowCustomer")
            cboClientCustomer.ValueMember = "CustomerID"
            cboClientCustomer.DisplayMember = "ShowCustomer"
            conStr.Close()
            'cboClientCustomer.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboObjectiveID()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboObjectiveID.Items.Clear()
            strsql = "Select * From Objective "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwObjective")
            cboObjectiveID.DataSource = myDs.Tables("vwObjective")
            cboObjectiveID.ValueMember = "ObjectiveID"
            cboObjectiveID.DisplayMember = "ObjectiveT"
            conStr.Close()
            cboObjectiveID.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboProcessSubID()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboProcessSubID.Items.Clear()
            strsql = "Select * From vwProcess2 "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwProcess2")
            cboProcessSubID.DataSource = myDs.Tables("vwProcess2")
            cboProcessSubID.ValueMember = "ProcessSubID"
            cboProcessSubID.DisplayMember = "StatusT"
            conStr.Close()
            'cboProcessSubID.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboEmployeeID()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboEmployeeID.Items.Clear()
            strsql = "Select * From vwShowEmpName "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwShowEmpName")
            cboEmployeeID.DataSource = myDs.Tables("vwShowEmpName")
            cboEmployeeID.ValueMember = "EmployeeID"
            cboEmployeeID.DisplayMember = "ShowName"
            conStr.Close()
            'cboEmployeeID.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub BindingcboBillCustomer()
    '    Dim conStr As New SqlClient.SqlConnection
    '    conStr.ConnectionString = objDB.strConn
    '    Dim strsql As String
    '    Try
    '        cboBillCustomer.Items.Clear()
    '        strsql = "Select * From vwShowCustomer "
    '        conStr.Open()
    '        Dim myDa As New SqlDataAdapter(strsql, conStr)
    '        Dim myDs As New DataSet
    '        myDa.Fill(myDs, "vwShowCustomer")
    '        cboBillCustomer.DataSource = myDs.Tables("vwShowCustomer")
    '        cboBillCustomer.ValueMember = "CustomerID"
    '        cboBillCustomer.DisplayMember = "ShowCustomer"
    '        conStr.Close()
    '        cboBillCustomer.Text = ""
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


   
    Private Sub cboBR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBR.SelectedIndexChanged
        If chkNotFirstOpen.Checked Then
            'MsgBox(cboBR.SelectedValue)
            'MsgBox(cboBR.SelectedText)
            cboProposalCustomer.SelectedValue = cboBR.SelectedValue
            cboProposalCustomer.Refresh()
            cboReportCustomer.SelectedValue = cboBR.SelectedValue
            cboReportCustomer.Refresh()
            cboClientCustomer.SelectedValue = cboBR.SelectedValue
            cboReportCustomer.Refresh()
        End If
    End Sub

    Private Sub cmdLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLC.Click
        txtProposalID.Text = NewReportID53("R", Strings.Right(ChangeToBC(Date.Today.Year), 2))
    End Sub

    Public Function NewReportID53(ByVal ReportType As String, ByVal yy As String) As String
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn

        Dim strsql As String
        Dim tempID As Long
        Dim tempstr As String = ""

        strsql = "SELECT SUBSTRING(P_ReportID, 6, 1) AS R_Type, "
        strsql = strsql & "SUBSTRING(P_ReportID, 4, 2) AS R_Year, "
        strsql = strsql & "MAX(CONVERT(int, RIGHT(P_ReportID, 3))) AS MaxID "
        strsql = strsql & "From dbo.P_Report "
        strsql = strsql & "GROUP BY SUBSTRING(P_ReportID, 4, 2), "
        strsql = strsql & "SUBSTRING(P_ReportID, 6, 1) "
        strsql = strsql & "HAVING (SUBSTRING(P_ReportID, 4, 2) = '" & yy & "') "
        strsql = strsql & "AND (SUBSTRING(P_ReportID, 6, 1) = '" & ReportType & "') "

        'rs.Open(strsql, gsConnection, adOpenForwardOnly, adLockReadOnly)
        'If Not rs.EOF Then
        '    If IsNull(rs.Fields("MaxID")) Then
        '        tempID = 1
        '    Else
        '        tempID = rs.Fields("MaxID")
        '        tempID = tempID + 1
        '    End If
        'Else
        '    tempID = 1
        'End If
        'rs.Close()
        'rs = Nothing
        conStr.Open()
        Dim comm As New SqlCommand(strsql, conStr)
        Dim dr As SqlDataReader = comm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If dr.Item("MaxID") = Nothing Then
                    tempID = 1
                Else
                    tempID = dr.Item("MaxID").ToString
                    tempID = tempID + 1
                End If
            End While
        Else
            tempID = 1
        End If
        dr.Close()
        conStr.Close()

        If ReportType = "R" Then
            tempstr = "LC/" & yy & ReportType & "-" & Format(tempID, "000")
        End If
        If ReportType = "B" Then
            tempstr = "LC/" & yy & ReportType & "F-" & Format(tempID, "000")
        End If
        Return tempstr

    End Function

    Private Sub cmdKK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKK.Click
        txtProposalID.Text = NewReportID53("B", Strings.Right(ChangeToBC(Date.Today.Year), 2))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtProposalDescription.Text = txtTemp.Text
    End Sub
End Class