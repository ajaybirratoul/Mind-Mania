<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chest))
        Me.lblkeys = New System.Windows.Forms.Label()
        Me.txtkeys = New System.Windows.Forms.TextBox()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.tmrchest = New System.Windows.Forms.Timer(Me.components)
        Me.tmrpicturerandomizer = New System.Windows.Forms.Timer(Me.components)
        Me.btninventory = New System.Windows.Forms.Button()
        Me.pcbitem = New System.Windows.Forms.PictureBox()
        Me.pcbchest = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pcbitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbchest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblkeys
        '
        Me.lblkeys.AutoSize = True
        Me.lblkeys.BackColor = System.Drawing.Color.Transparent
        Me.lblkeys.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkeys.ForeColor = System.Drawing.Color.White
        Me.lblkeys.Location = New System.Drawing.Point(18, 15)
        Me.lblkeys.Name = "lblkeys"
        Me.lblkeys.Size = New System.Drawing.Size(71, 32)
        Me.lblkeys.TabIndex = 0
        Me.lblkeys.Text = "KEYS"
        '
        'txtkeys
        '
        Me.txtkeys.Font = New System.Drawing.Font("Myriad Web Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkeys.Location = New System.Drawing.Point(95, 17)
        Me.txtkeys.Name = "txtkeys"
        Me.txtkeys.ReadOnly = True
        Me.txtkeys.Size = New System.Drawing.Size(82, 29)
        Me.txtkeys.TabIndex = 1
        '
        'btnreturn
        '
        Me.btnreturn.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(18, 260)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(159, 46)
        Me.btnreturn.TabIndex = 2
        Me.btnreturn.Text = "RETURN"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'btnopen
        '
        Me.btnopen.BackColor = System.Drawing.SystemColors.Control
        Me.btnopen.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.Location = New System.Drawing.Point(18, 63)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(159, 149)
        Me.btnopen.TabIndex = 3
        Me.btnopen.Text = "OPEN"
        Me.btnopen.UseVisualStyleBackColor = False
        '
        'tmrchest
        '
        Me.tmrchest.Interval = 1
        '
        'tmrpicturerandomizer
        '
        Me.tmrpicturerandomizer.Interval = 1
        '
        'btninventory
        '
        Me.btninventory.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventory.Location = New System.Drawing.Point(18, 213)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Size = New System.Drawing.Size(159, 46)
        Me.btninventory.TabIndex = 6
        Me.btninventory.Text = "INVENTORY"
        Me.btninventory.UseVisualStyleBackColor = True
        '
        'pcbitem
        '
        Me.pcbitem.BackColor = System.Drawing.SystemColors.Control
        Me.pcbitem.Location = New System.Drawing.Point(356, 98)
        Me.pcbitem.Name = "pcbitem"
        Me.pcbitem.Size = New System.Drawing.Size(79, 66)
        Me.pcbitem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbitem.TabIndex = 5
        Me.pcbitem.TabStop = False
        Me.pcbitem.Visible = False
        '
        'pcbchest
        '
        Me.pcbchest.BackColor = System.Drawing.Color.Transparent
        Me.pcbchest.Image = Global.Mind_Mania.My.Resources.Resources.CLOSED_CHEST
        Me.pcbchest.Location = New System.Drawing.Point(200, 63)
        Me.pcbchest.Name = "pcbchest"
        Me.pcbchest.Size = New System.Drawing.Size(398, 261)
        Me.pcbchest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbchest.TabIndex = 4
        Me.pcbchest.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "COST: 3 KEYS"
        '
        'Chest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mind_Mania.My.Resources.Resources.html_color_codes_color_tutorials_hero_00e10b1f1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(610, 327)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btninventory)
        Me.Controls.Add(Me.pcbitem)
        Me.Controls.Add(Me.pcbchest)
        Me.Controls.Add(Me.btnopen)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.txtkeys)
        Me.Controls.Add(Me.lblkeys)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Chest"
        Me.Text = "Mind Mania"
        CType(Me.pcbitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbchest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblkeys As System.Windows.Forms.Label
    Friend WithEvents txtkeys As System.Windows.Forms.TextBox
    Friend WithEvents btnreturn As System.Windows.Forms.Button
    Friend WithEvents btnopen As System.Windows.Forms.Button
    Friend WithEvents pcbchest As System.Windows.Forms.PictureBox
    Friend WithEvents tmrchest As System.Windows.Forms.Timer
    Friend WithEvents pcbitem As System.Windows.Forms.PictureBox
    Friend WithEvents tmrpicturerandomizer As System.Windows.Forms.Timer
    Friend WithEvents btninventory As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
