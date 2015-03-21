<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AppVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnWorkshup = New System.Windows.Forms.Button()
        Me.btnWorkshop = New System.Windows.Forms.PictureBox()
        Me.btnFRPS = New System.Windows.Forms.PictureBox()
        Me.btnSV = New System.Windows.Forms.PictureBox()
        Me.btnCHT = New System.Windows.Forms.PictureBox()
        Me.btnGame = New System.Windows.Forms.PictureBox()
        Me.btnSC = New System.Windows.Forms.PictureBox()
        Me.btnCC = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.btnWorkshop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFRPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCHT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Black
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppVer, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 526)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(507, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 19
        '
        'AppVer
        '
        Me.AppVer.BackColor = System.Drawing.Color.Black
        Me.AppVer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AppVer.Name = "AppVer"
        Me.AppVer.Size = New System.Drawing.Size(63, 17)
        Me.AppVer.Text = "SM64FM ;)"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel1.IsLink = True
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(55, 17)
        Me.ToolStripStatusLabel1.Text = "Donate :)"
        '
        'btnWorkshup
        '
        Me.btnWorkshup.BackColor = System.Drawing.Color.Transparent
        Me.btnWorkshup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWorkshup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWorkshup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWorkshup.Location = New System.Drawing.Point(483, 12)
        Me.btnWorkshup.Name = "btnWorkshup"
        Me.btnWorkshup.Size = New System.Drawing.Size(152, 149)
        Me.btnWorkshup.TabIndex = 4
        Me.btnWorkshup.UseVisualStyleBackColor = False
        '
        'btnWorkshop
        '
        Me.btnWorkshop.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.ADD
        Me.btnWorkshop.Location = New System.Drawing.Point(160, 169)
        Me.btnWorkshop.Name = "btnWorkshop"
        Me.btnWorkshop.Size = New System.Drawing.Size(151, 160)
        Me.btnWorkshop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnWorkshop.TabIndex = 20
        Me.btnWorkshop.TabStop = False
        '
        'btnFRPS
        '
        Me.btnFRPS.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.FR4PS
        Me.btnFRPS.Location = New System.Drawing.Point(160, 3)
        Me.btnFRPS.Name = "btnFRPS"
        Me.btnFRPS.Size = New System.Drawing.Size(151, 160)
        Me.btnFRPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFRPS.TabIndex = 18
        Me.btnFRPS.TabStop = False
        '
        'btnSV
        '
        Me.btnSV.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.Vegas10
        Me.btnSV.Location = New System.Drawing.Point(317, 3)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(151, 160)
        Me.btnSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSV.TabIndex = 18
        Me.btnSV.TabStop = False
        '
        'btnCHT
        '
        Me.btnCHT.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.CHT
        Me.btnCHT.Location = New System.Drawing.Point(317, 169)
        Me.btnCHT.Name = "btnCHT"
        Me.btnCHT.Size = New System.Drawing.Size(151, 160)
        Me.btnCHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCHT.TabIndex = 18
        Me.btnCHT.TabStop = False
        '
        'btnGame
        '
        Me.btnGame.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.PJ6A
        Me.btnGame.Location = New System.Drawing.Point(3, 3)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.Size = New System.Drawing.Size(151, 160)
        Me.btnGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGame.TabIndex = 18
        Me.btnGame.TabStop = False
        '
        'btnSC
        '
        Me.btnSC.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.SC
        Me.btnSC.Location = New System.Drawing.Point(160, 335)
        Me.btnSC.Name = "btnSC"
        Me.btnSC.Size = New System.Drawing.Size(151, 160)
        Me.btnSC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSC.TabIndex = 21
        Me.btnSC.TabStop = False
        '
        'btnCC
        '
        Me.btnCC.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.CC
        Me.btnCC.Location = New System.Drawing.Point(3, 335)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(151, 160)
        Me.btnCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCC.TabIndex = 22
        Me.btnCC.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Super_Mario_64_Filmmaker.My.Resources.Resources.Extras
        Me.PictureBox1.Location = New System.Drawing.Point(3, 169)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGame)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFRPS)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSV)
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnWorkshop)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCHT)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCC)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSC)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(483, 523)
        Me.FlowLayoutPanel1.TabIndex = 24
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 548)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnWorkshup)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Main Menu"
        Me.TransparencyKey = System.Drawing.Color.Blue
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.btnWorkshop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFRPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCHT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWorkshup As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGame As System.Windows.Forms.PictureBox
    Friend WithEvents btnCHT As System.Windows.Forms.PictureBox
    Friend WithEvents btnSV As System.Windows.Forms.PictureBox
    Friend WithEvents btnFRPS As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnWorkshop As System.Windows.Forms.PictureBox
    Friend WithEvents btnSC As System.Windows.Forms.PictureBox
    Friend WithEvents btnCC As System.Windows.Forms.PictureBox
    Friend WithEvents AppVer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

End Class
