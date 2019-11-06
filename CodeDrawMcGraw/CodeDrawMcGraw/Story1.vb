Public Class Story1
    Dim ctr As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click

        Select Case [ctr]
            Case 0
                TextBox1.Text = "You have no idea who you just messed with!"
                TextBox1.Location = New Point(50, 300)
                TextBox1.Height = 30
                ctr += 1
                PictureBox1.BackColor = Color.Blue
                PictureBox2.BackColor = Color.Red
            Case 1
                TextBox1.Text = "Billy, I’ll handle this. *looks at you* The name is Big Hex, I can't have you ruining my reputation like that. Meet me at high noon on main street. We’ll settle this with a duel."
                TextBox1.Location = New Point(50, 250)
                TextBox1.Height = 60
                ctr += 1
            Case 2
                'duel'
        End Select
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
