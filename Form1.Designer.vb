<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        ClockPage = New TabPage()
        PictureBox1 = New PictureBox()
        ClockAlarm3 = New CheckBox()
        ClockAlarm2 = New CheckBox()
        ClockAlarm1 = New CheckBox()
        TimePanelClock = New TimePanel()
        PictureBox2 = New PictureBox()
        AlarmPage1 = New TabPage()
        AlarmPanel1 = New AlarmPanel()
        AlarmPage2 = New TabPage()
        AlarmPanel2 = New AlarmPanel()
        AlarmPage3 = New TabPage()
        AlarmPanel3 = New AlarmPanel()
        ClockPanel = New Panel()
        ButtonCANCEL = New Button()
        Button2 = New Button()
        ButtonOK = New Button()
        Button3 = New Button()
        Button0 = New Button()
        Button4 = New Button()
        Button9 = New Button()
        Button5 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button1 = New Button()
        Timer1 = New Timer(components)
        TabControl1.SuspendLayout()
        ClockPage.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        AlarmPage1.SuspendLayout()
        AlarmPage2.SuspendLayout()
        AlarmPage3.SuspendLayout()
        ClockPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(ClockPage)
        TabControl1.Controls.Add(AlarmPage1)
        TabControl1.Controls.Add(AlarmPage2)
        TabControl1.Controls.Add(AlarmPage3)
        TabControl1.Font = New Font("Verdana", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.Location = New Point(1, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(393, 346)
        TabControl1.TabIndex = 0
        ' 
        ' ClockPage
        ' 
        ClockPage.BackColor = Color.DarkGray
        ClockPage.Controls.Add(PictureBox1)
        ClockPage.Controls.Add(ClockAlarm3)
        ClockPage.Controls.Add(ClockAlarm2)
        ClockPage.Controls.Add(ClockAlarm1)
        ClockPage.Controls.Add(TimePanelClock)
        ClockPage.Controls.Add(PictureBox2)
        ClockPage.Location = New Point(4, 27)
        ClockPage.Name = "ClockPage"
        ClockPage.Padding = New Padding(3)
        ClockPage.Size = New Size(385, 315)
        ClockPage.TabIndex = 0
        ClockPage.Text = "Clock"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Bee
        PictureBox1.Location = New Point(19, 161)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 78)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' ClockAlarm3
        ' 
        ClockAlarm3.AutoSize = True
        ClockAlarm3.Font = New Font("Impact", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ClockAlarm3.Location = New Point(188, 204)
        ClockAlarm3.Name = "ClockAlarm3"
        ClockAlarm3.Size = New Size(76, 24)
        ClockAlarm3.TabIndex = 5
        ClockAlarm3.Text = "Alarm 3"
        ClockAlarm3.UseVisualStyleBackColor = True
        ' 
        ' ClockAlarm2
        ' 
        ClockAlarm2.AutoSize = True
        ClockAlarm2.Font = New Font("Impact", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ClockAlarm2.Location = New Point(190, 174)
        ClockAlarm2.Name = "ClockAlarm2"
        ClockAlarm2.Size = New Size(76, 24)
        ClockAlarm2.TabIndex = 4
        ClockAlarm2.Text = "Alarm 2"
        ClockAlarm2.UseVisualStyleBackColor = True
        ' 
        ' ClockAlarm1
        ' 
        ClockAlarm1.AutoSize = True
        ClockAlarm1.Font = New Font("Impact", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ClockAlarm1.Location = New Point(190, 144)
        ClockAlarm1.Name = "ClockAlarm1"
        ClockAlarm1.Size = New Size(74, 24)
        ClockAlarm1.TabIndex = 3
        ClockAlarm1.Text = "Alarm 1"
        ClockAlarm1.UseVisualStyleBackColor = True
        ' 
        ' TimePanelClock
        ' 
        TimePanelClock.BorderStyle = BorderStyle.Fixed3D
        TimePanelClock.Location = New Point(12, 7)
        TimePanelClock.Margin = New Padding(4)
        TimePanelClock.Name = "TimePanelClock"
        TimePanelClock.Size = New Size(341, 122)
        TimePanelClock.TabIndex = 1
        TimePanelClock.ValueOfX = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Lily
        PictureBox2.Location = New Point(78, 136)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(123, 126)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' AlarmPage1
        ' 
        AlarmPage1.Controls.Add(AlarmPanel1)
        AlarmPage1.Location = New Point(4, 27)
        AlarmPage1.Name = "AlarmPage1"
        AlarmPage1.Padding = New Padding(3)
        AlarmPage1.Size = New Size(192, 69)
        AlarmPage1.TabIndex = 1
        AlarmPage1.Text = "Alarm-1"
        AlarmPage1.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel1
        ' 
        AlarmPanel1.BackColor = Color.LightPink
        AlarmPanel1.Location = New Point(0, -3)
        AlarmPanel1.Margin = New Padding(4)
        AlarmPanel1.Name = "AlarmPanel1"
        AlarmPanel1.Size = New Size(385, 320)
        AlarmPanel1.TabIndex = 0
        ' 
        ' AlarmPage2
        ' 
        AlarmPage2.Controls.Add(AlarmPanel2)
        AlarmPage2.Location = New Point(4, 27)
        AlarmPage2.Name = "AlarmPage2"
        AlarmPage2.Size = New Size(192, 69)
        AlarmPage2.TabIndex = 2
        AlarmPage2.Text = "Alarm-2"
        AlarmPage2.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel2
        ' 
        AlarmPanel2.BackColor = Color.DarkSlateGray
        AlarmPanel2.ForeColor = Color.DarkGoldenrod
        AlarmPanel2.Location = New Point(0, 0)
        AlarmPanel2.Margin = New Padding(6, 5, 6, 5)
        AlarmPanel2.Name = "AlarmPanel2"
        AlarmPanel2.Size = New Size(376, 317)
        AlarmPanel2.TabIndex = 1
        ' 
        ' AlarmPage3
        ' 
        AlarmPage3.Controls.Add(AlarmPanel3)
        AlarmPage3.Location = New Point(4, 27)
        AlarmPage3.Name = "AlarmPage3"
        AlarmPage3.Size = New Size(192, 69)
        AlarmPage3.TabIndex = 3
        AlarmPage3.Text = "Alarm-3"
        AlarmPage3.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel3
        ' 
        AlarmPanel3.BackColor = Color.PaleTurquoise
        AlarmPanel3.Location = New Point(0, 0)
        AlarmPanel3.Margin = New Padding(6, 5, 6, 5)
        AlarmPanel3.Name = "AlarmPanel3"
        AlarmPanel3.Size = New Size(370, 321)
        AlarmPanel3.TabIndex = 1
        ' 
        ' ClockPanel
        ' 
        ClockPanel.BackColor = Color.DarkGray
        ClockPanel.BorderStyle = BorderStyle.Fixed3D
        ClockPanel.Controls.Add(ButtonCANCEL)
        ClockPanel.Controls.Add(Button2)
        ClockPanel.Controls.Add(ButtonOK)
        ClockPanel.Controls.Add(Button3)
        ClockPanel.Controls.Add(Button0)
        ClockPanel.Controls.Add(Button4)
        ClockPanel.Controls.Add(Button9)
        ClockPanel.Controls.Add(Button5)
        ClockPanel.Controls.Add(Button8)
        ClockPanel.Controls.Add(Button7)
        ClockPanel.Controls.Add(Button6)
        ClockPanel.Controls.Add(Button1)
        ClockPanel.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ClockPanel.Location = New Point(7, 352)
        ClockPanel.Name = "ClockPanel"
        ClockPanel.Size = New Size(380, 168)
        ClockPanel.TabIndex = 0
        ' 
        ' ButtonCANCEL
        ' 
        ButtonCANCEL.BackColor = Color.Red
        ButtonCANCEL.Font = New Font("Impact", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonCANCEL.ForeColor = Color.Black
        ButtonCANCEL.Location = New Point(160, 76)
        ButtonCANCEL.Name = "ButtonCANCEL"
        ButtonCANCEL.Size = New Size(66, 29)
        ButtonCANCEL.TabIndex = 11
        ButtonCANCEL.Text = "Cancel"
        ButtonCANCEL.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(61, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(38, 29)
        Button2.TabIndex = 1
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ButtonOK
        ' 
        ButtonOK.BackColor = Color.Lime
        ButtonOK.Font = New Font("Impact", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonOK.Location = New Point(160, 41)
        ButtonOK.Name = "ButtonOK"
        ButtonOK.Size = New Size(66, 29)
        ButtonOK.TabIndex = 10
        ButtonOK.Text = "OK"
        ButtonOK.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(105, 19)
        Button3.Name = "Button3"
        Button3.Size = New Size(38, 29)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Location = New Point(61, 132)
        Button0.Name = "Button0"
        Button0.Size = New Size(38, 29)
        Button0.TabIndex = 9
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(17, 62)
        Button4.Name = "Button4"
        Button4.Size = New Size(38, 29)
        Button4.TabIndex = 3
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(105, 97)
        Button9.Name = "Button9"
        Button9.Size = New Size(38, 29)
        Button9.TabIndex = 8
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(61, 61)
        Button5.Name = "Button5"
        Button5.Size = New Size(38, 29)
        Button5.TabIndex = 4
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(61, 97)
        Button8.Name = "Button8"
        Button8.Size = New Size(38, 29)
        Button8.TabIndex = 7
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(17, 97)
        Button7.Name = "Button7"
        Button7.Size = New Size(38, 29)
        Button7.TabIndex = 6
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(105, 62)
        Button6.Name = "Button6"
        Button6.Size = New Size(38, 29)
        Button6.TabIndex = 5
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(17, 18)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 29)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 60000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1046, 522)
        Controls.Add(TabControl1)
        Controls.Add(ClockPanel)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fardin Rahman's Clock"
        TabControl1.ResumeLayout(False)
        ClockPage.ResumeLayout(False)
        ClockPage.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        AlarmPage1.ResumeLayout(False)
        AlarmPage2.ResumeLayout(False)
        AlarmPage3.ResumeLayout(False)
        ClockPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ClockPage As TabPage
    Friend WithEvents AlarmPage1 As TabPage
    Friend WithEvents AlarmPage2 As TabPage
    Friend WithEvents AlarmPage3 As TabPage
    Friend WithEvents ClockPanel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonCANCEL As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TimePanelClock As TimePanel
    Friend WithEvents AlarmPanel1 As AlarmPanel
    Friend WithEvents AlarmPanel2 As AlarmPanel
    Friend WithEvents AlarmPanel3 As AlarmPanel
    Friend WithEvents ClockAlarm3 As CheckBox
    Friend WithEvents ClockAlarm2 As CheckBox
    Friend WithEvents ClockAlarm1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
