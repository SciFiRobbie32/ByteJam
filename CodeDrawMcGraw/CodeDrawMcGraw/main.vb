Public Class main
    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim frmStory1 As New Story1
        frmStory1.ShowDialog()
        Dim frmStory2 As New Story2
        frmStory2.ShowDialog()
        Dim frmStory3 As New Story3
        frmStory3.ShowDialog()
        Dim frmStory4 As New Story4
        frmStory4.ShowDialog()
        Dim frmStory5 As New Story5
        frmStory5.ShowDialog()
        Dim frmStory6 As New Story6
        frmStory6.ShowDialog()
        Dim frmStory7 As New Story7
        frmStory7.ShowDialog()
        Dim frmStory8 As New Story8
        frmStory8.ShowDialog()
        Dim frmStory9 As New Story9
        frmStory9.ShowDialog()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
