Public Class INVENTORY
    Public Shared item1 As Integer = 0          'declaring varialbes
    Public Shared item2 As Integer = 0
    Public Shared item3 As Integer = 0
    Public Shared item4 As Integer = 0
    Public Shared item5 As Integer = 0
    Public Shared item6 As Integer = 0
    Public Shared item7 As Integer = 0
    Public Shared item8 As Integer = 0
    Public Shared item9 As Integer = 0
    Public Shared item10 As Integer = 0
    Public Shared boatprogress As Integer
    Private Sub INVENTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrgamecheck.Start()
    End Sub
    Private Sub bntreturn_Click(sender As Object, e As EventArgs) Handles bntreturn.Click
        If Game.Enabled = False And Chest.Enabled = False Then          '
            Chest.Enabled = True                'chest form becomes visible if the user accesses the inventory from the chest form
            tmrgamecheck.Stop()
            Me.Hide()
        Else
            Game.Enabled = True                 'game form becomes visible
            tmrgamecheck.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub tmrgamecheck_Tick(sender As Object, e As EventArgs) Handles tmrgamecheck.Tick
        If item1 = 1 Then                                   'if the user has acquired an item, they will se it in the inventory, else they will see a question mark in the corresponding picturebox
            pcbitem1.Image = My.Resources.boat1
        Else
            pcbitem1.Image = My.Resources.question_mark_318_52837
        End If

        If item2 = 1 Then
            pcbitem2.Image = My.Resources.boat2
        Else
            pcbitem2.Image = My.Resources.question_mark_318_52837
        End If

        If item3 = 1 Then
            pcbitem3.Image = My.Resources.boat3
        Else
            pcbitem3.Image = My.Resources.question_mark_318_52837
        End If

        If item4 = 1 Then
            pcbitem4.Image = My.Resources.boat4
        Else
            pcbitem4.Image = My.Resources.question_mark_318_52837
        End If

        If item5 = 1 Then
            pcbitem5.Image = My.Resources.boat5
        Else
            pcbitem5.Image = My.Resources.question_mark_318_52837
        End If

        If item6 = 1 Then
            pcbitem6.Image = My.Resources.boat6
        Else
            pcbitem6.Image = My.Resources.question_mark_318_52837
        End If

        If item7 = 1 Then
            pcbitem7.Image = My.Resources.boat7
        Else
            pcbitem7.Image = My.Resources.question_mark_318_52837
        End If

        If item8 = 1 Then
            pcbitem8.Image = My.Resources.boat8
        Else
            pcbitem8.Image = My.Resources.question_mark_318_52837
        End If

        If item9 = 1 Then
            pcbitem9.Image = My.Resources.boat9
        Else
            pcbitem9.Image = My.Resources.question_mark_318_52837
        End If

        If item10 = 1 Then
            pcbitem10.Image = My.Resources.boat10
        Else
            pcbitem10.Image = My.Resources.question_mark_318_52837
        End If

        boatprogress = (item1 + item2 + item3 + item4 + item5 + item6 + item7 + item8 + item9 + item10) * 10                'determindes the total items collected for the boat progress
        pgbboatprogress.Value = boatprogress

        lblitemscollected.Text = (item1 + item2 + item3 + item4 + item5 + item6 + item7 + item8 + item9 + item10) & " OUT OF 10"                    'tells the user the total items they have got through the chest ou of 10

        If item1 = 1 And item2 = 1 And item3 = 1 And item4 = 1 And item5 = 1 And item6 = 1 And item7 = 1 And item8 = 1 And item9 = 1 And item10 = 1 Then
            btnfinishgame.Enabled = True
        Else                    'if the user has all 10 items of the boat, they have the finish game button visible
            btnfinishgame.Enabled = False
        End If
    End Sub
    Private Sub Inventory_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If Game.Enabled = False And Chest.Enabled = False Then
            Chest.Enabled = True                                            'enables the chest form
            tmrgamecheck.Stop()
        Else
            Game.Enabled = True                 'enables the game form
            tmrgamecheck.Stop()
        End If
    End Sub

    Private Sub btnfinishgame_Click(sender As Object, e As EventArgs) Handles btnfinishgame.Click
        Game.tmrtimeelapsed.Stop()                  'the user is prompted a msgbox showing them results of the game
        MsgBox("Well done, " & StartPage.charactername & " has successfully made it off the island!" & ControlChars.NewLine & "Your final time is " & Game.hrs & ":" & Game.min & ":" & Game.sec & ControlChars.NewLine & "Your Mountain Jump Mini-Game high score is " & Game.mjmhighscore & ControlChars.NewLine & "Your Rock Throwing Mini-Game high score is " & Game.rtmhighscore, MsgBoxStyle.Information, "Mind Mania")
        MsgBox("Thank you for playing Mind Mania!", MsgBoxStyle.Exclamation, "Mind Mania")
        End
    End Sub
End Class