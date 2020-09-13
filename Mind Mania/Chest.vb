Public Class Chest
    Public Shared keyscurrency As Integer           'declaring variables
    Dim chesttime As Integer = 1
    Dim item As Integer
    Dim randomizecount As Integer
    Dim origionaltime As Integer
    Private Sub Chest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        keyscurrency = Game.keyscurrency            'carrys over the total keys from main form
        txtkeys.Text = keyscurrency
    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        INVENTORY.tmrgamecheck.Start()
        If keyscurrency >= 3 Then
            tmrchest.Start()                        'disables the buttons on the screen when the chest is opened to show an animation
            btnopen.Enabled = False
            btnreturn.Enabled = False
            btninventory.Enabled = False
            keyscurrency -= 3
            txtkeys.Text = keyscurrency
        ElseIf keyscurrency < 3 Then                    'if the user does not have enough keys to open the chest, they are propmted a message telling them they do not have enough keys
            MsgBox("YOU DO NOT HAVE ENOUGH KEYS TO OPEN THE CHEST! PLAY MINIGAMES AND EARN KEYS AND AFTERWARDS TRY AGAIN LATER!", MsgBoxStyle.Critical, "Mind Mania")
        End If
    End Sub

    Private Sub tmrchest_Tick(sender As Object, e As EventArgs) Handles tmrchest.Tick

        If chesttime = 1 Then                           'displays an animation of the chest opening 
            pcbchest.Image = My.Resources.HALF_CHEST
            pcbchest.Location = New Point(200, 53)
            pcbitem.Visible = True
            tmrpicturerandomizer.Start()
            tmrchest.Stop()
        ElseIf chesttime = 2 Then
            Dim xitem As Integer
            Dim yitem As Integer
            xitem = pcbitem.Location.X
            yitem = pcbitem.Location.Y
            pcbitem.Location = New Point(xitem, yitem - 2)
            If pcbitem.Location.Y = 12 Then
                chesttime = 3
            End If
        ElseIf chesttime = 3 Then
            pcbchest.Image = My.Resources.OPEN_CHEST
            pcbchest.Location = New Point(200, 63)
            origionaltime += 1
            If origionaltime = 50 Then
                chesttime = 4
            End If
        ElseIf chesttime = 4 Then
            pcbitem.Location = New Point(365, 98)
            chesttime = 1
            btnopen.Enabled = True
            btnreturn.Enabled = True
            btninventory.Enabled = True
            pcbitem.Visible = False
            pcbchest.Image = My.Resources.CLOSED_CHEST
            origionaltime = 0
            randomizecount = 0
            tmrchest.Stop()
        End If
    End Sub

    Private Sub btngoback_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

    Private Sub picturerandomizer_Tick(sender As Object, e As EventArgs) Handles tmrpicturerandomizer.Tick
        randomizecount += 1
        Randomize()
        item = Int(Rnd() * 10) + 1
        If item = 1 Then
            pcbitem.Image = My.Resources.boat1
        ElseIf item = 2 Then
            pcbitem.Image = My.Resources.boat2              'an animation of multiple pictures being placed in the item picture box in rapid session happens
        ElseIf item = 3 Then
            pcbitem.Image = My.Resources.boat3
        ElseIf item = 4 Then
            pcbitem.Image = My.Resources.boat4
        ElseIf item = 5 Then
            pcbitem.Image = My.Resources.boat5
        ElseIf item = 6 Then
            pcbitem.Image = My.Resources.boat6
        ElseIf item = 7 Then
            pcbitem.Image = My.Resources.boat7
        ElseIf item = 8 Then
            pcbitem.Image = My.Resources.boat8
        ElseIf item = 9 Then
            pcbitem.Image = My.Resources.boat9
        ElseIf item = 10 Then
            pcbitem.Image = My.Resources.boat10
        End If
        If randomizecount = 50 Then
            chesttime = 2
            tmrchest.Start()
            If item = 1 Then
                INVENTORY.item1 = 1                     'rewards the item earned by the user within the chest on the inventory form
            ElseIf item = 2 Then
                INVENTORY.item2 = 1
            ElseIf item = 3 Then
                INVENTORY.item3 = 1
            ElseIf item = 4 Then
                INVENTORY.item4 = 1
            ElseIf item = 5 Then
                INVENTORY.item5 = 1
            ElseIf item = 6 Then
                INVENTORY.item6 = 1
            ElseIf item = 7 Then
                INVENTORY.item7 = 1
            ElseIf item = 8 Then
                INVENTORY.item8 = 1
            ElseIf item = 9 Then
                INVENTORY.item9 = 1
            ElseIf item = 10 Then
                INVENTORY.item10 = 1
            End If
            tmrpicturerandomizer.Stop()
        End If
    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs) Handles btninventory.Click
        INVENTORY.Show()                        'inventory form is visible and the chest form is disabled
        Me.Enabled = False
    End Sub
    Private Sub Chest_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Game.keyscurrency = keyscurrency            'outputs the total keys left to the main form
        Game.Enabled = True                         'enables the game form
    End Sub
End Class