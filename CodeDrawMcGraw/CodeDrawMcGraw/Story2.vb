Public Class Story2
    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Me.Close()
    End Sub

    Private Sub Story2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 0
    End Sub
End Class