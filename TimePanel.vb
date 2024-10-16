Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class TimePanel
    Public Property HoursTens As DigitLED
        Get
            Return HourLED1
        End Get
        Set(value As DigitLED)
            HourLED1 = value
        End Set
    End Property
    Public Property HoursMins As DigitLED
        Get
            Return HourLED2
        End Get
        Set(value As DigitLED)
            HourLED2 = value
        End Set
    End Property
    Public Property MinutesTens As DigitLED
        Get
            Return MinuteLED1
        End Get
        Set(value As DigitLED)
            MinuteLED1 = value
        End Set
    End Property
    Public Property MinutesOnes As DigitLED
        Get
            Return MinuteLED2
        End Get
        Set(value As DigitLED)
            MinuteLED2 = value
        End Set
    End Property
    Private serialLED As Integer = 0
    Private digitLEDs As List(Of DigitLED)




    Public Sub New()

        InitializeComponent()

        radioAM.Checked = True

        digitLEDs = New List(Of DigitLED) From {HourLED1, HourLED2, MinuteLED1, MinuteLED2}

    End Sub
    Public Sub SetDigitForActiveLED(digit As Integer)

        If serialLED >= 0 And serialLED < digitLEDs.Count Then
            digitLEDs(serialLED).SetDigit(digit)


        End If
        serialLED += 1
        Form1.ValueOfX = serialLED
        If serialLED >= digitLEDs.Count Then
            Form1.ButtonOK.Enabled = True
            serialLED = -1
        Else
            Form1.EnableKeypadForCurrentLED()
        End If
    End Sub
    Public Sub Case2Info()
        If HourLED1.CurrentDigit = 1 Then
            For i As Integer = 0 To 2
                Form1.digitButtons(i).Enabled = True
            Next
        Else
            For i As Integer = 1 To 9
                Form1.digitButtons(i).Enabled = True
            Next
        End If
    End Sub




    Public Sub ResetLEDs()
        For Each led As DigitLED In digitLEDs
            led.SetDigit(0)
        Next
        serialLED = 0
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form1.Size = New Size(411, 389)



        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("ClockPage") Then
            Form1.SetInitialTime()


        End If
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage1") Then
            ResetLEDs()
            Form1.AlarmPanel1.CheckBox1.CheckState = CheckState.Unchecked

        End If
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage2") Then
            ResetLEDs()
            Form1.AlarmPanel2.CheckBox1.CheckState = CheckState.Unchecked

        End If
        If Form1.TabControl1.SelectedTab Is Form1.TabControl1.TabPages("AlarmPage3") Then
            ResetLEDs()
            Form1.AlarmPanel3.CheckBox1.CheckState = CheckState.Unchecked

        End If
    End Sub
    Private Sub InitializeMaxDigits()
        HourLED1.MaxDigit = 1
        HourLED2.MaxDigit = 2
        MinuteLED1.MaxDigit = 5
        MinuteLED2.MaxDigit = 9
    End Sub


    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Form1.Size = New Size(411, 561)
        ResetLEDs()
        Form1.ClockPanel.Visible = True
        Form1.ValueOfX = serialLED
        Form1.EnableKeypadForCurrentLED()
    End Sub

    Public Property ValueOfX As Integer
        Get
            Return serialLED
        End Get
        Set(value As Integer)
            serialLED = value
        End Set
    End Property




End Class




