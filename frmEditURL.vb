Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmEditURL


    Public v_FormMode As String
    Public v_UrlID As String
    Dim objDB As New clsDB

    Private Sub frmEditURL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingcboPropertyType()
        BindingcboProvinceID()

        If v_FormMode = "Add" Then
            txtURLID.Text = NewID("URL", "URLID")
            cmdSaveAs.Text = "Save As"
        Else
            cmdSaveAs.Text = "View"
            Call BindingData()
        End If
    End Sub

    Private Sub BindingData()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM URL WHERE UrlID='" & v_UrlID & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtURLID.Text = dr.Item("UrlID").ToString
                    txtURLGlobal.Text = dr.Item("URLGlobal").ToString
                    txtURLLocal.Text = dr.Item("URLLocal").ToString
                    WebBrowser1.Navigate(txtURLLocal.Text)
                    txtProjectName.Text = dr.Item("ProjectName").ToString
                    txtLocation.Text = dr.Item("Location").ToString
                    txtRoad.Text = dr.Item("Road").ToString
                    txtSoi.Text = dr.Item("Soi").ToString
                    cboProvinceID.SelectedValue = dr.Item("ProvinceID").ToString
                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            strsql = "Select AmphoeID, AmphoeName From  Amphoe Order by AmphoeID "
            strsql += "Where ProvinceID = '" & ProvinceID & "' "
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
            strsql = "Select TumbonID, TumbonName From  Tumbon Order by TumbonID "
            strsql += "Where AmphoeID = '" & AmphoeID & "' "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwTumbonID")
            cboAmphoeID.DataSource = myDs.Tables("vwTumbonID")
            cboAmphoeID.ValueMember = "TumbonID"
            cboAmphoeID.DisplayMember = "TumbonName"
            conStr.Close()
            myDs = Nothing
            myDa = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmEditURL_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmURL.Show()
    End Sub

    Private Sub cmdSaveURL_Click(sender As Object, e As EventArgs) Handles cmdSaveURL.Click
        WebBrowser1.Navigate(txtURLGlobal.Text)
    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            Dim strsql As String = ""

            If v_FormMode = "Add" Then
                strsql = "INSERT INTO URL "
                strsql += "(URLID, URLGlobal, URLLocal, "
                strsql += "Location, ProjectName, Soi, Road, "
                strsql += "ProvinceID, "
                strsql += "InputBy, InputDate, ModifiedBy, ModifiedDate) "
                strsql += "Values ('" & txtURLID.Text & "',"
                strsql += "'" & txtURLGlobal.Text & "', "
                strsql += "'" & txtURLLocal.Text & "', "
                strsql += "'" & txtLocation.Text & "', "
                strsql += "'" & txtProjectName.Text & "', "
                strsql += "'" & txtSoi.Text & "', "
                strsql += "'" & txtRoad.Text & "', "
                strsql += "'" & cboProvinceID.SelectedValue & "', "
                strsql += "'" & v_LogInName & "', "
                strsql += "'" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "', "
                strsql += "'" & v_LogInName & "', "
                strsql += "'" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "') "
            Else
                strsql = "Update URL Set "
                strsql += "URLGlobal = '" & txtURLGlobal.Text & "', "
                strsql += "URLLocal = '" & txtURLLocal.Text & "', "
                strsql += "ProjectName = '" & txtProjectName.Text & "', "
                strsql += "Location = '" & txtLocation.Text & "', "
                strsql += "Road = '" & txtRoad.Text & "', "
                strsql += "Soi = '" & txtSoi.Text & "', "
                strsql += "ProvinceID = '" & cboProvinceID.SelectedValue & "', "
                strsql += "ModifiedBy = '" & v_LogInName & "', "
                strsql += "ModifiedDate = '" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "' "
                strsql += "WHERE "
                strsql += "URLID = '" & v_UrlID & "'"
            End If
            If Not objDB.funExecuteNonQuery(strsql) Then
                MsgBox("ไม่สามารถทำการบันทึกรายการได้ กรุณาตรวจสอบข้อมูล", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            frmURL.ShowDataGrid()
            MsgBox("Save Completed")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmURL.Show()
        Me.Close()

    End Sub

    Private Sub cmdSaveAs_Click(sender As Object, e As EventArgs) Handles cmdSaveAs.Click
        If v_FormMode = "Add" Then
            txtURLLocal.Text = "Z:\@URL\" & txtURLID.Text & ".htm"
            WebBrowser1.ShowSaveAsDialog()
            MessageBox.Show("completed")
        Else
            WebBrowser1.Navigate(txtURLLocal.Text)
        End If

    End Sub



    Private Sub cboProvinceID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvinceID.SelectedIndexChanged
        'BindingcboAmphoeID(cboProvinceID.SelectedValue)

    End Sub

    Private Sub cboAmphoeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAmphoeID.SelectedIndexChanged
        'BindingcboTumbonID(cboAmphoeID.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub cboPropertyTypeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyTypeID.SelectedIndexChanged

    End Sub
End Class