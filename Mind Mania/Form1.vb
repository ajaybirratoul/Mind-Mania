Public Class StartPage
    Public Shared displayimage As Integer
    Public Shared charactername As String
    Dim check1 As Boolean
    Dim check2 As Boolean
    Dim characternamelength As Integer
    Public Shared instructions As Boolean = False
    Dim instructionsoptions As MsgBoxResult
    Public Shared through As Boolean = False
    Public Shared through1 As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If instructions = False Then
            instructionsoptions = MsgBox("Would you like to go through the instructions first? (Recommended for first time players)", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Tutorial")
        End If

        If instructionsoptions = MsgBoxResult.No Or instructions = True Then
            Do Until charactername <> "" And check1 = True
                charactername = InputBox("What would you like to call your character?" & ControlChars.NewLine & "Please use letters only and no spaces!" & ControlChars.NewLine & "Name can be up to 16 characters in length.")
                charactername.Replace(" ", "")
                characternamelength = charactername.Length
                If characternamelength > 16 Then
                    MsgBox("Name is too long! Names can only be up to 16 characters in length!", MsgBoxStyle.Critical, "Error")
                End If
                Select Case characternamelength
                    Case 0
                        Exit Sub
                    Case 1
                        check1 = charactername Like "[A-Za-z]"
                    Case 2
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]"
                    Case 3
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 4
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 5
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 6
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 7
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 8
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 9
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 10
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 11
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 12
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 13
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 14
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 15
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 16
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                End Select
                If check1 = False Then
                    MsgBox("Please, only use letters in the name!", MsgBoxStyle.Critical, "Error")
                End If
            Loop
            Me.Hide()
            Game.Show()
        ElseIf instructionsoptions = MsgBoxResult.Yes Then
            Instrustions.Show()
            Me.Enabled = False
            through = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrdisplayimage.Start()
    End Sub

    Private Sub tmrdisplayimage_Tick(sender As Object, e As EventArgs) Handles tmrdisplayimage.Tick
        displayimage = displayimage + 1
        If displayimage = 3 Then
            pcbbackground.Image = My.Resources.tropical_island_clipart_island_clipart_island_Clip_Art
        ElseIf displayimage = 6 Then
            pcbbackground.Image = My.Resources.tent_clip_art_green_tent_clip_art_vector_clip_art_online_royalty_free_public_600x284
        ElseIf displayimage = 9 Then
            pcbbackground.Image = My.Resources.chest_clipart_treasure_chest5
            displayimage = 0
        End If
        If through1 = True Then
            through1 = False
            Do Until charactername <> "" And check1 = True
                charactername = InputBox("What would you like to call your character?" & ControlChars.NewLine & "Please use letters only and no spaces!" & ControlChars.NewLine & "Name can be up to 16 characters in length.")
                charactername.Replace(" ", "")
                characternamelength = charactername.Length
               
                Select Case characternamelength
                    Case 0
                        Exit Sub
                    Case 1
                        check1 = charactername Like "[A-Za-z]"
                    Case 2
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]"
                    Case 3
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 4
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 5
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 6
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 7
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 8
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 9
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 10
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 11
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 12
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 13
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 14
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 15
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                    Case 16
                        check1 = charactername Like "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]" & "[A-Za-z]"
                End Select

                If characternamelength > 16 Then
                    MsgBox("Name is too long! Names can only be up to 16 characters in length!", MsgBoxStyle.Critical, "Error")
                ElseIf check1 = False Then
                    MsgBox("Please, only use letters in the name!", MsgBoxStyle.Critical, "Error")
                End If
            Loop
            Me.Hide()
            Game.Show()
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btninstructions_Click(sender As Object, e As EventArgs) Handles btninstructions.Click
        Instrustions.Show()
        Me.Enabled = False
    End Sub
End Class
