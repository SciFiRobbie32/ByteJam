Public Class main
    Public Shared userName As String

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'TESTING----------------------
        Dim frmTravel1 As New quickdraw1
        frmTravel1.Show()
        '-----------------------------

        'Dim frmStory1 As New Story1
        'frmStory1.Show()
        'Dim frmStory2 As New Story2
        'frmStory2.Show()
        'Dim frmStory3 As New Story3
        'frmStory3.Show()
        'Dim frmStory4 As New Story4
        'frmStory4.Show()
        'Dim frmStory5 As New Story5
        'frmStory5.Show()
        'Dim frmStory6 As New Story6
        'frmStory6.Show()
        'Dim frmStory7 As New Story7
        'frmStory7.Show()
        'Dim frmStory8 As New Story8
        'frmStory8.Show()
        'Dim frmStory9 As New Story9
        'frmStory9.Show()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName = Environment.UserName.ToString()
    End Sub
End Class
