Public Class MOUNTAIN_JUMP_MINIGAME
    Dim x As Integer            'declaring variables
    Dim y As Integer
    Dim yincrement As Integer = 15
    Dim score As Integer
    Public Shared keyscurrency As Integer
    Public Shared mjmhighscore As Integer
    Dim keysearned As Integer
    Dim ack As Integer
    Dim overlap As Boolean
    Dim countdown As Integer


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        x = pcbcharacter.Location.X                         'moves the character left or right across the screen when the game is not paused
        y = pcbcharacter.Location.Y

        If btnpause.Text = "PAUSE" Then
            If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
                If pcbcharacter.Location.X > 12 Then
                    pcbcharacter.Location = New Point(x - 125, y)
                End If
            End If

            If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
                If pcbcharacter.Location.X < 1012 Then
                    pcbcharacter.Location = New Point(x + 125, y)
                End If
            End If
        End If
    End Sub

    Private Sub tmrgame_Tick(sender As Object, e As EventArgs) Handles tmrgame.Tick
        pcbbird1.Visible = True                 'makes all the bird pictureboxes visible
        pcbbird2.Visible = True
        pcbbird3.Visible = True
        pcbbird4.Visible = True
        pcbbird5.Visible = True
        pcbbird6.Visible = True
        pcbbird7.Visible = True
        pcbbird8.Visible = True
        pcbbird9.Visible = True

        Dim path As Integer                 'randomizes a path that will need to be taken by the user to pass a wave of birds

        Randomize()
        path = Int(Rnd() * 9) + 1

        If path = 1 Then
            pcbbird1.Visible = False                'when a path is chosen, the corresponding bird is made invisible
        End If

        If path = 2 Then
            pcbbird2.Visible = False
        End If

        If path = 3 Then
            pcbbird3.Visible = False
        End If

        If path = 4 Then
            pcbbird4.Visible = False
        End If

        If path = 5 Then
            pcbbird5.Visible = False
        End If

        If path = 6 Then
            pcbbird6.Visible = False
        End If

        If path = 7 Then
            pcbbird7.Visible = False
        End If

        If path = 8 Then
            pcbbird8.Visible = False
        End If

        If path = 9 Then
            pcbbird9.Visible = False
        End If

        tmrbirdanimation.Start()
        tmrgame.Stop()

    End Sub

    Private Sub MOUNTAIN_JUMP_MINIGAME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txthighscore.Text = Game.mjmhighscore       'carrys the total high score for the mountain gump mini game from the main form
        keyscurrency = Game.keyscurrency            'carrys over the total keys currency from the main game form
        txtkeys.Text = keyscurrency                     'outputs the total keys currency
        btnpause.Enabled = False                        'disables the pause button as the game is not started
    End Sub

    Private Sub tmrbirdanimation_Tick(sender As Object, e As EventArgs) Handles tmrbirdanimation.Tick
        Dim b1y As Integer
        Dim b2y As Integer
        Dim b3y As Integer
        Dim b4y As Integer                                      'declaring variables for the y-coordnate locations of the birds
        Dim b5y As Integer
        Dim b6y As Integer
        Dim b7y As Integer
        Dim b8y As Integer
        Dim b9y As Integer

        b1y = pcbbird1.Location.Y
        b2y = pcbbird2.Location.Y
        b3y = pcbbird3.Location.Y                               'sets the y coordnate value of the birds pictureboxes to the corresponding variables 
        b4y = pcbbird4.Location.Y
        b5y = pcbbird5.Location.Y
        b6y = pcbbird6.Location.Y
        b7y = pcbbird7.Location.Y
        b8y = pcbbird8.Location.Y
        b9y = pcbbird9.Location.Y

        If b1y < 675 Then
            pcbbird1.Location = New Point(12, b1y + yincrement)                 'moves the birds across the screen as an animation
            pcbbird2.Location = New Point(137, b2y + yincrement)
            pcbbird3.Location = New Point(262, b3y + yincrement)
            pcbbird4.Location = New Point(387, b4y + yincrement)
            pcbbird5.Location = New Point(512, b5y + yincrement)
            pcbbird6.Location = New Point(637, b6y + yincrement)
            pcbbird7.Location = New Point(762, b7y + yincrement)
            pcbbird8.Location = New Point(887, b8y + yincrement)
            pcbbird9.Location = New Point(1012, b9y + yincrement)
        ElseIf b1y >= 675 Then
            pcbbird1.Location = New Point(x, -1)                                'resets the bird pictureboxes to their deafult location on the top margin of the screen
            pcbbird2.Location = New Point(x, -1)
            pcbbird3.Location = New Point(x, -1)
            pcbbird4.Location = New Point(x, -1)
            pcbbird5.Location = New Point(x, -1)
            pcbbird6.Location = New Point(x, -1)
            pcbbird7.Location = New Point(x, -1)
            pcbbird8.Location = New Point(x, -1)
            pcbbird9.Location = New Point(x, -1)
            If yincrement <> 30 Then            'increases the y increment of the birds animation to make the game progressively harder as the birds move faster down the screen
                yincrement += 1
            End If
            tmrgame.Start()
            tmrbirdanimation.Stop()
        End If
    End Sub

    Private Sub tmrgameovercheck_Tick(sender As Object, e As EventArgs) Handles tmrgameovercheck.Tick
        If pcbbird1.Visible = False Then                                            'makes sure the user is on the correct path on the screen with a boolean to see if the collision with the path picture box is present
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird1.Bounds)
        End If
        If pcbbird2.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird2.Bounds)
        End If
        If pcbbird3.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird3.Bounds)
        End If
        If pcbbird4.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird4.Bounds)
        End If
        If pcbbird5.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird5.Bounds)
        End If
        If pcbbird6.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird6.Bounds)
        End If
        If pcbbird7.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird7.Bounds)
        End If
        If pcbbird8.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird8.Bounds)
        End If
        If pcbbird9.Visible = False Then
            overlap = pcbcharacter.Bounds.IntersectsWith(pcbbird9.Bounds)
        End If

        If pcbbird1.Location.Y > 428 And pcbbird1.Location.Y < 650 Then             'if the correct path is not taken and the user character hits the bird on the screen, the game ends
            If overlap = False Then
                lblgameover.Visible = True
                tmrbirdanimation.Stop()
                tmrgame.Stop()
                TMRSCORE.Stop()
                tmrack.Start()
                btnpause.Enabled = False
            End If
        End If
    End Sub

    Private Sub TMRSCORE_Tick(sender As Object, e As EventArgs) Handles TMRSCORE.Tick
        score += 25                 'score addition
        txtscore.Text = score
    End Sub

    Private Sub bttnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        tmrcountdown.Start()                'starts tghe countdown timer
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Game.keyscurrency = keyscurrency                    'carrys over the total keys from the mountain jump mini game to the main form
        Me.Close()                      'closes the form
    End Sub

    Private Sub tmrack_Tick(sender As Object, e As EventArgs) Handles tmrack.Tick
        ack += 1000
        If ack = 3000 Then                                  'resets the program after 3 seconds to allow for user to acknowledge how the game has ended (they have collided with a bird on the screen)
            pcbbird1.Location = New Point(x, -1)
            pcbbird2.Location = New Point(x, -1)
            pcbbird3.Location = New Point(x, -1)
            pcbbird4.Location = New Point(x, -1)            'resets the birds location on the screen
            pcbbird5.Location = New Point(x, -1)
            pcbbird6.Location = New Point(x, -1)
            pcbbird7.Location = New Point(x, -1)
            pcbbird8.Location = New Point(x, -1)
            pcbbird9.Location = New Point(x, -1)
            pcbcharacter.Location = New Point(512, 538)
            keysearned = score / 1000                   'the keys earned are calculated  
            If score > mjmhighscore Then
                mjmhighscore = score
                txthighscore.Text = mjmhighscore                                                    'outputs results of the game
                MsgBox("Well Played! You have earned " & keysearned & " Key(s)!" & ControlChars.NewLine & "Your new high score in Mountain Jump is " & mjmhighscore & "!", MsgBoxStyle.Information, "Game Over")
            Else
                MsgBox("Well Played! You have earned " & keysearned & " Key(s)!", MsgBoxStyle.Information, "Game Over")
            End If
            keyscurrency = keyscurrency + keysearned            'adds up the keys earned with the total currency
            score = 0
            keysearned = 0
            yincrement = 15
            lblgameover.Visible = False
            overlap = False
            ack = 0
            txtscore.Text = score
            txtkeys.Text = keyscurrency
            btnstart.Enabled = True
            btnreturn.Enabled = True
            tmrgameovercheck.Stop()
            tmrack.Stop()
        End If
    End Sub

    Private Sub tmrcountdown_Tick(sender As Object, e As EventArgs) Handles tmrcountdown.Tick
        countdown += 1
        btnstart.Enabled = False
        btnreturn.Enabled = False
        btnpause.Enabled = False                'starts a countdown before the game starts
        If countdown = 1 Then
            lblcountdown.Visible = True
            lblcountdown.Text = "3"
        ElseIf countdown = 2 Then
            lblcountdown.Text = "2"
        ElseIf countdown = 3 Then
            lblcountdown.Text = "1"
        End If
        If countdown = 4 Then
            If btnpause.Text = "PAUSE" Then
                tmrgame.Start()
            End If
            If btnpause.Text = "CONTINUE" Then
                tmrbirdanimation.Start()
            End If
            tmrgameovercheck.Start()
            TMRSCORE.Start()
            lblcountdown.Visible = False
            btnpause.Enabled = True
            countdown = 0
            tmrcountdown.Stop()
            btnpause.Text = "PAUSE"
            btnpause.Enabled = True
        End If
    End Sub

    Private Sub btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        If btnpause.Text = "PAUSE" Then
            tmrgame.Stop()                      'pauses the game by stopping timers that make the game work
            tmrgameovercheck.Stop()
            TMRSCORE.Stop()
            tmrbirdanimation.Stop()
            btnpause.Text = "CONTINUE"
        ElseIf btnpause.Text = "CONTINUE" Then
            tmrcountdown.Start()
        End If
    End Sub
    Private Sub MOUNTAIN_JUMP_MINIGAME_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Game.mjmhighscore = mjmhighscore                'conveys the high score within the mountain jump mini game over to the mountain jump mini game high score on the main form 
        Game.keyscurrency = keyscurrency                'conveys the keys within the mountain jump mini game over to the total keys on the main form 
        Game.Enabled = True                             'enables the game form
    End Sub
End Class