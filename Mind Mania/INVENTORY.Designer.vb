<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INVENTORY
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
        Me.brpitems = New System.Windows.Forms.GroupBox()
        Me.lblitemscollected = New System.Windows.Forms.Label()
        Me.btnfinishgame = New System.Windows.Forms.Button()
        Me.pgbboatprogress = New System.Windows.Forms.ProgressBar()
        Me.lblboatprogress = New System.Windows.Forms.Label()
        Me.bntreturn = New System.Windows.Forms.Button()
        Me.tmrgamecheck = New System.Windows.Forms.Timer(Me.components)
        Me.pcbitem10 = New System.Windows.Forms.PictureBox()
        Me.pcbitem9 = New System.Windows.Forms.PictureBox()
        Me.pcbitem8 = New System.Windows.Forms.PictureBox()
        Me.pcbitem7 = New System.Windows.Forms.PictureBox()
        Me.pcbitem6 = New System.Windows.Forms.PictureBox()
        Me.pcbitem5 = New System.Windows.Forms.PictureBox()
        Me.pcbitem4 = New System.Windows.Forms.PictureBox()
        Me.pcbitem3 = New System.Windows.Forms.PictureBox()
        Me.pcbitem2 = New System.Windows.Forms.PictureBox()
        Me.pcbitem1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.brpitems.SuspendLayout()
        CType(Me.pcbitem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbitem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brpitems
        '
        Me.brpitems.BackColor = System.Drawing.Color.Transparent
        Me.brpitems.Controls.Add(Me.lblitemscollected)
        Me.brpitems.Controls.Add(Me.btnfinishgame)
        Me.brpitems.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brpitems.Location = New System.Drawing.Point(40, 58)
        Me.brpitems.Name = "brpitems"
        Me.brpitems.Size = New System.Drawing.Size(698, 318)
        Me.brpitems.TabIndex = 10
        Me.brpitems.TabStop = False
        Me.brpitems.Text = "ITEMS COLLECTED"
        '
        'lblitemscollected
        '
        Me.lblitemscollected.AutoSize = True
        Me.lblitemscollected.Location = New System.Drawing.Point(16, 35)
        Me.lblitemscollected.Name = "lblitemscollected"
        Me.lblitemscollected.Size = New System.Drawing.Size(70, 28)
        Me.lblitemscollected.TabIndex = 13
        Me.lblitemscollected.Text = "ITEMS"
        '
        'btnfinishgame
        '
        Me.btnfinishgame.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinishgame.Location = New System.Drawing.Point(470, 21)
        Me.btnfinishgame.Name = "btnfinishgame"
        Me.btnfinishgame.Size = New System.Drawing.Size(212, 53)
        Me.btnfinishgame.TabIndex = 13
        Me.btnfinishgame.Text = "FINISH GAME"
        Me.btnfinishgame.UseVisualStyleBackColor = True
        '
        'pgbboatprogress
        '
        Me.pgbboatprogress.Location = New System.Drawing.Point(360, 21)
        Me.pgbboatprogress.Name = "pgbboatprogress"
        Me.pgbboatprogress.Size = New System.Drawing.Size(378, 30)
        Me.pgbboatprogress.TabIndex = 11
        '
        'lblboatprogress
        '
        Me.lblboatprogress.AutoSize = True
        Me.lblboatprogress.BackColor = System.Drawing.Color.Transparent
        Me.lblboatprogress.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblboatprogress.Location = New System.Drawing.Point(188, 22)
        Me.lblboatprogress.Name = "lblboatprogress"
        Me.lblboatprogress.Size = New System.Drawing.Size(166, 28)
        Me.lblboatprogress.TabIndex = 12
        Me.lblboatprogress.Text = "BOAT PROGRESS"
        '
        'bntreturn
        '
        Me.bntreturn.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntreturn.Location = New System.Drawing.Point(40, 16)
        Me.bntreturn.Name = "bntreturn"
        Me.bntreturn.Size = New System.Drawing.Size(124, 40)
        Me.bntreturn.TabIndex = 14
        Me.bntreturn.Text = "RETURN"
        Me.bntreturn.UseVisualStyleBackColor = True
        '
        'tmrgamecheck
        '
        Me.tmrgamecheck.Interval = 1
        '
        'pcbitem10
        '
        Me.pcbitem10.Location = New System.Drawing.Point(589, 248)
        Me.pcbitem10.Name = "pcbitem10"
        Me.pcbitem10.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem10.TabIndex = 9
        Me.pcbitem10.TabStop = False
        '
        'pcbitem9
        '
        Me.pcbitem9.Location = New System.Drawing.Point(455, 248)
        Me.pcbitem9.Name = "pcbitem9"
        Me.pcbitem9.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem9.TabIndex = 8
        Me.pcbitem9.TabStop = False
        '
        'pcbitem8
        '
        Me.pcbitem8.Location = New System.Drawing.Point(321, 248)
        Me.pcbitem8.Name = "pcbitem8"
        Me.pcbitem8.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem8.TabIndex = 7
        Me.pcbitem8.TabStop = False
        '
        'pcbitem7
        '
        Me.pcbitem7.Location = New System.Drawing.Point(187, 248)
        Me.pcbitem7.Name = "pcbitem7"
        Me.pcbitem7.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem7.TabIndex = 6
        Me.pcbitem7.TabStop = False
        '
        'pcbitem6
        '
        Me.pcbitem6.Location = New System.Drawing.Point(53, 248)
        Me.pcbitem6.Name = "pcbitem6"
        Me.pcbitem6.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem6.TabIndex = 5
        Me.pcbitem6.TabStop = False
        '
        'pcbitem5
        '
        Me.pcbitem5.Location = New System.Drawing.Point(589, 138)
        Me.pcbitem5.Name = "pcbitem5"
        Me.pcbitem5.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem5.TabIndex = 4
        Me.pcbitem5.TabStop = False
        '
        'pcbitem4
        '
        Me.pcbitem4.Location = New System.Drawing.Point(455, 138)
        Me.pcbitem4.Name = "pcbitem4"
        Me.pcbitem4.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem4.TabIndex = 3
        Me.pcbitem4.TabStop = False
        '
        'pcbitem3
        '
        Me.pcbitem3.Location = New System.Drawing.Point(321, 138)
        Me.pcbitem3.Name = "pcbitem3"
        Me.pcbitem3.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem3.TabIndex = 2
        Me.pcbitem3.TabStop = False
        '
        'pcbitem2
        '
        Me.pcbitem2.Location = New System.Drawing.Point(187, 138)
        Me.pcbitem2.Name = "pcbitem2"
        Me.pcbitem2.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem2.TabIndex = 1
        Me.pcbitem2.TabStop = False
        '
        'pcbitem1
        '
        Me.pcbitem1.Location = New System.Drawing.Point(53, 138)
        Me.pcbitem1.Name = "pcbitem1"
        Me.pcbitem1.Size = New System.Drawing.Size(133, 108)
        Me.pcbitem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbitem1.TabIndex = 0
        Me.pcbitem1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Mind_Mania.My.Resources.Resources._95131645d89bf13e54bfbe4f78365804
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(782, 407)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'INVENTORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mind_Mania.My.Resources.Resources._95131645d89bf13e54bfbe4f78365804
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(782, 407)
        Me.Controls.Add(Me.bntreturn)
        Me.Controls.Add(Me.lblboatprogress)
        Me.Controls.Add(Me.pgbboatprogress)
        Me.Controls.Add(Me.pcbitem10)
        Me.Controls.Add(Me.pcbitem9)
        Me.Controls.Add(Me.pcbitem8)
        Me.Controls.Add(Me.pcbitem7)
        Me.Controls.Add(Me.pcbitem6)
        Me.Controls.Add(Me.pcbitem5)
        Me.Controls.Add(Me.pcbitem4)
        Me.Controls.Add(Me.pcbitem3)
        Me.Controls.Add(Me.pcbitem2)
        Me.Controls.Add(Me.pcbitem1)
        Me.Controls.Add(Me.brpitems)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "INVENTORY"
        Me.Text = "INVENTORY"
        Me.brpitems.ResumeLayout(False)
        Me.brpitems.PerformLayout()
        CType(Me.pcbitem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbitem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbitem1 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem3 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem4 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem5 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem6 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem7 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem8 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem9 As System.Windows.Forms.PictureBox
    Friend WithEvents pcbitem10 As System.Windows.Forms.PictureBox
    Friend WithEvents brpitems As System.Windows.Forms.GroupBox
    Friend WithEvents pgbboatprogress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblboatprogress As System.Windows.Forms.Label
    Friend WithEvents lblitemscollected As System.Windows.Forms.Label
    Friend WithEvents btnfinishgame As System.Windows.Forms.Button
    Friend WithEvents bntreturn As System.Windows.Forms.Button
    Friend WithEvents tmrgamecheck As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
