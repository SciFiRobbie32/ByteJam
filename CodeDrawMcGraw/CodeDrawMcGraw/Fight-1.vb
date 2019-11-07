Public Class Fight_1
    Dim boolPunching As Boolean = False
    Dim boolShield As Boolean = False
    Dim intGoodHealth As Int16 = 100
    Dim intBadHealth As Int16 = 100

    Private Sub Fight_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'bad guy punching start
        picBad.BackColor = Color.White
        Timer2.Enabled = True

        'Reduces player health if not shielding, otherwise stuns bad guy
        If boolShield = False Then
            intGoodHealth -= 10
            lblGoodHealth.Text = intGoodHealth.ToString() + "%"
            Timer1.Interval = 1000
        Else
            Timer1.Interval = 2000
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'bad guy punching end
        picBad.BackColor = Color.Red
        Timer2.Enabled = False
    End Sub

    Private Sub Fight_1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And boolPunching = False Then
            'change to punching picture, reduce enemy health
            picChar.BackColor = Color.Black
            intBadHealth -= 10
            lblBadHealth.Text = intBadHealth.ToString + "%"
            boolPunching = True
            Timer3.Enabled = True

        End If

        If e.KeyCode = Keys.E And boolPunching = False And boolShield = False Then
            picChar.BackColor = Color.LightBlue
            boolShield = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'good guy punching end
        picChar.BackColor = Color.Green
        boolPunching = False
        Timer3.Enabled = False
    End Sub

    Private Sub Fight_1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.E Then
            boolShield = False
            picChar.BackColor = Color.Green
        End If
    End Sub
End Class