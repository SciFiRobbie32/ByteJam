﻿Public Class Story1
    Dim ctr As Integer
    Private Sub Story1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 0
    End Sub

    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Select Case [ctr]
            Case 0
                TextBox1.Text = "You have no idea who you just messed with!"
                TextBox1.Location = New Point(50, 250)
                TextBox1.Height = 40
                PictureBox1.BackColor = Color.Blue
                PictureBox2.BackColor = Color.Red
                ctr += 1
            Case 1
                TextBox1.Text = "Billy, I’ll handle this. *He looks at you* The name is Big Hex, I can't have you ruining my reputation like that. Meet me at high noon on main street. We’ll settle this with a duel."
                TextBox1.Location = New Point(50, 200)
                TextBox1.Height = 200
        End Select
    End Sub
End Class