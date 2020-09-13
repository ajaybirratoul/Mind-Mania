Imports System.Drawing.Drawing2D

Public Class ROCK_THROWING_MINIGAME
    Dim anglewind As Integer            'declaring variables
    Dim windspeed As Single
    Dim anglethrow As Integer
    Dim mathslope As Single
    Dim radian As Double
    Dim degrees As Double
    Dim radian1 As Double
    Dim degrees1 As Double
    Dim mathslope1 As Single
    Dim rockyincrease As Single
    Dim rockxincrease As Single
    Dim windximpact As Single
    Dim windyimpact As Single
    Dim targetx As Integer
    Dim targety As Integer
    Public Shared keyscurrency As Integer
    Public Shared score As Integer
    Dim collision1 As Boolean = False
    Dim collision2 As Boolean = False
    Dim collision3 As Boolean = False
    Dim pointsrewarded As Boolean = False
    Public Shared rtmhighscore As Integer
    Dim countdown As Integer
    Dim counthitormiss As Integer
    Dim keysearned As Integer
    Dim timeleft As Integer = 20
    Dim count As Integer
    Private Sub btnthrow_Click(sender As Object, e As EventArgs) Handles btnthrow.Click
        trbangleofshot.Enabled = False              'disables the trackbar so that the user will not be able to randomly take another throw without considering the target area
        btnthrow.Enabled = False

        anglethrow = trbangleofshot.Value                   'the following piece of code decides where the rock is thrown depending on what angle and power the user has inputted
        If anglethrow > 90 Then
            degrees = anglethrow - 90
            degrees = 90 - degrees
        ElseIf anglethrow < 90 Then
            degrees = anglethrow
        End If
        radian = degrees * (Math.PI / 180)
        mathslope = Math.Tan(Val(radian))
     
        rockxincrease = trbpowerofthrow.Value * 4.5
        If anglethrow <> 0 And anglethrow <> 180 And anglethrow <> 90 Then
            If anglethrow >= 0 And anglethrow < 45 Or anglethrow < 180 And anglethrow > 135 Then
                rockxincrease = trbpowerofthrow.Value * 4.5
                rockyincrease = trbpowerofthrow.Value * mathslope * 4.5
            ElseIf anglethrow > 45 And anglethrow < 90 Or anglethrow < 135 And anglethrow > 90 Then
                rockyincrease = trbpowerofthrow.Value * 4.5
                rockxincrease = trbpowerofthrow.Value * (1 / mathslope) * 4.5
            ElseIf anglethrow = 45 Or anglethrow = 135 Then
                rockxincrease = trbpowerofthrow.Value * 4.5
                rockyincrease = rockxincrease
            End If
        Else
            rockyincrease = trbpowerofthrow.Value * 4.5
        End If
        If anglethrow > 90 And anglethrow < 180 Then
            pcbrock.Location = New Point(pcbrock.Location.X + rockxincrease, pcbrock.Location.Y - rockyincrease)
        ElseIf anglethrow < 90 And anglethrow > 0 Then
            pcbrock.Location = New Point(pcbrock.Location.X - rockxincrease, pcbrock.Location.Y - rockyincrease)
        ElseIf anglethrow = 90 Then
            pcbrock.Location = New Point(pcbrock.Location.X, pcbrock.Location.Y - rockyincrease)
        ElseIf anglethrow = 0 Or anglethrow = 180 Then
            If anglethrow = 0 Then
                pcbrock.Location = New Point(pcbrock.Location.X - rockxincrease, pcbrock.Location.Y)
            ElseIf anglethrow = 180 Then
                pcbrock.Location = New Point(pcbrock.Location.X + rockxincrease, pcbrock.Location.Y)
            End If
        End If

        If anglewind > 90 And anglewind < 180 Then                  'the following code sdetermines where the rock lands after it gets impacted by the wind 
            degrees1 = anglewind - 90
            degrees1 = 90 - degrees1
        ElseIf anglewind > 180 And anglewind < 270 Then
            degrees1 = anglewind - 180
        ElseIf anglewind > 270 And anglewind < 360 Then
            degrees1 = anglewind - 270
            degrees1 = 90 - degrees1
        ElseIf anglewind > 0 And anglewind < 90 Then
            degrees1 = anglewind
        End If
        radian1 = degrees1 * (Math.PI / 180)
        mathslope1 = Math.Tan(Val(radian1))

        If anglewind > 0 And anglewind < 45 Or anglewind > 315 And anglewind < 360 Or anglewind > 135 And anglewind < 180 Or anglewind > 180 And anglewind < 225 Then
            windximpact = windspeed * 9 * mathslope1
            windyimpact = windspeed * 9
        ElseIf anglewind > 45 And anglewind < 90 Or anglewind > 270 And anglewind < 315 Or anglewind > 90 And anglewind < 135 Or anglewind > 225 And anglewind < 270 Then
            windyimpact = windspeed * 9 * (1 / mathslope1)
            windximpact = windspeed * 9
        End If

        If anglewind > 0 And anglewind < 90 Then
            pcbrock.Location = New Point(pcbrock.Location.X + windximpact, pcbrock.Location.Y - windyimpact)
        ElseIf anglewind > 90 And anglewind < 180 Then
            pcbrock.Location = New Point(pcbrock.Location.X + windximpact, pcbrock.Location.Y + windyimpact)
        ElseIf anglewind > 180 And anglewind < 270 Then
            pcbrock.Location = New Point(pcbrock.Location.X - windximpact, pcbrock.Location.Y + windyimpact)
        ElseIf anglewind > 270 And anglewind < 360 Then
            pcbrock.Location = New Point(pcbrock.Location.X - windximpact, pcbrock.Location.Y - windyimpact)
        ElseIf anglewind = 0 Then
            pcbrock.Location = New Point(pcbrock.Location.X, pcbrock.Location.Y - windspeed * 9)
        ElseIf anglewind = 90 Then
            pcbrock.Location = New Point(pcbrock.Location.X + windspeed * 9, pcbrock.Location.Y)
        ElseIf anglewind = 180 Then
            pcbrock.Location = New Point(pcbrock.Location.X, pcbrock.Location.Y + windspeed * 9)
        ElseIf anglewind = 270 Then
            pcbrock.Location = New Point(pcbrock.Location.X - windspeed * 9, pcbrock.Location.Y)
        ElseIf anglewind = 45 Then
            pcbrock.Location = New Point(pcbrock.Location.X + windspeed * 9, pcbrock.Location.Y - windspeed * 9)
        ElseIf anglewind = 135 Then
            pcbrock.Location = New Point(pcbrock.Location.X + windspeed * 9, pcbrock.Location.Y + windspeed * 9)
        ElseIf anglewind = 225 Then
            pcbrock.Location = New Point(pcbrock.Location.X - windspeed * 9, pcbrock.Location.Y + windspeed * 9)
        ElseIf anglewind = 315 Then
            pcbrock.Location = New Point(pcbrock.Location.X - windspeed * 9, pcbrock.Location.Y - windspeed * 9)
        End If

        tmrhitormiss.Start()                'this timer will tell if the user hits the target or misses the target after the rock is thrown
    End Sub

    Private Sub ROCK_THROWING_MINIGAME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        keyscurrency = Game.keyscurrency               'carrys over the amount of keys the user has onto the rock throwing mini game
        rtmhighscore = Game.rtmhighscore               'carrys over the high score of the rock throwing minigame if there was a high score previously
        txthighscore.Text = rtmhighscore               ' outputs the high score of the rock throwing minigame to corresponding textbox for user acknowledgment 
        txtkeys.Text = keyscurrency                    'outputs the keys to the corresponding textbox for user acknowledgment
    End Sub

    Private Sub tmrhitcal_Tick(sender As Object, e As EventArgs) Handles tmrgamecheck.Tick
        If radgraphical.Checked = True Then                 'this code determines what options the user wants for the visual section of the program
            chkhorizontalscale.Visible = True
            chktargetarea.Visible = True
            chkverticalscale.Visible = True
            chkhorizontalscale.Enabled = True
            chktargetarea.Enabled = True
            chkverticalscale.Enabled = True
        ElseIf radregular.Checked = True Then
            chkhorizontalscale.Visible = False
            chktargetarea.Visible = False
            chkverticalscale.Visible = False
            chkhorizontalscale.Enabled = False
            chktargetarea.Enabled = False
            chkverticalscale.Enabled = False
        End If

        If pointsrewarded = False Then                                          'checks to see if the rock hits the target area
            If pcbtarget1.Bounds.IntersectsWith(pcbrock.Bounds) Then
                collision1 = True
            End If
            If pcbtarget2.Bounds.IntersectsWith(pcbrock.Bounds) Then
                collision2 = True
            End If
            If pcbtarget3.Bounds.IntersectsWith(pcbrock.Bounds) Then
                collision3 = True
            End If
            If collision1 = True And collision2 = True Then
                collision2 = False
            End If
            If collision1 = True And collision3 = True Then
                collision3 = False
            End If
            If collision2 = True And collision3 = True Then
                collision3 = False
            End If
            If collision2 = True And collision3 = True And collision1 = True Then
                collision3 = False
                collision2 = False
            End If

            If collision1 = True Then                           'Determines how mant points are to be awarded depending on the target area hit
                score += 800
                pointsrewarded = True
                txtscore.Text = score                           'scores are outputted to corresponding textbox
            ElseIf collision2 = True Then
                score += 600
                pointsrewarded = True
                txtscore.Text = score
            ElseIf collision3 = True Then
                score += 400
                pointsrewarded = True
                txtscore.Text = score
            End If
        End If
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        tmrstart.Start()

    End Sub
    Private Sub btnnexttarget_Click(sender As Object, e As EventArgs) Handles btnnexttarget.Click
        timeleft = 20                                               'resets the time remaining
        txttimeleft.Text = timeleft                                 'outputs time left to corresponding textbox
        tmrtimeleft.Start()
        Randomize()
        targetx = Int(Rnd() * 723)                                  'randomizes the target area on the visual screen
        targety = Int(Rnd() * 100)
        btnnexttarget.Enabled = False                               'disables the next target button

        trbangleofshot.Value = 90
        trbangleofshot.Enabled = True

        pcbrock.Location = New Point(515, 590)                          'resets the location of the rock on the screen bact to its origional location
        pcbtarget3.Location = New Point(104, 198)                       'resets the targets locations
        pcbtarget2.Location = New Point(124, 198)
        pcbtarget1.Location = New Point(154, 218)
        pcbtarget3.Location = New Point(pcbtarget3.Location.X + targetx, pcbtarget3.Location.Y + targety)       'the randomized target locations are outtputted for the users acknowledgment
        pcbtarget2.Location = New Point(pcbtarget2.Location.X + targetx, pcbtarget2.Location.Y + targety)
        pcbtarget1.Location = New Point(pcbtarget1.Location.X + targetx, pcbtarget1.Location.Y + targety)

        anglewind = Int(Rnd() * 360)                    'randomizes the direction of the wind
        windspeed = (Int(Rnd() * 100)) / 10             'randomizes the speed of the wind
        txtwindspeed.Text = windspeed & " KM/H"         'outputs the speed of the wind for user acknowledgment

        Dim bm_in As New Bitmap(My.Resources.COMPASS2)                      'the following code rotates a  of an arrow and outputs it to the corresponding picturebox to show the user the direction of the wind
        ' Make an array of points defining the
        ' image's corners.
        Dim wid As Single = bm_in.Width
        Dim hgt As Single = bm_in.Height
        Dim corners As Point() = { _
            New Point(0, 0), _
            New Point(wid, 0), _
            New Point(0, hgt), _
            New Point(wid, hgt)}

        ' Translate to center the bounding box at the origin.
        Dim cx As Single = wid / 2
        Dim cy As Single = hgt / 2
        Dim i As Long
        For i = 0 To 3
            corners(i).X -= cx
            corners(i).Y -= cy
        Next i

        ' Rotate.
        Dim theta As Single = Single.Parse(anglewind) * Math.PI / 180.0
        Dim sin_theta As Single = Math.Sin(theta)
        Dim cos_theta As Single = Math.Cos(theta)
        Dim X As Single
        Dim Y As Single
        For i = 0 To 3
            X = corners(i).X
            Y = corners(i).Y
            corners(i).X = X * cos_theta + Y * sin_theta
            corners(i).Y = -X * sin_theta + Y * cos_theta
        Next i

        ' Translate so X >= 0 and Y >=0 for all corners.
        Dim xmin As Single = corners(0).X
        Dim ymin As Single = corners(0).Y
        For i = 1 To 3
            If xmin > corners(i).X Then xmin = corners(i).X
            If ymin > corners(i).Y Then ymin = corners(i).Y
        Next i
        For i = 0 To 3
            corners(i).X -= xmin
            corners(i).Y -= ymin
        Next i

        ' Create an output Bitmap and Graphics object.
        Dim bm_out As New Bitmap(CInt(-2 * xmin), CInt(-2 * _
            ymin))
        Dim gr_out As Graphics = Graphics.FromImage(bm_out)

        ' Drop the last corner lest we confuse DrawImage, 
        ' which expects an array of three corners.
        ReDim Preserve corners(2)

        ' Draw the result onto the output Bitmap.
        gr_out.DrawImage(bm_in, corners)

        ' Display the result.
        bm_out.RotateFlip(RotateFlipType.RotateNoneFlipX)
        pcbarrow.Image = bm_out
    End Sub

    Private Sub trbangleofshot_Scroll(sender As Object, e As EventArgs) Handles trbangleofshot.Scroll
        pointsrewarded = False                      'disables the points rewarded booleam such that the user will not be rewarded points when the trackbar is being used
        anglethrow = trbangleofshot.Value           'the angle on the trackbar is converted to an integer

        btnthrow.Enabled = True
        '
        Dim bm_in2 As New Bitmap(My.Resources.COMPASS2)         'rotates a picture of an arrow depending on what angle the user decides to throw to show a visual of where the rock will land
        ' Make an array of points defining the
        ' image's corners.
        Dim wid As Single = bm_in2.Width
        Dim hgt As Single = bm_in2.Height
        Dim corners As Point() = { _
            New Point(0, 0), _
            New Point(wid, 0), _
            New Point(0, hgt), _
            New Point(wid, hgt)}

        ' Translate to center the bounding box at the origin.
        Dim cx As Single = wid / 2
        Dim cy As Single = hgt / 2
        Dim i As Long
        For i = 0 To 3
            corners(i).X -= cx
            corners(i).Y -= cy
        Next i

        ' Rotate.
        Dim theta As Single = Single.Parse(anglethrow) * Math.PI / 180.0
        Dim sin_theta As Single = Math.Sin(theta)
        Dim cos_theta As Single = Math.Cos(theta)
        Dim X As Single
        Dim Y As Single
        For i = 0 To 3
            X = corners(i).X
            Y = corners(i).Y
            corners(i).X = X * cos_theta + Y * sin_theta
            corners(i).Y = -X * sin_theta + Y * cos_theta
        Next i

        ' Translate so X >= 0 and Y >=0 for all corners.
        Dim xmin As Single = corners(0).X
        Dim ymin As Single = corners(0).Y
        For i = 1 To 3
            If xmin > corners(i).X Then xmin = corners(i).X
            If ymin > corners(i).Y Then ymin = corners(i).Y
        Next i
        For i = 0 To 3
            corners(i).X -= xmin
            corners(i).Y -= ymin
        Next i

        ' Create an output Bitmap and Graphics object.
        Dim bm_out2 As New Bitmap(CInt(-2 * xmin), CInt(-2 * _
            ymin))
        Dim gr_out As Graphics = Graphics.FromImage(bm_out2)

        ' Drop the last corner lest we confuse DrawImage, 
        ' which expects an array of three corners.
        ReDim Preserve corners(2)

        ' Draw the result onto the output Bitmap.
        gr_out.DrawImage(bm_in2, corners)

        ' Display the result.
        bm_out2.RotateFlip(RotateFlipType.Rotate90FlipX)
        pcbarrowofuser.Image = bm_out2

        '

        Dim bm_in3 As New Bitmap(My.Resources.character)
        ' Make an array of points defining the
        ' image's corners.
        Dim wid1 As Single = bm_in3.Width
        Dim hgt1 As Single = bm_in3.Height
        Dim corners1 As Point() = { _
            New Point(0, 0), _
            New Point(wid1, 0), _
            New Point(0, hgt1), _
            New Point(wid1, hgt1)}

        ' Translate to center the bounding box at the origin.
        Dim cx1 As Single = wid1 / 2
        Dim cy1 As Single = hgt1 / 2
        Dim i1 As Long
        For i1 = 0 To 3
            corners1(i1).X -= cx1
            corners1(i1).Y -= cy1
        Next i1

        ' Rotate.
        Dim theta1 As Single = Single.Parse(anglethrow) * Math.PI / 180.0
        Dim sin_theta1 As Single = Math.Sin(theta1)
        Dim cos_theta1 As Single = Math.Cos(theta1)
        Dim X1 As Single
        Dim Y1 As Single
        For i1 = 0 To 3
            X1 = corners1(i1).X
            Y1 = corners1(i1).Y
            corners1(i1).X = X1 * cos_theta1 + Y1 * sin_theta1
            corners1(i1).Y = -X1 * sin_theta1 + Y1 * cos_theta1
        Next i1

        ' Translate so X >= 0 and Y >=0 for all corners.
        Dim xmin1 As Single = corners1(0).X
        Dim ymin1 As Single = corners1(0).Y
        For i1 = 1 To 3
            If xmin1 > corners1(i1).X Then xmin1 = corners1(i1).X
            If ymin1 > corners1(i1).Y Then ymin1 = corners1(i1).Y
        Next i1
        For i1 = 0 To 3
            corners1(i1).X -= xmin1
            corners1(i1).Y -= ymin1
        Next i1

        ' Create an output Bitmap and Graphics object.
        Dim bm_out4 As New Bitmap(CInt(-2 * xmin1), CInt(-2 * _
            ymin1))
        Dim gr_out4 As Graphics = Graphics.FromImage(bm_out4)

        ' Drop the last corner lest we confuse DrawImage, 
        ' which expects an array of three corners.
        ReDim Preserve corners1(2)

        ' Draw the result onto the output Bitmap.
        gr_out4.DrawImage(bm_in3, corners1)

        ' Display the result.
        bm_out4.RotateFlip(RotateFlipType.Rotate90FlipX)
        pcbcharacter.Image = bm_out4
    End Sub

    Private Sub tmrgameresponse_Tick(sender As Object, e As EventArgs) Handles tmrstart.Tick

        countdown += 1                                                      'this code makes a countdown appear for user acknowledgment before the game starts 
        btnstart.Enabled = False
        btnreturn.Enabled = False
        If countdown = 1 Then
            lbloutput.Visible = True
            lbloutput.Text = "3"
        ElseIf countdown = 2 Then
            lbloutput.Text = "2"
        ElseIf countdown = 3 Then
            lbloutput.Text = "1"
        ElseIf countdown = 4 Then
            lbloutput.Visible = False                                       'makes the countdown label invisible
            grpoptions.Enabled = True                                       'enables all the groupboxes on the form
            grpthrow.Enabled = True
            grpvisual.Enabled = True
            grpweather.Enabled = True
            btnstart.Enabled = False                                        'disables the start button such that the user will not create an error within the program when the game has already started
            btnnexttarget.Enabled = False
            Randomize()
            targetx = Int(Rnd() * 763)                                      'randomizes the target area on the visual screen
            targety = Int(Rnd() * 100)
            pcbtarget3.Location = New Point(pcbtarget3.Location.X + targetx, pcbtarget3.Location.Y + targety)               'the randomized target locations are outtputted for the users acknowledgment
            pcbtarget2.Location = New Point(pcbtarget2.Location.X + targetx, pcbtarget2.Location.Y + targety)
            pcbtarget1.Location = New Point(pcbtarget1.Location.X + targetx, pcbtarget1.Location.Y + targety)
            tmrgamecheck.Start()
            tmrtimeleft.Start()
            timeleft = 20
            txttimeleft.Text = timeleft
            Randomize()
            anglewind = Int(Rnd() * 360)                                    'randomizes the angle of the wind
            windspeed = (Int(Rnd() * 100)) / 10                             'randomizes the speed of the wind
            txtwindspeed.Text = windspeed & " KM/H"                         'outputs the wind details for user acknowledgment

            Dim bm_in As New Bitmap(My.Resources.COMPASS2)                  'the following code rotates a  of an arrow and outputs it to the corresponding picturebox to show the user the direction of the wind
            ' Make an array of points defining the
            ' image's corners.
            Dim wid As Single = bm_in.Width
            Dim hgt As Single = bm_in.Height
            Dim corners As Point() = { _
                New Point(0, 0), _
                New Point(wid, 0), _
                New Point(0, hgt), _
                New Point(wid, hgt)}

            ' Translate to center the bounding box at the origin.
            Dim cx As Single = wid / 2
            Dim cy As Single = hgt / 2
            Dim i As Long
            For i = 0 To 3
                corners(i).X -= cx
                corners(i).Y -= cy
            Next i

            ' Rotate.
            Dim theta As Single = Single.Parse(anglewind) * Math.PI / 180.0
            Dim sin_theta As Single = Math.Sin(theta)
            Dim cos_theta As Single = Math.Cos(theta)
            Dim X As Single
            Dim Y As Single
            For i = 0 To 3
                X = corners(i).X
                Y = corners(i).Y
                corners(i).X = X * cos_theta + Y * sin_theta
                corners(i).Y = -X * sin_theta + Y * cos_theta
            Next i

            ' Translate so X >= 0 and Y >=0 for all corners.
            Dim xmin As Single = corners(0).X
            Dim ymin As Single = corners(0).Y
            For i = 1 To 3
                If xmin > corners(i).X Then xmin = corners(i).X
                If ymin > corners(i).Y Then ymin = corners(i).Y
            Next i
            For i = 0 To 3
                corners(i).X -= xmin
                corners(i).Y -= ymin
            Next i

            ' Create an output Bitmap and Graphics object.
            Dim bm_out As New Bitmap(CInt(-2 * xmin), CInt(-2 * _
                ymin))
            Dim gr_out As Graphics = Graphics.FromImage(bm_out)

            ' Drop the last corner lest we confuse DrawImage, 
            ' which expects an array of three corners.
            ReDim Preserve corners(2)

            ' Draw the result onto the output Bitmap.
            gr_out.DrawImage(bm_in, corners)

            ' Display the result.
            bm_out.RotateFlip(RotateFlipType.RotateNoneFlipX)
            pcbarrow.Image = bm_out
            countdown = 0
            trbangleofshot.Enabled = True
            tmrstart.Stop()
        End If

    End Sub

    Private Sub Tmrhit_Tick(sender As Object, e As EventArgs) Handles tmrhitormiss.Tick
        If timeleft <> 0 Then
            counthitormiss += 1
            tmrtimeleft.Stop()                                                                              'stops the timeleft timer 
            If collision1 = False And collision2 = False And collision3 = False Then                        'this code is run if the user misses and does not hit the target area
                If counthitormiss <> 2 Then
                    lbloutput.Visible = True
                    lbloutput.Location = New Point(lbloutput.Location.X - 100, lbloutput.Location.Y)
                    lbloutput.BackColor = Color.Red                                                         'makes the output label background red and makes the text witnin the label  say miss for user acknowledgment
                    lbloutput.Text = "MISS"
                    btnnexttarget.Enabled = False
                ElseIf counthitormiss = 2 Then
                    lbloutput.Visible = False
                    lbloutput.Location = New Point(lbloutput.Location.X + 100, lbloutput.Location.Y)
                    btnnexttarget.Enabled = False
                    counthitormiss = 0
                    tmrstart.Stop()
                    tmrgamecheck.Stop()
                    tmrhitormiss.Stop()
                    keysearned = score / 1000           'determines how many keys the user has earned and outputs the total keys earned within a msgbox for user acknowledgment
                    If score <= rtmhighscore Then
                        MsgBox("Well Played!, your final score is " & score & "!" & ControlChars.NewLine & "You have earned " & keysearned & " key(s)!", MsgBoxStyle.Information, "Game Over")
                    ElseIf score > rtmhighscore Then
                        MsgBox("Well Played!, your new high score is " & score & "!" & ControlChars.NewLine & "You have earned " & keysearned & " key(s)!", MsgBoxStyle.Information, "Game Over")
                        rtmhighscore = score
                    End If
                    keyscurrency = keyscurrency + keysearned                    'adds the keys earned by the user to the total key count
                    txtkeys.Text = keyscurrency
                    Game.keyscurrency = keyscurrency                    'relays the total keys to the main form in which the total keys currency is stored 
                    Game.rtmhighscore = rtmhighscore
                    keysearned = 0                              'resets the program for it to be playable again
                    grpoptions.Enabled = False
                    grpthrow.Enabled = False                                'disables the groupboxes so that the user will not be able to play the game
                    grpvisual.Enabled = False
                    grpweather.Enabled = False
                    timeleft = 0                                            'resets the time left to 0
                    txttimeleft.Text = timeleft
                    score = 0                                               ' resets the score to 0
                    txtwindspeed.Clear()
                    trbangleofshot.Value = 90                           'resets the deafult angle of the shot on the corresponding trackbar to 90 degrees
                    txtscore.Text = score
                    txthighscore.Text = rtmhighscore
                    pcbrock.Location = New Point(515, 590)                              'resets the rock location on the visual groupbox
                    btnstart.Enabled = True
                    lbloutput.BackColor = Color.Transparent
                    pcbtarget3.Location = New Point(104, 198)                   'resets the target locations on the visual groupbox
                    pcbtarget2.Location = New Point(124, 198)
                    pcbtarget1.Location = New Point(154, 218)
                    btnreturn.Enabled = True                                'enables the return button for the user such that they can return to the main form
                End If
            ElseIf collision1 = True Or collision2 = True Or collision3 = True Then     'if the user hits the target, a label appears that says "hit" for user acknowledgment 
                If counthitormiss <> 2 Then
                    lbloutput.Visible = True
                    lbloutput.Location = New Point(lbloutput.Location.X - 70, lbloutput.Location.Y)
                    lbloutput.BackColor = Color.Green
                    lbloutput.Text = "HIT"
                    btnnexttarget.Enabled = False
                ElseIf counthitormiss = 2 Then
                    lbloutput.Visible = False
                    lbloutput.Location = New Point(lbloutput.Location.X + 70, lbloutput.Location.Y)
                    btnnexttarget.Enabled = True                                                        'enables the next target button such that the user can proceed to the next target
                    counthitormiss = 0
                    tmrhitormiss.Stop()
                    collision1 = False
                    collision2 = False
                    collision3 = False
                End If
            End If
        End If
    End Sub
    Private Sub ROCK_THROWING_MINIGAME_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Game.Enabled = True         'enables the game form if the user exits the rock throwing minigame form
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

    Private Sub radregular_CheckedChanged(sender As Object, e As EventArgs) Handles radregular.CheckedChanged
        If radregular.Checked = True Then           'decides which view the user decides to have visible
            grpvisual1.Visible = True
            grpvisual.Visible = False
        ElseIf radregular.Checked = False Then
            grpvisual1.Visible = False
            grpvisual.Visible = True
        End If
    End Sub

    Private Sub radgraphical_CheckedChanged(sender As Object, e As EventArgs) Handles radgraphical.CheckedChanged
        pcbarrowofuser.Visible = True                                       'decides what attributes the user wants visible with the graphical view
        If chktargetarea.Checked = True Then
            pcbtargetlocation.Visible = True
        End If
        If chkhorizontalscale.Checked = True Then
            pcbhorizontalscale.Visible = True
        End If
        If chkverticalscale.Checked = True Then
            pcbverticalscale.Visible = True
        End If
        pcbuserangles.Visible = True
    End Sub

    Private Sub chkhorizontalscale_CheckedChanged(sender As Object, e As EventArgs) Handles chkhorizontalscale.CheckedChanged
        If chkhorizontalscale.Checked = True Then           'decides if the user wants the horizontal scale visible
            pcbhorizontalscale.Visible = True
        Else
            pcbhorizontalscale.Visible = False
        End If
    End Sub

    Private Sub chkverticalscale_CheckedChanged(sender As Object, e As EventArgs) Handles chkverticalscale.CheckedChanged
        If chkverticalscale.Checked = True Then             'decides if the user wants the vertical scale visible
            pcbverticalscale.Visible = True
        Else
            pcbverticalscale.Visible = False
        End If
    End Sub

    Private Sub chktargetarea_CheckedChanged(sender As Object, e As EventArgs) Handles chktargetarea.CheckedChanged
        If chktargetarea.Checked = True Then                'decides if the user wants the potential target area visible
            pcbtargetlocation.Visible = True
        Else
            pcbtargetlocation.Visible = False
        End If
    End Sub

    Private Sub tmrtimeleft_Tick(sender As Object, e As EventArgs) Handles tmrtimeleft.Tick
        If timeleft <> 0 Then               'decreases the time left every second
            timeleft -= 1
        End If
        txttimeleft.Text = timeleft             'outputs the time left to the corresponding textbox for the user acknowledgment
        If timeleft = 0 Then                    'if the user runs out of the the following code runs to display results
            count += 1
            If count = 1 Then
                lbloutput.Visible = True
                lbloutput.Location = New Point(lbloutput.Location.X - 250, lbloutput.Location.Y)            ' when the user runs out of time, a label pops up signalling the users that they have run out of time to throw the rock
                lbloutput.BackColor = Color.Orange
                lbloutput.Text = "TIMES UP"
                btnnexttarget.Enabled = False
            ElseIf count = 2 Then
                lbloutput.Visible = False                                                                       'the following code resets the program to deafult after displaying the results of the user on screen and awarding the earned keys
                lbloutput.Location = New Point(lbloutput.Location.X + 250, lbloutput.Location.Y)
                btnnexttarget.Enabled = False
                counthitormiss = 0
                tmrstart.Stop()
                tmrgamecheck.Stop()
                tmrhitormiss.Stop()
                keysearned = score / 1000
                If score <= rtmhighscore Then
                    MsgBox("Times up!, your final score is " & score & "!" & ControlChars.NewLine & "You have earned " & keysearned & " key(s)!", MsgBoxStyle.Information, "Game Over")
                ElseIf score > rtmhighscore Then
                    MsgBox("Times up!, your new high score is " & score & "!" & ControlChars.NewLine & "You have earned " & keysearned & " key(s)!", MsgBoxStyle.Information, "Game Over")
                    rtmhighscore = score
                End If
                keyscurrency = keyscurrency + keysearned
                txtkeys.Text = keyscurrency
                Game.keyscurrency = keyscurrency
                Game.rtmhighscore = rtmhighscore
                keysearned = 0
                grpoptions.Enabled = False
                grpthrow.Enabled = False
                grpvisual.Enabled = False
                grpweather.Enabled = False
                score = 0
                trbangleofshot.Value = 90
                txtscore.Text = score
                txthighscore.Text = rtmhighscore
                pcbrock.Location = New Point(515, 590)
                btnstart.Enabled = True
                lbloutput.BackColor = Color.Transparent
                pcbtarget3.Location = New Point(104, 198)
                pcbtarget2.Location = New Point(124, 198)
                pcbtarget1.Location = New Point(154, 218)
                btnreturn.Enabled = True
                count = 0
                tmrtimeleft.Stop()
            End If
        End If
    End Sub
End Class