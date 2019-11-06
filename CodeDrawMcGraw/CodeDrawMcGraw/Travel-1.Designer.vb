<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Travel_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.picChar = New System.Windows.Forms.PictureBox()
        Me.picObj1 = New System.Windows.Forms.PictureBox()
        Me.picObj2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtGameOver = New System.Windows.Forms.TextBox()
        Me.picObj3 = New System.Windows.Forms.PictureBox()
        Me.picLengthLine = New System.Windows.Forms.PictureBox()
        Me.picFinishLine = New System.Windows.Forms.PictureBox()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLengthLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChar
        '
        Me.picChar.BackColor = System.Drawing.Color.Lime
        Me.picChar.Location = New System.Drawing.Point(459, 427)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(139, 63)
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
        '
        'picObj1
        '
        Me.picObj1.BackColor = System.Drawing.Color.Red
        Me.picObj1.Location = New System.Drawing.Point(881, 310)
        Me.picObj1.Name = "picObj1"
        Me.picObj1.Size = New System.Drawing.Size(120, 77)
        Me.picObj1.TabIndex = 1
        Me.picObj1.TabStop = False
        '
        'picObj2
        '
        Me.picObj2.BackColor = System.Drawing.Color.Red
        Me.picObj2.Location = New System.Drawing.Point(1276, 531)
        Me.picObj2.Name = "picObj2"
        Me.picObj2.Size = New System.Drawing.Size(120, 77)
        Me.picObj2.TabIndex = 2
        Me.picObj2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'txtGameOver
        '
        Me.txtGameOver.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txtGameOver.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGameOver.Font = New System.Drawing.Font("Castellar", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameOver.Location = New System.Drawing.Point(844, 63)
        Me.txtGameOver.Name = "txtGameOver"
        Me.txtGameOver.ReadOnly = True
        Me.txtGameOver.Size = New System.Drawing.Size(241, 39)
        Me.txtGameOver.TabIndex = 3
        Me.txtGameOver.Text = "GAME OVER"
        Me.txtGameOver.Visible = False
        '
        'picObj3
        '
        Me.picObj3.BackColor = System.Drawing.Color.Red
        Me.picObj3.Location = New System.Drawing.Point(1802, 436)
        Me.picObj3.Name = "picObj3"
        Me.picObj3.Size = New System.Drawing.Size(120, 77)
        Me.picObj3.TabIndex = 4
        Me.picObj3.TabStop = False
        '
        'picLengthLine
        '
        Me.picLengthLine.BackColor = System.Drawing.Color.Red
        Me.picLengthLine.Location = New System.Drawing.Point(447, 932)
        Me.picLengthLine.Name = "picLengthLine"
        Me.picLengthLine.Size = New System.Drawing.Size(4527, 33)
        Me.picLengthLine.TabIndex = 5
        Me.picLengthLine.TabStop = False
        '
        'picFinishLine
        '
        Me.picFinishLine.BackColor = System.Drawing.Color.Lime
        Me.picFinishLine.Location = New System.Drawing.Point(2036, 0)
        Me.picFinishLine.Name = "picFinishLine"
        Me.picFinishLine.Size = New System.Drawing.Size(34, 926)
        Me.picFinishLine.TabIndex = 6
        Me.picFinishLine.TabStop = False
        '
        'Travel_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1344, 1017)
        Me.Controls.Add(Me.picFinishLine)
        Me.Controls.Add(Me.picLengthLine)
        Me.Controls.Add(Me.picObj3)
        Me.Controls.Add(Me.txtGameOver)
        Me.Controls.Add(Me.picObj2)
        Me.Controls.Add(Me.picObj1)
        Me.Controls.Add(Me.picChar)
        Me.Name = "Travel_1"
        Me.Text = "Travel_1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLengthLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picChar As PictureBox
    Friend WithEvents picObj1 As PictureBox
    Friend WithEvents picObj2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtGameOver As TextBox
    Friend WithEvents picObj3 As PictureBox
    Friend WithEvents picLengthLine As PictureBox
    Friend WithEvents picFinishLine As PictureBox
End Class
