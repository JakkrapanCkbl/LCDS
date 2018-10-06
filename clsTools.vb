Imports System.IO

Public Class clsTools

    Public Function Nz(ByVal obj As Object, ByVal replaceValue As String) As String
        If Convert.IsDBNull(obj) Then
            Return replaceValue
        Else
            Return obj.ToString()
        End If
    End Function

    Public Function Ez(ByVal obj As Object, ByVal replaceValue As String) As String
       
        If String.IsNullOrEmpty(obj) Then
            Return replaceValue
        Else
            Return obj.ToString()
        End If
    End Function

    Public Function MonthLastDay(ByVal dCurrDate As Date)
        Dim dFirstDayNextMonth As Date

        On Error GoTo lbl_Error

        'MonthLastDay = Empty
        dFirstDayNextMonth = DateSerial(CInt(Format(dCurrDate, "yyyy")), CInt(Format(dCurrDate, "mm")) + 1, 1)
        MonthLastDay = DateAdd("d", -1, dFirstDayNextMonth)

        Exit Function
lbl_Error:
        MsgBox(Err.Description, vbOKOnly + vbExclamation)
    End Function

    Public Function FirstDayOfMonth(ByVal dCurrDate As Date)
        On Error GoTo lbl_Error
        FirstDayOfMonth = DateSerial(Year(dCurrDate), Month(dCurrDate), 1)
        Exit Function
lbl_Error:
        MsgBox(Err.Description, vbOKOnly + vbExclamation)
    End Function

    Public Function LastDayOfMonth(ByVal dCurrDate As Date)
        Dim tempdate As Date
        On Error GoTo lbl_Error
        tempdate = DateSerial(Year(dCurrDate), Month(dCurrDate) + 1, 1)
        LastDayOfMonth = DateAdd(DateInterval.Day, -1, tempdate)
        Exit Function
lbl_Error:
        MsgBox(Err.Description, vbOKOnly + vbExclamation)
    End Function

    Public Function FirstDayByMonth(ByVal intMonth As Integer, ByVal intYear As Integer)
        On Error GoTo lbl_Error
        FirstDayByMonth = DateSerial(intYear, intMonth, 1)
        Exit Function
lbl_Error:
        MsgBox(Err.Description, vbOKOnly + vbExclamation)
    End Function

    Public Function LastDayByMonth(ByVal intMonth As Integer, ByVal intYear As Integer)
        Dim tempdate As Date
        On Error GoTo lbl_Error
        tempdate = DateSerial(intYear, intMonth + 1, 1)
        LastDayByMonth = DateAdd(DateInterval.Day, -1, tempdate)
        Exit Function
