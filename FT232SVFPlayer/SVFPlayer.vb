Public Class SVFPlayer
    Public IsOpen As Boolean
    Public IsSetup As Boolean
    Public lHandle As Long

    Public Declare Function FT_ListDevices Lib "FTD2XX.DLL" (ByVal arg1 As Long, ByVal arg2 As String, ByVal dwFlags As Long) As Long
    Public Declare Function FT_GetNumDevices Lib "FTD2XX.DLL" Alias "FT_ListDevices" (ByRef arg1 As Long, ByVal arg2 As String, ByVal dwFlags As Long) As Long

    'Not used
    Public Declare Function FT_Open Lib "FTD2XX.DLL" (ByVal intDeviceNumber As Integer, ByRef lngHandle As Long) As Long
    Public Declare Function FT_OpenEx Lib "FTD2XX.DLL" (ByVal arg1 As String, ByVal arg2 As Long, ByRef lngHandle As Long) As Long
    Public Declare Function FT_Close Lib "FTD2XX.DLL" (ByVal lngHandle As Long) As Long

    ' Flags for FT_ListDevices
    Public Const FT_LIST_BY_NUMBER_ONLY = &H80000000
    Public Const FT_LIST_BY_INDEX = &H40000000
    Public Const FT_LIST_ALL = &H20000000

    ' Flags for FT_OpenEx
    Public Const FT_OPEN_BY_SERIAL_NUMBER = 1
    Public Const FT_OPEN_BY_DESCRIPTION = 2

    Private Sub cmd_Find_Click(sender As Object, e As EventArgs) Handles cmd_Find.Click
        Dim GotDevice As Boolean
        Dim lNumDevs As Long
        Dim lResult As Long
        'Dim sBuffer As String
        Dim sBuffer As New String(Chr(0), 50)
        Dim sMyDescription As String

        GotDevice = False

        lResult = FT_GetNumDevices(lNumDevs, 0, FT_LIST_BY_NUMBER_ONLY)

        'Check for a total bombout
        If lResult <> 0 Then
            Call CheckResult(lResult, "FT_GetNumDevices")
            Exit Sub
        End If

        'Check for nothing connected
        If lNumDevs = 0 Then
            MsgBox("No FTDI Devices Detected." & vbCrLf & "Please connect one or replug a hung FTDI.  Then Restart..")
            'Unload Me
            'End
        End If

        'Loop through all adapters and check their description strings
        For i = 0 To lNumDevs - 1
            'Get a device's description
            lResult = FT_ListDevices(i, sBuffer, (FT_OPEN_BY_DESCRIPTION Or FT_LIST_BY_INDEX))
            'If we got one, check it for our devices
            If (InStr(sBuffer, "FT232B") Or InStr(sBuffer, "FT232R") Or InStr(sBuffer, txt_FTString.Text)) Then
                'Hooray, we got one!  First flag it
                GotDevice = True
                'Now get the description and stuff it into the Interfaces combo box
                sMyDescription = sBuffer.Substring(0, InStr(sBuffer, Chr(0)) - 1)
                cmb_Interfaces.Items.Add(Str(i) & " - " & sMyDescription)

            End If
        Next i

        'Check to see if we successfully found anything
        If GotDevice = True Then
            'If so, update the combo box so it displays the first interface
            cmb_Interfaces.SelectedIndex = 0
        Else
            'If not, go display debug message and die
            Call CheckResult(lResult, "FT_ListDevices")
            MsgBox("Fatal error opening FTDI.  Please replug and restart tool..")
            'Unload Me
            'End
        End If

    End Sub

    Private Sub cmd_OpenInterface_Click(sender As Object, e As EventArgs) Handles cmd_OpenInterface.Click
        Dim lResult As Long
        Dim sMyDescription As String

        'First check to see if we have any interfaces
        If cmb_Interfaces.Items.Count = 0 Then Me.cmd_Find.PerformClick()

        txt_log.Text = txt_log.Text & "OPENFT: Finding interfaces.. " & vbCrLf

        'Get the selected interface from the combo box
        sMyDescription = cmb_Interfaces.SelectedItem
        sMyDescription = sMyDescription.Substring(" 0 - ".Length)

        txt_log.Text = txt_log.Text & "OPENFT: Attempting to open [" & cmb_Interfaces.SelectedItem & "]... "

        'Attempt to open the interface
        lResult = FT_OpenEx(sMyDescription, FT_OPEN_BY_DESCRIPTION, lHandle)

        'Check for a total bombout
        If lResult <> 0 Then
            Call CheckResult(lResult, "FT_OpenEx")
            Exit Sub
        Else
            IsOpen = True
            'Change connection indicator to green
            openInterface.Checked = True
        End If

        txt_log.Text = txt_log.Text & "Success." & vbCrLf

    End Sub

    Private Sub CheckResult(lResult As Long, CallStr As String)
        If lResult <> 0 Then MsgBox("Bad result: " & CallStr & " returned 0x" & Hex(lResult))
    End Sub

    Private Sub cmd_CloseInterface_Click(sender As Object, e As EventArgs) Handles cmd_CloseInterface.Click
        Dim lResult As Long
        If IsOpen Then lResult = FT_Close(lHandle)
        'Check for an error
        If lResult <> 0 Then Call CheckResult(lResult, "FT_OpenEx")
        'Change connection indicator to red
        openInterface.Checked = False
        IsOpen = False
        IsSetup = False
    End Sub

    Private Sub cmd_FTSetup_Click(sender As Object, e As EventArgs) Handles cmd_FTSetup.Click
        Dir1.Items.Clear()

        Dim fileNames = My.Computer.FileSystem.GetFiles(
            "z:", FileIO.SearchOption.SearchTopLevelOnly, "*.svf")

        For Each fileName As String In fileNames
            Dir1.Items.Add(fileName)
        Next
    End Sub

    Private Sub Dir1_Click(sender As Object, e As EventArgs) Handles Dir1.Click
        TextBox1.Text = Dir1.SelectedItem
    End Sub
End Class
