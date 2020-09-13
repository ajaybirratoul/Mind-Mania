<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instrustions
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
        Me.GrpGame = New System.Windows.Forms.GroupBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.pcbpage = New System.Windows.Forms.PictureBox()
        Me.GrpGame.SuspendLayout()
        CType(Me.pcbpage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpGame
        '
        Me.GrpGame.Controls.Add(Me.btnnext)
        Me.GrpGame.Controls.Add(Me.txt)
        Me.GrpGame.Controls.Add(Me.pcbpage)
        Me.GrpGame.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpGame.Location = New System.Drawing.Point(12, 12)
        Me.GrpGame.Name = "GrpGame"
        Me.GrpGame.Size = New System.Drawing.Size(898, 575)
        Me.GrpGame.TabIndex = 3
        Me.GrpGame.TabStop = False
        Me.GrpGame.Text = "GAME INSTRUCTIONS"
        '
        'btnnext
        '
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnext.Location = New System.Drawing.Point(739, 527)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(125, 38)
        Me.btnnext.TabIndex = 3
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Myriad Web Pro Condensed", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(28, 537)
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(705, 21)
        Me.txt.TabIndex = 1
        Me.txt.Text = "Welcome to Mind Mania, in this game your objective is to build a boat and get off" & _
    " the island as soon as possible." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pcbpage
        '
        Me.pcbpage.Image = Global.Mind_Mania.My.Resources.Resources.Game
        Me.pcbpage.Location = New System.Drawing.Point(28, 30)
        Me.pcbpage.Name = "pcbpage"
        Me.pcbpage.Size = New System.Drawing.Size(836, 487)
        Me.pcbpage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbpage.TabIndex = 0
        Me.pcbpage.TabStop = False
        '
        'Instrustions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 599)
        Me.Controls.Add(Me.GrpGame)
        Me.Name = "Instrustions"
        Me.Text = "Instrustions"
        Me.GrpGame.ResumeLayout(False)
        Me.GrpGame.PerformLayout()
        CType(Me.pcbpage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbpage As System.Windows.Forms.PictureBox
    Friend WithEvents GrpGame As System.Windows.Forms.GroupBox
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents btnnext As System.Windows.Forms.Button
End Class
