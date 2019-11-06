Public Class Travel_1
    Dim lstObjects As New List(Of PictureBox)

    Private Sub Travel_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        Timer1.Enabled = True
    End Sub

    Sub init()
        'adds pictureboxes to list
        lstObjects.AddRange({picObj1, picObj2, picObj3})
        AutoScroll = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'moves all obstacles to the left



        If picObj1.Left < Me.Width Then
            For Each pic In lstObjects
                pic.Left = pic.Left - 3

                'LOSE
                If pic.Bounds.IntersectsWith(picChar.Bounds) Then
                    gameOver()
                    Exit Sub
                End If
                'WIN
                If picFinishLine.Bounds.IntersectsWith(picChar.Bounds) Then
                    win()
                    Exit Sub
                End If
            Next
        Else
            For Each pic In lstObjects
                pic.Left = 0
            Next
        End If

        picFinishLine.Left = picFinishLine.Left - 3
    End Sub

    Sub gameOver()
        'sets game over state
        txtGameOver.Visible = True
        Timer1.Enabled = False
        txtGameOver.SelectionStart = 0
    End Sub

    Sub win()
        Timer1.Enabled = False
        MessageBox.Show("You win! Press enter to continue.")
    End Sub

    Private Sub Travel_1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Down Then
            picChar.Top += 10
        End If
        If e.KeyCode = Keys.Up Then
            picChar.Top += -10
        End If

        'Restart the form (ISSUES? - start without debugging works)
        If e.KeyCode = Keys.R Then
            Application.Restart()
            Me.Refresh()
        End If
    End Sub
End Class