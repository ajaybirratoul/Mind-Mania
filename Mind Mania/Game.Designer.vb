<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.tmrplanebanner = New System.Windows.Forms.Timer(Me.components)
        Me.pcbbackground = New System.Windows.Forms.PictureBox()
        Me.pcbplanebanner = New System.Windows.Forms.PictureBox()
        Me.pcbcharacter = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btninventory = New System.Windows.Forms.Button()
        Me.lblkeys = New System.Windows.Forms.Label()
        Me.txtkeys = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.pgbboatcompletion = New System.Windows.Forms.ProgressBar()
        Me.lblboatprogress = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.tmrtimeelapsed = New System.Windows.Forms.Timer(Me.components)
        Me.tmrbtncheck = New System.Windows.Forms.Timer(Me.components)
        Me.gamecheck = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnrock = New System.Windows.Forms.Button()
        Me.btnmountain = New System.Windows.Forms.Button()
        Me.btnchest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pcbbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbplanebanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrup
        '
        Me.tmrup.Interval = 1
        '
        'tmrdown
        '
        Me.tmrdown.Interval = 1
        '
        'tmrleft
        '
        Me.tmrleft.Interval = 1
        '
        'tmrright
        '
        Me.tmrright.Interval = 1
        '
        'tmrplanebanner
        '
        Me.tmrplanebanner.Interval = 1
        '
        'pcbbackground
        '
        Me.pcbbackground.BackColor = System.Drawing.Color.Transparent
        Me.pcbbackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcbbackground.Image = Global.Mind_Mania.My.Resources.Resources.BACKGROUND
        Me.pcbbackground.Location = New System.Drawing.Point(0, 0)
        Me.pcbbackground.Name = "pcbbackground"
        Me.pcbbackground.Size = New System.Drawing.Size(1057, 619)
        Me.pcbbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbbackground.TabIndex = 2
        Me.pcbbackground.TabStop = False
        '
        'pcbplanebanner
        '
        Me.pcbplanebanner.BackColor = System.Drawing.Color.Transparent
        Me.pcbplanebanner.Image = Global.Mind_Mania.My.Resources.Resources.plane_pulling_banner_vector_8550070
        Me.pcbplanebanner.Location = New System.Drawing.Point(1046, 136)
        Me.pcbplanebanner.Name = "pcbplanebanner"
        Me.pcbplanebanner.Size = New System.Drawing.Size(221, 85)
        Me.pcbplanebanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbplanebanner.TabIndex = 1
        Me.pcbplanebanner.TabStop = False
        '
        'pcbcharacter
        '
        Me.pcbcharacter.BackColor = System.Drawing.Color.Transparent
        Me.pcbcharacter.Image = Global.Mind_Mania.My.Resources.Resources.CASUAL
        Me.pcbcharacter.Location = New System.Drawing.Point(486, 502)
        Me.pcbcharacter.Name = "pcbcharacter"
        Me.pcbcharacter.Size = New System.Drawing.Size(95, 73)
        Me.pcbcharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbcharacter.TabIndex = 0
        Me.pcbcharacter.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mind_Mania.My.Resources.Resources.PROFILE
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(109, 10)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(48, 20)
        Me.lblname.TabIndex = 8
        Me.lblname.Text = "Name"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btninventory
        '
        Me.btninventory.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventory.Location = New System.Drawing.Point(806, 6)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Size = New System.Drawing.Size(142, 84)
        Me.btninventory.TabIndex = 10
        Me.btninventory.Text = "INVENTORY"
        Me.btninventory.UseVisualStyleBackColor = True
        '
        'lblkeys
        '
        Me.lblkeys.AutoSize = True
        Me.lblkeys.BackColor = System.Drawing.Color.Transparent
        Me.lblkeys.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkeys.Location = New System.Drawing.Point(365, 10)
        Me.lblkeys.Name = "lblkeys"
        Me.lblkeys.Size = New System.Drawing.Size(43, 20)
        Me.lblkeys.TabIndex = 11
        Me.lblkeys.Text = "KEYS"
        Me.lblkeys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtkeys
        '
        Me.txtkeys.BackColor = System.Drawing.Color.White
        Me.txtkeys.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkeys.Location = New System.Drawing.Point(348, 42)
        Me.txtkeys.Name = "txtkeys"
        Me.txtkeys.ReadOnly = True
        Me.txtkeys.Size = New System.Drawing.Size(77, 43)
        Me.txtkeys.TabIndex = 12
        Me.txtkeys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(954, 6)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 84)
        Me.btnexit.TabIndex = 14
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'pgbboatcompletion
        '
        Me.pgbboatcompletion.Location = New System.Drawing.Point(227, 54)
        Me.pgbboatcompletion.Name = "pgbboatcompletion"
        Me.pgbboatcompletion.Size = New System.Drawing.Size(100, 21)
        Me.pgbboatcompletion.TabIndex = 15
        '
        'lblboatprogress
        '
        Me.lblboatprogress.AutoSize = True
        Me.lblboatprogress.BackColor = System.Drawing.Color.Transparent
        Me.lblboatprogress.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblboatprogress.Location = New System.Drawing.Point(109, 56)
        Me.lblboatprogress.Name = "lblboatprogress"
        Me.lblboatprogress.Size = New System.Drawing.Size(100, 16)
        Me.lblboatprogress.TabIndex = 16
        Me.lblboatprogress.Text = "BOAT PROGRESS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblboatprogress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(463, 8)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(130, 24)
        Me.lbltime.TabIndex = 17
        Me.lbltime.Text = "TIME ELAPSED"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txttime
        '
        Me.txttime.BackColor = System.Drawing.Color.White
        Me.txttime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttime.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(444, 39)
        Me.txttime.Name = "txttime"
        Me.txttime.ReadOnly = True
        Me.txttime.Size = New System.Drawing.Size(169, 49)
        Me.txttime.TabIndex = 18
        Me.txttime.Text = "00:00:00"
        Me.txttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmrtimeelapsed
        '
        Me.tmrtimeelapsed.Interval = 1000
        '
        'tmrbtncheck
        '
        Me.tmrbtncheck.Interval = 1
        '
        'gamecheck
        '
        Me.gamecheck.Interval = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Mind_Mania.My.Resources.Resources.blueborder
        Me.PictureBox2.Location = New System.Drawing.Point(630, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'btnrock
        '
        Me.btnrock.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrock.Location = New System.Drawing.Point(635, 43)
        Me.btnrock.Name = "btnrock"
        Me.btnrock.Size = New System.Drawing.Size(148, 43)
        Me.btnrock.TabIndex = 20
        Me.btnrock.Text = "ROCK THROWING MINI-GAME"
        Me.btnrock.UseVisualStyleBackColor = True
        Me.btnrock.Visible = False
        '
        'btnmountain
        '
        Me.btnmountain.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmountain.Location = New System.Drawing.Point(635, 43)
        Me.btnmountain.Name = "btnmountain"
        Me.btnmountain.Size = New System.Drawing.Size(148, 43)
        Me.btnmountain.TabIndex = 21
        Me.btnmountain.Text = "MOUNTAIN DIVE MINIGAME"
        Me.btnmountain.UseVisualStyleBackColor = True
        Me.btnmountain.Visible = False
        '
        'btnchest
        '
        Me.btnchest.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchest.Location = New System.Drawing.Point(635, 43)
        Me.btnchest.Name = "btnchest"
        Me.btnchest.Size = New System.Drawing.Size(148, 43)
        Me.btnchest.TabIndex = 19
        Me.btnchest.Text = "CHEST"
        Me.btnchest.UseVisualStyleBackColor = True
        Me.btnchest.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(645, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ACTION CENTRE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mind_Mania.My.Resources.Resources.BACKGROUND
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1057, 619)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnchest)
        Me.Controls.Add(Me.btnmountain)
        Me.Controls.Add(Me.btnrock)
        Me.Controls.Add(Me.pcbcharacter)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.pgbboatcompletion)
        Me.Controls.Add(Me.lblboatprogress)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtkeys)
        Me.Controls.Add(Me.lblkeys)
        Me.Controls.Add(Me.btninventory)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pcbplanebanner)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pcbbackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Game"
        Me.Text = "Mind Mania"
        CType(Me.pcbbackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbplanebanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbcharacter As System.Windows.Forms.PictureBox
    Friend WithEvents tmrup As System.Windows.Forms.Timer
    Friend WithEvents tmrdown As System.Windows.Forms.Timer
    Friend WithEvents tmrleft As System.Windows.Forms.Timer
    Friend WithEvents tmrright As System.Windows.Forms.Timer
    Friend WithEvents tmrplanebanner As System.Windows.Forms.Timer
    Friend WithEvents pcbplanebanner As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbackground As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents btninventory As System.Windows.Forms.Button
    Friend WithEvents lblkeys As System.Windows.Forms.Label
    Friend WithEvents txtkeys As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents pgbboatcompletion As System.Windows.Forms.ProgressBar
    Friend WithEvents lblboatprogress As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents tmrtimeelapsed As System.Windows.Forms.Timer
    Friend WithEvents tmrbtncheck As System.Windows.Forms.Timer
    Friend WithEvents gamecheck As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnrock As System.Windows.Forms.Button
    Friend WithEvents btnmountain As System.Windows.Forms.Button
    Friend WithEvents btnchest As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
