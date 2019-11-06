Public Class Story2
    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Dim frmStory3 As New Story3
        Story3.ShowDialog()
    End Sub

    Private Sub Story2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 0
    End Sub
End Class