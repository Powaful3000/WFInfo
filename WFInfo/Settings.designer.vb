﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.btnHkey1 = New System.Windows.Forms.Button()
        Me.lbKey = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCommands = New System.Windows.Forms.CheckBox()
        Me.cbFullscreen = New System.Windows.Forms.CheckBox()
        Me.cbAnimations = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHkey2 = New System.Windows.Forms.Button()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbDebug = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHkey1
        '
        Me.btnHkey1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnHkey1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHkey1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnHkey1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnHkey1.Location = New System.Drawing.Point(13, 34)
        Me.btnHkey1.Name = "btnHkey1"
        Me.btnHkey1.Size = New System.Drawing.Size(139, 24)
        Me.btnHkey1.TabIndex = 14
        Me.btnHkey1.Text = "Print Screen"
        Me.btnHkey1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHkey1.UseVisualStyleBackColor = False
        '
        'lbKey
        '
        Me.lbKey.AutoSize = True
        Me.lbKey.BackColor = System.Drawing.Color.Transparent
        Me.lbKey.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbKey.Location = New System.Drawing.Point(26, 12)
        Me.lbKey.Name = "lbKey"
        Me.lbKey.Size = New System.Drawing.Size(116, 18)
        Me.lbKey.TabIndex = 15
        Me.lbKey.Text = "Activation Key"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(185, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Command Key"
        '
        'cbCommands
        '
        Me.cbCommands.AutoSize = True
        Me.cbCommands.BackColor = System.Drawing.Color.Transparent
        Me.cbCommands.Checked = True
        Me.cbCommands.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCommands.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCommands.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbCommands.Location = New System.Drawing.Point(14, 121)
        Me.cbCommands.Name = "cbCommands"
        Me.cbCommands.Size = New System.Drawing.Size(129, 17)
        Me.cbCommands.TabIndex = 17
        Me.cbCommands.Text = "Enable Commands"
        Me.cbCommands.UseVisualStyleBackColor = False
        '
        'cbFullscreen
        '
        Me.cbFullscreen.AutoSize = True
        Me.cbFullscreen.BackColor = System.Drawing.Color.Transparent
        Me.cbFullscreen.Enabled = False
        Me.cbFullscreen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFullscreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbFullscreen.Location = New System.Drawing.Point(187, 121)
        Me.cbFullscreen.Name = "cbFullscreen"
        Me.cbFullscreen.Size = New System.Drawing.Size(117, 17)
        Me.cbFullscreen.TabIndex = 18
        Me.cbFullscreen.Text = "Fullscreen Mode"
        Me.cbFullscreen.UseVisualStyleBackColor = False
        '
        'cbAnimations
        '
        Me.cbAnimations.AutoSize = True
        Me.cbAnimations.BackColor = System.Drawing.Color.Transparent
        Me.cbAnimations.Checked = True
        Me.cbAnimations.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAnimations.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnimations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbAnimations.Location = New System.Drawing.Point(14, 144)
        Me.cbAnimations.Name = "cbAnimations"
        Me.cbAnimations.Size = New System.Drawing.Size(90, 17)
        Me.cbAnimations.TabIndex = 20
        Me.cbAnimations.Text = "Animations"
        Me.cbAnimations.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbKey)
        Me.Panel1.Controls.Add(Me.btnHkey2)
        Me.Panel1.Controls.Add(Me.btnHkey1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 71)
        Me.Panel1.TabIndex = 21
        '
        'btnHkey2
        '
        Me.btnHkey2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnHkey2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHkey2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnHkey2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnHkey2.Location = New System.Drawing.Point(174, 33)
        Me.btnHkey2.Name = "btnHkey2"
        Me.btnHkey2.Size = New System.Drawing.Size(129, 24)
        Me.btnHkey2.TabIndex = 13
        Me.btnHkey2.Text = "Insert"
        Me.btnHkey2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHkey2.UseVisualStyleBackColor = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbTitle.Location = New System.Drawing.Point(32, 4)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(63, 17)
        Me.lbTitle.TabIndex = 17
        Me.lbTitle.Text = "Settings"
        '
        'pTitle
        '
        Me.pTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitle.Controls.Add(Me.PictureBox3)
        Me.pTitle.Controls.Add(Me.lbTitle)
        Me.pTitle.Controls.Add(Me.btnClose)
        Me.pTitle.Location = New System.Drawing.Point(1, 1)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(319, 27)
        Me.pTitle.TabIndex = 22
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WFInfo.My.Resources.Resources.WFLogo
        Me.PictureBox3.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(290, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 32)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "x"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cbDebug)
        Me.Panel2.Location = New System.Drawing.Point(1, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 74)
        Me.Panel2.TabIndex = 22
        '
        'cbDebug
        '
        Me.cbDebug.AutoSize = True
        Me.cbDebug.BackColor = System.Drawing.Color.Transparent
        Me.cbDebug.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbDebug.Location = New System.Drawing.Point(185, 45)
        Me.cbDebug.Name = "cbDebug"
        Me.cbDebug.Size = New System.Drawing.Size(96, 17)
        Me.cbDebug.TabIndex = 23
        Me.cbDebug.Text = "Debug Mode"
        Me.cbDebug.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 173)
        Me.Controls.Add(Me.cbFullscreen)
        Me.Controls.Add(Me.cbAnimations)
        Me.Controls.Add(Me.cbCommands)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pTitle)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "WFInfo  v2.0.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pTitle.ResumeLayout(False)
        Me.pTitle.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHkey1 As Button
    Friend WithEvents lbKey As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCommands As CheckBox
    Friend WithEvents cbFullscreen As CheckBox
    Friend WithEvents cbAnimations As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbTitle As Label
    Friend WithEvents pTitle As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbDebug As CheckBox
    Friend WithEvents btnHkey2 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class