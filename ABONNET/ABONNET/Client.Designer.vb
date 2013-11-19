<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregisterSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToutSélectionnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToutEffacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblMontant = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtMontant = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.cmbServices = New System.Windows.Forms.ComboBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ÉditerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(480, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.EnregistrerToolStripMenuItem, Me.EnregisterSousToolStripMenuItem, Me.ToolStripMenuItem1, Me.FermerToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EnregistrerToolStripMenuItem.Text = "&Enregistrer"
        '
        'EnregisterSousToolStripMenuItem
        '
        Me.EnregisterSousToolStripMenuItem.Name = "EnregisterSousToolStripMenuItem"
        Me.EnregisterSousToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EnregisterSousToolStripMenuItem.Text = "Enregister-&Sous"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 6)
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.FermerToolStripMenuItem.Text = "&Fermer"
        '
        'ÉditerToolStripMenuItem
        '
        Me.ÉditerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToutSélectionnerToolStripMenuItem, Me.ToutEffacerToolStripMenuItem})
        Me.ÉditerToolStripMenuItem.Name = "ÉditerToolStripMenuItem"
        Me.ÉditerToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ÉditerToolStripMenuItem.Text = "Édit&er"
        '
        'ToutSélectionnerToolStripMenuItem
        '
        Me.ToutSélectionnerToolStripMenuItem.Name = "ToutSélectionnerToolStripMenuItem"
        Me.ToutSélectionnerToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ToutSélectionnerToolStripMenuItem.Text = "Tout &Sélectionner"
        '
        'ToutEffacerToolStripMenuItem
        '
        Me.ToutEffacerToolStripMenuItem.Name = "ToutEffacerToolStripMenuItem"
        Me.ToutEffacerToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ToutEffacerToolStripMenuItem.Text = "Tout &Effacer"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.Location = New System.Drawing.Point(162, 34)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(153, 21)
        Me.lblClient.TabIndex = 1
        Me.lblClient.Text = "Information Clients"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(12, 70)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(32, 13)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(12, 97)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(46, 13)
        Me.lblPrenom.TabIndex = 3
        Me.lblPrenom.Text = "Prenom:"
        '
        'lblMontant
        '
        Me.lblMontant.AutoSize = True
        Me.lblMontant.Location = New System.Drawing.Point(12, 124)
        Me.lblMontant.Name = "lblMontant"
        Me.lblMontant.Size = New System.Drawing.Size(49, 13)
        Me.lblMontant.TabIndex = 4
        Me.lblMontant.Text = "Montant:"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(238, 124)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(46, 13)
        Me.lblService.TabIndex = 5
        Me.lblService.Text = "Service:"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(98, 70)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 6
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(98, 97)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 7
        '
        'txtMontant
        '
        Me.txtMontant.Location = New System.Drawing.Point(98, 124)
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.Size = New System.Drawing.Size(100, 20)
        Me.txtMontant.TabIndex = 8
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(239, 70)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(48, 13)
        Me.lblAdresse.TabIndex = 10
        Me.lblAdresse.Text = "Adresse:"
        '
        'cmbServices
        '
        Me.cmbServices.FormattingEnabled = True
        Me.cmbServices.Location = New System.Drawing.Point(302, 124)
        Me.cmbServices.Name = "cmbServices"
        Me.cmbServices.Size = New System.Drawing.Size(165, 21)
        Me.cmbServices.TabIndex = 11
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(303, 70)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(165, 20)
        Me.txtAdresse.TabIndex = 12
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 171)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.cmbServices)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.txtMontant)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblMontant)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClient"
        Me.Text = "ABONET -Client-"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregisterSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÉditerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToutSélectionnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToutEffacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents lblMontant As System.Windows.Forms.Label
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtMontant As System.Windows.Forms.TextBox
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents cmbServices As System.Windows.Forms.ComboBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
End Class
