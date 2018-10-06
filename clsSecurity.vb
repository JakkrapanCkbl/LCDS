Imports System.Data
Imports System.Data.SqlClient

Public Class clsSecurity

    Private _AllowView As Boolean
    Private _AllowAdd As Boolean
    Private _AllowEdit As Boolean
    Private _AllowDelete As Boolean
    Private _AllowPrint As Boolean



    Public Property AllowView() As Boolean
        Get
            Return _AllowView
        End Get
        Set(ByVal value As Boolean)
            _AllowView = value
        End Set
    End Property

    Public Property AllowAdd() As Boolean
        Get
            Return _AllowAdd
        End Get
        Set(ByVal value As Boolean)
            _AllowAdd = value
        End Set
    End Property

    Public Property AllowEdit() As Boolean
        Get
            Return _AllowEdit
        End Get
        Set(ByVal value As Boolean)
            _AllowEdit = value
        End Set
    End Property

    Public Property AllowDelete() As Boolean
        Get
            Return _AllowDelete
        End Get
        Set(ByVal value As Boolean)
            _AllowDelete = value
        End Set
    End Property

    Public Property AllowPrint() As Boolean
        Get
            Return _AllowPrint
        End Get
        Set(ByVal value As Boolean)
            _AllowPrint = value
        End Set
    End Property

    Public ReadOnly Property UserID() As Integer
        Get
            Return v_UserID
        End Get

    End Property



    Public Function CheckUser(ByVal UserName As String, ByVal Password As String) As Boolean
       

        Dim strsql As String
        Dim Result As String = ""
        Dim Result2 As String = ""
        Dim Result3 As String = ""
        Dim Result4 As Integer
        Dim objDB As New clsDB
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        strsql = "Select * "
        strsql = strsql & "From vwUserAccount "
        strsql = strsql & "Where LoginName = '" & UserName & "' "
        strsql = strsql & "And Password_1 = '" & Password & "' "
        Dim comm As New SqlCommand(strsql, conStr)
        conStr.Open()
        Dim dr As SqlDataReader = comm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Result = dr.Item("LoginName").ToString
                Result2 = dr.Item("UserLoginID").ToString
                Result3 = dr.Item("ShowName").ToString
                Result4 = dr.Item("UserLevelID").ToString
            End While
        End If
        dr.Close()
        conStr.Close()
        If Result = "" Then
            Return False
        Else
            v_LogInName = Result
            v_UserID = Result2
            v_UserName = Result3
            v_UserLevel = Result4
            Call SetUserLogin(UserName, Password)
            Return True
        End If
        
    End Function

    Private Sub SetUserLogin(ByVal UserName As String, ByVal Password As String)
        Try
            Dim conStr As New SqlClient.SqlConnection
            Dim objdb As New clsDB
            conStr.ConnectionString = objdb.strConn
            Dim strsql As String
            strsql = "Select FullName, UserLevelID "
            strsql = strsql & "From UserLogin "
            strsql = strsql & "Where LoginName = '" & UserName & "' "
            strsql = strsql & "And Password = '" & Password & "' "

            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read

                    v_LogInName = dr.Item("FullName").ToString
                    v_UserGroup = dr.Item("UserLevelID").ToString
                End While
            End If
            dr.Close()
            conStr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Public Sub GetAttribute(ByVal ZoneNo As Integer)
        Dim conStr As New SqlClient.SqlConnection
        Dim objdb As New clsDB
        Dim temp As String
        conStr.ConnectionString = objdb.strConn
        Try
            conStr.Open()
            Dim sql As String = "SELECT UserLoginID, SecureZone" & ZoneNo & " "
            sql = sql & "FROM UserLogin "
            sql = sql & "WHERE UserLoginID = '" & v_UserID & "' "

            Dim comm As New SqlCommand(sql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                temp = dr.GetValue(1).ToString
                If temp = "" Then
                    Me.AllowView = False
                    Me.AllowAdd = False
                    Me.AllowEdit = False
                    Me.AllowDelete = False
                    Me.AllowPrint = False
                    dr.Close()
                    Exit Sub
                End If
                If Strings.Left(temp, 1) = "1" Then
                    Me.AllowView = True
                Else
                    Me.AllowView = False
                End If
                If Strings.Mid(temp, 2, 1) = "1" Then
                    Me.AllowAdd = True
                Else
                    Me.AllowAdd = False
                End If
                If Strings.Mid(temp, 3, 1) = "1" Then
                    Me.AllowEdit = True
                Else
                    Me.AllowEdit = False
                End If
                If Strings.Mid(temp, 4, 1) = "1" Then
                    Me.AllowDelete = True
                Else
                    Me.AllowDelete = False
                End If
                If Strings.Right(temp, 1) = "1" Then
                    Me.AllowPrint = True
                Else
                    Me.AllowPrint = False
                End If
            Else
                Me.AllowView = False
                Me.AllowAdd = False
                Me.AllowEdit = False
                Me.AllowDelete = False
                Me.AllowPrint = False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conStr.Dispose()
        End Try
    End Sub
End Class
