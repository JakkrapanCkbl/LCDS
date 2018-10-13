Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditProposal

    Public v_frmMode As String
    Dim objDB As New clsDB
    Public v_ID As String

    Private Sub frmEditProposal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call BindingcboProposalCustomer()
        Call BindingcboClientCustomer()
        Call BindingcbocboReportCustomer()
        Call BindingcboObjectiveID()

        Call BindingcboPropertyType()
        Call BindingcboPropertyTypeDetailID(cboPropertyTypeID.SelectedValue)
        Call BindingcboProvinceID()

        chkNotFirstOpen.Checked = True
        If v_frmMode = "Add" Then
            Me.Text = "ทำใบเสนองาน (Add New Proposal)"
            dtpProposalDate.Value = Today
            txtProposalID.Text = "LC/L0000/56"


        ElseIf v_frmMode = "Edit" Then
            Call BindingData()
            Call BindingProDetail()

        End If
    End Sub


    Private Sub BindingData()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM Proposal WHERE ProposalID='" & v_ID & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read

                    dtpProposalDate.Value = Now
                    txtProposalID.Text = dr.Item("ProposalID").ToString
                    dtpProposalDate.Checked = True
                    dtpProposalDate.Value = dr.Item("ProposalDate_1")
                    dtpProposalDate.Text = dr.Item("ProposalDate_1")

                    cboProposalCustomer.SelectedValue = dr.Item("ProposalCustomer").ToString
                    cboClientCustomer.SelectedValue = dr.Item("ClientCustomer").ToString
                    cboReportCustomer.SelectedValue = dr.Item("ReportCustomer").ToString
                    cboObjectiveID.SelectedValue = dr.Item("ObjectiveID").ToString

                    txtRemark.Text = dr.Item("Remark").ToString



                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BindingProDetail()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM ProposalDetail WHERE ProposalID='" & v_ID & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read


                    txtAddress.Text = dr.Item("Address").ToString
                    txtSoi.Text = dr.Item("Soi").ToString
                    txtRoad.Text = dr.Item("Road").ToString
                    cboProvinceID.SelectedValue = dr.Item("ProvinceID").ToString
                    cboAmphoeID.SelectedValue = dr.Item("AmphoeID").ToString
                    cboTumbonID.SelectedValue = dr.Item("TumbonID").ToString
                    cboPropertyTypeID.SelectedValue = dr.Item("PropertyTypeID").ToString
                    cboPropertyTypeDetailID.SelectedValue = dr.Item("PropertyTypeDetailID").ToString
                    txtRai.Text = dr.Item("Rai").ToString
                    txtNgan.Text = dr.Item("Ngan").ToString
                    txtSqWah.Text = dr.Item("SqWah").ToString
                    txtSqMeter.Text = dr.Item("SqMeter").ToString



                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Sub BindingcboBR()
    '    Dim conStr As New SqlClient.SqlConnection
    '    conStr.ConnectionString = objDB.strConn
    '    Dim strsql As String
    '    Try
    '        cboBR.Items.Clear()
    '        strsql = "Select * From vwBranch "
    '        conStr.Open()
    '        Dim myDa As New SqlDataAdapter(strsql, conStr)
    '        Dim myDs As New DataSet
    '        myDa.Fill(myDs, "vwBranch")
    '        cboBR.DataSource = myDs.Tables("vwBranch")
    '        cboBR.ValueMember = "CustomerID"
    '        cboBR.DisplayMember = "BranchID"
    '        conStr.Close()
    '        cboBR.Text = ""
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub BindingcboProposalCustomer()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            'cboProposalCustomer.DataSource = vbNull
            'cboProposalCustomer.Items.Clear()

            strsql = "Select * From vwShowCustomer order by customerid "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwShowCustomer")
            cboProposalCustomer.DataSource = myDs.Tables("vwShowCustomer")
            cboProposalCustomer.ValueMember = "CustomerID"
            cboProposalCustomer.DisplayMember = "ShowCustomer"
            conStr.Close()
            cboProposalCustomer.SelectedIndex = 89
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
            'cboReportCustomer.DataSource = vbNull
            'cboReportCustomer.Items.Clear()

            strsql = "Select * From vwShowCustomer order by customerid "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwShowCustomer")
            cboReportCustomer.DataSource = myDs.Tables("vwShowCustomer")
            cboReportCustomer.ValueMember = "CustomerID"
            cboReportCustomer.DisplayMember = "ShowCustomer"
            conStr.Close()
            cboReportCustomer.SelectedIndex = 89
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
            'cboClientCustomer.DataSource = vbNull
            'cboClientCustomer.Items.Clear()
            strsql = "Select * From vwShowCustomer order by customerid "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwShowCustomer")
            cboClientCustomer.DataSource = myDs.Tables("vwShowCustomer")
            cboClientCustomer.ValueMember = "CustomerID"
            cboClientCustomer.DisplayMember = "ShowCustomer"
            conStr.Close()
            cboClientCustomer.SelectedIndex = 89
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboObjectiveID()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            'cboObjectiveID.DataSource = vbNull
            'cboObjectiveID.Items.Clear()
            strsql = "Select * From Objective order by objectiveID "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwObjective")
            cboObjectiveID.DataSource = myDs.Tables("vwObjective")
            cboObjectiveID.ValueMember = "ObjectiveID"
            cboObjectiveID.DisplayMember = "ObjectiveT"
            conStr.Close()
            cboObjectiveID.SelectedIndex = 4
            'cboObjectiveID.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub BindingcboProcessSubID()
    '    Dim conStr As New SqlClient.SqlConnection
    '    conStr.ConnectionString = objDB.strConn
    '    Dim strsql As String
    '    Try
    '        cboProcessSubID.Items.Clear()
    '        strsql = "Select * From vwProcess2 "
    '        conStr.Open()
    '        Dim myDa As New SqlDataAdapter(strsql, conStr)
    '        Dim myDs As New DataSet
    '        myDa.Fill(myDs, "vwProcess2")
    '        cboProcessSubID.DataSource = myDs.Tables("vwProcess2")
    '        cboProcessSubID.ValueMember = "ProcessSubID"
    '        cboProcessSubID.DisplayMember = "StatusT"
    '        conStr.Close()
    '        'cboProcessSubID.Text = ""
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub BindingcboEmployeeID()
    '    Dim conStr As New SqlClient.SqlConnection
    '    conStr.ConnectionString = objDB.strConn
    '    Dim strsql As String
    '    Try
    '        'cboEmployeeID.DataSource = vbNull
    '        'cboEmployeeID.Items.Clear()
    '        strsql = "Select * From vwShowEmpName "
    '        conStr.Open()
    '        Dim myDa As New SqlDataAdapter(strsql, conStr)
    '        Dim myDs As New DataSet
    '        myDa.Fill(myDs, "vwShowEmpName")
    '        cboEmployeeID.DataSource = myDs.Tables("vwShowEmpName")
    '        cboEmployeeID.ValueMember = "EmployeeID"
    '        cboEmployeeID.DisplayMember = "ShowName"
    '        conStr.Close()
    '        'cboEmployeeID.Text = ""
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

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




    Private Sub cmdLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLC.Click
        txtProposalID.Text = NewReportID53("R", Strings.Right(ChangeToBC(Date.Today.Year), 2))
    End Sub

    Public Function NewReportID53(ByVal ReportType As String, ByVal yy As String) As String
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn

        Dim strsql As String
        Dim tempID As Long
        Dim tempstr As String = ""

        'strsql = "SELECT SUBSTRING(P_ReportID, 6, 1) AS R_Type, "
        'strsql = strsql & "SUBSTRING(P_ReportID, 4, 2) AS R_Year, "
        'strsql = strsql & "MAX(CONVERT(int, RIGHT(P_ReportID, 3))) AS MaxID "
        'strsql = strsql & "From dbo.P_Report "
        'strsql = strsql & "GROUP BY SUBSTRING(P_ReportID, 4, 2), "
        'strsql = strsql & "SUBSTRING(P_ReportID, 6, 1) "
        'strsql = strsql & "HAVING (SUBSTRING(P_ReportID, 4, 2) = '" & yy & "') "
        'strsql = strsql & "AND (SUBSTRING(P_ReportID, 6, 1) = '" & ReportType & "') "
        strsql = "SELECT SUBSTRING(P_ReportID, 6, 1) AS R_Type, "
        strsql = strsql & "SUBSTRING(P_ReportID, 4, 2) AS R_Year, "
        strsql = strsql & "MAX(CONVERT(int, RIGHT(P_ReportID, 4))) AS MaxID "
        strsql = strsql & "From dbo.P_Report "
        strsql = strsql & "GROUP BY SUBSTRING(P_ReportID, 4, 2), "
        strsql = strsql & "SUBSTRING(P_ReportID, 6, 1) "
        strsql = strsql & "HAVING (SUBSTRING(P_ReportID, 4, 2) = '" & yy & "') "
        strsql = strsql & "AND (SUBSTRING(P_ReportID, 6, 1) = '" & ReportType & "') "


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



    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim strsql As String = ""

            If MsgBox("ยืนยันการบันทักข้อมูล", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If v_frmMode = "Add" Then
                    strsql = "INSERT INTO Proposal "
                    strsql += " (ProposalID, ProposalDate, ProposalDate_1, ProposalCustomer, ClientCustomer, "
                    strsql += " ReportCustomer, ObjectiveID, Remark, ModifiedBy,ModifiedDate) "
                    strsql += "Values('" & txtProposalID.Text & "', "
                    strsql += "'" & Format(dtpProposalDate.Value.Year, "0000") & Format(dtpProposalDate.Value.Month, "00") & Format(dtpProposalDate.Value.Day, "00") & "', "
                    strsql += "'" & Format(dtpProposalDate.Value.Year, "0000") & Format(dtpProposalDate.Value.Month, "00") & Format(dtpProposalDate.Value.Day, "00") & "', "
                    strsql += "'" & Me.cboProposalCustomer.SelectedValue & "', "
                    strsql += "'" & Me.cboClientCustomer.SelectedValue & "', "
                    strsql += "'" & Me.cboReportCustomer.SelectedValue & "', "
                    strsql += "'" & Me.cboObjectiveID.SelectedValue & "', "
                    strsql += "'" & Me.txtRemark.Text & "', "
                    strsql += "'" & v_UserName & "', "
                    strsql += "getdate()) "
                    If Not objDB.funExecuteNonQuery(strsql) Then
                        MsgBox("Error Insert Proposal")
                        Exit Sub
                    End If
                    'Proposal detail
                    strsql = "INSERT INTO ProposalDetail "
                    strsql += "(ProposalID, PropertyNo, ObjectiveID, PropertyTypeID, PropertyTypeDetailID, "
                    strsql += "Address, Soi, Road, ProvinceID, AmphoeID, "
                    strsql += "TumbonID, Rai, Ngan, SqWah, SqMeter, "
                    strsql += "ModifiedBy,ModifiedDate) Values ("
                    strsql += "'" & txtProposalID.Text & "', "
                    strsql += "'1', "
                    strsql += "'" & cboObjectiveID.SelectedValue & "', "
                    strsql += "'" & cboPropertyTypeID.SelectedValue & "', "
                    strsql += "'" & cboPropertyTypeDetailID.SelectedValue & "', "
                    strsql += "'" & txtAddress.Text & "', "
                    strsql += "'" & txtSoi.Text & "', "
                    strsql += "'" & txtRoad.Text & "', "
                    strsql += "'" & cboProvinceID.SelectedValue & "', "
                    strsql += "'" & cboAmphoeID.SelectedValue & "', "
                    strsql += "'" & cboTumbonID.SelectedValue & "', "
                    strsql += "'" & txtRai.Text & "', "
                    strsql += "'" & txtNgan.Text & "', "
                    strsql += "'" & txtSqWah.Text & "', "
                    strsql += "'" & txtSqMeter.Text & "', "
                    strsql += "'" & v_UserName & "', "
                    strsql += "getdate())"
                    If Not objDB.funExecuteNonQuery(strsql) Then
                        MsgBox("Error Insert Proposal Detail")
                        Exit Sub
                    End If
                    v_frmMode = "Edit"
                    MsgBox("Save completed")

                ElseIf v_frmMode = "Edit" Then
                    strsql = "UPDATE Proposal Set "
                    strsql += "ProposalDate = '" & Format(dtpProposalDate.Value.Year, "0000") & Format(dtpProposalDate.Value.Month, "00") & Format(dtpProposalDate.Value.Day, "00") & "', "
                    strsql += "ProposalDate_1 = '" & Format(dtpProposalDate.Value.Year, "0000") & Format(dtpProposalDate.Value.Month, "00") & Format(dtpProposalDate.Value.Day, "00") & "', "
                    strsql += "ProposalCustomer = '" & Me.cboProposalCustomer.SelectedValue & "', "
                    strsql += "ClientCustomer = '" & Me.cboClientCustomer.SelectedValue & "', "
                    strsql += "ReportCustomer = '" & Me.cboReportCustomer.SelectedValue & "', "
                    strsql += "ObjectiveID = '" & Me.cboObjectiveID.SelectedValue & "', "
                    strsql += "Remark = '" & txtRemark.Text & "', "
                    strsql += "ModifiedBy = '" & v_UserName & "', "
                    strsql += "ModifiedDate = getdate() "
                    strsql += "Where ProposalID = '" & txtProposalID.Text & "' "
                    If Not objDB.funExecuteNonQuery(strsql) Then
                        MsgBox("Error Update Proposal")
                        Exit Sub
                    End If
                    'Prop Detail
                    strsql = "UPDATE ProposalDetail Set "
                    strsql += "ObjectiveID = '" & cboObjectiveID.SelectedValue & "', "
                    strsql += "PropertyTypeID = '" & cboPropertyTypeID.SelectedValue & "', "
                    strsql += "PropertyTypeDetailID = '" & cboPropertyTypeDetailID.SelectedValue & "', "
                    strsql += "Address = '" & txtAddress.Text & "', "
                    strsql += "Soi = '" & txtSoi.Text & "', "
                    strsql += "Road = '" & txtRoad.Text & "', "
                    strsql += "ProvinceID = '" & cboProvinceID.SelectedValue & "', "
                    strsql += "AmphoeID = '" & cboAmphoeID.SelectedValue & "', "
                    strsql += "TumbonID = '" & cboTumbonID.SelectedValue & "', "
                    strsql += "Rai = '" & txtRai.Text & "', "
                    strsql += "Ngan = '" & txtNgan.Text & "', "
                    strsql += "SqWah = '" & txtSqWah.Text & "', "
                    strsql += "SqMeter = '" & txtSqMeter.Text & "', "
                    strsql += "ModifiedBy = '" & v_UserName & "', "
                    strsql += "ModifiedDate = getdate() "
                    strsql += "Where ProposalID = '" & txtProposalID.Text & "' "
                    If Not objDB.funExecuteNonQuery(strsql) Then
                        MsgBox("Error Update Proposal Detail")
                        Exit Sub
                    End If
                    MsgBox("Save completed")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingcboProvinceID()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select ProvinceID, ProvinceName From  Province Order by ProvinceID "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwProvinceID")
            cboProvinceID.DataSource = myDs.Tables("vwProvinceID")
            cboProvinceID.ValueMember = "ProvinceID"
            cboProvinceID.DisplayMember = "ProvinceName"
            conStr.Close()
            myDs = Nothing
            myDa = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboAmphoeID(ByVal ProvinceID As String)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select AmphoeID, AmphoeName From  Amphoe "
            strsql += "Where ProvinceID = '" & ProvinceID & "' "
            strsql += "Order by AmphoeID "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwAmphoeID")
            cboAmphoeID.DataSource = myDs.Tables("vwAmphoeID")
            cboAmphoeID.ValueMember = "AmphoeID"
            cboAmphoeID.DisplayMember = "AmphoeName"
            conStr.Close()
            myDs = Nothing
            myDa = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboTumbonID(ByVal AmphoeID As String)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select TumbonID, TumbonName From Tumbon "
            strsql += "Where AmphoeID = '" & AmphoeID & "' "
            strsql += "Order by TumbonID "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwTumbonID")
            cboTumbonID.DataSource = myDs.Tables("vwTumbonID")
            cboTumbonID.ValueMember = "TumbonID"
            cboTumbonID.DisplayMember = "TumbonName"
            conStr.Close()
            myDs = Nothing
            myDa = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindingcboAmphoeID(cboProvinceID.SelectedValue)

    End Sub

    Private Sub BindingcboPropertyType()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try

            strsql = "Select PropertyTypeID, PropertyTypeT From  PropertyType Order by PropertyTypeID "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwTypeID")
            cboPropertyTypeID.DataSource = myDs.Tables("vwTypeID")
            cboPropertyTypeID.ValueMember = "PropertyTypeID"
            cboPropertyTypeID.DisplayMember = "PropertyTypeT"
            'cboPropertyTypeID.SelectedIndex = 0
            'cboPropertyTypeID.Text = "All"
            conStr.Close()
            myDs = Nothing
            myDa = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboPropertyTypeDetailID(ByVal PropID As String)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select PropertyTypeDetailID, PropertyDetailT, PropertyTypeID From  PropertyTypeDetail "
            strsql += "WHERE PropertyTypeID = '" & PropID & "' "
            strsql += "Order by PropertyTypeID, PropertyTypeDetailID "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwPropID")
            cboPropertyTypeDetailID.DataSource = myDs.Tables("vwPropID")
            cboPropertyTypeDetailID.ValueMember = "PropertyTypeDetailID"
            cboPropertyTypeDetailID.DisplayMember = "PropertyDetailT"
            conStr.Close()
            myDs = Nothing
            myDa = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboPropertyTypeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyTypeID.SelectedIndexChanged
        Try
            Call BindingcboPropertyTypeDetailID(cboPropertyTypeID.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboAmphoeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAmphoeID.SelectedIndexChanged
        Try
            BindingcboTumbonID(cboAmphoeID.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub
End Class