Public Class Instrustions
    Dim count As Integer                'declaring variables
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        count = count + 1
        If count = 1 Then                   'text is outputted to the instrustions text for each each different form on the instrustions form, a photo of the corresponding form is places inside the form picturebox
            txt.Text = "In the bar at the top, you will notice the time elapsed section, this shows how long you have been playing for."
        ElseIf count = 2 Then
            txt.Text = "The 3 main locations on the map are the following; the chest, the rock-throwing mini-game and the mountain jump mini-game."
        ElseIf count = 3 Then
            txt.Text = "To travel to the 3 main locations on the map, use the WASD keys or up, down, left and right keys."
        ElseIf count = 4 Then
            txt.Text = "Once you are at one of the three locations, you will see a button pop-up under the action centre in the hud."
        ElseIf count = 5 Then
            txt.Text = "In the hud, you will see a section that shows your keys, these keys are earned by playing minigames and are used to open the chest."
        ElseIf count = 6 Then
            txt.Text = "In the mountain jump mini-game, you have to avoid hitting the birds by moving your character left or right using the a key or d key or left and right keys."
            pcbpage.Image = My.Resources.MJMG
        ElseIf count = 7 Then
            txt.Text = "When its game over, keys are rewarded by the following conversion; 1 key every 1000 score."
        ElseIf count = 8 Then
            txt.Text = "Also, the birds will progressively speed up!"
        ElseIf count = 9 Then
            txt.Text = "In the rock throwing mini-game, you will need to precisely aim and hit a target with a rock."
            pcbpage.Image = My.Resources.RTMG
        ElseIf count = 10 Then
            txt.Text = "You will use the track bars at the bottom to angle your shot and determine how much power you will throw the rock with."
        ElseIf count = 11 Then
            txt.Text = "Note, there is a time limit of 20 seconds to throw and hit the target else its game over!"
        ElseIf count = 12 Then
            txt.Text = "The weather informaion given at the right of the screen will impact your shot so when deciding the angle and power of the throw, factor in the weather."
        ElseIf count = 13 Then
            txt.Text = "Score is given based on where your rock lands. If the rock lands on the dark green target, you get 800 points."
        ElseIf count = 14 Then
            txt.Text = "If the rock lands on the normal green target, you get 600 points, and if the rock lands on the light green area, you are rewarded 400 points."
        ElseIf count = 15 Then
            txt.Text = "If the rock lands anywhere else then the target, it is instantly game over. Keys are rewarded in the following conversion; 1 key every 1000 score."
        ElseIf count = 16 Then
            txt.Text = "This is the chest, and  also the place where you will spend your keys to unlock the necessary items to build the bout you will use to get off the island"
            pcbpage.Image = My.Resources.CHEST
        ElseIf count = 17 Then
            txt.Text = "The cost of opening a chest is 10 keys. Remember, there is also a chance of getting duplicates!"
        ElseIf count = 18 Then
            txt.Text = "Anything you earn from the chest can be found in your inventory."
        ElseIf count = 19 Then
            txt.Text = "This is the inventory, anything you have earned through the chest will appear here. Your boat progress is also here."
            pcbpage.Image = My.Resources.INVENTORY
        ElseIf count = 20 Then
            txt.Text = "Once you have got all the 10 items, you will need to come to the inventory menu and press the finish game button to finish the game."
        ElseIf count = 21 Then
            MsgBox("That concludes the instructions for Mind Mania! Good Luck!", MsgBoxStyle.Information, "Mind Mania")
            Me.Close()
        End If
    End Sub

    Private Sub Instrustions_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        StartPage.Enabled = True                    'decides if the user should be prompted the option to go through instructions if they have already gone through them
        If count = 21 Then
            StartPage.instructions = True
        End If
        If StartPage.through = True Then
            StartPage.through1 = True
        End If
        count = 0
    End Sub
End Class