<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOUNTAIN_JUMP_MINIGAME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MOUNTAIN_JUMP_MINIGAME))
        Me.pcbbird1 = New System.Windows.Forms.PictureBox()
        Me.pcbcharacter = New System.Windows.Forms.PictureBox()
        Me.tmrgame = New System.Windows.Forms.Timer(Me.components)
        Me.pcbbird2 = New System.Windows.Forms.PictureBox()
        Me.pcbbird3 = New System.Windows.Forms.PictureBox()
        Me.pcbbird4 = New System.Windows.Forms.PictureBox()
        Me.pcbbird5 = New System.Windows.Forms.PictureBox()
        Me.pcbbird6 = New System.Windows.Forms.PictureBox()
        Me.pcbbird7 = New System.Windows.Forms.PictureBox()
        Me.pcbbird8 = New System.Windows.Forms.PictureBox()
        Me.pcbbird9 = New System.Windows.Forms.PictureBox()
        Me.tmrbirdanimation = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgameovercheck = New System.Windows.Forms.Timer(Me.components)
        Me.lblgameover = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtscore = New System.Windows.Forms.TextBox()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.pcbbannerhud = New System.Windows.Forms.PictureBox()
        Me.TMRSCORE = New System.Windows.Forms.Timer(Me.components)
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.lblkeys = New System.Windows.Forms.Label()
        Me.txtkeys = New System.Windows.Forms.TextBox()
        Me.tmrack = New System.Windows.Forms.Timer(Me.components)
        Me.pcbskydiver = New System.Windows.Forms.PictureBox()
        Me.tmrcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblcountdown = New System.Windows.Forms.Label()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.lblhighscore = New System.Windows.Forms.Label()
        Me.txthighscore = New System.Windows.Forms.TextBox()
        CType(Me.pcbbird1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbird9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbbannerhud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbskydiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbbird1
        '
        Me.pcbbird1.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird1.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird1.Location = New System.Drawing.Point(12, 32)
        Me.pcbbird1.Name = "pcbbird1"
        Me.pcbbird1.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird1.TabIndex = 1
        Me.pcbbird1.TabStop = False
        Me.pcbbird1.Visible = False
        '
        'pcbcharacter
        '
        Me.pcbcharacter.BackColor = System.Drawing.Color.Transparent
        Me.pcbcharacter.Image = Global.Mind_Mania.My.Resources.Resources.MOUNTAIN_DIVE_CHAR
        Me.pcbcharacter.Location = New System.Drawing.Point(512, 538)
        Me.pcbcharacter.Name = "pcbcharacter"
        Me.pcbcharacter.Size = New System.Drawing.Size(125, 125)
        Me.pcbcharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbcharacter.TabIndex = 0
        Me.pcbcharacter.TabStop = False
        '
        'tmrgame
        '
        Me.tmrgame.Interval = 1
        '
        'pcbbird2
        '
        Me.pcbbird2.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird2.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird2.Location = New System.Drawing.Point(137, 32)
        Me.pcbbird2.Name = "pcbbird2"
        Me.pcbbird2.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird2.TabIndex = 2
        Me.pcbbird2.TabStop = False
        Me.pcbbird2.Visible = False
        '
        'pcbbird3
        '
        Me.pcbbird3.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird3.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird3.Location = New System.Drawing.Point(262, 32)
        Me.pcbbird3.Name = "pcbbird3"
        Me.pcbbird3.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird3.TabIndex = 3
        Me.pcbbird3.TabStop = False
        Me.pcbbird3.Visible = False
        '
        'pcbbird4
        '
        Me.pcbbird4.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird4.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird4.Location = New System.Drawing.Point(387, 32)
        Me.pcbbird4.Name = "pcbbird4"
        Me.pcbbird4.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird4.TabIndex = 4
        Me.pcbbird4.TabStop = False
        Me.pcbbird4.Visible = False
        '
        'pcbbird5
        '
        Me.pcbbird5.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird5.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird5.Location = New System.Drawing.Point(512, 32)
        Me.pcbbird5.Name = "pcbbird5"
        Me.pcbbird5.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird5.TabIndex = 5
        Me.pcbbird5.TabStop = False
        Me.pcbbird5.Visible = False
        '
        'pcbbird6
        '
        Me.pcbbird6.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird6.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird6.Location = New System.Drawing.Point(637, 32)
        Me.pcbbird6.Name = "pcbbird6"
        Me.pcbbird6.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird6.TabIndex = 6
        Me.pcbbird6.TabStop = False
        Me.pcbbird6.Visible = False
        '
        'pcbbird7
        '
        Me.pcbbird7.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird7.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird7.Location = New System.Drawing.Point(762, 32)
        Me.pcbbird7.Name = "pcbbird7"
        Me.pcbbird7.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird7.TabIndex = 7
        Me.pcbbird7.TabStop = False
        Me.pcbbird7.Visible = False
        '
        'pcbbird8
        '
        Me.pcbbird8.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird8.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird8.Location = New System.Drawing.Point(887, 32)
        Me.pcbbird8.Name = "pcbbird8"
        Me.pcbbird8.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird8.TabIndex = 8
        Me.pcbbird8.TabStop = False
        Me.pcbbird8.Visible = False
        '
        'pcbbird9
        '
        Me.pcbbird9.BackColor = System.Drawing.Color.Transparent
        Me.pcbbird9.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue
        Me.pcbbird9.Location = New System.Drawing.Point(1012, 32)
        Me.pcbbird9.Name = "pcbbird9"
        Me.pcbbird9.Size = New System.Drawing.Size(125, 125)
        Me.pcbbird9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbird9.TabIndex = 9
        Me.pcbbird9.TabStop = False
        Me.pcbbird9.Visible = False
        '
        'tmrbirdanimation
        '
        Me.tmrbirdanimation.Interval = 20
        '
        'tmrgameovercheck
        '
        Me.tmrgameovercheck.Interval = 1
        '
        'lblgameover
        '
        Me.lblgameover.AutoSize = True
        Me.lblgameover.BackColor = System.Drawing.Color.Transparent
        Me.lblgameover.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgameover.Location = New System.Drawing.Point(425, 292)
        Me.lblgameover.Name = "lblgameover"
        Me.lblgameover.Size = New System.Drawing.Size(296, 64)
        Me.lblgameover.TabIndex = 10
        Me.lblgameover.Text = "GAME OVER"
        Me.lblgameover.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1149, 675)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'txtscore
        '
        Me.txtscore.BackColor = System.Drawing.Color.White
        Me.txtscore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtscore.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 60.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtscore.Location = New System.Drawing.Point(445, 60)
        Me.txtscore.Name = "txtscore"
        Me.txtscore.ReadOnly = True
        Me.txtscore.Size = New System.Drawing.Size(257, 82)
        Me.txtscore.TabIndex = 20
        Me.txtscore.Text = "0000"
        Me.txtscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.BackColor = System.Drawing.Color.Transparent
        Me.lblscore.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(509, 18)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(129, 48)
        Me.lblscore.TabIndex = 19
        Me.lblscore.Text = "SCORE"
        Me.lblscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbbannerhud
        '
        Me.pcbbannerhud.BackColor = System.Drawing.Color.White
        Me.pcbbannerhud.Location = New System.Drawing.Point(0, 0)
        Me.pcbbannerhud.Name = "pcbbannerhud"
        Me.pcbbannerhud.Size = New System.Drawing.Size(1149, 157)
        Me.pcbbannerhud.TabIndex = 21
        Me.pcbbannerhud.TabStop = False
        '
        'TMRSCORE
        '
        Me.TMRSCORE.Interval = 250
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.Color.White
        Me.btnstart.BackgroundImage = CType(resources.GetObject("btnstart.BackgroundImage"), System.Drawing.Image)
        Me.btnstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnstart.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.Color.White
        Me.btnstart.Location = New System.Drawing.Point(302, 18)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(120, 120)
        Me.btnstart.TabIndex = 22
        Me.btnstart.Text = "START"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'btnreturn
        '
        Me.btnreturn.BackColor = System.Drawing.Color.White
        Me.btnreturn.BackgroundImage = CType(resources.GetObject("btnreturn.BackgroundImage"), System.Drawing.Image)
        Me.btnreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnreturn.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.ForeColor = System.Drawing.Color.White
        Me.btnreturn.Location = New System.Drawing.Point(50, 18)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(120, 120)
        Me.btnreturn.TabIndex = 23
        Me.btnreturn.Text = "RETURN"
        Me.btnreturn.UseVisualStyleBackColor = False
        '
        'lblkeys
        '
        Me.lblkeys.AutoSize = True
        Me.lblkeys.BackColor = System.Drawing.Color.Transparent
        Me.lblkeys.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkeys.Location = New System.Drawing.Point(714, 23)
        Me.lblkeys.Name = "lblkeys"
        Me.lblkeys.Size = New System.Drawing.Size(81, 38)
        Me.lblkeys.TabIndex = 24
        Me.lblkeys.Text = "KEYS"
        '
        'txtkeys
        '
        Me.txtkeys.BackColor = System.Drawing.Color.White
        Me.txtkeys.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtkeys.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 39.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkeys.Location = New System.Drawing.Point(704, 69)
        Me.txtkeys.Name = "txtkeys"
        Me.txtkeys.ReadOnly = True
        Me.txtkeys.Size = New System.Drawing.Size(100, 55)
        Me.txtkeys.TabIndex = 25
        Me.txtkeys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmrack
        '
        Me.tmrack.Interval = 1000
        '
        'pcbskydiver
        '
        Me.pcbskydiver.Image = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue3
        Me.pcbskydiver.Location = New System.Drawing.Point(975, 3)
        Me.pcbskydiver.Name = "pcbskydiver"
        Me.pcbskydiver.Size = New System.Drawing.Size(171, 150)
        Me.pcbskydiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbskydiver.TabIndex = 26
        Me.pcbskydiver.TabStop = False
        '
        'tmrcountdown
        '
        Me.tmrcountdown.Interval = 1000
        '
        'lblcountdown
        '
        Me.lblcountdown.AutoSize = True
        Me.lblcountdown.BackColor = System.Drawing.Color.Transparent
        Me.lblcountdown.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 144.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountdown.Location = New System.Drawing.Point(491, 239)
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(165, 192)
        Me.lblcountdown.TabIndex = 27
        Me.lblcountdown.Text = "3"
        Me.lblcountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblcountdown.Visible = False
        '
        'btnpause
        '
        Me.btnpause.BackColor = System.Drawing.Color.White
        Me.btnpause.BackgroundImage = CType(resources.GetObject("btnpause.BackgroundImage"), System.Drawing.Image)
        Me.btnpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnpause.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.ForeColor = System.Drawing.Color.White
        Me.btnpause.Location = New System.Drawing.Point(176, 18)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(120, 120)
        Me.btnpause.TabIndex = 28
        Me.btnpause.Text = "PAUSE"
        Me.btnpause.UseVisualStyleBackColor = False
        '
        'lblhighscore
        '
        Me.lblhighscore.AutoSize = True
        Me.lblhighscore.BackColor = System.Drawing.Color.Transparent
        Me.lblhighscore.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhighscore.Location = New System.Drawing.Point(833, 28)
        Me.lblhighscore.Name = "lblhighscore"
        Me.lblhighscore.Size = New System.Drawing.Size(112, 28)
        Me.lblhighscore.TabIndex = 29
        Me.lblhighscore.Text = "High score"
        Me.lblhighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthighscore
        '
        Me.txthighscore.BackColor = System.Drawing.Color.White
        Me.txthighscore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthighscore.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthighscore.Location = New System.Drawing.Point(820, 69)
        Me.txthighscore.Name = "txthighscore"
        Me.txthighscore.ReadOnly = True
        Me.txthighscore.Size = New System.Drawing.Size(128, 28)
        Me.txthighscore.TabIndex = 30
        Me.txthighscore.Text = "0000"
        Me.txthighscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MOUNTAIN_JUMP_MINIGAME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mind_Mania.My.Resources.Resources.finder_clipart_41_clip_art_bird_blue1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1149, 675)
        Me.Controls.Add(Me.lblhighscore)
        Me.Controls.Add(Me.txthighscore)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.lblcountdown)
        Me.Controls.Add(Me.pcbskydiver)
        Me.Controls.Add(Me.txtkeys)
        Me.Controls.Add(Me.lblkeys)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.txtscore)
        Me.Controls.Add(Me.pcbbannerhud)
        Me.Controls.Add(Me.pcbcharacter)
        Me.Controls.Add(Me.lblgameover)
        Me.Controls.Add(Me.pcbbird9)
        Me.Controls.Add(Me.pcbbird8)
        Me.Controls.Add(Me.pcbbird7)
        Me.Controls.Add(Me.pcbbird6)
        Me.Controls.Add(Me.pcbbird5)
        Me.Controls.Add(Me.pcbbird4)
        Me.Controls.Add(Me.pcbbird3)
        Me.Controls.Add(Me.pcbbird2)
        Me.Controls.Add(Me.pcbbird1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MOUNTAIN_JUMP_MINIGAME"
        Me.Text = "Mountain Jump Mini-Game"
        CType(Me.pcbbird1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbird9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbbannerhud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbskydiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbcharacter As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrgame As System.Windows.Forms.Timer
    Friend WithEvents pcbbird2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird3 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird4 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird5 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird6 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird7 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird8 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbird9 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrbirdanimation As System.Windows.Forms.Timer
    Friend WithEvents tmrgameovercheck As System.Windows.Forms.Timer
    Friend WithEvents lblgameover As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtscore As System.Windows.Forms.TextBox
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents pcbbannerhud As System.Windows.Forms.PictureBox
    Friend WithEvents TMRSCORE As System.Windows.Forms.Timer
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents btnreturn As System.Windows.Forms.Button
    Friend WithEvents lblkeys As System.Windows.Forms.Label
    Friend WithEvents txtkeys As System.Windows.Forms.TextBox
    Friend WithEvents tmrack As System.Windows.Forms.Timer
    Friend WithEvents pcbskydiver As System.Windows.Forms.PictureBox
    Friend WithEvents tmrcountdown As System.Windows.Forms.Timer
    Friend WithEvents lblcountdown As System.Windows.Forms.Label
    Friend WithEvents btnpause As System.Windows.Forms.Button
    Friend WithEvents lblhighscore As System.Windows.Forms.Label
    Friend WithEvents txthighscore As System.Windows.Forms.TextBox
End Class
