<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrat
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
        Me.btnOuvrir = New System.Windows.Forms.Button()
        Me.btnRenouveller = New System.Windows.Forms.Button()
        Me.btnResilier = New System.Windows.Forms.Button()
        Me.btnFacturer = New System.Windows.Forms.Button()
        Me.btnLivrer = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlEcran = New System.Windows.Forms.Panel()
        Me.lblSousTitre = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.lblDescrButtons = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOuvrir
        '
        Me.btnOuvrir.AccessibleDescription = ""
        Me.btnOuvrir.Location = New System.Drawing.Point(12, 71)
        Me.btnOuvrir.Name = "btnOuvrir"
        Me.btnOuvrir.Size = New System.Drawing.Size(75, 33)
        Me.btnOuvrir.TabIndex = 0
        Me.btnOuvrir.Text = "Ouvrir"
        Me.btnOuvrir.UseVisualStyleBackColor = True
        '
        'btnRenouveller
        '
        Me.btnRenouveller.Location = New System.Drawing.Point(12, 115)
        Me.btnRenouveller.Name = "btnRenouveller"
        Me.btnRenouveller.Size = New System.Drawing.Size(75, 33)
        Me.btnRenouveller.TabIndex = 1
        Me.btnRenouveller.Text = "Renouveller"
        Me.btnRenouveller.UseVisualStyleBackColor = True
        '
        'btnResilier
        '
        Me.btnResilier.Location = New System.Drawing.Point(12, 159)
        Me.btnResilier.Name = "btnResilier"
        Me.btnResilier.Size = New System.Drawing.Size(75, 33)
        Me.btnResilier.TabIndex = 2
        Me.btnResilier.Text = "Résilier"
        Me.btnResilier.UseVisualStyleBackColor = True
        '
        'btnFacturer
        '
        Me.btnFacturer.Location = New System.Drawing.Point(12, 247)
        Me.btnFacturer.Name = "btnFacturer"
        Me.btnFacturer.Size = New System.Drawing.Size(75, 33)
        Me.btnFacturer.TabIndex = 3
        Me.btnFacturer.Text = "Facturer"
        Me.btnFacturer.UseVisualStyleBackColor = True
        '
        'btnLivrer
        '
        Me.btnLivrer.Location = New System.Drawing.Point(12, 203)
        Me.btnLivrer.Name = "btnLivrer"
        Me.btnLivrer.Size = New System.Drawing.Size(75, 33)
        Me.btnLivrer.TabIndex = 4
        Me.btnLivrer.Text = "Livrer"
        Me.btnLivrer.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitre.Location = New System.Drawing.Point(12, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(309, 26)
        Me.lblTitre.TabIndex = 5
        Me.lblTitre.Text = "Bienvennue Chez ABONNET"
        '
        'pnlEcran
        '
        Me.pnlEcran.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.pnlEcran.Location = New System.Drawing.Point(93, 71)
        Me.pnlEcran.Name = "pnlEcran"
        Me.pnlEcran.Size = New System.Drawing.Size(496, 209)
        Me.pnlEcran.TabIndex = 6
        '
        'lblSousTitre
        '
        Me.lblSousTitre.AutoSize = True
        Me.lblSousTitre.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSousTitre.Location = New System.Drawing.Point(400, 44)
        Me.lblSousTitre.Name = "lblSousTitre"
        Me.lblSousTitre.Size = New System.Drawing.Size(169, 24)
        Me.lblSousTitre.TabIndex = 7
        Me.lblSousTitre.Text = "Contrats Annuelle"
        '
        'lblDescr
        '
        Me.lblDescr.AutoSize = True
        Me.lblDescr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescr.Location = New System.Drawing.Point(8, 305)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(117, 22)
        Me.lblDescr.TabIndex = 8
        Me.lblDescr.Text = "Descriptions:"
        '
        'lblDescrButtons
        '
        Me.lblDescrButtons.AutoSize = True
        Me.lblDescrButtons.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrButtons.Location = New System.Drawing.Point(137, 306)
        Me.lblDescrButtons.Name = "lblDescrButtons"
        Me.lblDescrButtons.Size = New System.Drawing.Size(0, 21)
        Me.lblDescrButtons.TabIndex = 9
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(494, 351)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 10
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'frmContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 401)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblDescrButtons)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.lblSousTitre)
        Me.Controls.Add(Me.pnlEcran)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnLivrer)
        Me.Controls.Add(Me.btnFacturer)
        Me.Controls.Add(Me.btnResilier)
        Me.Controls.Add(Me.btnRenouveller)
        Me.Controls.Add(Me.btnOuvrir)
        Me.Name = "frmContrat"
        Me.Text = "ABONET -Contrat-"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOuvrir As System.Windows.Forms.Button
    Friend WithEvents btnRenouveller As System.Windows.Forms.Button
    Friend WithEvents btnResilier As System.Windows.Forms.Button
    Friend WithEvents btnFacturer As System.Windows.Forms.Button
    Friend WithEvents btnLivrer As System.Windows.Forms.Button
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents pnlEcran As System.Windows.Forms.Panel
    Friend WithEvents lblSousTitre As System.Windows.Forms.Label
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    Friend WithEvents lblDescrButtons As System.Windows.Forms.Label
    Friend WithEvents btnQuitter As System.Windows.Forms.Button

End Class
