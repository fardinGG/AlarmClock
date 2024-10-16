<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmPanel
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
        PictureBox1 = New PictureBox()
        ListBox1 = New ListBox()
        CheckBox1 = New CheckBox()
        TimePanel1 = New TimePanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(11, 155)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(123, 105)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 19
        ListBox1.Items.AddRange(New Object() {"Bird", "Boat Horn", "Cow", "Crickets", "Drum Roll", "Fan Fare", "Train"})
        ListBox1.Location = New Point(140, 155)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(114, 99)
        ListBox1.TabIndex = 2
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(156, 126)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(83, 23)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Alarm On"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TimePanel1
        ' 
        TimePanel1.Location = New Point(3, 3)
        TimePanel1.Name = "TimePanel1"
        TimePanel1.Size = New Size(341, 122)
        TimePanel1.TabIndex = 4
        ' 
        ' AlarmPanel
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TimePanel1)
        Controls.Add(CheckBox1)
        Controls.Add(ListBox1)
        Controls.Add(PictureBox1)
        Name = "AlarmPanel"
        Size = New Size(276, 276)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TimePanel1 As TimePanel

End Class
