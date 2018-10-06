
Public Class clsFileControl

    'Check if specified file exist
    Public Function FileExistX(ByVal Pathname As String) As Boolean
        FileExistX = Len(Dir(Pathname)) > 0
    End Function

    'Make sure that specified dir exist (create it if not exist)
    Public Sub MkDirExist(ByVal Pathname As String)
        On Error Resume Next
        MkDir(Pathname)
    End Sub

    Public Function GetFileDate(ByVal FileName As String) As String
        GetFileDate = ""
        If IO.File.Exists(FileName) Then
            'GetFileDate = IO.File.GetCreationTime(FileName)
            GetFileDate = IO.File.GetLastWriteTime(FileName)

        End If
    End Function

    

    Public Sub RenameFolder(ByVal OldFolder As String, ByVal NewFolderName As String)
        'OldFolder =  c:\test
        'NewFolder = 'SecondTest'
        Try
            If FileIO.FileSystem.DirectoryExists(OldFolder) Then
                FileIO.FileSystem.RenameDirectory(OldFolder, NewFolderName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    

End Class
