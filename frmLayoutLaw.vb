Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmLayoutLaw
    Dim objDB As New clsDB

    Private Sub frmLayoutLaw_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmLayoutLaw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BindingcboProvince()
        Call BindingcboProvince1()
        chkNotFirstOpen.Checked = True
    End Sub

    Private Sub BindingcboProvince()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboProvince.Items.Clear()
            strsql = "SELECT ProvinceID, ProvinceName From Province "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwProvince")
            cboProvince.DataSource = myDs.Tables("vwProvince")
            cboProvince.ValueMember = "ProvinceID"
            cboProvince.DisplayMember = "ProvinceName"
            conStr.Close()
            cboProvince.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingcboProvince1()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String
        Try
            cboProvince1.Items.Clear()
            strsql = "SELECT ProvinceID, ProvinceName From Province "
            conStr.Open()
            Dim myDa As New SqlDataAdapter(strsql, conStr)
            Dim myDs As New DataSet
            myDa.Fill(myDs, "vwProvince")
            cboProvince1.DataSource = myDs.Tables("vwProvince")
            cboProvince1.ValueMember = "ProvinceID"
            cboProvince1.DisplayMember = "ProvinceName"
            conStr.Close()
            cboProvince1.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvince.SelectedIndexChanged
        If chkNotFirstOpen.Checked Then
            BindingGrid("Where ProvinceID = '" & cboProvince.SelectedValue & "' ")
        End If
    End Sub

    Public Sub BindingGrid(Optional ByVal wc As String = "")

        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String = ""
        strsql = "Select * from KK_ZoneLayout "
        strsql += wc
        Dim ColAll As Integer = 7
        With fg
            '.Redraw = True
            '.Clear()
            .Rows.Count = 1
            .Cols.Count = ColAll

            'set format
            fg.Rows.Fixed = 1
            fg.Styles.Alternate.BackColor = Color.LightSteelBlue

            Dim cs As C1.Win.C1FlexGrid.CellStyle
            cs = fg.Styles.Add("Red")
            cs.ForeColor = Color.Red
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("Green")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("SuperGreen")
            cs.ForeColor = Color.Lime
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("Blue")
            cs.ForeColor = Color.Blue
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("Yellow")
            cs.ForeColor = Color.Yellow
            cs = fg.Styles.Add("Bold")
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs.ForeColor = Color.Orange
            cs = fg.Styles.Add("Pre_Re")
            cs.ForeColor = Color.Maroon
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            cs = fg.Styles.Add("PreOnly")
            cs.ForeColor = Color.Green
            cs.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
            'fg2.Cols(0).DataType = GetType(Image)
            'write data
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    fg.Rows.Count = fg.Rows.Count + 1
                    For i = 0 To ColAll - 1
                        Select Case i
                            Case 5, 6
                                If String.IsNullOrEmpty(dr.GetValue(i).ToString) Then
                                    fg(.Rows.Count - 1, i) = False
                                Else
                                    fg(.Rows.Count - 1, i) = True
                                End If
                            Case Else
                                fg(.Rows.Count - 1, i) = dr.GetValue(i).ToString
                        End Select

                    Next i
                End While
            End If
            dr.Close()
            conStr.Close()
        End With
    End Sub

    Private Sub frmLayoutLaw_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        fg.Width = Me.Width - 5
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        chkAddMode.Checked = True
        cmdDelete.Visible = False
        cmdAdd.Visible = False
        cboProvince1.SelectedValue = cboProvince.SelectedValue.ToString
        txtAreaColor.Text = "พื้นที่สี"
        txtAreaColerID.Text = ""
        txtDescription.Text = ""
        txtDescription2.Text = ""
        txtFilename.Text = ""
        Panel1.Visible = True
    End Sub

    Private Sub cmdClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose1.Click
        cmdDelete.Visible = True
        cmdAdd.Visible = True

        fg.Enabled = True
        Panel1.Visible = False
    End Sub


    Private Sub cmdImg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImg1.Click
        Try

            Dim objFileControl As New clsFileControl
            Dim MyPath As String = "d:\"
            OpenFileDialog1.Multiselect = False
            OpenFileDialog1.Title = "Open Picture File"
            OpenFileDialog1.InitialDirectory = MyPath
            OpenFileDialog1.Filter = "JPEG File (*.jpg)|*.jpg|BMP File (*.bmp)|*.bmp"
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.RestoreDirectory = True
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                For Each filename As String In OpenFileDialog1.FileNames
                    txtFilename.Text = filename
                Next
            End If
            Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not ValidateScreen() Then
                Exit Sub
            End If
            ErrorProvider1.Clear()
            Dim strsql As String = ""
            If MsgBox("ยืนยันการบันทึกรายการ?", MsgBoxStyle.YesNo, "ยืนยัน") = MsgBoxResult.Yes Then
                If chkAddMode.Checked Then
                    strsql = "Insert into KK_ZoneLayout "
                    strsql += "(ProvinceID, AreaColor, AreaColerID, Description, Description2) "
                    strsql += "Values ("
                    strsql += "'" & cboProvince1.SelectedValue.ToString & "', "
                    strsql += "'" & txtAreaColor.Text & "', "
                    strsql += "'" & txtAreaColerID.Text & "', "
                    strsql += "'" & txtDescription.Text & "', "
                    strsql += "'" & txtDescription2.Text & "') "
                Else
                    strsql = "Update KK_ZoneLayout Set "
                    strsql += "ProvinceID = '" & cboProvince1.SelectedValue.ToString & "', "
                    strsql += "AreaColor = '" & txtAreaColor.Text & "', "
                    strsql += "AreaColerID = '" & txtAreaColerID.Text & "', "
                    strsql += "Description = '" & txtDescription.Text & "', "
                    strsql += "Description2 = '" & txtDescription2.Text & "' "
                    strsql += "Where ProvinceID = '" & cboProvince1.SelectedValue.ToString & "' "
                    strsql += "And AreaColor = '" & txtTempID.Text & "' "
                End If
                If Not objDB.funExecuteNonQuery(strsql) Then
                    MsgBox("Can't Update Data", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                Else
                    'update image
                    If (txtFilename.Text <> "") Then
                        Cursor = Cursors.WaitCursor
                        Dim wc As String
                        wc = "Where ProvinceID = '" & cboProvince1.SelectedValue.ToString & "' "
                        wc += "And AreaColor = '" & txtAreaColor.Text & "' "
                        UpLoadPDF(txtFilename.Text, "KK_ZoneLayout", "Img1", wc)
                        Cursor = Cursors.Default
                    End If
                End If
                ErrorProvider1.Clear()
                chkAddMode.Checked = False
                cmdDelete.Visible = True
                cmdAdd.Visible = True
                fg.Enabled = True
                'Panel1.Visible = False
                BindingGrid("Where ProvinceID = '" & cboProvince.SelectedValue & "' ")
                MsgBox("Save completed")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateScreen() As Boolean
        If txtAreaColor.Text = "" Then
            ErrorProvider1.SetError(txtAreaColor, "กรุณากรอกพื้นที่สี")
            Return False
        End If
        If txtDescription.Text = "" Then
            ErrorProvider1.SetError(txtDescription, "กรุณากรอกเรื่อง")
            Return False
        End If
        If txtDescription2.Text = "" Then
            ErrorProvider1.SetError(txtDescription2, "กรุณากรอกข้อกฏหมาย")
            Return False
        End If
       

        'If Not objDB.IsNumeric(txtRevision.Text) Then
        '    ErrorProvider1.SetError(txtRevision, "Revision is not number")
        '    Return False
        'End If

        Return True
    End Function

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click

    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        If fg.Rows.Count > 1 Then
            Dim v_WC As String
            v_WC = "Where ProvinceID = '" & cboProvince.SelectedValue.ToString & "' "
            v_WC += "And AreaColor = '" & fg(fg.Row, 1).ToString & "' "
            Dim fn As String = ReplaceSlash2minus(fg(fg.Row, 0)) & "_" & Format(DateTime.Now, "dd-MM-yyyy-hh-mm-ss") & ".jpg"
            If fg.Col = 5 Then
                If fg(fg.Row, 5) Then
                    StartImage("KK_ZoneLayout", "Img1", v_WC, fn)
                End If
            Else
                If fg.Rows.Count > 1 Then
                    cmdDelete.Visible = False
                    cmdAdd.Visible = False
                    fg.Enabled = False
                    chkAddMode.Checked = False
                    txtTempID.Text = fg(fg.Row, 1).ToString
                    BindingData()
                    txtFilename.Text = ""
                    Panel1.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub BindingData()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "Select * From KK_ZoneLayout "
            strsql = strsql & "Where ProvinceID = '" & cboProvince.SelectedValue.ToString & "' "
            strsql += "And AreaColor = '" & fg(fg.Row, 1).ToString & "' "


            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboProvince1.SelectedValue = dr.Item("ProvinceID").ToString
                    txtAreaColor.Text = dr.Item("AreaColor").ToString
                    txtTempID.Text = dr.Item("AreaColor").ToString
                    txtAreaColerID.Text = dr.Item("AreaColerID").ToString
                    txtDescription.Text = dr.Item("Description").ToString
                    txtDescription2.Text = dr.Item("Description2").ToString
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conStr.Close()
        End Try
    End Sub

End Class