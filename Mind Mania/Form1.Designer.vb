<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPage))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrdisplayimage = New System.Windows.Forms.Timer(Me.components)
        Me.btninstructions = New System.Windows.Forms.Button()
        Me.pcbbackground = New System.Windows.Forms.PictureBox()
        Me.pcbtitle = New System.Windows.Forms.PictureBox()
        Me.btnexit = New System.Windows.Forms.Button()
        CType(Me.pcbbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbtitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(112, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 53)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tmrdisplayimage
        '
        Me.tmrdisplayimage.Interval = 1000
        '
        'btninstructions
        '
        Me.btninstructions.BackColor = System.Drawing.Color.White
        Me.btninstructions.Location = New System.Drawing.Point(112, 267)
        Me.btninstructions.Name = "btninstructions"
        Me.btninstructions.Size = New System.Drawing.Size(144, 53)
        Me.btninstructions.TabIndex = 4
        Me.btninstructions.Text = "INSTRUCTIONS"
        Me.btninstructions.UseVisualStyleBackColor = False
        '
        'pcbbackground
        '
        Me.pcbbackground.BackColor = System.Drawing.Color.Transparent
        Me.pcbbackground.Image = Global.Mind_Mania.My.Resources.Resources.chest_clipart_treasure_chest5
        Me.pcbbackground.Location = New System.Drawing.Point(379, 91)
        Me.pcbbackground.Name = "pcbbackground"
        Me.pcbbackground.Size = New System.Drawing.Size(380, 313)
        Me.pcbbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbbackground.TabIndex = 1
        Me.pcbbackground.TabStop = False
        '
        'pcbtitle
        '
        Me.pcbtitle.BackColor = System.Drawing.Color.Transparent
        Me.pcbtitle.Image = Global.Mind_Mania.My.Resources.Resources.Untitled_1
        Me.pcbtitle.Location = New System.Drawing.Point(18, 12)
        Me.pcbtitle.Name = "pcbtitle"
        Me.pcbtitle.Size = New System.Drawing.Size(355, 166)
        Me.pcbtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbtitle.TabIndex = 0
        Me.pcbtitle.TabStop = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(112, 326)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(144, 53)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(791, 454)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btninstructions)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pcbbackground)
        Me.Controls.Add(Me.pcbtitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartPage"
        Me.Text = "Mind Mania"
        CType(Me.pcbbackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbtitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbtitle As System.Windows.Forms.PictureBox
    Friend WithEvents pcbbackground As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tmrdisplayimage As System.Windows.Forms.Timer
    Friend WithEvents btninstructions As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button

End Class
