Imports System.IO
Imports System.Reflection

Public NotInheritable Class SplashScreen
    Private i As UInteger = 0

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private Sub TimerOpenForm_Tick(sender As Object, e As EventArgs) Handles TimerOpenForm.Tick
        Me.Opacity = i / 100
        Me.Refresh()

        If i >= 100 Then
            PrepareDLL()

            Me.TimerOpenForm.Stop()
            Me.Hide()
            FrmMain.Show()
            FrmMain.Hide()
            Exit Sub
        End If

        i += 1
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load this in the background
        Try
            Me.Hide()
            Dim CPU = New PerformanceCounter("Processor", "% Processor Time", "_Total")
            Dim RAM = New PerformanceCounter("Memory", "% Committed Bytes In Use")
        Catch ex As Exception
            ' Do nothing
        End Try

        Me.Show()
    End Sub

    ''' <summary>
    ''' Prepare dlls for loading
    ''' </summary>
    Private Sub PrepareDLL()
        On Error Resume Next
        Dim DLLPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)

        Me.LblProgress.Text = "Loading CircularProgressBar.dll"
        Me.LblProgress.Refresh()
        Assembly.Load("CircularProgressBar")

        Me.LblProgress.Text = "Loading Canary.SoC.dll"
        Me.LblProgress.Refresh()
        Assembly.Load("Canary.SoC")

        Me.LblProgress.Text = "Loading Canary.Soc.Abstraction.dll"
        Me.LblProgress.Refresh()
        Assembly.Load("Canary.SoC.Abstraction")

        Me.LblProgress.Text = "Loading ConsoleProgressbar.dll"
        Me.LblProgress.Refresh()
        Assembly.Load("ConsoleProgressBar")

        Me.LblProgress.Text = "Loading WinFormAnimation.dll"
        Me.LblProgress.Refresh()
        Assembly.Load("WinFormAnimation")

        Me.Refresh()

        Me.LblProgress.Text = "Finished loading"
        Me.LblProgress.Refresh()
        Threading.Thread.Sleep(2000)

        Me.LblProgress.Text = "Opening main form..."
        Me.LblProgress.Refresh()
        Threading.Thread.Sleep(2000)

    End Sub
End Class
