Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient

Public Class frmRecive

    Dim objSecurity As New clsSecurity
    Dim v_ReceiveID As String
    Const ZoneNo = 7

    Private Sub frmRecive_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmRecive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetSecurity()
        dtp1.Value = Today.AddDays(-90)
        dtp2.Value = Today
        Dim strWc As String
        strWc = "Where (ReceiveDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
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

    Public Sub ShowDataGrid(ByVal wc As String)
        Dim objDB As New clsDB
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from vw_ReceiveList "
        strsql += wc
        strsql += "Order by ReceiveDate_1 desc "
        Dim ColAll As Integer = 13
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

    Private Sub chkMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMode.CheckedChanged
        If chkMode.Checked Then
            Call ShowDataGrid("")
        Else
            Dim strWc As String
            strWc = "Where (ReceiveDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            Call ShowDataGrid(strWc)
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmEditRecive.v_FormMode = "Add"
        frmEditRecive.ShowDialog()
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        If fg.Rows.Count > 1 Then
            v_ReceiveID = fg(fg.Row, 1).ToString
        Else
            v_ReceiveID = ""
        End If
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        If fg.Rows.Count > 1 Then
            v_ReceiveID = fg(fg.Row, 1).ToString
            frmEditRecive.v_ReceiveID = v_ReceiveID
            frmEditRecive.v_FormMode = "Edit"
            frmEditRecive.ShowDialog()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If fg.Rows.Count > 1 Then
                Dim objDB As New clsDB
                Dim strsql As String
                If MsgBox("Do you want to delete ReceiveID = '" & fg(fg.Row, 1) & "' ", MsgBoxStyle.YesNo, "Confirm delete") = MsgBoxResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    'delete Drawing_Register
                    strsql = "Delete from Receive "
                    strsql += "WHERE (ReceiveID = '" & v_ReceiveID & "') "
                    objDB.ExecuteNonQuery(strsql)
                    'delete Drawing_Revision
                    Dim strWc As String
                    strWc = "Where (ReceiveDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
                    Call ShowDataGrid(strWc)
                    Cursor = Cursors.Default
                    MsgBox("Delete completed")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class