Imports System.IO
Imports System.Globalization
Imports System.Threading
Imports System.Environment
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics

Module mdlTool

    Public v_UserID As String
    Public v_LogInName As String
    Public v_UserDBA As Boolean
    Public v_UserName As String
    Public v_UserLevel As Integer
    Public v_MainFolder As String
    Public v_ReportFolder As String
    Public v_TemplateFolder As String
    Public v_UserGroup As String
    Public Const FolderSave As String = "d:\WorkInProgress\"
    Public Const V_Vat As Single = 0.07
    Dim objDB As New clsDB

    Private Declare Function GetComputerName Lib "kernel32" _
        Alias "GetComputerNameA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Private Declare Function GetWindowsDirectory Lib "kernel32.dll" _
        Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    'for hide close button ---------------------------
    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As IntPtr, ByVal nPosition As Integer, ByVal wFlags As Long) As IntPtr
    Private Declare Function GetSystemMenu Lib "user32" (ByVal hWnd As IntPtr, ByVal bRevert As Boolean) As IntPtr
    Private Declare Function GetMenuItemCount Lib "user32" (ByVal hMenu As IntPtr) As Integer
    Private Declare Function DrawMenuBar Lib "user32" (ByVal hwnd As IntPtr) As Boolean

    Private Const MF_BYPOSITION = &H400
    Private Const MF_REMOVE = &H1000
    Private Const MF_DISABLED = &H2
    Private Const HKEY_CLASSES_ROOT = &H80000000 'The HKEY_CLASSES_ROOT (HKCR) key contains file name extension associations and COM class registration information such as ProgIDs, CLSIDs, and IIDs.

    'mapdrive ------------------------------------------
    Public Const NO_ERROR As Long = 0
    Public Const CONNECT_UPDATE_PROFILE As Long = &H1
    Public Const RESOURCETYPE_DISK As Long = &H1
    Public Const RESOURCE_GLOBALNET As Long = &H2
    Public Const RESOURCEDISPLAYTYPE_SHARE As Long = &H3
    Public Const RESOURCEUSAGE_CONNECTABLE As Long = &H1
    Public Const SW_SHOWNORMAL As Long = 1

    Public Structure NETRESOURCE
        Public dwScope As Long
        Public dwType As Long
        Public dwDisplayType As Long
        Public dwUsage As Long
        Public lpLocalName As String
        Public lpRemoteName As String
        Public lpComment As String
        Public lpProvider As String
    End Structure

    Public Declare Function WNetAddConnection2 Lib "mpr.dll" _
   Alias "WNetAddConnection2A" _
  (ByVal lpNetResource As NETRESOURCE, _
   ByVal lpPassword As String, _
   ByVal lpUserName As String, _
   ByVal dwFlags As Long) As Long
    'end mapdrive--------------------------------------------

    Public Sub SetRegionalDate()
        Dim myCI As New CultureInfo("en-US", False)
        Dim myCIclone As CultureInfo = myCI.Clone()
        myCIclone.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Thread.CurrentThread.CurrentCulture = myCIclone
    End Sub

    Public Function CheckExcelIsOpen() As Boolean
        Try
            Dim p As Process()
            p = Process.GetProcessesByName("Excel")
            If p.Length = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ChangeToBC(ByVal YearNum As String) As String
        'Objective : เปลี่ยนค่าเป็นอักษรตัวเลขเป็นปีพุทธศักราช
        If CLng(YearNum) < 2500 Then
            ChangeToBC = YearNum + 543
        Else
            ChangeToBC = YearNum
        End If
    End Function

    Public Function IsInstallAutoCAD() As Boolean
        Try
            If System.IO.File.Exists("C:\Football Manager 2012\fm.exe") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function OSisBit64() As Boolean
        If IntPtr.Size = 8 Then
            OSisBit64 = True
        ElseIf IntPtr.Size = 4 Then
            OSisBit64 = False
        End If
    End Function


    Public Function GetTheWindowsDirectory() As String

        Dim strWindowsDir As String        ' Variable to return the path of Windows Directory
        Dim lngWindowsDirLength As Long    ' Variable to return the length of the path

        strWindowsDir = Space(250)         ' Initialize the buffer to receive the string
        lngWindowsDirLength = GetWindowsDirectory(strWindowsDir, 250) ' Read the path of the windows directory
        strWindowsDir = Mid(strWindowsDir, 1, lngWindowsDirLength) ' Extract the windows path from the buffer

        GetTheWindowsDirectory = strWindowsDir
    End Function

    Public Function ReplaceSingleQuote(ByVal str As String) As String
        Dim result As String
        result = Replace(str, "'", "''")
        ReplaceSingleQuote = result
    End Function

    Public Sub InnitApp()
        Try
            Dim objDB As New clsDB
            Dim objTools As New clsTools
            'Call SetRegionalDate()
            v_MainFolder = objDB.MainFolder
            objTools.MkDirExist(v_MainFolder)
            objTools.MkDirExist(v_ReportFolder)
            objTools.MkDirExist(v_TemplateFolder)
        Catch ex As Exception
            MsgBox("Can not conecting to Database", MsgBoxStyle.Exclamation)
        End Try
        
    End Sub



    Public Function Isloaded(ByVal MyFormName As String) As Boolean
        Dim i
        Isloaded = False

        For i = 0 To My.Application.OpenForms.Count - 1
            If My.Application.OpenForms(i).name = MyFormName Then
                Isloaded = True
                Exit Function
            End If
        Next
    End Function

    Public Function testDataFormat(ByVal Date_Input As String) As String
        'input case (day/month/year)
        '04/07/2010, 4/7/2010, 14/7/2010, 4/10/2010
        '04/07/10, 4/7/10, 14/7/10, 4/10/10
        'Return MM/dd/yyyy
        Dim result As String = ""

        testDataFormat = result
    End Function

    Public Function ChangeDataFormat(ByVal Date_Input As String) As String
        'input dd/mm/yyyy
        'Return MM/dd/yyyy (ค.ศ)
        Dim result As String = ""
        Dim slashPosition As Integer = Date_Input.IndexOf("/")
        Dim LenFormat As Integer = Len(Date_Input)
        Dim dd As String = ""
        Dim MM As String = ""
        Dim yyyy As String = ""
        Select Case LenFormat
            Case 10 '16/06/2010, 06/16/2010
                If slashPosition = 2 Then
                    MM = Left(Date_Input, 2)
                    dd = Mid(Date_Input, 4, 2)
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                    'result = MM & "/" & dd & "/" & yyyy
                End If
            Case 9  '7/12/2010, 14/7/2010
                If slashPosition = 1 Then
                    MM = "0" & Left(Date_Input, 1)
                    dd = ""
                    If Date_Input.IndexOf("/", 2) = 3 Then '4/1/2010
                        MM = "0" & Mid(Date_Input, 3, 1)
                    ElseIf Date_Input.IndexOf("/", 2) = 4 Then '4/12/2010
                        MM = Mid(Date_Input, 3, 2)
                    End If
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                    'result = MM & "/" & dd & "/" & yyyy
                ElseIf slashPosition = 2 Then ', 14/7/2010
                    MM = Left(Date_Input, 2)
                    dd = "0" & Mid(Date_Input, 4, 1)
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                    'result = MM & "/" & dd & "/" & yyyy
                End If
            Case 8  '16/06/10, 06/16/10 , 1/1/2010
                If slashPosition = 1 Then
                    MM = "0" & Left(Date_Input, 1)
                    dd = "0" & Mid(Date_Input, 3, 1)
                ElseIf slashPosition = 2 Then '06/16/10
                    MM = Left(Date_Input, 2)
                    dd = Mid(Date_Input, 4, 2)
                End If
                yyyy = Date_Input.Substring(Date_Input.LastIndexOf("/") + 1)
                If Len(yyyy) = 4 Then
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                Else 'year 2 digit
                    If CInt(yyyy) > 48 Then
                        'เป็น พ.ศ
                        yyyy = ((CInt(yyyy) + 2500) - 543)
                    Else
                        'เป็น ค.ศ
                        yyyy = ((CInt(yyyy) + 2000))
                    End If
                End If


            Case 7 '1/11/53, 14/7/10
                If slashPosition = 1 Then '1/11/53
                    MM = "0" & Left(Date_Input, 1)
                    dd = Mid(Date_Input, 3, 2)
                ElseIf slashPosition = 2 Then '14/7/10
                    MM = Left(Date_Input, 2)
                    dd = Mid(Date_Input, 4, 1)
                End If
                yyyy = Date_Input.Substring(Date_Input.LastIndexOf("/") + 1)
                If Len(yyyy) = 4 Then
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                Else 'year 2 digit
                    If CInt(yyyy) > 48 Then
                        'เป็น พ.ศ
                        yyyy = ((CInt(yyyy) + 2500) - 543)
                    Else
                        'เป็น ค.ศ
                        yyyy = ((CInt(yyyy) + 2000))
                    End If
                End If


            Case 6 '4/7/10
                MM = "0" & Left(Date_Input, 1)
                dd = "0" & Mid(Date_Input, 3, 1)
                yyyy = Date_Input.Substring(Date_Input.LastIndexOf("/") + 1)
                If Len(yyyy) = 4 Then
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                Else 'year 2 digit
                    If CInt(yyyy) > 48 Then
                        'เป็น พ.ศ
                        yyyy = ((CInt(yyyy) + 2500) - 543)
                    Else
                        'เป็น ค.ศ
                        yyyy = ((CInt(yyyy) + 2000))
                    End If
                End If
        End Select
        If MM > 12 Then
            result = dd & "/" & MM & "/" & yyyy
        Else
            result = MM & "/" & dd & "/" & yyyy
        End If
        'return month/day/year
        ChangeDataFormat = result
    End Function

    Public Function ChangeDataFormat_Old(ByVal Date_Input As String) As String
        'input dd/mm/yyyy
        'Return MM/dd/yyyy (ค.ศ)
        Dim result As String = ""
        Dim slashPosition As Integer = Date_Input.IndexOf("/")
        Dim LenFormat As Integer = Len(Date_Input)
        Dim dd As String = ""
        Dim MM As String = ""
        Dim yyyy As String = ""
        Select Case LenFormat
            Case 10 '16/06/2010, 06/16/2010
                If slashPosition = 2 Then
                    dd = Left(Date_Input, 2)
                    MM = Mid(Date_Input, 4, 2)
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                    'result = MM & "/" & dd & "/" & yyyy
                End If
            Case 9  '7/12/2010, 14/7/2010
                If slashPosition = 1 Then
                    dd = "0" & Left(Date_Input, 1)
                    MM = ""
                    If Date_Input.IndexOf("/", 2) = 3 Then '4/1/2010
                        MM = "0" & Mid(Date_Input, 3, 1)
                    ElseIf Date_Input.IndexOf("/", 2) = 4 Then '4/12/2010
                        MM = Mid(Date_Input, 3, 2)
                    End If
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                    'result = MM & "/" & dd & "/" & yyyy
                ElseIf slashPosition = 2 Then ', 14/7/2010
                    dd = Left(Date_Input, 2)
                    MM = "0" & Mid(Date_Input, 4, 1)
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                    'result = MM & "/" & dd & "/" & yyyy
                End If
            Case 8  '16/06/10, 06/16/10 , 1/1/2010
                If slashPosition = 1 Then
                    dd = "0" & Left(Date_Input, 1)
                    MM = "0" & Mid(Date_Input, 3, 1)
                ElseIf slashPosition = 2 Then '06/16/10
                    dd = Left(Date_Input, 2)
                    MM = Mid(Date_Input, 4, 2)
                End If
                yyyy = Date_Input.Substring(Date_Input.LastIndexOf("/") + 1)
                If Len(yyyy) = 4 Then
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                Else 'year 2 digit
                    If CInt(yyyy) > 48 Then
                        'เป็น พ.ศ
                        yyyy = ((CInt(yyyy) + 2500) - 543)
                    Else
                        'เป็น ค.ศ
                        yyyy = ((CInt(yyyy) + 2000))
                    End If
                End If


            Case 7 '1/11/53, 14/7/10
                If slashPosition = 1 Then '1/11/53
                    dd = "0" & Left(Date_Input, 1)
                    MM = Mid(Date_Input, 3, 2)
                ElseIf slashPosition = 2 Then '14/7/10
                    dd = Left(Date_Input, 2)
                    MM = Mid(Date_Input, 4, 1)
                End If
                yyyy = Date_Input.Substring(Date_Input.LastIndexOf("/") + 1)
                If Len(yyyy) = 4 Then
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                Else 'year 2 digit
                    If CInt(yyyy) > 48 Then
                        'เป็น พ.ศ
                        yyyy = ((CInt(yyyy) + 2500) - 543)
                    Else
                        'เป็น ค.ศ
                        yyyy = ((CInt(yyyy) + 2000))
                    End If
                End If


            Case 6 '4/7/10
                dd = "0" & Left(Date_Input, 1)
                MM = "0" & Mid(Date_Input, 3, 1)
                yyyy = Date_Input.Substring(Date_Input.LastIndexOf("/") + 1)
                If Len(yyyy) = 4 Then
                    yyyy = Right(Date_Input, 4)
                    If CInt(yyyy) > 2500 Then
                        yyyy = CInt(yyyy) - 543
                    End If
                Else 'year 2 digit
                    If CInt(yyyy) > 48 Then
                        'เป็น พ.ศ
                        yyyy = ((CInt(yyyy) + 2500) - 543)
                    Else
                        'เป็น ค.ศ
                        yyyy = ((CInt(yyyy) + 2000))
                    End If
                End If
        End Select
        If MM > 12 Then
            result = dd & "/" & MM & "/" & yyyy
        Else
            result = MM & "/" & dd & "/" & yyyy
        End If
        'return month/day/year
        ChangeDataFormat_Old = result
    End Function

    Public Function GetTrn_Key(ByVal Date_In As String, ByVal Time_In As String)
        'retrun YYYYMMDDHHMM
        GetTrn_Key = Right(Date_In, 4) & Left(Date_In, 2) & Mid(Date_In, 4, 2) & Left(Time_In, 2) & Right(Time_In, 2)
    End Function

    Public Function GetNewID(ByVal Month_No As String, ByVal ClassType As String, ByVal UserID As String) As Integer
        Dim strsql As String = ""
        Dim Result As Integer
        Dim objDB As New clsDB
        If ClassType = "I" Then
            strsql = "SELECT MAX(CONVERT(INT, RIGHT(RegisterID, 4))) AS MaxValue, ClassID "
            strsql += "FROM RegisterDoc "
            strsql += "GROUP BY ClassID "
            strsql += "HAVING (ClassID = '" & ClassType & "') "
        ElseIf ClassType = "O" Then
            strsql = "SELECT MAX(CONVERT(INT, RIGHT(RegisterID, 4))) AS MaxValue, DocFrom, ClassID "
            strsql += "FROM RegisterDoc "
            strsql += "GROUP BY ClassID, DocFrom "
            strsql += "HAVING (ClassID = '" & ClassType & "') "
            strsql += "AND (DocFrom = '" & UserID & "') "
        End If
        Result = objDB.ExecuteScalar(strsql)
        If Result <= 0 Then
            Result = 1
        ElseIf Result > 9999 Then
            Result = 1
        Else
            Result = Result + 1
        End If

        Return Result

    End Function

    Public Function NewID(strTable As String, strKEY As String, Optional strFilter As String = "") As String
        Dim rs As New ADODB.Recordset
        Dim i As Integer
        Dim strsql As String
        Dim Result As String


        strsql = "select max("
        strsql = strsql & strKEY
        strsql = strsql & ") from "
        strsql = strsql & strTable
        If strFilter <> "" Then
            strsql = strsql & " where " & strFilter
        End If
        Result = objDB.ExecuteScalar(strsql)
        If Result <= 0 Then
            Result = 1
        Else
            Result = Result + 1
        End If

        Return Result


    End Function


    Public Function GetNewMMID(ByVal Month_No As String, ByVal UserID As String) As Integer
        Dim strsql As String
        Dim Result As Integer
        Dim objDB As New clsDB
        strsql = "SELECT MAX(CONVERT(INT, RIGHT(RegisterID, 4))) AS MaxValue, DocFrom, ClassID "
        strsql += "FROM RegisterDoc "
        strsql += "GROUP BY LEFT(RegisterID, 2), ClassID, DocFrom "
        strsql += "HAVING (LEFT(RegisterID, 2) = '" & Month_No & "') "
        strsql += "AND (ClassID = 'MM') "
        strsql += "AND (DocFrom = '" & UserID & "') "

        Result = objDB.ExecuteScalar(strsql)
        If Result <= 0 Then
            Result = 1
        ElseIf Result > 9999 Then
            Result = 1
        Else
            Result = Result + 1
        End If

        Return Result

    End Function

    Public Function MyFind(ByVal strConnection As String, ByVal strTable As String, ByVal strFieldOut As String, Optional ByRef strFilter As String = "") As String
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = strConnection

        '--------------------------
        Dim strSql As String
        Dim sOut As String

        sOut = Nothing
        sOut = ""
        Try
            strSql = "select top 1 " & strFieldOut
            strSql = strSql & " from " & strTable
            If strFilter <> "" Then strSql = strSql & " where " & strFilter
            '--------------------------------------
            conStr.Open()
            Dim comm As New SqlClient.SqlCommand(strSql, conStr)
            comm.CommandTimeout = 0
            sOut = comm.ExecuteScalar()
            sOut = sOut & ""
            comm = Nothing
        Catch ex As Exception
            sOut = ""
        Finally
            conStr.Close()
        End Try
        Return sOut

    End Function

    Public Function myText2Int(ByVal strInt As String) As Integer

        Dim dOut As Integer = 0
        Try

            dOut = Convert.ToInt32(strInt)


        Catch ex As Exception
            dOut = 0
        End Try
        Return dOut

    End Function

    Public Function AlreadyRunning() As Boolean
        ' Get our process name.
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName

        ' Get information about processes with this name.
        Dim procs() As Process = _
            Process.GetProcessesByName(my_name)

        ' If there is only one, it's us.
        If procs.Length = 1 Then Return False

        ' If there is more than one process,
        ' see if one has a StartTime before ours.
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then _
                Return True
        Next i

        ' If we get here, we were first.
        Return False
    End Function

    Public Sub DisableCloseButton(ByVal hwnd As IntPtr)

        Dim hMenu As IntPtr
        Dim menuItemCount As Integer

        hMenu = GetSystemMenu(hwnd, False)
        menuItemCount = GetMenuItemCount(hMenu)

        Call RemoveMenu(hMenu, menuItemCount - 1, _
        MF_DISABLED Or MF_BYPOSITION)
        Call RemoveMenu(hMenu, menuItemCount - 2, _
        MF_DISABLED Or MF_BYPOSITION)
        Call DrawMenuBar(hwnd)

    End Sub

    Public Sub Exportfg(ByVal FileName As String, ByVal objGrid As C1.Win.C1FlexGrid.C1FlexGrid)
        Dim objDB As New clsDB
        Dim strSave As String = v_MainFolder & FileName & ".xls"
        Dim ixl As Object
        Try
            objGrid.SaveExcel(strSave, FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            Process.Start(strSave)
            'ixl = CreateObject("Excel.Application")
            'ixl.Workbooks.Open(strSave)
            'ixl.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ixl = Nothing
        End Try
    End Sub

    Public Sub Exportfg2(ByVal FileName As String, ByVal objGrid As C1.Win.C1FlexGrid.C1FlexGrid)
        Dim objDB As New clsDB
        Dim strSave As String = v_ReportFolder & FileName & Format(DateTime.Now, "dd-MMM-yyyy") & ".xlsx"
        Dim ixl As Object
        Try
            objGrid.SaveExcel(strSave, FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            ixl = CreateObject("Excel.Application")
            ixl.Workbooks.Open(strSave)
            ixl.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ixl = Nothing
        End Try
    End Sub

    Public Sub Exportfg2Excel(ByVal FileName As String, ByVal objGrid As C1.Win.C1FlexGrid.C1FlexGrid)
        Dim objDB As New clsDB
        Dim strSave As String = v_ReportFolder & FileName & Format(DateTime.Now, "dd-MMM-yyyy-hh-mm-ss") & ".xlsx"
        'Dim ixl As Object
        Try
            objGrid.SaveExcel(strSave, "Sheet1", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            'ixl = CreateObject("Excel.Application")
            'ixl.Workbooks.Open(strSave)
            'ixl.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'ixl = Nothing
        End Try
    End Sub

    Public Sub Exportfg2ExcelBetween(ByVal FileName As String, ByVal objGrid As C1.Win.C1FlexGrid.C1FlexGrid)
        Dim objDB As New clsDB
        Dim strSave As String = v_ReportFolder & FileName & ".xlsx"

        Try
            objGrid.SaveExcel(strSave, "Sheet1", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    

    Public Sub UpLoadPDF(ByVal SourceFile As String, ByVal TableName As String, ByVal FieldName As String, ByVal WC As String)
        Dim objDB As New clsDB
        Dim imageData As Byte()
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim SqlCom As SqlCommand
        Dim strsql As String = ""
        Dim thisLock As New Object
        Try
            'แปลงไฟล์เป็น Binary Image
            imageData = ReadFile(SourceFile)
            'Exit Sub
            If conStr.State = ConnectionState.Closed Then
                conStr.Open()
            End If
            'Update ลงตาราง Drawing_Register
            strsql = "Update " & TableName & " Set "
            strsql += FieldName & " = @PDF_Image "
            strsql += WC
            SqlCom = New SqlCommand(strsql, conStr)
            ''Execute the Query
            SqlCom.Parameters.Add(New SqlParameter("@PDF_Image", DirectCast(imageData, Object)))
            SyncLock thisLock
                SqlCom.ExecuteNonQuery()
            End SyncLock
            SqlCom = Nothing

            If conStr.State = ConnectionState.Open Then
                conStr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'nothing
        End Try
    End Sub

    Public Sub UpLoadPDF_FromAecom(ByVal AecomRef As String, ByVal AecomIssued As String, ByVal SourceFile As String, ByVal TableName As String, ByVal FieldName As String)
        Dim objDB As New clsDB
        Dim imageData As Byte()
        Dim dnTemp As String = ""
        Dim dn As String 'drawing name
        Dim Rev As String 'Revision
        Dim Status As String 'Status
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim SqlCom As SqlCommand
        Dim strsql As String = ""
        Dim thisLock As New Object
        Try

            'MessageBox.Show(Path.GetFileName(fdlg.FileName))
            'แปลงชื่อไฟล์ W2AR1021A.pdf ให้ตามฟอร์แม็ท , แยกคำ Revision, แยกคำ Status
            dnTemp = Path.GetFileNameWithoutExtension(SourceFile)
            Status = Strings.Left(dnTemp, 1)
            Rev = Strings.Right(dnTemp, 1)
            dn = Mid(dnTemp, 2, 1) & "/" & Mid(dnTemp, 3, 2) & "/" & Mid(dnTemp, 5, 4)
            'MsgBox(dn)
            'แปลงไฟล์เป็น Binary Image
            imageData = ReadFile(SourceFile)
            'Exit Sub
            If conStr.State = ConnectionState.Closed Then
                conStr.Open()
            End If
            'delete old befor
            strsql = "Delete from AECOM_Dwg "
            strsql += "Where AECOM_REF = '" & AecomRef & "' "
            strsql += "And Revision_issued = " & AecomIssued & " "
            strsql += "And Dwg_no = '" & dn & "' "
            strsql += "And AECOM_Rev = '" & Rev & "' "
            strsql += "And Dwg_status = '" & Status & "' "
            SqlCom = New SqlCommand(strsql, conStr)
            SyncLock thisLock
                SqlCom.ExecuteNonQuery()
            End SyncLock
            'Insert Aecom_Dwg
            strsql = "Insert into AECOM_Dwg ("
            strsql += "AECOM_REF, Revision_issued, Dwg_no, AECOM_Rev, Dwg_status, PrintLastedRev) "
            strsql += "VALUES ('" & AecomRef & "', "
            strsql += "'" + AecomIssued + "', "
            strsql += "'" + dn + "', "
            strsql += "'" + Rev + "', "
            strsql += "'" + Status + "', "
            strsql += "0) "
            SqlCom = New SqlCommand(strsql, conStr)
            SyncLock thisLock
                SqlCom.ExecuteNonQuery()
            End SyncLock
            'Update ลงตาราง Drawing_Register
            strsql = "Update " & TableName & " Set "
            strsql += FieldName & " = @PDF_Image "
            strsql += "WHERE (Dwg_no = '" & dn & "') AND (AECOM_Rev = '" & Rev & "') AND (Dwg_status = '" & Status & "')"
            SqlCom = New SqlCommand(strsql, conStr)
            ''Execute the Query
            SqlCom.Parameters.Add(New SqlParameter("@PDF_Image", DirectCast(imageData, Object)))
            SyncLock thisLock
                SqlCom.ExecuteNonQuery()
            End SyncLock
            SqlCom = Nothing

            If conStr.State = ConnectionState.Open Then
                conStr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "dwg_no = " & dnTemp)
        Finally
            'nothing
        End Try
    End Sub

    Public Function ReadFile(ByVal sPath As String) As Byte()
        'Initialize byte array with a null value initially.
        Dim data As Byte() = Nothing
        'Use FileInfo object to get file size. 
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length
        'Open FileStream to read file 
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)
        'Use BinaryReader to read file stream into byte array.
        Dim br As New BinaryReader(fStream)
        'When you use BinaryReader, you need to supply number of bytes to read from file. 
        'In this case we want to read entire file. So supplying total number of bytes.
        data = br.ReadBytes(CInt(numBytes))
        fStream.Close()
        Return data
    End Function

    Public Sub UpdateImage(ByVal SourcePath As String, ByVal TableName As String, ByVal FieldName As String, ByVal WC As String)
        Dim objDB As New clsDB
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        Dim imageData As Byte()
        Dim dnTemp As String = ""
        Dim dn As String 'drawing name
        Dim Rev As String 'Revision
        Dim Status As String 'Status
        'Dim sr As StreamReader
        'sr = New StreamReader(filename)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim SqlCom As SqlCommand
        Dim strsql As String

        Dim thisLock As New Object
        Try
            'open ไฟล์ Dialog แบบ Mutiple ไฟล์ 
            fdlg.Title = "Open File CSC PDF"
            fdlg.InitialDirectory = SourcePath
            fdlg.Filter = "Text files (*.pdf)|*.pdf|PDF files (*.pdf)|*.pdf"
            fdlg.FilterIndex = 2
            fdlg.RestoreDirectory = True
            fdlg.Multiselect = True
            If fdlg.ShowDialog() = DialogResult.OK Then
                For Each filename As String In fdlg.FileNames
                    'MessageBox.Show(Path.GetFileName(fdlg.FileName))
                    'แปลงชื่อไฟล์ W2AR1021A.pdf ให้ตามฟอร์แม็ท , แยกคำ Revision, แยกคำ Status
                    dnTemp = Path.GetFileNameWithoutExtension(filename)
                    Status = Strings.Left(dnTemp, 1)
                    Rev = Strings.Right(dnTemp, 1)
                    dn = Mid(dnTemp, 2, 1) & "/" & Mid(dnTemp, 3, 2) & "/" & Mid(dnTemp, 5, 4)
                    'MsgBox(dn)
                    'แปลงไฟล์เป็น Binary Image
                    imageData = ReadFile(filename)
                    If conStr.State = ConnectionState.Closed Then
                        conStr.Open()
                    End If
                    'Update ลงตาราง Drawing_Register
                    strsql = "Update " & TableName & " Set "
                    strsql += "Chk" & FieldName & " = @Bool, "
                    strsql += FieldName & " = @PDF_Image "
                    strsql += WC
                    SqlCom = New SqlCommand(strsql, conStr)
                    ''Execute the Query
                    SqlCom.Parameters.Add("@Bool", SqlDbType.Bit)
                    SqlCom.Parameters("@Bool").Value = 1
                    SqlCom.Parameters.Add(New SqlParameter("@PDF_Image", DirectCast(imageData, Object)))
                    SyncLock thisLock
                        SqlCom.ExecuteNonQuery()
                    End SyncLock
                    SqlCom = Nothing
                    'MsgBox("File uploaded successfully")
                Next
                If conStr.State = ConnectionState.Open Then
                    conStr.Close()
                End If
            Else  'cancel
                If MsgBox("คุณต้องการเก็บไฟล์ pdf เดิมไว้?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    If conStr.State = ConnectionState.Closed Then
                        conStr.Open()
                    End If
                    'Update ลงตาราง Drawing_Register
                    strsql = "Update " & TableName & " Set "
                    strsql += "Chk" & FieldName & " = 0, "
                    strsql += FieldName & " = Null "
                    strsql += WC
                    SqlCom = New SqlCommand(strsql, conStr)
                    SyncLock thisLock
                        SqlCom.ExecuteNonQuery()
                    End SyncLock
                    SqlCom = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "dwg_no = " & dnTemp)
        Finally
            'nothing
        End Try
    End Sub

    Public Sub UpdateImageAndEndorsedDate(ByVal SourcePath As String, ByVal TableName As String, ByVal FieldName As String, ByVal WC As String)
        Dim objDB As New clsDB
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        Dim imageData As Byte()
        Dim dnTemp As String = ""
        Dim dn As String 'drawing name
        Dim Rev As String 'Revision
        Dim Status As String 'Status
        'Dim sr As StreamReader
        'sr = New StreamReader(filename)
        Dim conStr As New SqlClient.SqlConnection
        conStr.ConnectionString = objDB.strConn
        Dim SqlCom As SqlCommand
        Dim strsql As String
        Dim TempDate As String = ""
        Dim EndorsedDate As String = ""

        Dim thisLock As New Object
        Try
            'open ไฟล์ Dialog แบบ Mutiple ไฟล์ 
            fdlg.Title = "Open File CSC PDF"
            fdlg.InitialDirectory = SourcePath
            fdlg.Filter = "Text files (*.pdf)|*.pdf|PDF files (*.pdf)|*.pdf"
            fdlg.FilterIndex = 2
            fdlg.RestoreDirectory = True
            fdlg.Multiselect = True
            If fdlg.ShowDialog() = DialogResult.OK Then
                For Each filename As String In fdlg.FileNames
                    'MessageBox.Show(Path.GetFileName(fdlg.FileName))
                    'แปลงชื่อไฟล์ W2AR1021A.pdf ให้ตามฟอร์แม็ท , แยกคำ Revision, แยกคำ Status
                    dnTemp = Path.GetFileNameWithoutExtension(filename)
                    'ตัดวันที่จากชื่อไฟล์
                    TempDate = Strings.Right(dnTemp, 6)
                    EndorsedDate = "20" & Strings.Right(TempDate, 2) & "-" & Mid(TempDate, 3, 2) & "-" & Strings.Left(TempDate, 2)
                    If (Mid(EndorsedDate, 5, 1) <> "-") And (Mid(EndorsedDate, 8, 1) <> "-") Then
                        MsgBox(dnTemp & " ชื่อไฟล์นำเข้าไม่ถูกต้องตามข้อกำหนด W2BT9999A_DDMMYY", MsgBoxStyle.Critical)
                    End If
                    Status = Strings.Left(dnTemp, 1)
                    Rev = Strings.Right(dnTemp, 1)
                    dn = Mid(dnTemp, 2, 1) & "/" & Mid(dnTemp, 3, 2) & "/" & Mid(dnTemp, 5, 4)
                    'MsgBox(dn)
                    'แปลงไฟล์เป็น Binary Image
                    imageData = ReadFile(filename)
                    If conStr.State = ConnectionState.Closed Then
                        conStr.Open()
                    End If
                    'Update ลงตาราง Drawing_Register
                    strsql = "Update " & TableName & " Set "
                    strsql += "Chk" & FieldName & " = @Bool, "
                    strsql += FieldName & "Date = @EndorsedDate, "
                    strsql += FieldName & " = @PDF_Image "
                    strsql += WC
                    SqlCom = New SqlCommand(strsql, conStr)
                    ''Execute the Query
                    SqlCom.Parameters.Add("@Bool", SqlDbType.Bit)
                    SqlCom.Parameters("@Bool").Value = 1
                    SqlCom.Parameters.Add("@EndorsedDate", SqlDbType.Date)
                    SqlCom.Parameters("@EndorsedDate").Value = EndorsedDate
                    SqlCom.Parameters.Add(New SqlParameter("@PDF_Image", DirectCast(imageData, Object)))
                    SyncLock thisLock
                        SqlCom.ExecuteNonQuery()
                    End SyncLock
                    SqlCom = Nothing
                    'MsgBox("File uploaded successfully")
                Next
                If conStr.State = ConnectionState.Open Then
                    conStr.Close()
                End If
            Else  'cancel
                If MsgBox("คุณต้องการเก็บไฟล์ pdf เดิมไว้?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    If conStr.State = ConnectionState.Closed Then
                        conStr.Open()
                    End If
                    'Update ลงตาราง Drawing_Register
                    strsql = "Update " & TableName & " Set "
                    strsql += "Chk" & FieldName & " = 0, "
                    strsql += FieldName & "Date = Null, "
                    strsql += FieldName & " = Null "
                    strsql += WC
                    SqlCom = New SqlCommand(strsql, conStr)
                    SyncLock thisLock
                        SqlCom.ExecuteNonQuery()
                    End SyncLock
                    SqlCom = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "dwg_no = " & dnTemp)
        Finally
            'nothing
        End Try
    End Sub

    Public Sub StartImage(ByVal TableName As String, ByVal FieldName As String, ByVal WC As String, ByVal FileName As String)
        Try
            Dim objDB As New clsDB
            Dim objTool As New clsTools
            Dim strSql As String
            Dim thisLock As New Object
            strSql = "Select " & FieldName & " from " & TableName & " "
            strSql += WC
            'Get image data from DB
            Dim fileData As Byte() = DirectCast(objDB.ExecuteScalar(strSql), Byte())
            Dim sTempFileName As String = v_MainFolder & FileName
            If objTool.FileExist(FileName) Then
                SyncLock thisLock
                    Kill(FileName)
                End SyncLock
            End If
            If Not fileData Is Nothing Then
                'Read image data into a file stream 
                Using fs As New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream.
                    fs.Flush()
                    fs.Close()
                End Using
                'Open File
                Process.Start(FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub WriteImage(ByVal TableName As String, ByVal FieldName As String, ByVal WC As String, ByVal FileName As String)
        Try
            Dim objDB As New clsDB
            Dim objTool As New clsTools
            Dim strSql As String
            Dim thisLock As New Object
            strSql = "Select " & FieldName & " from " & TableName & " "
            strSql += WC
            'Get image data from DB
            Dim fileData As Byte() = DirectCast(objDB.ExecuteScalar(strSql), Byte())
            Dim sTempFileName As String = FileName
            If objTool.FileExist(FileName) Then
                SyncLock thisLock
                    Kill(FileName)
                End SyncLock
            End If
            If Not fileData Is Nothing Then
                'Read image data into a file stream 
                Using fs As New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream.
                    fs.Flush()
                    fs.Close()
                End Using
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Function SplitComma(ByVal Tmt_To As String) As Boolean

        'Dim s As String
        's = "Chilkat Mail, ActiveX Component, $99, free upgrades, 1-Year Support"
        'Dim fields() As String
        '' Split the string at the comma characters and add each field to a ListBox
        'fields() = Split(s, ",")
        'For i = 0 To UBound(fields)
        '    MsgBox(Trim$(fields(i)))
        'Next i
        'SplitComma = True

    End Function

    Public Function MyChangeDate(ByVal StrDate As String) As String
        Dim result As String = ""
        Dim yy As String
        Dim mm As String
        Dim dd As String
        Dim Digit As Integer

        Digit = Len(StrDate)
        Select Case Digit
            Case 0
                result = ""
            Case 7
                '19-1211
                yy = "20" & Right(StrDate, 2)
                mm = Mid(StrDate, 4, 2)
                dd = Left(StrDate, 2)
                result = yy & "-" & mm & "-" & dd
            Case 8
                '21-05-12
                yy = "20" & Right(StrDate, 2)
                mm = Mid(StrDate, 4, 2)
                dd = Left(StrDate, 2)
                result = yy & "-" & mm & "-" & dd
            Case 9
                '5/04/2012', 14-MAY-12
                If Mid(StrDate, 7, 1) = "-" Or Mid(StrDate, 7, 1) = "/" Then
                    yy = "20" & Right(StrDate, 2)
                    mm = CONVERT_MONTH_TONUM(Mid(StrDate, 4, 3))
                    dd = Left(StrDate, 2)
                Else
                    yy = Right(StrDate, 4)
                    mm = Mid(StrDate, 3, 2)
                    dd = Left(StrDate, 1)
                End If
                result = yy & "-" & mm & "-" & dd
            Case 10
                '20/02/2012
                yy = Right(StrDate, 4)
                mm = Mid(StrDate, 4, 2)
                dd = Left(StrDate, 2)
                result = yy & "-" & mm & "-" & dd
        End Select
        MyChangeDate = result
    End Function

    Public Function GetMonthName(ByVal monthNum As Integer) As String
        Dim strDate As New DateTime(1, monthNum, 1)
        Return strDate.ToString("MMM")
    End Function

    Public Function ReplaceSlash(ByVal str As String) As String
        Dim result As String
        result = Replace(str, "/", "_")
        ReplaceSlash = result
    End Function

    Public Function ReplaceSlash2minus(ByVal str As String) As String
        Dim result As String
        result = Replace(str, "/", "-")
        ReplaceSlash2minus = result
    End Function

    Public Function CONVERT_MONTH_TONUM(ByVal STRMM As String)
        CONVERT_MONTH_TONUM = ""
        If STRMM = "JAN" Then
            CONVERT_MONTH_TONUM = "01"
        ElseIf STRMM = "FEB" Then
            CONVERT_MONTH_TONUM = "02"
        ElseIf STRMM = "MAR" Then
            CONVERT_MONTH_TONUM = "03"
        ElseIf STRMM = "APR" Then
            CONVERT_MONTH_TONUM = "04"
        ElseIf STRMM = "MAY" Then
            CONVERT_MONTH_TONUM = "05"
        ElseIf STRMM = "JUN" Then
            CONVERT_MONTH_TONUM = "06"
        ElseIf STRMM = "JUL" Then
            CONVERT_MONTH_TONUM = "07"
        ElseIf STRMM = "SEP" Then
            CONVERT_MONTH_TONUM = "08"
        ElseIf STRMM = "AUG" Then
            CONVERT_MONTH_TONUM = "09"
        ElseIf STRMM = "OCT" Then
            CONVERT_MONTH_TONUM = "10"
        ElseIf STRMM = "NOV" Then
            CONVERT_MONTH_TONUM = "11"
        ElseIf STRMM = "DEC" Then
            CONVERT_MONTH_TONUM = "12"
        End If
    End Function



    Public Function ConnectNetDrive(ByVal serverpath As String, ByVal driveletter As String) As Boolean

        'attempts to connect to the passed network
        'connection to the specified drive.
        'ErrInfo=NO_ERROR if sucessful.

        Dim NETR As New NETRESOURCE

        Dim errInfo As Long

        With NETR
            .dwScope = RESOURCE_GLOBALNET
            .dwType = RESOURCETYPE_DISK
            .dwDisplayType = RESOURCEDISPLAYTYPE_SHARE
            .dwUsage = RESOURCEUSAGE_CONNECTABLE
            .lpRemoteName = serverpath
            .lpLocalName = driveletter
            .lpProvider = vbNullString
        End With
        errInfo = WNetAddConnection2(NETR, vbNullString, "birchr", CONNECT_UPDATE_PROFILE)
        ConnectNetDrive = errInfo = NO_ERROR

    End Function

    Public Function ChangeToTableDate(ByVal YearNum As String, ByVal MonthName As String, ByVal DayNum As String) As String
        ChangeToTableDate = ChangeToCC(YearNum) _
                                        & ChangeMonthToNum(MonthName) _
                                        & DayNum
    End Function

    Public Function ChangeToCC(ByVal YearNum As String) As String
        'Objective : เปลี่ยนค่าเป็นอักษรตัวเลขเป็นปีคริสตศักราช
        If CLng(YearNum) > 2500 Then
            ChangeToCC = CLng(YearNum) - 543
        Else
            ChangeToCC = YearNum
        End If
    End Function

    Public Function ChangeMonthToNum(ByVal MonthName As String) As String
        Select Case MonthName
            Case "มกราคม"
                ChangeMonthToNum = "01"
            Case "January"
                ChangeMonthToNum = "01"
            Case "กุมภาพันธ์"
                ChangeMonthToNum = "02"
            Case "February"
                ChangeMonthToNum = "02"
            Case "มีนาคม"
                ChangeMonthToNum = "03"
            Case "March"
                ChangeMonthToNum = "03"
            Case "เมษายน"
                ChangeMonthToNum = "04"
            Case "April"
                ChangeMonthToNum = "04"
            Case "พฤษภาคม"
                ChangeMonthToNum = "05"
            Case "May"
                ChangeMonthToNum = "05"
            Case "มิถุนายน"
                ChangeMonthToNum = "06"
            Case "June"
                ChangeMonthToNum = "06"
            Case "กรกฎาคม"
                ChangeMonthToNum = "07"
            Case "July"
                ChangeMonthToNum = "07"
            Case "สิงหาคม"
                ChangeMonthToNum = "08"
            Case "August"
                ChangeMonthToNum = "08"
            Case "กันยายน"
                ChangeMonthToNum = "09"
            Case "September"
                ChangeMonthToNum = "09"
            Case "ตุลาคม"
                ChangeMonthToNum = "10"
            Case "October"
                ChangeMonthToNum = "10"
            Case "พฤศจิกายน"
                ChangeMonthToNum = "11"
            Case "November"
                ChangeMonthToNum = "11"
            Case "ธันวาคม"
                ChangeMonthToNum = "12"
            Case "December"
                ChangeMonthToNum = "12"
            Case Else
                ChangeMonthToNum = ""
        End Select
    End Function

    Public Function GetFractionalPart(ByVal number As Single) As Single
        Dim WholePart As Single = Math.Truncate(number)
        GetFractionalPart = number - WholePart
    End Function

    Public Function GetWorkingTimeSpan(ByVal StartDate As Date, ByVal EndDate As Date) As Single
        On Error GoTo QuitNow
        'Note : 1 Hour = 3,600 Sec
        'Note : 1 WorkingDay = 8 Hour = 28,800 Sec
        'Note : FirstHalfDay = 4 Hour (9.00 to 13.00) = 14,400 sec
        'Note : SecordHalfDay = 5 Hour (13.01 to 18.00)

        Dim cd As Integer
        Dim Result As Single
        Dim i As Integer
        Dim j As Integer

        Dim TmpCurStartDate As Date
        Dim TmpCurEndDate As Date

        Dim TmpCurStartDateMaxFirstHalf As Date 'set default = 13:00:00
        Dim TmpCurStartDateMaxSecondHalf As Date 'set default = 18:00:00

        Dim KeepSeconds As Single
        Dim IsWorkingDay As Boolean
        Dim HolidayName As String

        cd = DateDiff("d", StartDate, EndDate) + 1

        For i = 1 To cd
            'ตั้งค่าให้ StratDate และเวลาเริ่มงาน
            TmpCurStartDate = StartDate.AddDays(j)
            Dim MinFirstHalfDay = New DateTime(TmpCurStartDate.Year, TmpCurStartDate.Month, TmpCurStartDate.Day, 9, 0, 0, 0)
            Dim MaxSecondHalfDay = New DateTime(TmpCurStartDate.Year, TmpCurStartDate.Month, TmpCurStartDate.Day, 18, 0, 0, 0)

            If TmpCurStartDate < MinFirstHalfDay Then
                TmpCurStartDate = MinFirstHalfDay
            ElseIf TmpCurStartDate > MaxSecondHalfDay Then
                TmpCurStartDate = MaxSecondHalfDay
            End If
            TmpCurStartDateMaxFirstHalf = New DateTime(TmpCurStartDate.Year, TmpCurStartDate.Month, TmpCurStartDate.Day, 13, 0, 0, 0)
            TmpCurStartDateMaxSecondHalf = New DateTime(TmpCurStartDate.Year, TmpCurStartDate.Month, TmpCurStartDate.Day, 18, 0, 0, 0)

            'ตั้งค่าให้ EndDate เช็คว่าเป็นวันเดียวกันกับStartDateหรือป่าวแล้วกำหนดค่าdefaultเวลาเลิกงาน 
            Dim x1 As Date
            Dim x2 As Date
            x1 = New DateTime(TmpCurStartDate.Year, TmpCurStartDate.Month, TmpCurStartDate.Day, 0, 0, 0, 0)
            x2 = New DateTime(EndDate.Year, EndDate.Month, EndDate.Day, 0, 0, 0, 0)
            If x1 = x2 Then  'เคสเป็นวันเดียวกัน
                TmpCurEndDate = EndDate
                If TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 0, 0, 0, 0) Then
                    TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0)
                ElseIf TmpCurEndDate < New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 9, 0, 0, 0) Then
                    TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 9, 0, 0, 0)
                ElseIf TmpCurEndDate > New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0) Then
                    TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0)
                End If
            Else 'เคสไม่ใช่วันเดียวกัน
                TmpCurEndDate = TmpCurStartDate
                If TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 0, 0, 0, 0) Then
                    TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0)
                ElseIf TmpCurEndDate < New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 9, 0, 0, 0) Then
                    TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 9, 0, 0, 0)
                ElseIf TmpCurEndDate > New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0) Then
                    TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0)
                Else
                    TmpCurEndDate = New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0)
                End If
            End If
            'check Is WorkingDay เช็คว่าเป็นวันทำงานหรือไม่-----------------------------------------
            If Weekday(TmpCurStartDate, vbMonday) <= 5 Then  'is Monday to Friday
                If CInt(Format(TmpCurStartDate, "yyyy")) > 2500 Then
                    HolidayName = MyFind(objDB.strConn, "Holiday", "HolidayName", "HolidayDate_1 = '" & CStr(CInt(Format(TmpCurStartDate, "yyyy")) - 543) & Format(TmpCurStartDate, "MMdd") & "' ")
                Else
                    HolidayName = MyFind(objDB.strConn, "Holiday", "HolidayName", "HolidayDate_1 = '" & Format(TmpCurStartDate, "yyyyMMdd") & "' ")
                End If
                If HolidayName = "" Then
                    IsWorkingDay = True
                Else
                    IsWorkingDay = False
                End If
            Else
                IsWorkingDay = False
            End If 'is Monday to Friday
            '---------------------------------------------------------------------
            If IsWorkingDay Then 'IsWorkingDay เคสวันทำงานต้องทำการคำนวณระยะเวลาการทำงาน
                If j = 0 Then
                    'first working day
                    If TmpCurEndDate < TmpCurStartDateMaxFirstHalf Then 'is First half day
                        KeepSeconds = DateDiff("s", TmpCurStartDate, TmpCurEndDate)
                    End If 'end is First half day
                    If TmpCurEndDate >= TmpCurStartDateMaxFirstHalf Then 'is Second half day or Full time
                        If TmpCurEndDate >= New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0) Then 'is working Full Time
                            'working full day
                            KeepSeconds = 28800
                        End If 'end Is Working Full Time
                        If TmpCurEndDate < New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0) Then 'is working in second half time
                            If TmpCurEndDate >= New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 14, 0, 0, 0) Then  'case is Lunch
                                If TmpCurStartDate < TmpCurStartDateMaxSecondHalf Then
                                    KeepSeconds = (DateDiff("s", TmpCurStartDate, TmpCurEndDate) - 3600)  'subtract lunch time
                                Else
                                    KeepSeconds = (DateDiff("s", TmpCurStartDate, TmpCurEndDate))
                                End If
                            Else 'else case is Lunch
                                'working half day
                                KeepSeconds = 14400
                            End If 'end case is Lunch
                        End If 'end is working in second half time
                    End If 'end is Second half day or Full time
                Else 'j = 0
                    'next working day
                    If TmpCurEndDate < TmpCurStartDateMaxFirstHalf Then 'is First half day
                        KeepSeconds = KeepSeconds + (DateDiff("s", TmpCurStartDate, TmpCurEndDate))
                    End If 'end is First half day
                    If TmpCurEndDate >= TmpCurStartDateMaxFirstHalf Then 'is Second half day or Full time
                        If TmpCurEndDate >= New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0) Then 'is working Full Time
                            'working full day
                            KeepSeconds = KeepSeconds + 28800
                        End If 'end Is Working Full Time
                        If TmpCurEndDate < New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 18, 0, 0, 0) Then 'is working in second half time
                            If TmpCurEndDate >= New DateTime(TmpCurEndDate.Year, TmpCurEndDate.Month, TmpCurEndDate.Day, 14, 0, 0, 0) Then  'case is Lunch
                                If TmpCurStartDate < TmpCurStartDateMaxSecondHalf Then
                                    KeepSeconds = KeepSeconds + (DateDiff("s", TmpCurStartDate, TmpCurEndDate) - 3600) 'subtract lunch time
                                Else
                                    KeepSeconds = KeepSeconds + (DateDiff("s", TmpCurStartDate, TmpCurEndDate))
                                End If
                            Else 'else case is Lunch
                                'working half day
                                KeepSeconds = KeepSeconds + 14400
                            End If 'end case is Lunch
                        End If 'end is working in second half time
                    End If 'end is Second half day or Full time
                End If 'j = 0
            End If 'IsWorkingDay
            j = j + 1
        Next i

        GetWorkingTimeSpan = KeepSeconds
QuitNow:
        Exit Function
    End Function

    Public Function Nearest(ByVal Number As Double, ByVal Interval As Double) As Double
        Dim r As Double, d As Double
        r = Math.Abs(Number) / Interval
        d = r - Fix(r)
        If d > 0 Then Nearest = Math.Abs(Number) + ((1 - d) * Interval) Else Nearest = Math.Abs(Number)
        If Number < 0 Then Nearest = Nearest * -1
    End Function

End Module
