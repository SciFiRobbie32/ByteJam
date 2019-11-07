Public Class main
    Public Shared userName As String

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'TESTING----------------------
        Dim frmTEST As New Story1
        frmTEST.Show()
        Me.Hide()
        '-----------------------------

        'RESIZING: 

        'Dim frmStory1 As New Story1 - DONE
        'frmStory1.Show()

        ''qd 1
        'Dim frmQuickDraw1 As New quickdraw1 - DONE
        'frmQuickDraw1.Show()

        'Dim frmStory2 As New Story2 - DONE
        'frmStory2.Show()



        ''ride 1
        'Dim frmTravel1 As New Travel_1 - DONE
        'frmTravel1.Show()

        'Dim frmStory3 As New Story3 - DONE
        'frmStory3.Show()

        ''ride 2
        'Dim frmTravel2 As New Travel_2 - DONE
        'frmTravel2.Show()

        'Dim frmStory5 As New Story5 - DONE
        'frmStory5.Show()



        ''qd 2
        'Dim frmQuickDraw2 As New quickdraw2 - DONE
        'frmQuickDraw2.Show()

        'Dim frmStory6 As New Story6 - DONE
        'frmStory6.Show()

        ''ride 3
        'Dim frmTravel3 As New Travel_3 - DONE
        'frmTravel3.Show()

        'Dim frmStory7 As New Story7 - DONE
        'frmStory7.Show()



        ''qd 3
        'Dim frmQuickDraw3 As New quickdraw3 - DONE
        'frmQuickDraw3.Show()

        'Dim frmStory8 As New Story8 - DONE
        'frmStory8.Show()

        ''fight
        'Dim frmFight As New Fight_1 - DONE
        'frmFight.Show()

        ''NEED STORY HERE - 8.5

        ''qd 3
        'Dim frmQuickDraw4 As New quickdraw4 - DONE
        'frmQuickDraw4.Show()

        'Dim frmStory9 As New Story9 - DONE
        'frmStory9.Show()

        ''CREDITS
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
