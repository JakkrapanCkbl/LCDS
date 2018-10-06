Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient

Public Class frmURL

    Dim objDB As New clsDB

    Private Sub frmURL_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmURL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BindingcboAddress()
        Call ShowDataGrid()
        chkNotFirstOpen.Checked = True
        If Option1.Checked Then
            cboAddress.Text = fg(fg.Row, 16).ToString
            WebBrowser1.Navigate(fg(fg.Row, 16).ToString)
        End If
        If Option2.Checked Then
            cboAddress.Text = fg(fg.Row, 17).ToString
            WebBrowser1.Navigate(fg(fg.Row, 17).ToString)
        End If
    End Sub

    Public Sub ShowDataGrid(Optional ByVal wc As String = "")
        Dim objDB As New clsDB
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        If Check1.Checked Then
            strsql = "SELECT TOP 30 * "
        Else
            strsql = "SELECT TOP 100 PERCENT * "
        End If
        strsql += "from vwURL_New "
        strsql += wc
        strsql += "ORDER BY URLID DESC "
        Dim ColAll As Integer = 18
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
            'lblSample.Text = "Total : " & fg.Rows.Count - 1 & " Records"
            'WebBrowser1.Navigate(fg(1, 16).ToString)
        End With


    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        cboAddress.Text = ""
        If Option1.Checked Then
            cboAddress.Text = fg(fg.Row, 16).ToString
            WebBrowser1.Navigate(fg(fg.Row, 16).ToString)
        End If
        If Option2.Checked Then
            cboAddress.Text = fg(fg.Row, 17).ToString
            WebBrowser1.Navigate(fg(fg.Row, 17).ToString)
        End If
      

    End Sub

    Private Sub BindingcboAddress()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            strsql = "Select * From TempURL "

            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwTempURL")
            cboAddress.DataSource = myDs.Tables("vwTempURL")
            cboAddress.ValueMember = "Urlname"
            cboAddress.DisplayMember = "UrlDescription"

            'cboEmployeeID.SelectedIndex = 1
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cboAddress.Text = "" Then
            WebBrowser1.Navigate(cboAddress.Text)
        Else
            WebBrowser1.Navigate(cboAddress.SelectedValue)
        End If
    End Sub

    Private Sub Check1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check1.CheckedChanged
        If chkNotFirstOpen.Checked Then
            Call ShowDataGrid()
        End If
    End Sub

    Private Sub frmURL_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        fg.Location = New Size(0, Line0.Y2)
        fg.Width = Me.Width - 10
        cboAddress.Location = New Size(5, Line1.Y2)
        WebBrowser1.Location = New Size(0, Line2.Y2)
        WebBrowser1.Width = Me.Width - 10
        WebBrowser1.Height = Me.Height / 2
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        If txtSearch.Text = "" Then
            Exit Sub
        Else
            Dim WCx As String
            WCx = "Where PropertyDetailT Like '%" & txtSearch.Text & "%' "
            WCx += "Or Location like '%" & txtSearch.Text & "%' "
            WCx += "Or ProjectName like '%" & txtSearch.Text & "%' "
            WCx += "Or Soi like '%" & txtSearch.Text & "%' "
            WCx += "Or Road like '%" & txtSearch.Text & "%' "
            WCx += "Or TumbonName like '%" & txtSearch.Text & "%' "
            WCx += "Or AmphoeName like '%" & txtSearch.Text & "%' "
            WCx += "Or ProvinceName like '%" & txtSearch.Text & "%' "
            Cursor = Cursors.WaitCursor
            ShowDataGrid(WCx)
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmEditURL.v_FormMode = "Add"
        frmEditURL.Show()
        Me.Hide()
    End Sub

    Private Sub fg_DoubleClick(sender As Object, e As EventArgs) Handles fg.DoubleClick
        If fg.Rows.Count > 1 Then
            'v_ReceiveID = fg(fg.Row, 1).ToString
            frmEditURL.v_UrlID = fg(fg.Row, 1).ToString
            frmEditURL.v_FormMode = "Edit"
            frmEditURL.ShowDialog()
        End If
    End Sub
End Class