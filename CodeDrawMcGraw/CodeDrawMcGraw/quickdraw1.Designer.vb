<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class quickdraw1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quickdraw1))
        Me.picbox_Bad = New System.Windows.Forms.PictureBox()
        Me.picbox_Good = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameOver = New System.Windows.Forms.Label()
        CType(Me.picbox_Bad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_Good, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picbox_Bad
        '
        Me.picbox_Bad.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picbox_Bad.Location = New System.Drawing.Point(961, 319)
        Me.picbox_Bad.Name = "picbox_Bad"
        Me.picbox_Bad.Size = New System.Drawing.Size(132, 118)
        Me.picbox_Bad.TabIndex = 4
        Me.picbox_Bad.TabStop = False
        '
        'picbox_Good
        '
        Me.picbox_Good.Image = CType(resources.GetObject("picbox_Good.Image"), System.Drawing.Image)
        Me.picbox_Good.Location = New System.Drawing.Point(617, 319)
        Me.picbox_Good.Name = "picbox_Good"
        Me.picbox_Good.Size = New System.Drawing.Size(132, 118)
        Me.picbox_Good.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_Good.TabIndex = 3
        Me.picbox_Good.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Castellar", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(667, 9)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(347, 66)
        Me.lblGameOver.TabIndex = 8
        Me.lblGameOver.Text = "      GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'R' to restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblGameOver.Visible = False
        '
        'quickdraw1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 648)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picbox_Bad)
        Me.Controls.Add(Me.picbox_Good)
        Me.Name = "quickdraw1"
        Me.Text = "quickdraw1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picbox_Bad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_Good, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picbox_Bad As PictureBox
    Friend WithEvents picbox_Good As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblGameOver As Label
End Class
