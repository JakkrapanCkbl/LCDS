Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditPercent
    Public v_Pkey As String
    Public v_Code As String
    Dim objDB As New clsDB

    Private Sub frmEditPercent_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub



    Private Sub frmEditPercent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim JT As String
        JT = GetJobSize(v_Pkey, v_Code)
        Select Case JT
            Case "", "S"
                Me.Text = "บันทึกความคืบหน้าการทำงาน " & v_Pkey & " (Small)"
                Label1.Text = "1.เตรียมเอกสาร (ภาพถ่ายทางอากาศ+เช็คข้อมูล)"
                Label2.Text = "2.รูปถ่าย (Pwt) + บรรยายใต้ภาพ"
                Label3.Text = "3.Appendices"
                Label4.Text = "4.เช็คข้อมูลทางโทรศัพท์/เช็คหน่วยราชการ ฯลฯ"
                Label5.Text = "5.คำนวณพื้นที่/อาคาร"
                Label6.Text = "6.เขียนรายงาน"
                Label7.Text = "7.ตรวจทานงานก่อนส่งตรวจ"
            Case "M"
                Me.Text = "บันทึกความคืบหน้าการทำงาน " & v_Pkey & " (Middle)"
                Label1.Text = "1.เตรียมเอกสาร (ภาพถ่ายทางอากาศ+เช็คข้อมูล)"
                Label2.Text = "2.รูปถ่าย (Pwt) + บรรยายใต้ภาพ"
                Label3.Text = "3.Appendices"
                Label4.Text = "4.เช็คข้อมูลทางโทรศัพท์/เช็คหน่วยราชการ ฯลฯ"
                Label5.Text = "5.คำนวณพื้นที่/อาคาร"
                Label6.Text = "6.เขียนรายงาน"
                Label7.Text = "7.ตรวจทานงานก่อนส่งตรวจ"
            Case "L"
                Me.Text = "บันทึกความคืบหน้าการทำงาน " & v_Pkey & " (Large)"
                Label1.Text = "1.เตรียมเอกสาร (ภาพถ่ายทางอากาศ+เช็คข้อมูล)"
                Label2.Text = "2.รูปถ่าย (Pwt) + บรรยายใต้ภาพ"
                Label3.Text = "3.Appendices"
                Label4.Text = "4.เช็คข้อมูลทางโทรศัพท์/เช็คหน่วยราชการ ฯลฯ"
                Label5.Text = "5.คำนวณพื้นที่/อาคาร"
                Label6.Text = "6.เขียนรายงาน"
                Label7.Text = "7.ตรวจทานงานก่อนส่งตรวจ"
        End Select
        '------
        '    Call SetCombo()
        Call BindingData()
        '    Call cboItemNo_Click()
        '    If v_Worktype Then
        '        Me.Frame4.Enabled = False
        '        txtMarketValue.Locked = True
        '    Else
        '        Me.Frame4.Enabled = True
        '        txtMarketValue.Locked = False
        '    End If
        'End Sub
    End Sub

    Private Function GetJobSize(ByVal ReportID As String, ByVal ReportCode As String) As String

        Dim strsql As String
        Dim temp As String
        strsql = "SELECT JobSize, P_ReportID, P_CodeID "
        strsql = strsql & "From OrderSheet "
        strsql = strsql & "Where (P_ReportID = '" & ReportID & "') "
        If ReportCode <> "" Then
            strsql = strsql & "And (P_CodeID = '" & ReportCode & "') "
        End If
        temp = objDB.ExecuteScalar(strsql)
        Return temp
    End Function

    Private Sub BindingData()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim strsql As String

        Try
            strsql = "SELECT * FROM P_Report WHERE P_ReportID='" & v_Pkey & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.cboChk1.Text = dr.Item("Chk1") & ""
                    Me.txtLast1.Text = dr.Item("Chk1_1") & ""
                    Me.cboChk1_1.Text = dr.Item("Chk1_1") & ""
                    Me.cboChk2.Text = dr.Item("Chk2") & ""
                    Me.txtLast2.Text = dr.Item("Chk2_1") & ""
                    Me.cboChk2_1.Text = dr.Item("Chk2_1") & ""
                    Me.cboChk3.Text = dr.Item("Chk3") & ""
                    Me.txtLast3.Text = dr.Item("Chk3_1") & ""
                    Me.cboChk3_1.Text = dr.Item("Chk3_1") & ""
                    Me.cboChk4.Text = dr.Item("Chk4") & ""
                    Me.txtLast4.Text = dr.Item("Chk4_1") & ""
                    Me.cboChk4_1.Text = dr.Item("Chk4_1") & ""
                    Me.cboChk5.Text = dr.Item("Chk5") & ""
                    Me.txtLast5.Text = dr.Item("Chk5_1") & ""
                    Me.cboChk5_1.Text = dr.Item("Chk5_1") & ""
                    Me.cboChk6.Text = dr.Item("Chk6") & ""
                    Me.txtLast6.Text = dr.Item("Chk6_1") & ""
                    Me.cboChk7.Text = dr.Item("Chk7") & ""
                    Me.txtLast7.Text = dr.Item("Chk7_1") & ""
                    Me.cboChk6_1.Text = dr.Item("Chk6_1") & ""
                    Me.cboChk7_1.Text = dr.Item("Chk7_1") & ""
                    Me.txtPercent.Text = dr.Item("PercentTask") & ""
                    Me.txtLast8.Text = dr.Item("PercentCompletion") & ""
                    Me.txtPercent2.Text = dr.Item("PercentCompletion") & ""
                    Me.txtCommentEmploy.Text = dr.Item("CommentEmploy") & ""
                    Me.txtCommentCus.Text = dr.Item("CommentCus") & ""
                    Me.txtCommentLC.Text = dr.Item("CommentLC") & ""
                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmdDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDefault.Click
        Dim JT As String
        JT = GetJobSize(v_Pkey, v_Code)
        Select Case JT
            Case "", "S"
                cboChk1.Text = 10
                cboChk2.Text = 10
                cboChk3.Text = 25
                cboChk4.Text = 10
                cboChk5.Text = 10
                cboChk6.Text = 25
                cboChk7.Text = 10
            Case "M", "L"
                cboChk1.Text = 10
                cboChk2.Text = 10
                cboChk3.Text = 20
                cboChk4.Text = 10
                cboChk5.Text = 10
                cboChk6.Text = 30
                cboChk7.Text = 10
        End Select
        Call SumPercent()
    End Sub

    Private Sub SumPercent()
        Try
            txtPercent.Text = CInt(cboChk1.Text) + CInt(cboChk2.Text) + CInt(cboChk3.Text) + CInt(cboChk4.Text) + CInt(cboChk5.Text) + CInt(cboChk6.Text) + CInt(cboChk7.Text)
            Me.txtKeep1.Text = Format((CSng(Me.cboChk1_1.Text) * CSng(Me.cboChk1.Text)) / 100, "#,##0.00")
            Me.txtKeep2.Text = Format((CSng(Me.cboChk2_1.Text) * CSng(Me.cboChk2.Text)) / 100, "#,##0.00")
            Me.txtKeep3.Text = Format((CSng(Me.cboChk3_1.Text) * CSng(Me.cboChk3.Text)) / 100, "#,##0.00")
            Me.txtKeep4.Text = Format((CSng(Me.cboChk4_1.Text) * CSng(Me.cboChk4.Text)) / 100, "#,##0.00")
            Me.txtKeep5.Text = Format((CSng(Me.cboChk5_1.Text) * CSng(Me.cboChk5.Text)) / 100, "#,##0.00")
            Me.txtKeep6.Text = Format((CSng(Me.cboChk6_1.Text) * CSng(Me.cboChk6.Text)) / 100, "#,##0.00")
            Me.txtKeep7.Text = Format((CSng(Me.cboChk7_1.Text) * CSng(Me.cboChk7.Text)) / 100, "#,##0.00")
            Me.txtPercent2.Text = Format((CSng(txtKeep1.Text) + CSng(Me.txtKeep2.Text) + CSng(Me.txtKeep3.Text) + CSng(Me.txtKeep4.Text) + CSng(Me.txtKeep5.Text) + CSng(Me.txtKeep6.Text) + CSng(Me.txtKeep7.Text)), "#,##0.00")
        Catch ex As Exception

        End Try
        
    End Sub



    
    Private Sub cboChk1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk1.SelectedIndexChanged
        SumPercent()
    End Sub



    Private Sub cboChk2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk2.SelectedIndexChanged
        SumPercent()
    End Sub



    Private Sub cboChk3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk3.SelectedIndexChanged
        SumPercent()
    End Sub



    Private Sub cboChk4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk4.SelectedIndexChanged
        SumPercent()
    End Sub



    Private Sub cboChk5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk5.SelectedIndexChanged
        SumPercent()
    End Sub



    Private Sub cboChk6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk6.SelectedIndexChanged
        SumPercent()
    End Sub


    Private Sub cboChk7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk7.SelectedIndexChanged
        SumPercent()
    End Sub


    Private Sub cboChk1_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk1_1.SelectedIndexChanged
        Me.txtPC1.Text = ((CSng(Me.cboChk1_1.Text) - CSng(Me.txtLast1.Text)) * 100) / 100
        SumPercent()
    End Sub



    Private Sub cboChk2_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk2_1.SelectedIndexChanged
        Me.txtPC2.Text = ((CSng(Me.cboChk2_1.Text) - CSng(Me.txtLast2.Text)) * 100) / 100
        SumPercent()
    End Sub



    Private Sub cboChk3_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk3_1.SelectedIndexChanged
        Me.txtPC3.Text = ((CSng(Me.cboChk3_1.Text) - CSng(Me.txtLast3.Text)) * 100) / 100
        SumPercent()
    End Sub



    Private Sub cboChk4_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk4_1.SelectedIndexChanged
        Me.txtPC4.Text = ((CSng(Me.cboChk4_1.Text) - CSng(Me.txtLast4.Text)) * 100) / 100
        SumPercent()
    End Sub



    Private Sub cboChk5_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk5_1.SelectedIndexChanged
        Me.txtPC5.Text = ((CSng(Me.cboChk5_1.Text) - CSng(Me.txtLast5.Text)) * 100) / 100
        SumPercent()
    End Sub

    Private Sub cboChk6_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboChk6_1.Click

    End Sub

    Private Sub cboChk6_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk6_1.SelectedIndexChanged
        Me.txtPC6.Text = ((CSng(Me.cboChk6_1.Text) - CSng(Me.txtLast6.Text)) * 100) / 100
        SumPercent()
    End Sub



    Private Sub cboChk7_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChk7_1.SelectedIndexChanged
        Me.txtPC7.Text = ((CSng(Me.cboChk7_1.Text) - CSng(Me.txtLast7.Text)) * 100) / 100
        SumPercent()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim strsql As String = ""
            
            If MsgBox("ยืนยันการบันทึกรายการ?", MsgBoxStyle.YesNo, "ยืนยัน") = MsgBoxResult.Yes Then
                
               
                strsql = "Update P_Report Set "
                strsql = strsql & "Chk1 = '" & Me.cboChk1.Text & "', "
                strsql = strsql & "Chk1_1 = '" & Me.cboChk1_1.Text & "', "
                strsql = strsql & "Chk2 = '" & Me.cboChk2.Text & "', "
                strsql = strsql & "Chk2_1 = '" & Me.cboChk2_1.Text & "', "
                strsql = strsql & "Chk3 = '" & Me.cboChk3.Text & "', "
                strsql = strsql & "Chk3_1 = '" & Me.cboChk3_1.Text & "', "
                strsql = strsql & "Chk4 = '" & Me.cboChk4.Text & "', "
                strsql = strsql & "Chk4_1 = '" & Me.cboChk4_1.Text & "', "
                strsql = strsql & "Chk5 = '" & Me.cboChk5.Text & "', "
                strsql = strsql & "Chk5_1 = '" & Me.cboChk5_1.Text & "', "
                strsql = strsql & "Chk6 = '" & Me.cboChk6.Text & "', "
                strsql = strsql & "Chk6_1 = '" & Me.cboChk6_1.Text & "', "
                strsql = strsql & "Chk7 = '" & Me.cboChk7.Text & "', "
                strsql = strsql & "Chk7_1 = '" & Me.cboChk7_1.Text & "', "
                strsql = strsql & "PercentTask = '" & txtPercent.Text & "', "
                strsql = strsql & "PercentCompletion = '" & txtPercent2.Text & "', "
                If CInt(Me.txtPercent2.Text) = 100 Then  'set WaitCheck status, SendProofDate
                    strsql = strsql & "WaitCheck = '1', "
                    strsql = strsql & "SendProofDate = getdate(), "
                Else
                    strsql = strsql & "WaitCheck = '0', "
                End If
                strsql = strsql & "PercentProgress = '" & txtPercentProgress.Text & "', "
                If Me.txtCommentEmploy.Text <> "" Then
                    strsql = strsql & "CommentEmploy = '" & Me.txtCommentEmploy.Text & "', "
                End If
                If Me.txtCommentCus.Text <> "" Then
                    strsql = strsql & "CommentCus = '" & Me.txtCommentCus.Text & "', "
                End If
                If Me.txtCommentLC.Text <> "" Then
                    strsql = strsql & "CommentLC = '" & Me.txtCommentLC.Text & "', "
                End If
                strsql = strsql & "ModifiedDate = getdate() "
                strsql = strsql & " WHERE "
                strsql = strsql & " P_ReportID = '" & v_Pkey & "'"
                If Not objDB.funExecuteNonQuery(strsql) Then
                    MsgBox("ไม่สามารถทำการบันทึกรายการได้ กรุณาตรวจสอบข้อมูล", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                Else
                    'insert into ProgressReport
                    Call InsertProgressReport()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertProgressReport()
        Dim strsql As String
        strsql = "Insert into ProgressReport (P_ReportID, P_CodeID, CheckDate, CheckPercent, ModifiedBy) "
        strsql = strsql & "Values ('" & v_Pkey & "', "
        strsql = strsql & "'" & v_Code & "', "
        strsql = strsql & "getdate(), "
        strsql = strsql & "'" & Me.txtPercent2.Text & "', "
        strsql = strsql & "'" & v_UserID & "') "
        objDB.ExecuteNonQuery(strsql)

    End Sub


End Class