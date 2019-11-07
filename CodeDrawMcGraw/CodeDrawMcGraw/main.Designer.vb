<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.pbxMenu = New System.Windows.Forms.PictureBox()
        CType(Me.pbxMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Castellar", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(615, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Code Draw McGraw"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(27, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 56)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.Transparent
        Me.btnCredits.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Location = New System.Drawing.Point(27, 199)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(139, 56)
        Me.btnCredits.TabIndex = 5
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.Transparent
        Me.btnNewGame.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(27, 137)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(139, 56)
        Me.btnNewGame.TabIndex = 4
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'pbxMenu
        '
        Me.pbxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxMenu.Image = CType(resources.GetObject("pbxMenu.Image"), System.Drawing.Image)
        Me.pbxMenu.Location = New System.Drawing.Point(0, 0)
        Me.pbxMenu.Name = "pbxMenu"
        Me.pbxMenu.Size = New System.Drawing.Size(1371, 748)
        Me.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMenu.TabIndex = 8
        Me.pbxMenu.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.pbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents pbxMenu As PictureBox
End Class
