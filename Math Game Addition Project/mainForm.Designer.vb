<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.leftAdd1Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rightAdd1Label = New System.Windows.Forms.Label()
        Me.rightAdd2Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.leftAdd2Label = New System.Windows.Forms.Label()
        Me.rightAdd3Label = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.leftAdd3Label = New System.Windows.Forms.Label()
        Me.rightAdd4Label = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.leftAdd4Label = New System.Windows.Forms.Label()
        Me.rightAdd5Label = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.leftAdd5Label = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sum1Numeric = New System.Windows.Forms.NumericUpDown()
        Me.sum2Numeric = New System.Windows.Forms.NumericUpDown()
        Me.sum3Numeric = New System.Windows.Forms.NumericUpDown()
        Me.sum4Numeric = New System.Windows.Forms.NumericUpDown()
        Me.sum5Numeric = New System.Windows.Forms.NumericUpDown()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.sum1Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sum2Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sum3Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sum4Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sum5Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time Left:"
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.timerLabel.Font = New System.Drawing.Font("Segoe UI", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.Location = New System.Drawing.Point(337, 43)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(2, 27)
        Me.timerLabel.TabIndex = 1
        '
        'leftAdd1Label
        '
        Me.leftAdd1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.leftAdd1Label.Location = New System.Drawing.Point(93, 108)
        Me.leftAdd1Label.Name = "leftAdd1Label"
        Me.leftAdd1Label.Size = New System.Drawing.Size(68, 36)
        Me.leftAdd1Label.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "="
        '
        'rightAdd1Label
        '
        Me.rightAdd1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rightAdd1Label.Location = New System.Drawing.Point(240, 108)
        Me.rightAdd1Label.Name = "rightAdd1Label"
        Me.rightAdd1Label.Size = New System.Drawing.Size(68, 36)
        Me.rightAdd1Label.TabIndex = 6
        '
        'rightAdd2Label
        '
        Me.rightAdd2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rightAdd2Label.Location = New System.Drawing.Point(240, 176)
        Me.rightAdd2Label.Name = "rightAdd2Label"
        Me.rightAdd2Label.Size = New System.Drawing.Size(68, 36)
        Me.rightAdd2Label.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "+"
        '
        'leftAdd2Label
        '
        Me.leftAdd2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.leftAdd2Label.Location = New System.Drawing.Point(93, 176)
        Me.leftAdd2Label.Name = "leftAdd2Label"
        Me.leftAdd2Label.Size = New System.Drawing.Size(68, 36)
        Me.leftAdd2Label.TabIndex = 7
        '
        'rightAdd3Label
        '
        Me.rightAdd3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rightAdd3Label.Location = New System.Drawing.Point(240, 254)
        Me.rightAdd3Label.Name = "rightAdd3Label"
        Me.rightAdd3Label.Size = New System.Drawing.Size(68, 36)
        Me.rightAdd3Label.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(332, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 25)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(184, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "+"
        '
        'leftAdd3Label
        '
        Me.leftAdd3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.leftAdd3Label.Location = New System.Drawing.Point(93, 254)
        Me.leftAdd3Label.Name = "leftAdd3Label"
        Me.leftAdd3Label.Size = New System.Drawing.Size(68, 36)
        Me.leftAdd3Label.TabIndex = 11
        '
        'rightAdd4Label
        '
        Me.rightAdd4Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rightAdd4Label.Location = New System.Drawing.Point(240, 324)
        Me.rightAdd4Label.Name = "rightAdd4Label"
        Me.rightAdd4Label.Size = New System.Drawing.Size(68, 36)
        Me.rightAdd4Label.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(332, 325)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 25)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "="
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(184, 325)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "+"
        '
        'leftAdd4Label
        '
        Me.leftAdd4Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.leftAdd4Label.Location = New System.Drawing.Point(93, 324)
        Me.leftAdd4Label.Name = "leftAdd4Label"
        Me.leftAdd4Label.Size = New System.Drawing.Size(68, 36)
        Me.leftAdd4Label.TabIndex = 15
        '
        'rightAdd5Label
        '
        Me.rightAdd5Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rightAdd5Label.Location = New System.Drawing.Point(240, 394)
        Me.rightAdd5Label.Name = "rightAdd5Label"
        Me.rightAdd5Label.Size = New System.Drawing.Size(68, 36)
        Me.rightAdd5Label.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(332, 395)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(25, 25)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "="
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(184, 395)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 25)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "+"
        '
        'leftAdd5Label
        '
        Me.leftAdd5Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.leftAdd5Label.Location = New System.Drawing.Point(93, 394)
        Me.leftAdd5Label.Name = "leftAdd5Label"
        Me.leftAdd5Label.Size = New System.Drawing.Size(68, 36)
        Me.leftAdd5Label.TabIndex = 19
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(558, 195)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(187, 58)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "&Begin Quiz"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(558, 283)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(187, 58)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "&Check Answers"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(558, 368)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(187, 58)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 28)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.NewGameToolStripMenuItem.Text = "New &Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToPlayToolStripMenuItem})
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.InstructionsToolStripMenuItem.Text = "I&nstructions"
        '
        'HowToPlayToolStripMenuItem
        '
        Me.HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem"
        Me.HowToPlayToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.HowToPlayToolStripMenuItem.Text = "How to &Play"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(132, 26)
        Me.AboutToolStripMenuItem1.Text = "A&bout"
        '
        'sum1Numeric
        '
        Me.sum1Numeric.Location = New System.Drawing.Point(388, 108)
        Me.sum1Numeric.Name = "sum1Numeric"
        Me.sum1Numeric.Size = New System.Drawing.Size(93, 33)
        Me.sum1Numeric.TabIndex = 1
        '
        'sum2Numeric
        '
        Me.sum2Numeric.Location = New System.Drawing.Point(388, 178)
        Me.sum2Numeric.Name = "sum2Numeric"
        Me.sum2Numeric.Size = New System.Drawing.Size(93, 33)
        Me.sum2Numeric.TabIndex = 2
        '
        'sum3Numeric
        '
        Me.sum3Numeric.Location = New System.Drawing.Point(388, 255)
        Me.sum3Numeric.Name = "sum3Numeric"
        Me.sum3Numeric.Size = New System.Drawing.Size(93, 33)
        Me.sum3Numeric.TabIndex = 3
        '
        'sum4Numeric
        '
        Me.sum4Numeric.Location = New System.Drawing.Point(388, 327)
        Me.sum4Numeric.Name = "sum4Numeric"
        Me.sum4Numeric.Size = New System.Drawing.Size(93, 33)
        Me.sum4Numeric.TabIndex = 4
        '
        'sum5Numeric
        '
        Me.sum5Numeric.Location = New System.Drawing.Point(388, 393)
        Me.sum5Numeric.Name = "sum5Numeric"
        Me.sum5Numeric.Size = New System.Drawing.Size(93, 33)
        Me.sum5Numeric.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(502, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'mainForm
        '
        Me.AcceptButton = Me.startButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(809, 479)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.sum5Numeric)
        Me.Controls.Add(Me.sum4Numeric)
        Me.Controls.Add(Me.sum3Numeric)
        Me.Controls.Add(Me.sum2Numeric)
        Me.Controls.Add(Me.sum1Numeric)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.rightAdd5Label)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.leftAdd5Label)
        Me.Controls.Add(Me.rightAdd4Label)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.leftAdd4Label)
        Me.Controls.Add(Me.rightAdd3Label)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.leftAdd3Label)
        Me.Controls.Add(Me.rightAdd2Label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.leftAdd2Label)
        Me.Controls.Add(Me.rightAdd1Label)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.leftAdd1Label)
        Me.Controls.Add(Me.timerLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addition Math Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.sum1Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sum2Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sum3Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sum4Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sum5Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents timerLabel As Label
    Friend WithEvents leftAdd1Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rightAdd1Label As Label
    Friend WithEvents rightAdd2Label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents leftAdd2Label As Label
    Friend WithEvents rightAdd3Label As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents leftAdd3Label As Label
    Friend WithEvents rightAdd4Label As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents leftAdd4Label As Label
    Friend WithEvents rightAdd5Label As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents leftAdd5Label As Label
    Friend WithEvents startButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToPlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents sum1Numeric As NumericUpDown
    Friend WithEvents sum2Numeric As NumericUpDown
    Friend WithEvents sum3Numeric As NumericUpDown
    Friend WithEvents sum4Numeric As NumericUpDown
    Friend WithEvents sum5Numeric As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
