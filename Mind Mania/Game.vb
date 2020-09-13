Public Class Game
    Dim x As Integer                        'declaring variables
    Dim y As Integer
    Public Shared seconds, minutes, hours As Integer
    Public Shared sec, min, hrs As String
    Public Shared keyscurrency As Integer
    Public Shared rtmhighscore As Integer
    Public Shared mjmhighscore As Integer
    Dim gameexit As MsgBoxResult
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then                   'When a certain key is pressed, the corresponding timer starts to move the character on the screen
            tmrup.Start()
        End If

        If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            tmrdown.Start()
        End If

        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            tmrleft.Start()
        End If

        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            tmrright.Start()
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then           'When a certain key is released, the corresponding timer stops such that the character on the screen does not move
            tmrup.Stop()
        End If

        If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            tmrdown.Stop()
        End If

        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            tmrleft.Stop()
        End If

        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            tmrright.Stop()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrplanebanner.Start()              'moves the plane in the background as an effect
        lblname.Text = StartPage.charactername          'transfers the character name inputted into the input box from the main screen
        tmrtimeelapsed.Start()              'starts the time elapsed timer 
        tmrbtncheck.Start()                 'this timer checks to see if the user is at a specific location on the screen to give the option of playing a mini-game or open the chest
        gamecheck.Start()
    End Sub

    Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrup.Tick
        x = pcbcharacter.Location.X         'if the user holds the up key or w key, this timer starts and the character picturebox location moves upwards by decreasing the y coordnate of the picturebox by 2 pixels every 1 ms
        y = pcbcharacter.Location.Y

        If pcbcharacter.Location.Y > 426 Then
            pcbcharacter.Location = New Point(x, y - 2)
        End If
        pcbcharacter.Image = My.Resources.UP                    'changes the picture inside the picturebox such that the character is appearing to move forwards (up on the screen)
    End Sub

    Private Sub tmrdown_Tick(sender As Object, e As EventArgs) Handles tmrdown.Tick
        x = pcbcharacter.Location.X
        y = pcbcharacter.Location.Y         'if the user holds the down key or s key, this timer starts and the character picturebox location moves downwards by increasing the y coordnate of the picturebox by 2 pixels every 1 ms

        If pcbcharacter.Location.Y < 520 Then
            pcbcharacter.Location = New Point(x, y + 2)
        End If
        pcbcharacter.Image = My.Resources.DOWN                   'changes the picture inside the picturebox such that the character is appearing to move towards the bottom of the screen 
    End Sub

    Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
        x = pcbcharacter.Location.X          'if the user holds the left key or a key, this timer starts and the character picturebox location moves left across the form by decreasing the x coordnate of the picturebox by 2 pixels every 1 ms
        y = pcbcharacter.Location.Y

        If pcbcharacter.Location.X > -10 Then
            pcbcharacter.Location = New Point(x - 3, y)
        End If
        pcbcharacter.Image = My.Resources.LEFT                  'changes the picture inside the picturebox such that the character is appearing to move left across the screen 
    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        x = pcbcharacter.Location.X          'if the user holds the right key or d key, this timer starts and the character picturebox location moves right across the form by increasing the x coordnate of the picturebox by 2 pixels every 1 ms
        y = pcbcharacter.Location.Y

        If pcbcharacter.Location.X < 983 Then
            pcbcharacter.Location = New Point(x + 3, y)
        End If
        pcbcharacter.Image = My.Resources.RIGHT                  'changes the picture inside the picturebox such that the character is appearing to move right across the screen 
    End Sub

    Private Sub tmrplanebanner_Tick(sender As Object, e As EventArgs) Handles tmrplanebanner.Tick
        Dim planex As Integer                       'moves the plane across the screen 
        Dim planey As Integer

        planex = pcbplanebanner.Location.X
        planey = pcbplanebanner.Location.Y

        If planex <= -204 Then                      'resets the plane location if the plane reaches the left margin of the screen
            planex = 1043
        End If

        pcbplanebanner.Location = New Point(planex - 1.5, planey)
    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tmrtimeelapsed_Tick(sender As Object, e As EventArgs) Handles tmrtimeelapsed.Tick
        seconds += 1
        If seconds = 60 Then                'counts the time taken by the user within the game
            seconds = 0
            minutes += 1                        'if the seconds count reaches 60, a minute is added to the minute count
        End If
        If minutes = 60 Then
            minutes = 0                          'if the minute count reaches 60, an hour is added to the hour count
            hours += 1
        End If

        Select Case seconds                             'decides how to display the time within the game
            Case 0
                sec = "0" & "0"
            Case Is < 10 And seconds > 0
                sec = "0" & seconds
            Case Is >= 10
                sec = seconds
        End Select

        Select Case minutes
            Case 0
                min = "0" & "0"
            Case Is < 10 And minutes > 0
                min = "0" & minutes
            Case Is >= 10
                min = minutes
        End Select

        Select Case hours
            Case 0
                hrs = "0" & "0"
            Case Is < 10 And hours > 0
                hrs = "0" & hours
            Case Is >= 10
                hrs = hours
        End Select

        txttime.Text = hrs & ":" & min & ":" & sec          'outputs the time in "00:00:00" format

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        gameexit = MsgBox("Are you sure you want to exit? You will lose any progress you have made within the game and " & StartPage.charactername & " will not make it off the island!", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "Mind Mania")
        If gameexit = MsgBoxResult.Yes Then         'if the user clicks the exit button, he is asked to confirm that they are sure they wan to exit and are warned of the loss if they do so
            MsgBox("Thank you for playing Mind Mania!", MsgBoxStyle.Exclamation, "Mind Mania")
            Me.Close()
            End                 'if the user confirms the they do in fact want to exit the program
        End If
    End Sub

    Private Sub tmrbtncheck_Tick(sender As Object, e As EventArgs) Handles tmrbtncheck.Tick
        If pcbcharacter.Location.X < 160 And pcbcharacter.Location.X > 10 And pcbcharacter.Location.Y < 525 And pcbcharacter.Location.Y > 455 Then
            btnchest.Visible = True                         'if the user moves the character picturebox to the chest locaton of the form, the chest button becomes visible under the action centre
        Else
            btnchest.Visible = False
        End If
        If pcbcharacter.Location.X < 429 And pcbcharacter.Location.X > 261 And pcbcharacter.Location.Y < 470 And pcbcharacter.Location.Y > 420 Then
            btnrock.Visible = True                          'if the user moves the character picturebox to the rock throwing mini game locaton of the form, the rock throwing mini game button becomes visible under the action centre
        Else
            btnrock.Visible = False
        End If
        If pcbcharacter.Location.X < 788 And pcbcharacter.Location.X > 647 And pcbcharacter.Location.Y < 470 And pcbcharacter.Location.Y > 420 Then
            btnmountain.Visible = True                       'if the user moves the character picturebox to the mountain jump mini game locaton of the form, the mountain jump mini game button becomes visible under the action centre
        Else
            btnmountain.Visible = False
        End If
    End Sub

    Private Sub btnchest_Click(sender As Object, e As EventArgs) Handles btnchest.Click
        Me.Enabled = False          'if th user clicks the chest button, the chest form is prompted 
        Chest.Show()
    End Sub

    Private Sub btninventory_Click_1(sender As Object, e As EventArgs) Handles btninventory.Click
        INVENTORY.Show()            'if th user clicks the inventory button, the inventory form is prompted 
        INVENTORY.tmrgamecheck.Start()
        Me.Enabled = False
    End Sub

    Private Sub gamecheck_Tick(sender As Object, e As EventArgs) Handles gamecheck.Tick
        txtkeys.Text = keyscurrency                         'displays how much of the total value of the boat is completed
        pgbboatcompletion.Value = (INVENTORY.item1 + INVENTORY.item2 + INVENTORY.item3 + INVENTORY.item4 + INVENTORY.item5 + INVENTORY.item6 + INVENTORY.item7 + INVENTORY.item8 + INVENTORY.item9 + INVENTORY.item10) * 10
    End Sub

    Private Sub btnmountain_Click(sender As Object, e As EventArgs) Handles btnmountain.Click
        MOUNTAIN_JUMP_MINIGAME.Show()       'if th user clicks the mountain jump mini game button, the mountain jump mini game form is prompted 
        Me.Enabled = False
    End Sub

    Private Sub btnrock_Click(sender As Object, e As EventArgs) Handles btnrock.Click
        Me.Enabled = False                  'if th user clicks the rock throwing mini game button, the rock throwing mini game form is prompted 
        ROCK_THROWING_MINIGAME.Show()
    End Sub

End Class