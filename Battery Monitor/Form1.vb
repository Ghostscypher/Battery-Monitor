Public Class FrmMain

    Private Property CPU As PerformanceCounter
    Private Property RAM As PerformanceCounter
    Private ReadOnly PowerInfo As PowerStatus = SystemInformation.PowerStatus
    Private alreadyDisplayedForLow As Boolean = False
    Private alreadyDisplayedForFull As Boolean = False
    Private timeSinceLastCharge As Date = Now
    Private error_occured As Boolean = False

    'Private Const CP_NOCLOSE_BUTTON As Integer = &H200

    'Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim myCp As CreateParams = MyBase.CreateParams
    '        myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
    '        Return myCp
    '    End Get
    'End Property

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)

        Me.NotifyIconMain.Visible = True

        Me.TimerMain.Enabled = True

        Try
            CPU = New PerformanceCounter("Processor", "% Processor Time", "_Total")
            RAM = New PerformanceCounter("Memory", "% Committed Bytes In Use")
        Catch ex As Exception
            error_occured = True

            If Not My.Computer.FileSystem.DirectoryExists("Logs") Then My.Computer.FileSystem.CreateDirectory("Logs")

            My.Computer.FileSystem.WriteAllText("Logs\error.log", "[" & Now.ToLongDateString & " " & Now.ToLongTimeString & "]" & vbNewLine & ex.Message & vbNewLine & vbNewLine & ex.StackTrace & vbNewLine & vbNewLine, True)
            MsgBox("Failed to initialize performance monitor {" & ex.Message & "}", vbCritical + vbOKOnly, "Error occured")
        End Try
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        Dim val As Double = 0
        If Not error_occured Then val = CPU.NextValue()

        Dim val2 As Double = 0
        If Not error_occured Then val2 = RAM.NextValue()

        Dim val3 As Integer = PowerInfo.BatteryLifePercent * 100

        Me.LblTime.Text = Now.ToLongTimeString
        Me.LblDate.Text = Now.ToLongDateString

        ' CPU usage
        Me.CircularProgressBarMain.Value = val
        Me.CircularProgressBarMain.ProgressColor = GetColor(1, val)
        Me.CircularProgressBarMain.Text = Math.Round(val, 1) & "%"
        Me.CircularProgressBarMain.Refresh()

        ' RAM usage
        Me.CircularProgressBarRAM.Value = val2
        Me.CircularProgressBarRAM.ProgressColor = GetColor(1, val2)
        Me.CircularProgressBarRAM.Text = Math.Round(val2, 1) & "%"
        Me.CircularProgressBarRAM.Refresh()

        ' Battery information
        Me.CircularProgressBarBattery.Value = val3
        Me.CircularProgressBarBattery.Text = Math.Round(val3, 1) & "%"
        Me.NotifyIconMain.Text = "Battery Percentage: " & Me.CircularProgressBarBattery.Text
        Me.CircularProgressBarBattery.ProgressColor = GetColor(0, val3)
        Me.CircularProgressBarBattery.StartAngle = 270
        Me.CircularProgressBarBattery.Refresh()

        If PowerInfo.PowerLineStatus = PowerLineStatus.Online And PowerInfo.BatteryChargeStatus <> BatteryChargeStatus.NoSystemBattery Then
            Me.LblCharging.Text = "    Charging"
            Me.LblCharging.ForeColor = Color.LawnGreen
            Me.CircularProgressBarBattery.Style = ProgressBarStyle.Marquee
            Me.LblLastCharge.Text = 0
            Me.timeSinceLastCharge = Now
        ElseIf PowerInfo.PowerLineStatus = PowerLineStatus.Offline And PowerInfo.BatteryChargeStatus <> BatteryChargeStatus.NoSystemBattery Then
            Me.LblCharging.Text = "Not Charging"
            Me.LblCharging.ForeColor = Color.Silver
            Me.CircularProgressBarBattery.Style = ProgressBarStyle.Blocks

            Dim t As Long = DateDiff(DateInterval.Second, timeSinceLastCharge, Now)
            Me.LblLastCharge.Text = ReturnTimeAsString(t)
        Else
            Me.LblCharging.Text = "No Battery"
            Me.LblCharging.ForeColor = Color.LightCoral
            Me.CircularProgressBarBattery.Style = ProgressBarStyle.Blocks
        End If

        If PowerInfo.PowerLineStatus = PowerLineStatus.Offline Then
            If val3 < 20 And alreadyDisplayedForLow = False Then
                Me.NotifyIconMain.BalloonTipText = "Battery below 20%"
                Me.NotifyIconMain.BalloonTipIcon = ToolTipIcon.Warning
                Me.NotifyIconMain.BalloonTipTitle = "Please connect charger"

                ' Play 5 sec sound to alert the user
                Try
                    My.Computer.Audio.Play("Alarm\Alarm1.wav", AudioPlayMode.Background)
                Catch ex As Exception
                    ' Do nothing
                End Try

                Me.NotifyIconMain.ShowBalloonTip(300000)
                Me.alreadyDisplayedForLow = True
            End If
        End If

        If ((PowerInfo.PowerLineStatus = PowerLineStatus.Online And PowerInfo.BatteryChargeStatus <> BatteryChargeStatus.NoSystemBattery) And CInt(val3) > 99) Then
            If (alreadyDisplayedForFull = False) Then
                Me.NotifyIconMain.BalloonTipText = "Battery is fully charged"
                Me.NotifyIconMain.BalloonTipIcon = ToolTipIcon.Info
                Me.NotifyIconMain.BalloonTipTitle = "[Fully Charged] Battery is 100%"
                Me.NotifyIconMain.ShowBalloonTip(300000)

                Dim gen As New Random
                gen.Next(2, 6)
                Dim fileName As String = "Alarm\alarm" & gen.Next(2, 6) & ".wav"

                ' Play 5 sec sound to alert the user
                Try
                    My.Computer.Audio.Play(fileName, AudioPlayMode.Background)
                Catch ex As Exception
                    ' Do nothing
                End Try

                alreadyDisplayedForFull = True
            End If

            Me.Visible = True
            Me.TopMost = True
        End If

        If alreadyDisplayedForFull And val3 < 100 Then alreadyDisplayedForFull = False
        If alreadyDisplayedForLow And val3 >= 20 Then alreadyDisplayedForLow = False

        ' Calculate remaining time
        Dim remT As Double = PowerInfo.BatteryLifeRemaining
        Dim remT1 As String = ReturnTimeAsString(remT)
        Me.LblRemainingTime.Text = remT1

        Me.CircularProgressBarBattery.Refresh()
    End Sub

    Private Function ReturnTimeAsString(time_ As Long) As String
        Dim hours As Double, minutes As Double, seconds As Double

        hours = time_ / 3600
        minutes = 60 * (hours - Int(hours))
        seconds = 60 * (minutes - Int(minutes))

        If time_ < 0 Then
            hours = 0
            minutes = 0
            seconds = -1
        End If

        Return Int(hours) & " Hours " & Int(minutes) & " Minutes " & CInt(seconds) & " Seconds"
    End Function

    Private Sub BalloonTipOnClick() Handles NotifyIconMain.BalloonTipClicked
        Me.Visible = True
        Me.TopMost = True
    End Sub

    Private Sub ToggleForm()
        If Me.Visible Then
            Me.Visible = False
            Me.TopMost = False
        Else
            Me.Visible = True
            Me.TopMost = True
            Me.TopMost = False
        End If
    End Sub

    Private Sub ShowHideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHideToolStripMenuItem.Click
        ToggleForm()
    End Sub

    Private Function GetColor(type As Integer, percentage As Integer) As Color
        Select Case type
            Case 0
                If (percentage >= 0 And percentage <= 10) Then
                    Return Color.Red
                ElseIf (percentage >= 11 And percentage <= 20) Then
                    Return Color.Orange
                ElseIf (percentage >= 21 And percentage <= 85) Then
                    Return Color.Aqua
                ElseIf (percentage >= 86 And percentage <= 100) Then
                    Return Color.Lime
                End If
            Case 1
                If (percentage >= 86 And percentage <= 100) Then
                    Return Color.Red
                ElseIf (percentage >= 65 And percentage <= 85) Then
                    Return Color.Orange
                ElseIf (percentage >= 11 And percentage <= 64) Then
                    Return Color.Aqua
                ElseIf (percentage >= 0 And percentage <= 10) Then
                    Return Color.Lime
                End If
        End Select
    End Function

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        MsgBox("Exiting the application", vbInformation + vbOKOnly, "Quitting")
        Application.Exit()
    End Sub

    Private Sub NotifyIconMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIconMain.MouseDoubleClick
        ToggleForm()
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Visible = False
            Me.TopMost = False
        End If
    End Sub

    Private Sub FrmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            ShowHelpFile()
        End If
    End Sub

    Private Sub ShowHelpFile()
        Try
            Process.Start(CurDir() & "\Help\index.html")
        Catch ex As Exception
            MsgBox("Help file is missing, reinstall/repair program to fix this problem", vbExclamation + vbOKOnly)
        End Try
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ShowHelpFile()
    End Sub
End Class