<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.NotifyIconMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStripNotifIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircularProgressBarMain = New CircularProgressBar.CircularProgressBar()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CircularProgressBarRAM = New CircularProgressBar.CircularProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CircularProgressBarBattery = New CircularProgressBar.CircularProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblCharging = New System.Windows.Forms.Label()
        Me.LblRemainingTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblLastCharge = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContextMenuStripNotifIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIconMain
        '
        Me.NotifyIconMain.ContextMenuStrip = Me.ContextMenuStripNotifIcon
        Me.NotifyIconMain.Icon = CType(resources.GetObject("NotifyIconMain.Icon"), System.Drawing.Icon)
        Me.NotifyIconMain.Text = "Battery Percentage:"
        Me.NotifyIconMain.Visible = True
        '
        'ContextMenuStripNotifIcon
        '
        Me.ContextMenuStripNotifIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStripNotifIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHideToolStripMenuItem, Me.ToolStripSeparator1, Me.HelpToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitToolStripMenuItem})
        Me.ContextMenuStripNotifIcon.Name = "ContextMenuStripNotifIcon"
        Me.ContextMenuStripNotifIcon.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStripNotifIcon.ShowImageMargin = False
        Me.ContextMenuStripNotifIcon.Size = New System.Drawing.Size(145, 82)
        '
        'ShowHideToolStripMenuItem
        '
        Me.ShowHideToolStripMenuItem.Name = "ShowHideToolStripMenuItem"
        Me.ShowHideToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ShowHideToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ShowHideToolStripMenuItem.Text = "Show/Hide"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'CircularProgressBarMain
        '
        Me.CircularProgressBarMain.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBarMain.AnimationSpeed = 500
        Me.CircularProgressBarMain.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarMain.ForeColor = System.Drawing.Color.White
        Me.CircularProgressBarMain.InnerColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarMain.InnerMargin = 2
        Me.CircularProgressBarMain.InnerWidth = -1
        Me.CircularProgressBarMain.Location = New System.Drawing.Point(9, 4)
        Me.CircularProgressBarMain.Margin = New System.Windows.Forms.Padding(17, 18, 17, 18)
        Me.CircularProgressBarMain.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBarMain.Name = "CircularProgressBarMain"
        Me.CircularProgressBarMain.OuterColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarMain.OuterMargin = -25
        Me.CircularProgressBarMain.OuterWidth = -5
        Me.CircularProgressBarMain.ProgressColor = System.Drawing.Color.Aqua
        Me.CircularProgressBarMain.ProgressWidth = 4
        Me.CircularProgressBarMain.SecondaryFont = New System.Drawing.Font("Harrington", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarMain.Size = New System.Drawing.Size(176, 168)
        Me.CircularProgressBarMain.StartAngle = 270
        Me.CircularProgressBarMain.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarMain.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBarMain.SubscriptText = ""
        Me.CircularProgressBarMain.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarMain.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBarMain.SuperscriptText = ""
        Me.CircularProgressBarMain.TabIndex = 0
        Me.CircularProgressBarMain.Text = "0%"
        Me.CircularProgressBarMain.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBarMain.Value = 68
        '
        'TimerMain
        '
        Me.TimerMain.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(22, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPU Usage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(249, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RAM usage"
        '
        'CircularProgressBarRAM
        '
        Me.CircularProgressBarRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBarRAM.AnimationSpeed = 500
        Me.CircularProgressBarRAM.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarRAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarRAM.ForeColor = System.Drawing.Color.White
        Me.CircularProgressBarRAM.InnerColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarRAM.InnerMargin = 2
        Me.CircularProgressBarRAM.InnerWidth = -1
        Me.CircularProgressBarRAM.Location = New System.Drawing.Point(231, 4)
        Me.CircularProgressBarRAM.Margin = New System.Windows.Forms.Padding(17, 18, 17, 18)
        Me.CircularProgressBarRAM.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBarRAM.Name = "CircularProgressBarRAM"
        Me.CircularProgressBarRAM.OuterColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarRAM.OuterMargin = 10
        Me.CircularProgressBarRAM.OuterWidth = 5
        Me.CircularProgressBarRAM.ProgressColor = System.Drawing.Color.Red
        Me.CircularProgressBarRAM.ProgressWidth = 4
        Me.CircularProgressBarRAM.SecondaryFont = New System.Drawing.Font("Harrington", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarRAM.Size = New System.Drawing.Size(146, 136)
        Me.CircularProgressBarRAM.StartAngle = 270
        Me.CircularProgressBarRAM.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarRAM.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBarRAM.SubscriptText = ""
        Me.CircularProgressBarRAM.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarRAM.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBarRAM.SuperscriptText = ""
        Me.CircularProgressBarRAM.TabIndex = 2
        Me.CircularProgressBarRAM.Text = "0%"
        Me.CircularProgressBarRAM.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBarRAM.Value = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(458, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Battery Information"
        '
        'CircularProgressBarBattery
        '
        Me.CircularProgressBarBattery.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBarBattery.AnimationSpeed = 500
        Me.CircularProgressBarBattery.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarBattery.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarBattery.ForeColor = System.Drawing.Color.White
        Me.CircularProgressBarBattery.InnerColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarBattery.InnerMargin = 2
        Me.CircularProgressBarBattery.InnerWidth = -1
        Me.CircularProgressBarBattery.Location = New System.Drawing.Point(459, 0)
        Me.CircularProgressBarBattery.Margin = New System.Windows.Forms.Padding(17, 18, 17, 18)
        Me.CircularProgressBarBattery.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBarBattery.Name = "CircularProgressBarBattery"
        Me.CircularProgressBarBattery.OuterColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarBattery.OuterMargin = -25
        Me.CircularProgressBarBattery.OuterWidth = -5
        Me.CircularProgressBarBattery.ProgressColor = System.Drawing.Color.Aqua
        Me.CircularProgressBarBattery.ProgressWidth = 4
        Me.CircularProgressBarBattery.SecondaryFont = New System.Drawing.Font("Harrington", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarBattery.Size = New System.Drawing.Size(188, 168)
        Me.CircularProgressBarBattery.StartAngle = 270
        Me.CircularProgressBarBattery.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarBattery.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBarBattery.SubscriptText = ""
        Me.CircularProgressBarBattery.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarBattery.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBarBattery.SuperscriptText = ""
        Me.CircularProgressBarBattery.TabIndex = 5
        Me.CircularProgressBarBattery.Text = "0%"
        Me.CircularProgressBarBattery.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBarBattery.Value = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(368, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Remaining Time:"
        '
        'LblCharging
        '
        Me.LblCharging.AutoSize = True
        Me.LblCharging.BackColor = System.Drawing.Color.Transparent
        Me.LblCharging.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCharging.ForeColor = System.Drawing.Color.LightCoral
        Me.LblCharging.Location = New System.Drawing.Point(519, 118)
        Me.LblCharging.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCharging.Name = "LblCharging"
        Me.LblCharging.Size = New System.Drawing.Size(69, 13)
        Me.LblCharging.TabIndex = 8
        Me.LblCharging.Text = "Not Charging"
        '
        'LblRemainingTime
        '
        Me.LblRemainingTime.AutoSize = True
        Me.LblRemainingTime.BackColor = System.Drawing.Color.Transparent
        Me.LblRemainingTime.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemainingTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblRemainingTime.Location = New System.Drawing.Point(484, 229)
        Me.LblRemainingTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRemainingTime.Name = "LblRemainingTime"
        Me.LblRemainingTime.Size = New System.Drawing.Size(16, 18)
        Me.LblRemainingTime.TabIndex = 9
        Me.LblRemainingTime.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(13, 318)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "© Grimm and Steene 2019"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTime.Location = New System.Drawing.Point(574, 291)
        Me.LblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(16, 18)
        Me.LblTime.TabIndex = 11
        Me.LblTime.Text = "0"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.BackColor = System.Drawing.Color.Transparent
        Me.LblDate.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblDate.Location = New System.Drawing.Point(534, 261)
        Me.LblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(16, 18)
        Me.LblDate.TabIndex = 12
        Me.LblDate.Text = "0"
        '
        'LblLastCharge
        '
        Me.LblLastCharge.AutoSize = True
        Me.LblLastCharge.BackColor = System.Drawing.Color.Transparent
        Me.LblLastCharge.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastCharge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblLastCharge.Location = New System.Drawing.Point(163, 246)
        Me.LblLastCharge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLastCharge.Name = "LblLastCharge"
        Me.LblLastCharge.Size = New System.Drawing.Size(16, 18)
        Me.LblLastCharge.TabIndex = 14
        Me.LblLastCharge.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(8, 246)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Time SinceLast Charge:"
        '
        'FrmMain
        '
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(699, 350)
        Me.ContextMenuStrip = Me.ContextMenuStripNotifIcon
        Me.Controls.Add(Me.LblLastCharge)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblRemainingTime)
        Me.Controls.Add(Me.LblCharging)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CircularProgressBarBattery)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CircularProgressBarRAM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CircularProgressBarMain)
        Me.Font = New System.Drawing.Font("Jokerman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(17, 18, 17, 18)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(715, 389)
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.Opacity = 0.75R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Battery Monitor"
        Me.ContextMenuStripNotifIcon.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIconMain As NotifyIcon
    Friend WithEvents CircularProgressBarMain As CircularProgressBar.CircularProgressBar
    Friend WithEvents TimerMain As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CircularProgressBarRAM As CircularProgressBar.CircularProgressBar
    Friend WithEvents ContextMenuStripNotifIcon As ContextMenuStrip
    Friend WithEvents ShowHideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents CircularProgressBarBattery As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents LblCharging As Label
    Friend WithEvents LblRemainingTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblLastCharge As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
