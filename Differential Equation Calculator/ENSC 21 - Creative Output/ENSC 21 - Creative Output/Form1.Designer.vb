<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.pnlinput = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrhs = New System.Windows.Forms.TextBox()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlsoln = New System.Windows.Forms.Panel()
        Me.txtsoln = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.pnlinput.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlsoln.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Californian FB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(237, 226)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 33)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'pnlinput
        '
        Me.pnlinput.Controls.Add(Me.Label5)
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.txtc)
        Me.pnlinput.Controls.Add(Me.txtb)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.txtrhs)
        Me.pnlinput.Controls.Add(Me.txta)
        Me.pnlinput.Controls.Add(Me.Label)
        Me.pnlinput.Controls.Add(Me.Label1)
        Me.pnlinput.Controls.Add(Me.Label4)
        Me.pnlinput.Location = New System.Drawing.Point(56, 95)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(470, 112)
        Me.pnlinput.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Californian FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 27)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Californian FB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Left Hand Side"
        '
        'txtc
        '
        Me.txtc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtc.Location = New System.Drawing.Point(207, 57)
        Me.txtc.Multiline = True
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(41, 24)
        Me.txtc.TabIndex = 4
        '
        'txtb
        '
        Me.txtb.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb.Location = New System.Drawing.Point(121, 57)
        Me.txtb.Multiline = True
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(41, 24)
        Me.txtb.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Californian FB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "y"
        '
        'txtrhs
        '
        Me.txtrhs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtrhs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrhs.Location = New System.Drawing.Point(318, 57)
        Me.txtrhs.Multiline = True
        Me.txtrhs.Name = "txtrhs"
        Me.txtrhs.Size = New System.Drawing.Size(113, 24)
        Me.txtrhs.TabIndex = 10
        '
        'txta
        '
        Me.txta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txta.Location = New System.Drawing.Point(32, 57)
        Me.txta.Multiline = True
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(41, 24)
        Me.txta.TabIndex = 0
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Californian FB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(81, 60)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(23, 19)
        Me.Label.TabIndex = 69
        Me.Label.Text = "y''"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Right Hand Side"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Californian FB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "y'"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Californian FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(477, 29)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Second-Order Differential Equation Solver "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(590, 30)
        Me.MenuStrip1.TabIndex = 78
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Californian FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(124, 26)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(124, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Californian FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'pnlsoln
        '
        Me.pnlsoln.Controls.Add(Me.txtsoln)
        Me.pnlsoln.Controls.Add(Me.Label11)
        Me.pnlsoln.Location = New System.Drawing.Point(56, 278)
        Me.pnlsoln.Name = "pnlsoln"
        Me.pnlsoln.Size = New System.Drawing.Size(470, 112)
        Me.pnlsoln.TabIndex = 76
        '
        'txtsoln
        '
        Me.txtsoln.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtsoln.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsoln.Location = New System.Drawing.Point(32, 37)
        Me.txtsoln.Multiline = True
        Me.txtsoln.Name = "txtsoln"
        Me.txtsoln.Size = New System.Drawing.Size(399, 60)
        Me.txtsoln.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Californian FB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(189, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "General Solution"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Californian FB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(237, 407)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(111, 33)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(590, 455)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.pnlsoln)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.pnlinput)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Second-Order Differential Equation Solver "
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlsoln.ResumeLayout(False)
        Me.pnlsoln.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents pnlinput As Panel
    Friend WithEvents txtrhs As TextBox
    Friend WithEvents txta As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents txtc As TextBox
    Friend WithEvents txtb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlsoln As Panel
    Friend WithEvents txtsoln As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnReset As Button
End Class
