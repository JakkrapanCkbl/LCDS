Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient

Public Class frmProposal

    Private Sub frmProposal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmProposal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp1.Value = Today.AddDays(-90)
        dtp2.Value = Today
        Dim strWc As String = ""
        strWc = "Where (ProposalDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
        Call ShowDataGrid(strWc)
    End Sub

    Public Sub ShowDataGrid(ByVal wc As String)
        Dim objDB As New clsDB
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select top 10 * from vw_ProposalList "
        strsql += wc
        strsql += "Order by ProposalDate_1 desc "
        Dim ColAll As Integer = 9
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
            strWc = "Where (ProposalDate_1 BETWEEN '" & Format(dtp1.Value.Year, "0000") + "-" + Format(dtp1.Value.Month, "00") + "-" & Format(dtp1.Value.Day, "00") & "' AND '" & Format(dtp2.Value.Year, "0000") + "-" + Format(dtp2.Value.Month, "00") + "-" & Format(dtp2.Value.Day, "00") & "') "
            Call ShowDataGrid(strWc)
        End If
    End Sub

   
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmEditProposal.v_frmMode = "Add"
        frmEditProposal.ShowDialog()
    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click
        frmEditProposal.v_frmMode = "Edit"
        frmEditProposal.v_ID = fg(fg.Row, 1).ToString
        frmEditProposal.txtID.Text = fg(fg.Row, 2).ToString
        frmEditProposal.ShowDialog()
    End Sub

End Class