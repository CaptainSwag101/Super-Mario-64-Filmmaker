<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cheatModeSel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cheatModeSel))
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.optionsStrip = New System.Windows.Forms.ToolStrip
        Me.closeStripButton = New System.Windows.Forms.ToolStripButton
        Me.optionsStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = My.Resources.CHT
        Me.Button3.Location = New System.Drawing.Point(68, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 157)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = My.Resources.CHT
        Me.Button1.Location = New System.Drawing.Point(231, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 157)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cheatModeSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(451, 273)
        Me.Controls.Add(Me.optionsStrip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cheatModeSel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select What to do..."
        Me.optionsStrip.ResumeLayout(False)
        Me.optionsStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents optionsStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents closeStripButton As System.Windows.Forms.ToolStripButton
End Class
