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
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChar
        '
        Me.picChar.BackColor = System.Drawing.Color.Lime
        Me.picChar.Location = New System.Drawing.Point(417, 228)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(100, 237)
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
        '
        'picBad
        '
        Me.picBad.BackColor = System.Drawing.Color.Red
        Me.picBad.Location = New System.Drawing.Point(523, 228)
        Me.picBad.Name = "picBad"
        Me.picBad.Size = New System.Drawing.Size(100, 237)
        Me.picBad.TabIndex = 1
        Me.picBad.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
        Me.lblGoodHealth.AutoSize = True
        Me.lblGoodHealth.Font = New System.Drawing.Font("Castellar", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoodHealth.Location = New System.Drawing.Point(411, 177)
        Me.lblGoodHealth.Name = "lblGoodHealth"
        Me.lblGoodHealth.Size = New System.Drawing.Size(89, 33)
        Me.lblGoodHealth.TabIndex = 2
        Me.lblGoodHealth.Text = "100%"
        '
        'lblBadHealth
        '
        Me.lblBadHealth.AutoSize = True
        Me.lblBadHealth.Font = New System.Drawing.Font("Castellar", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBadHealth.Location = New System.Drawing.Point(534, 177)
        Me.lblBadHealth.Name = "lblBadHealth"
        Me.lblBadHealth.Size = New System.Drawing.Size(89, 33)
        Me.lblBadHealth.TabIndex = 3
        Me.lblBadHealth.Text = "100%"
        '
        'Fight_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 583)
        Me.Controls.Add(Me.lblBadHealth)
        Me.Controls.Add(Me.lblGoodHealth)
        Me.Controls.Add(Me.picBad)
        Me.Controls.Add(Me.picChar)
        Me.Name = "Fight_1"
        Me.Text = "Fight_1"
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
End Class
