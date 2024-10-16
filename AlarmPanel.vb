Imports System.IO
Imports System.Media
Public Class AlarmPanel
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage1") Then
            Form1.ClockAlarm1.Checked = CheckBox1.Checked
        End If
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage2") Then
            Form1.ClockAlarm2.Checked = CheckBox1.Checked
        End If
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage3") Then
            Form1.ClockAlarm3.Checked = CheckBox1.Checked
        End If
        alarmEnabled = CheckBox1.Checked

    End Sub

    Public alarmHour As Integer
    Public alarmMinute As Integer
    Public alarmIsAM As Boolean
    Public alarmEnabled As Boolean

    Public Sub SetAlarmTime(hours As Integer, minutes As Integer, isAM As Boolean)
        alarmHour = hours
        alarmMinute = minutes
        alarmIsAM = isAM
        alarmEnabled = True
    End Sub

    Public Sub CheckAlarm()
        If Not alarmEnabled Then
            Return
        End If

        Dim currentTime As DateTime = DateTime.Now
        Dim currentHour As Integer = currentTime.Hour
        Dim currentMinute As Integer = currentTime.Minute

        Dim currentIsAM As Boolean = (currentHour < 12)
        If currentHour = 0 Then
            currentHour = 12
        ElseIf currentHour > 12 Then
            currentHour -= 12
        End If

        If currentHour = alarmHour AndAlso currentMinute = alarmMinute AndAlso currentIsAM = alarmIsAM Then
            TriggerAlarm()
            CheckBox1.Checked = False
        End If
    End Sub




    Private Sub TriggerAlarm()
        ' Play a sound (use a .wav file) but since my one was not working, so I gave a pop-up message box for 3 alarmpages.
        Dim player As New System.Media.SoundPlayer()
        player.Play()
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage1") Then
            MessageBox.Show("Alarm 1 is ringing.....")
        End If
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage2") Then
            MessageBox.Show("Alarm 2 is ringing.....")
        End If
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage1") Then
            MessageBox.Show("Alarm 3 is ringing.....")
        End If

        alarmEnabled = False
    End Sub



End Class
