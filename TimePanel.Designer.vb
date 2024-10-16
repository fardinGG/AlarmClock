<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        HourLED1 = New DigitLED()
        HourLED2 = New DigitLED()
        Label1 = New Label()
        MinuteLED1 = New DigitLED()
        MinuteLED2 = New DigitLED()
        GroupBox1 = New GroupBox()
        radioPM = New RadioButton()
        radioAM = New RadioButton()
        Button12 = New Button()
        Button21 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' HourLED1
        ' 
        HourLED1.Digit = 0
        HourLED1.Location = New Point(16, 35)
        HourLED1.MaxDigit = 9
        HourLED1.Name = "HourLED1"
        HourLED1.Size = New Size(27, 27)
        HourLED1.TabIndex = 0
        ' 
        ' HourLED2
        ' 
        HourLED2.Digit = 0
        HourLED2.Location = New Point(49, 35)
        HourLED2.MaxDigit = 9
        HourLED2.Name = "HourLED2"
        HourLED2.Size = New Size(27, 27)
        HourLED2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(82, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(14, 23)
        Label1.TabIndex = 2
        Label1.Text = ":"
        ' 
        ' MinuteLED1
        ' 
        MinuteLED1.Digit = 0
        MinuteLED1.Location = New Point(102, 35)
        MinuteLED1.MaxDigit = 9
        MinuteLED1.Name = "MinuteLED1"
        MinuteLED1.Size = New Size(27, 27)
        MinuteLED1.TabIndex = 3
        ' 
        ' MinuteLED2
        ' 
        MinuteLED2.Digit = 0
        MinuteLED2.Location = New Point(135, 35)
        MinuteLED2.MaxDigit = 9
        MinuteLED2.Name = "MinuteLED2"
        MinuteLED2.Size = New Size(27, 27)
        MinuteLED2.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioPM)
        GroupBox1.Controls.Add(radioAM)
        GroupBox1.Location = New Point(168, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(58, 88)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' radioPM
        ' 
        radioPM.AutoSize = True
        radioPM.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radioPM.Location = New Point(6, 47)
        radioPM.Name = "radioPM"
        radioPM.Size = New Size(46, 24)
        radioPM.TabIndex = 1
        radioPM.TabStop = True
        radioPM.Text = "PM"
        radioPM.UseVisualStyleBackColor = True
        ' 
        ' radioAM
        ' 
        radioAM.AutoSize = True
        radioAM.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radioAM.Location = New Point(6, 22)
        radioAM.Name = "radioAM"
        radioAM.Size = New Size(45, 24)
        radioAM.TabIndex = 0
        radioAM.TabStop = True
        radioAM.Text = "AM"
        radioAM.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button12.Location = New Point(16, 68)
        Button12.Name = "Button12"
        Button12.Size = New Size(60, 26)
        Button12.TabIndex = 6
        Button12.Text = "Reset"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button21
        ' 
        Button21.Font = New Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button21.Location = New Point(102, 68)
        Button21.Name = "Button21"
        Button21.Size = New Size(60, 26)
        Button21.TabIndex = 7
        Button21.Text = "Set"
        Button21.UseVisualStyleBackColor = True
        ' 
        ' TimePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button21)
        Controls.Add(Button12)
        Controls.Add(GroupBox1)
        Controls.Add(MinuteLED2)
        Controls.Add(MinuteLED1)
        Controls.Add(Label1)
        Controls.Add(HourLED2)
        Controls.Add(HourLED1)
        Name = "TimePanel"
        Size = New Size(341, 122)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HourLED1 As DigitLED
    Friend WithEvents HourLED2 As DigitLED
    Friend WithEvents Label1 As Label
    Friend WithEvents MinuteLED1 As DigitLED
    Friend WithEvents MinuteLED2 As DigitLED
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioPM As RadioButton
    Friend WithEvents radioAM As RadioButton
    Friend WithEvents Button12 As Button
    Friend WithEvents Button21 As Button

End Class
