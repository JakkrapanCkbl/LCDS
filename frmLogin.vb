Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim objDB As New clsDB

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        
        Application.Exit()
        'Me.Close()
    End Sub

    

    

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(Application.ProductVersion)
        Me.Text = "Data Management (Ver. " & Application.ProductVersion & ")"
        If AlreadyRunning() Then
            MessageBox.Show( _
                "Another instance is already running.", _
                "Already Running", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Exclamation)
            Me.Close()
        End If
        InnitApp()
        Me.AcceptButton = btnOK
        btnOK.DialogResult = Windows.Forms.DialogResult.OK

    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim objSecu As New clsSecurity
        If objSecu.CheckUser(txtUserName.Text, txtPassword.Text) Then
            frmMain.Show()
            'frmQboard.Show()
            Me.Hide()
        Else
            MsgBox("Login  fail!", MsgBoxStyle.Exclamation)
        End If
    End Sub


   
End Class
