Public Class quickdraw1
    Dim WeaponDraw As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        picbox_Bad.BackColor = Color.Red
        WeaponDraw = True
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        picbox_Bad.BackColor = Color.Blue
        Timer2.Enabled = False
        WeaponDraw = False
    End Sub

    Private Sub quickdraw1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            picbox_Bad.BackColor = Color.ForestGreen
            picbox_Good.BackColor = Color.ForestGreen

            If WeaponDraw Then
                MessageBox.Show("you win, press ok to continue")
                'open next form here
            Else
                lblGameOver.Visible = True
            End If
        End If

        'Restart the form
        If e.KeyCode = Keys.R Then
            Dim frmReset As New quickdraw1
            frmReset.Show()
            Me.Close()
        End If
    End Sub
End Class