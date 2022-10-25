<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gioco
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Giocatore1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TEST = New System.Windows.Forms.Label()
        Me.TEST2 = New System.Windows.Forms.Label()
        CType(Me.Giocatore1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Giocatore1
        '
        Me.Giocatore1.BackColor = System.Drawing.Color.Transparent
        Me.Giocatore1.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.oca3
        Me.Giocatore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Giocatore1.Location = New System.Drawing.Point(63, 732)
        Me.Giocatore1.Name = "Giocatore1"
        Me.Giocatore1.Size = New System.Drawing.Size(63, 61)
        Me.Giocatore1.TabIndex = 0
        Me.Giocatore1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(228, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 90)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tira Il Dado"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TEST
        '
        Me.TEST.AutoSize = True
        Me.TEST.Location = New System.Drawing.Point(253, 271)
        Me.TEST.Name = "TEST"
        Me.TEST.Size = New System.Drawing.Size(53, 20)
        Me.TEST.TabIndex = 2
        Me.TEST.Text = "Label1"
        '
        'TEST2
        '
        Me.TEST2.AutoSize = True
        Me.TEST2.Location = New System.Drawing.Point(253, 315)
        Me.TEST2.Name = "TEST2"
        Me.TEST2.Size = New System.Drawing.Size(53, 20)
        Me.TEST2.TabIndex = 3
        Me.TEST2.Text = "Label1"
        '
        'Gioco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gioco_Oca.My.Resources.Resources.tabbella
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 836)
        Me.Controls.Add(Me.TEST2)
        Me.Controls.Add(Me.TEST)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Giocatore1)
        Me.DoubleBuffered = True
        Me.Name = "Gioco"
        Me.Text = "Gioco"
        CType(Me.Giocatore1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Giocatore1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TEST As Label
    Friend WithEvents TEST2 As Label
End Class