lbl_Error:
        MsgBox(Err.Description, vbOKOnly + vbExclamation)
    End Function

    Public Function GetStartOfWeek() As DateTime
        'Return XDate.AddDays(-XDate.DayOfWeek)
        Dim today As DateTime, daysSinceMonday As Integer
        today = DateTime.Today
        daysSinceMonday = today.DayOfWeek - DayOfWeek.Monday
        If daysSinceMonday < 0 Then
            daysSinceMonday += 7
        End If
        Return today.AddDays(-daysSinceMonday)
    End Function

    Public Function ReplaceSingleQuote(ByVal str As String) As String
        Dim result As String
        result = Replace(str, "'", "''")
        ReplaceSingleQuote = result
    End Function

    'Check if specified file exist
    Public Function FileExist(ByVal Pathname As String) As Boolean
        FileExist = Len(Dir(Pathname)) > 0
    End Function

    'Make sure that specified dir exist (create it if not exist)
    Public Sub MkDirExist(ByVal Pathname As String)
        On Error Resume Next
        MkDir(Pathname)
    End Sub

    Public Function GetFileDate(ByVal FileName As String) As String
        GetFileDate = ""
        If IO.File.Exists(FileName) Then
            GetFileDate = IO.File.GetCreationTime(FileName)
        End If
    End Function

    Public Function GetFileNameOnly(ByVal FileName As String) As String

        Dim slashPosition As Integer = FileName.LastIndexOf("\")

        GetFileNameOnly = FileName.Substring(slashPosition + 1)

    End Function

    Public Function WriteTextFile(ByVal FullFileName As String, ByVal Msg As String) As Boolean
        Dim LogFile As String = FullFileName
        Dim streamWriter As New StreamWriter(LogFile)
        streamWriter.WriteLine(Msg)
        streamWriter.Close()
        WriteTextFile = True
    End Function

    Public Function WriteTextFile_MultiLine(ByVal FullFileName As String, ByVal arr() As String) As Boolean
        Try
            Dim LogFile As String = FullFileName
            Dim streamWriter As New StreamWriter(LogFile)
            Dim i As Integer
            For i = 0 To (arr.Length - 1)
                streamWriter.WriteLine(arr(i))
            Next
            streamWriter.Close()
            WriteTextFile_MultiLine = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function ConvertCode_Old(ByVal strSource As String) As String
        '- ----------- -------- ------------------- ------------------------------
        '- Function : ConvertCode
        '- Description : แปลงข้อมูลเป็น Formate "XX XXXXXXXXXXX..."
        '- Date        Issue#   Name                Remarks
        '- ----------- -------- ------------------- ------------------------------
        '- 24 Jan 2011      1   Nathakorn Sr.       Initial Development.
        '- ----------- -------- ------------------- ------------------------------
        '- Example :
        '- --------------------------------------
        '- strA = ConvertCode("AB1234XX+-")
        '- --------------------------------------
        '- Result :
        '- AB 1234XX
        '- --------------------------------------

        Dim strOut As String = ""
        Dim i As Integer
        Dim strTemp As String
        Dim strTextCheck As String
        Dim str1 As String
        '--------------- ตัวอักษรที่รับได้
        strTextCheck = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        If strSource.Length > 0 Then
            '----------------------------------- ตัดช่องว่างจากข้อความต้นทางไปสู่ strTemp
            strTemp = Replace(strSource, " ", "")
            For i = 0 To strTemp.Length - 1
                str1 = strTemp.Substring(i, 1)
                'ถ้าเป็นอักขระที่ต้องการให้รวมในตัวแปรใหม่
                If InStr(strTextCheck, str1, CompareMethod.Text) > 0 Then
                    strOut = strOut & str1
                End If
            Next
            '----------------- นำข้อมูลที่ได้
            '----------------- ตัดตัวแรก สองตัว
            '----------------- ต่อด้วย ช่องว่าง
            '----------------- ต่อด้วยส่วนที่เหลือ
            strOut = strOut.Substring(0, 2) & " " & strOut.Substring(2, strOut.Length - 2)
        End If
        Return strOut
    End Function

    Public Function ConvertCode(ByVal strSource As String) As String
        '- ----------- -------- ------------------- ------------------------------
        '- Function : ConvertCode
        '- Description : แปลงข้อมูลเป็น Formate "XX XXXXXXXXXXX..."
        '- Date Issue# Name Remarks
        '- ----------- -------- ------------------- ------------------------------
        '- 24 Jan 2011 1 Nathakorn Sr. Initial Development.
        '- ----------- -------- ------------------- ------------------------------
        '- Example :
        '- --------------------------------------
        '- strA = ConvertCode("AB1234XX+-")
        '- --------------------------------------
        '- Result :
        '- AB 1234XX
        '- --------------------------------------
        Dim strOut As String = ""
        Dim i As Integer
        Dim strTemp As String
        Dim strTextCheck As String
        Dim str1 As String
        Dim iSpace As Integer
        '--------------- ตัวอักษรที่รับได้
        strTextCheck = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz.-!@#$%^&*()"
        If strSource.Length > 0 Then
            '----------------------------------- ตัดช่องว่างจากข้อความต้นทางไปสู่ strTemp
            iSpace = InStr(strSource, " ") - 1
            If iSpace = -1 Then iSpace = 2
            strTemp = Replace(strSource, " ", "")
            For i = 0 To strTemp.Length - 1
                str1 = strTemp.Substring(i, 1)
                'ถ้าเป็นอักขระที่ต้องการให้รวมในตัวแปรใหม่
                If InStr(strTextCheck, str1, CompareMethod.Text) > 0 Then
                    strOut = strOut & str1
                End If
            Next
            '----------------- นำข้อมูลที่ได้
            '----------------- ตัดตัวแรก สองตัว 
            '----------------- ต่อด้วย ช่องว่าง
            '----------------- ต่อด้วยส่วนที่เหลือ
            strOut = strOut.Substring(0, iSpace) & " " & strOut.Substring(iSpace, strOut.Length - iSpace)
        End If
        Return strOut
    End Function

End Class
