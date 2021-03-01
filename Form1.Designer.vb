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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_gerar = New System.Windows.Forms.Button
        Me.texto1 = New System.Windows.Forms.RichTextBox
        Me.texto2 = New System.Windows.Forms.RichTextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_decriptografar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModoDeUsarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btn_ajuda_chave = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_gerar
        '
        Me.btn_gerar.Location = New System.Drawing.Point(207, 353)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(119, 23)
        Me.btn_gerar.TabIndex = 2
        Me.btn_gerar.Text = "CRIPTOGRAFAR"
        Me.btn_gerar.UseVisualStyleBackColor = True
        '
        'texto1
        '
        Me.texto1.Location = New System.Drawing.Point(1, 41)
        Me.texto1.Name = "texto1"
        Me.texto1.RightMargin = 310
        Me.texto1.Size = New System.Drawing.Size(325, 280)
        Me.texto1.TabIndex = 1
        Me.texto1.Text = ""
        '
        'texto2
        '
        Me.texto2.Location = New System.Drawing.Point(332, 41)
        Me.texto2.Name = "texto2"
        Me.texto2.RightMargin = 310
        Me.texto2.Size = New System.Drawing.Size(325, 280)
        Me.texto2.TabIndex = 3
        Me.texto2.Text = ""
        Me.texto2.WordWrap = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(222, 327)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Chave:"
        '
        'btn_decriptografar
        '
        Me.btn_decriptografar.Location = New System.Drawing.Point(332, 353)
        Me.btn_decriptografar.Name = "btn_decriptografar"
        Me.btn_decriptografar.Size = New System.Drawing.Size(119, 23)
        Me.btn_decriptografar.TabIndex = 4
        Me.btn_decriptografar.Text = "DECRIPTOGRAFAR"
        Me.btn_decriptografar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Codificação Enigma"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem, Me.ModoDeUsarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(659, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'ModoDeUsarToolStripMenuItem
        '
        Me.ModoDeUsarToolStripMenuItem.Name = "ModoDeUsarToolStripMenuItem"
        Me.ModoDeUsarToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ModoDeUsarToolStripMenuItem.Text = "Modo de usar"
        '
        'btn_ajuda_chave
        '
        Me.btn_ajuda_chave.Location = New System.Drawing.Point(439, 326)
        Me.btn_ajuda_chave.Name = "btn_ajuda_chave"
        Me.btn_ajuda_chave.Size = New System.Drawing.Size(25, 23)
        Me.btn_ajuda_chave.TabIndex = 8
        Me.btn_ajuda_chave.Text = "?"
        Me.btn_ajuda_chave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 381)
        Me.Controls.Add(Me.btn_ajuda_chave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_decriptografar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.texto2)
        Me.Controls.Add(Me.texto1)
        Me.Controls.Add(Me.btn_gerar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Enigma LITE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_gerar As System.Windows.Forms.Button
    Friend WithEvents texto1 As System.Windows.Forms.RichTextBox
    Friend WithEvents texto2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_decriptografar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoDeUsarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_ajuda_chave As System.Windows.Forms.Button

End Class
