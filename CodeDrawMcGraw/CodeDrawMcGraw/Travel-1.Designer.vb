﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.picObj3 = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picFinishLine = New System.Windows.Forms.PictureBox()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.picObj4 = New System.Windows.Forms.PictureBox()
        Me.picObj5 = New System.Windows.Forms.PictureBox()
        Me.picObj6 = New System.Windows.Forms.PictureBox()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChar
        '
        Me.picChar.BackColor = System.Drawing.Color.Lime
        Me.picChar.Location = New System.Drawing.Point(258, 822)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(139, 63)
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
        '
        'picObj1
        '
        Me.picObj1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj1.BackColor = System.Drawing.Color.Red
        Me.picObj1.Location = New System.Drawing.Point(962, 622)
        Me.picObj1.Name = "picObj1"
        Me.picObj1.Size = New System.Drawing.Size(120, 77)
        Me.picObj1.TabIndex = 1
        Me.picObj1.TabStop = False
        '
        'picObj2
        '
        Me.picObj2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj2.BackColor = System.Drawing.Color.Red
        Me.picObj2.Location = New System.Drawing.Point(1065, 947)
        Me.picObj2.Name = "picObj2"
        Me.picObj2.Size = New System.Drawing.Size(120, 77)
        Me.picObj2.TabIndex = 2
        Me.picObj2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'picObj3
        '
        Me.picObj3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj3.BackColor = System.Drawing.Color.Red
        Me.picObj3.Location = New System.Drawing.Point(1851, 622)
        Me.picObj3.Name = "picObj3"
        Me.picObj3.Size = New System.Drawing.Size(120, 77)
        Me.picObj3.TabIndex = 4
        Me.picObj3.TabStop = False
        '
        'picGround
        '
        Me.picGround.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picGround.BackColor = System.Drawing.Color.Goldenrod
        Me.picGround.Location = New System.Drawing.Point(-88, 622)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(2787, 425)
        Me.picGround.TabIndex = 5
        Me.picGround.TabStop = False
        '
        'picFinishLine
        '
        Me.picFinishLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picFinishLine.BackColor = System.Drawing.Color.Lime
        Me.picFinishLine.Location = New System.Drawing.Point(2595, 622)
        Me.picFinishLine.Name = "picFinishLine"
        Me.picFinishLine.Size = New System.Drawing.Size(34, 425)
        Me.picFinishLine.TabIndex = 6
        Me.picFinishLine.TabStop = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Castellar", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(748, 76)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(409, 78)
        Me.lblGameOver.TabIndex = 7
        Me.lblGameOver.Text = "      GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'R' to restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblGameOver.Visible = False
        '
        'picObj4
        '
        Me.picObj4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj4.BackColor = System.Drawing.Color.Red
        Me.picObj4.Location = New System.Drawing.Point(2043, 824)
        Me.picObj4.Name = "picObj4"
        Me.picObj4.Size = New System.Drawing.Size(120, 77)
        Me.picObj4.TabIndex = 8
        Me.picObj4.TabStop = False
        '
        'picObj5
        '
        Me.picObj5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj5.BackColor = System.Drawing.Color.Red
        Me.picObj5.Location = New System.Drawing.Point(2183, 947)
        Me.picObj5.Name = "picObj5"
        Me.picObj5.Size = New System.Drawing.Size(120, 77)
        Me.picObj5.TabIndex = 9
        Me.picObj5.TabStop = False
        '
        'picObj6
        '
        Me.picObj6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj6.BackColor = System.Drawing.Color.Red
        Me.picObj6.Location = New System.Drawing.Point(1312, 732)
        Me.picObj6.Name = "picObj6"
        Me.picObj6.Size = New System.Drawing.Size(120, 77)
        Me.picObj6.TabIndex = 10
        Me.picObj6.TabStop = False
        '
        'Travel_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.picObj6)
        Me.Controls.Add(Me.picObj5)
        Me.Controls.Add(Me.picObj4)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picFinishLine)
        Me.Controls.Add(Me.picObj3)
        Me.Controls.Add(Me.picObj2)
        Me.Controls.Add(Me.picObj1)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.picGround)
        Me.Name = "Travel_1"
        Me.Text = "Travel_1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picChar As PictureBox
    Friend WithEvents picObj1 As PictureBox
    Friend WithEvents picObj2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picObj3 As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents picFinishLine As PictureBox
    Friend WithEvents lblGameOver As Label
    Friend WithEvents picObj4 As PictureBox
    Friend WithEvents picObj5 As PictureBox
    Friend WithEvents picObj6 As PictureBox
End Class
