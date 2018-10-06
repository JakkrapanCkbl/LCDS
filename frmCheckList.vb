Imports System.Data
Imports System.Data.SqlClient

Public Class frmCheckList
    Dim objDB As New clsDB
    Public v_Pkey As String

    Private v_FormMode As String

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim strsql As String = ""

            If v_FormMode = "Add" Then
                strsql = "INSERT INTO CheckList "
                strsql = strsql & "(P_ReportID, Task1, Task2, Task3, Task4, Task5, "
                strsql = strsql & "Task6, Task7, Task8, Task9, Task10, "
                strsql = strsql & "Task11, Task12, Task13, Task14, Task15, "
                strsql = strsql & "Task16, Task17, Task18, Task19, Task20) "
                strsql = strsql & "Values ('" & Me.v_Pkey & "', "
                strsql += CInt(chkTask1.Checked) & ", "
                strsql += CInt(chkTask2.Checked) & ", "
                strsql += CInt(chkTask3.Checked) & ", "
                strsql += CInt(chkTask4.Checked) & ", "
                strsql += CInt(chkTask5.Checked) & ", "
                strsql += CInt(chkTask6.Checked) & ", "
                strsql += CInt(chkTask7.Checked) & ", "
                strsql += CInt(chkTask8.Checked) & ", "
                strsql += "'" & cboTask9.Text & "', "
                strsql += CInt(chkTask10.Checked) & ", "
                strsql += CInt(chkTask11.Checked) & ", "
                strsql += CInt(chkTask12.Checked) & ", "
                strsql += "'" & cboTask13.Text & "', "
                strsql += CInt(chkTask14.Checked) & ", "
                strsql += CInt(chkTask15.Checked) & ", "
                strsql += CInt(chkTask16.Checked) & ", "
                strsql += CInt(chkTask17.Checked) & ", "
                strsql += CInt(chkTask18.Checked) & ", "
                strsql += CInt(chkTask19.Checked) & ", "
                strsql += CInt(chkTask20.Checked) & ") "
            ElseIf v_FormMode = "Edit" Then
                strsql = "Update CheckList Set "
                strsql += "Task1 = " & CInt(chkTask1.Checked) & ", "
                strsql += "Task2 = " & CInt(chkTask2.Checked) & ", "
                strsql += "Task3 = " & CInt(chkTask3.Checked) & ", "
                strsql += "Task4 = " & CInt(chkTask4.Checked) & ", "
                strsql += "Task5 = " & CInt(chkTask5.Checked) & ", "
                strsql += "Task6 = " & CInt(chkTask6.Checked) & ", "
                strsql += "Task7 = " & CInt(chkTask7.Checked) & ", "
                strsql += "Task8 = " & CInt(chkTask8.Checked) & ", "
                strsql += "Task9 = '" & cboTask9.Text & "', "
                strsql += "Task10 = " & CInt(chkTask10.Checked) & ", "
                strsql += "Task11 = " & CInt(chkTask11.Checked) & ", "
                strsql += "Task12 = " & CInt(chkTask12.Checked) & ", "
                strsql += "Task13 = '" & cboTask13.Text & "', "
                strsql += "Task14 = " & CInt(chkTask14.Checked) & ", "
                strsql += "Task15 = " & CInt(chkTask15.Checked) & ", "
                strsql += "Task16 = " & CInt(chkTask16.Checked) & ", "
                strsql += "Task17 = " & CInt(chkTask17.Checked) & ", "
                strsql += "Task18 = " & CInt(chkTask18.Checked) & ", "
                strsql += "Task19 = " & CInt(chkTask19.Checked) & ", "
                strsql += "Task20 = " & CInt(chkTask20.Checked) & " "
                strsql = strsql & "WHERE "
                strsql = strsql & "P_ReportID = '" & v_Pkey & "'"
            End If
            If objDB.funExecuteNonQuery(strsql) Then
                MsgBox("Save Completed.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCheckList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Check List for " & Me.v_Pkey
        Me.v_FormMode = MyFind(objDB.strConn, "CheckList", "P_ReportID", "P_ReportID = '" & Me.v_Pkey & "'")
        If Me.v_FormMode = "" Then
            Me.v_FormMode = "Add"
        Else
            Me.v_FormMode = "Edit"
        End If
        If Me.v_FormMode = "Add" Then
            Call ClearData()
        Else
            Call BindingData()
        End If
    End Sub

    Private Sub ClearData()
        chkTask1.Checked = False
        chkTask2.Checked = False
        chkTask3.Checked = False
        chkTask4.Checked = False
        chkTask5.Checked = False
        chkTask6.Checked = False
        chkTask7.Checked = False
        chkTask8.Checked = False
        cboTask9.Text = ""
        chkTask10.Checked = False
        chkTask11.Checked = False
        chkTask12.Checked = False
        cboTask13.Text = ""
        chkTask14.Checked = False
        chkTask15.Checked = False
        chkTask16.Checked = False
        chkTask17.Checked = False
        chkTask18.Checked = False
        chkTask19.Checked = False
        chkTask20.Checked = False
    End Sub

    Private Sub BindingData()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM CheckList WHERE P_ReportID='" & v_Pkey & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    chkTask1.Checked = CBool(dr.Item("Task1").ToString)
                    chkTask2.Checked = CBool(dr.Item("Task2").ToString)
                    chkTask3.Checked = CBool(dr.Item("Task3").ToString)
                    chkTask4.Checked = CBool(dr.Item("Task4").ToString)
                    chkTask5.Checked = CBool(dr.Item("Task5").ToString)
                    chkTask6.Checked = CBool(dr.Item("Task6").ToString)
                    chkTask7.Checked = CBool(dr.Item("Task7").ToString)
                    chkTask8.Checked = CBool(dr.Item("Task8").ToString)
                    cboTask9.Text = dr.Item("Task9").ToString
                    chkTask10.Checked = CBool(dr.Item("Task10").ToString)
                    chkTask11.Checked = CBool(dr.Item("Task11").ToString)
                    chkTask12.Checked = CBool(dr.Item("Task12").ToString)
                    cboTask13.Text = dr.Item("Task13").ToString
                    chkTask14.Checked = CBool(dr.Item("Task14").ToString)
                    chkTask15.Checked = CBool(dr.Item("Task15").ToString)
                    chkTask16.Checked = CBool(dr.Item("Task16").ToString)
                    chkTask17.Checked = CBool(dr.Item("Task17").ToString)
                    chkTask18.Checked = CBool(dr.Item("Task18").ToString)
                    chkTask19.Checked = CBool(dr.Item("Task19").ToString)
                    chkTask20.Checked = CBool(dr.Item("Task20").ToString)
                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class