<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fight_1
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
        Me.picBad = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblGoodHealth = New System.Windows.Forms.Label()
        Me.lblBadHealth = New System.Windows.Forms.Label()
        Me.lblGameOver = New System.Windows.Forms.Label()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChar
        '
        Me.picChar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picChar.BackColor = System.Drawing.Color.Lime
        Me.picChar.Location = New System.Drawing.Point(600, 323)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(349, 718)
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
        '
        'picBad
        '
        Me.picBad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picBad.BackColor = System.Drawing.Color.Red
        Me.picBad.Location = New System.Drawing.Point(955, 323)
        Me.picBad.Name = "picBad"
        Me.picBad.Size = New System.Drawing.Size(349, 718)
        Me.picBad.TabIndex = 1
        Me.picBad.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 750
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'lblGoodHealth
        '
        Me.lblGoodHealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGoodHealth.AutoSize = True
        Me.lblGoodHealth.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoodHealth.Location = New System.Drawing.Point(689, 249)
        Me.lblGoodHealth.Name = "lblGoodHealth"
        Me.lblGoodHealth.Size = New System.Drawing.Size(159, 58)
        Me.lblGoodHealth.TabIndex = 2
        Me.lblGoodHealth.Text = "100%"
        '
        'lblBadHealth
        '
        Me.lblBadHealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBadHealth.AutoSize = True
        Me.lblBadHealth.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBadHealth.Location = New System.Drawing.Point(1056, 249)
        Me.lblBadHealth.Name = "lblBadHealth"
        Me.lblBadHealth.Size = New System.Drawing.Size(159, 58)
        Me.lblBadHealth.TabIndex = 3
        Me.lblBadHealth.Text = "100%"
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Castellar", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(748, 9)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(409, 78)
        Me.lblGameOver.TabIndex = 9
        Me.lblGameOver.Text = "      GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'R' to restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblGameOver.Visible = False
        '
        'Fight_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblBadHealth)
        Me.Controls.Add(Me.lblGoodHealth)
        Me.Controls.Add(Me.picBad)
        Me.Controls.Add(Me.picChar)
        Me.Name = "Fight_1"
        Me.Text = "Fight_1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picChar As PictureBox
    Friend WithEvents picBad As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents lblGoodHealth As Label
    Friend WithEvents lblBadHealth As Label
    Friend WithEvents lblGameOver As Label
End Class
