Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class clsDB

    Dim objAppSettingsReader As New AppSettingsReader()
    Dim value As String = String.Empty
    'Private _strConn As String = objAppSettingsReader.GetValue("strConn", value.GetType())
    Private _strConn As String = objAppSettingsReader.GetValue("strConn", value.GetType()) & "Dido12345;"
    'Private _cdcsConn As String = objAppSettingsReader.GetValue("cdcsConn", value.GetType()) & "asdf;"
    Private _cdcsConn As String = ""
    Private _MainFolder As String = objAppSettingsReader.GetValue("MainFolder", value.GetType())

    ReadOnly Property strConn() As String
        Get
            Return _strConn
        End Get
    End Property

    ReadOnly Property cdcsConn() As String
        Get
            Return _cdcsConn
        End Get
    End Property

    ReadOnly Property MainFolder() As String
        Get
            Return _MainFolder
        End Get
    End Property

    Public Sub ExecuteNonQuery(ByVal sqlStr As String)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = _strConn
        Dim comm As New SqlCommand(sqlStr, conStr)
        Try
            conStr.Open()
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            comm = Nothing
            conStr.Close()
        End Try
    End Sub


    Public Function funExecuteNonQuery(ByVal sqlStr As String) As Boolean
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = _strConn
        Dim comm As New SqlCommand(sqlStr, conStr)
        Try
            conStr.Open()
            comm.ExecuteNonQuery()
            funExecuteNonQuery = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            comm = Nothing
            conStr.Close()
        End Try
    End Function

    Public Function ExecuteScalar(ByVal sqlStr As String)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = _strConn
        Dim comm As New SqlCommand(sqlStr, conStr)
        Try
            conStr.Open()
            ExecuteScalar = comm.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conStr.Close()
        End Try
    End Function

    Public Function GetConfig(ByVal Key_Ref As String)
        Dim strsql As String
        strsql = "Select Return_Ref From Config "
        strsql = strsql & "Where Key_Ref = '" & Key_Ref & "'"
        GetConfig = ExecuteScalar(strsql)
    End Function

    Public Function GetSystemDate() As Date
        Dim strsql As String
        strsql = "SELECT SYSDATETIME() AS Today "
        GetSystemDate = ExecuteScalar(strsql)
    End Function

    Public Function GetResponseTo(ByVal RegisterCode As String) As String
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = strConn
        Dim strsql As String
        Dim result As String = ""
        Dim i As String = 1
        Try
            strsql = "Select * From Register_To "
            strsql = strsql & "Where RegisterID = '" & RegisterCode & "' "
            conStr.Open()
            Dim comm As New SqlCommand(strsql, conStr)
            Dim dr As SqlDataReader = comm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If i = 1 Then
                        result = dr.Item("UserID").ToString
                    Else
                        result = result & ", " & dr.Item("UserID").ToString
                    End If
                    i = i + 1
                End While
            End If
            conStr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GetResponseTo = result
        End Try
    End Function

    Public Function IsNumeric(ByVal s As String) As Boolean
        Try
            Single.Parse(s)
        Catch
            Return False
        End Try
        Return True
    End Function

End Class
