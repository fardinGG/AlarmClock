Imports System.Drawing.Text

Public Class Form1
    Public serialLED As Integer
    Public Sub SetInitialTime(Optional newTime As DateTime = Nothing)
        Dim currentTime As DateTime
        If newTime = Nothing Then
            currentTime = DateTime.Now
        Else
            currentTime = newTime
        End If

        Dim h As Integer = currentTime.Hour
        Dim m As Integer = currentTime.Minute
        Dim isAM As Boolean = (h < 12)

        If h > 12 Then
            h -= 12
        ElseIf h = 0 Then
            h = 12
        End If

        Dim hTens As Integer = h \ 10
        Dim hOnes As Integer = h Mod 10

        Dim mTens As Integer = m \ 10
        Dim mOnes As Integer = m Mod 10

        TimePanelClock.HourLED1.SetDigit(hTens)
        TimePanelClock.HourLED2.SetDigit(hOnes)
        TimePanelClock.MinuteLED1.SetDigit(mTens)
        TimePanelClock.MinuteLED2.SetDigit(mOnes)

        If isAM Then
            TimePanelClock.radioAM.Checked = True
        Else
            TimePanelClock.radioPM.Checked = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currentTime As DateTime = GetTimeFromDigitLEDs()
        SetInitialTime(currentTime.AddMinutes(1))

        AlarmPanel1.CheckAlarm()
        AlarmPanel2.CheckAlarm()
        AlarmPanel3.CheckAlarm()
    End Sub
    Private Function GetTimeFromDigitLEDs() As DateTime
        Dim h As Integer = (TimePanelClock.HourLED1.GetDigit() * 10) + TimePanelClock.HourLED2.GetDigit()
        Dim m As Integer = (TimePanelClock.MinuteLED1.GetDigit() * 10) + TimePanelClock.MinuteLED2.GetDigit()

        Dim isAM As Boolean = TimePanelClock.radioAM.Checked

        If Not isAM AndAlso h < 12 Then
            h += 12
        ElseIf isAM AndAlso h = 12 Then
            h = 0
        End If

        Return New DateTime(Now.Year, Now.Month, Now.Day, h, m, 0)
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(411, 389)
        SetInitialTime()
        Timer1.Start()
        InitializeKeyPad()

    End Sub




    Public Sub ResetToZero()
        TimePanelClock.HourLED1.SetDigit(0)
        TimePanelClock.HourLED2.SetDigit(0)
        TimePanelClock.MinuteLED1.SetDigit(0)
        TimePanelClock.MinuteLED2.SetDigit(0)

    End Sub

    Private Sub ButtonCANCEL_Click(sender As Object, e As EventArgs) Handles ButtonCANCEL.Click
        Me.Size = New Size(411, 389)
        ClockPanel.Visible = False
        If TabControl1.SelectedTab Is TabControl1.TabPages("ClockPage") Then

            SetInitialTime()

        ElseIf TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage1") Then
            AlarmPanel1.TimePanel1.ResetLEDs()
        ElseIf TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage2") Then
            AlarmPanel2.TimePanel1.ResetLEDs()
        ElseIf TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage3") Then
            AlarmPanel3.TimePanel1.ResetLEDs()
        End If

    End Sub



    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Me.Size = New Size(411, 389)
        Dim alarmHours1 As Integer = AlarmPanel1.TimePanel1.HoursTens.CurrentDigit * 10 + AlarmPanel1.TimePanel1.HoursMins.CurrentDigit
        Dim alarmMinutes1 As Integer = AlarmPanel1.TimePanel1.MinutesTens.CurrentDigit * 10 + AlarmPanel1.TimePanel1.MinutesOnes.CurrentDigit
        Dim isAM1 As Boolean = AlarmPanel1.TimePanel1.radioAM.Checked
        Dim alarmHours2 As Integer = AlarmPanel2.TimePanel1.HoursTens.CurrentDigit * 10 + AlarmPanel2.TimePanel1.HoursMins.CurrentDigit
        Dim alarmMinutes2 As Integer = AlarmPanel2.TimePanel1.MinutesTens.CurrentDigit * 10 + AlarmPanel2.TimePanel1.MinutesOnes.CurrentDigit
        Dim isAM2 As Boolean = AlarmPanel2.TimePanel1.radioAM.Checked
        Dim alarmHours3 As Integer = AlarmPanel3.TimePanel1.HoursTens.CurrentDigit * 10 + AlarmPanel3.TimePanel1.HoursMins.CurrentDigit
        Dim alarmMinutes3 As Integer = AlarmPanel3.TimePanel1.MinutesTens.CurrentDigit * 10 + AlarmPanel3.TimePanel1.MinutesOnes.CurrentDigit
        Dim isAM3 As Boolean = AlarmPanel3.TimePanel1.radioAM.Checked




        If TabControl1.SelectedTab Is TabControl1.TabPages("ClockPage") Then

            ClockPanel.Visible = False


        End If
        If TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage1") Then

            AlarmPanel1.CheckBox1.CheckState = CheckState.Checked
            AlarmPanel1.SetAlarmTime(alarmHours1, alarmMinutes1, isAM1)
            ClockPanel.Visible = False


        End If
        If TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage2") Then
            AlarmPanel2.CheckBox1.CheckState = CheckState.Checked
            AlarmPanel2.SetAlarmTime(alarmHours2, alarmMinutes2, isAM2)
            ClockPanel.Visible = False

        End If
        If TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage3") Then
            AlarmPanel3.CheckBox1.CheckState = CheckState.Checked
            AlarmPanel3.SetAlarmTime(alarmHours3, alarmMinutes3, isAM3)
            ClockPanel.Visible = False

        End If
    End Sub

    Private Sub ClockAlarm1_CheckedChanged(sender As Object, e As EventArgs) Handles ClockAlarm1.CheckedChanged
        AlarmPanel1.CheckBox1.Checked = ClockAlarm1.Checked
    End Sub
    Private Sub ClockAlarm2_CheckedChanged(sender As Object, e As EventArgs) Handles ClockAlarm2.CheckedChanged
        AlarmPanel2.CheckBox1.Checked = ClockAlarm2.Checked
    End Sub
    Private Sub ClockAlarm3_CheckedChanged(sender As Object, e As EventArgs) Handles ClockAlarm3.CheckedChanged
        AlarmPanel3.CheckBox1.Checked = ClockAlarm3.Checked
    End Sub

    Public Sub UpdatePictureBoxImage(SelectedTab As TabPage)
        Select Case SelectedTab.Name
            Case "AlarmPage1"
                AlarmPanel1.PictureBox1.Image = My.Resources.Heart
            Case "AlarmPage2"
                AlarmPanel2.PictureBox1.Image = My.Resources.Train
            Case "AlarmPage3"
                AlarmPanel3.PictureBox1.Image = My.Resources.Twister
        End Select
    End Sub
    Public Sub UpdateKeyPadColor(SelectedTab As TabPage)
        Select Case SelectedTab.Name
            Case "AlarmPage1"
                ClockPanel.BackColor = Color.LightPink
            Case "AlarmPage2"
                ClockPanel.BackColor = Color.DarkSlateGray
            Case "AlarmPage3"
                ClockPanel.BackColor = Color.PaleTurquoise
            Case "ClockPage"
                ClockPanel.BackColor = Color.DarkGray


        End Select
    End Sub

    Private Sub TabControl1_SelectedIndeChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        UpdatePictureBoxImage(TabControl1.SelectedTab)
        UpdateKeyPadColor(TabControl1.SelectedTab)

    End Sub






    Public digitButtons(9) As Button
    Public Sub InitializeKeyPad()
        digitButtons(1) = Button1
        digitButtons(2) = Button2
        digitButtons(3) = Button3
        digitButtons(4) = Button4
        digitButtons(5) = Button5
        digitButtons(6) = Button6
        digitButtons(7) = Button7
        digitButtons(8) = Button8
        digitButtons(9) = Button9
        digitButtons(0) = Button0
        ClockPanel.Visible = False

        For Each btn As Button In digitButtons
            AddHandler btn.Click, AddressOf ClockPanel_Click
        Next
    End Sub
    Public Property ValueOfX As Integer
        Get
            Return serialLED
        End Get
        Set(value As Integer)
            serialLED = value
        End Set
    End Property
    Public Sub EnableKeypadForCurrentLED()


        For Each btn As Button In digitButtons
            btn.Enabled = False
        Next

        Select Case serialLED
            Case 0
                digitButtons(0).Enabled = True
                digitButtons(1).Enabled = True
                ButtonOK.Enabled = False

            Case 1
                If TabControl1.SelectedTab Is TabControl1.TabPages("ClockPage") Then
                    TimePanelClock.Case2Info()
                    ButtonOK.Enabled = False
                ElseIf TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage1") Then
                    AlarmPanel1.TimePanel1.Case2Info()
                    ButtonOK.Enabled = False
                ElseIf TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage2") Then
                    AlarmPanel2.TimePanel1.Case2Info()
                    ButtonOK.Enabled = False
                ElseIf TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage3") Then
                    AlarmPanel3.TimePanel1.Case2Info()
                    ButtonOK.Enabled = False
                End If
            Case 2
                For i As Integer = 0 To 5
                    digitButtons(i).Enabled = True
                    ButtonOK.Enabled = False
                Next
            Case 3
                For i As Integer = 0 To 9
                    digitButtons(i).Enabled = True
                    ButtonOK.Enabled = False
                Next

        End Select

    End Sub

    Private Sub ClockPanel_Click(sender As Object, e As EventArgs)
        Dim PressedButton As Button = CType(sender, Button)
        Dim digit As Integer = CInt(PressedButton.Text)

        If TabControl1.SelectedTab Is TabControl1.TabPages("ClockPage") Then

            TimePanelClock.SetDigitForActiveLED(digit)
            TimePanelClock.ValueOfX = serialLED
        End If
        If TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage1") Then
            AlarmPanel1.TimePanel1.SetDigitForActiveLED(digit)
        End If
        If TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage2") Then
            AlarmPanel2.TimePanel1.SetDigitForActiveLED(digit)
        End If
        If TabControl1.SelectedTab Is TabControl1.TabPages("AlarmPage3") Then
            AlarmPanel3.TimePanel1.SetDigitForActiveLED(digit)
        End If


    End Sub


End Class
