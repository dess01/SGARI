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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlEcran = New System.Windows.Forms.Panel()
        Me.lblDescrButtons = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenouvelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RésilierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉquipementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FournisseursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitre.Location = New System.Drawing.Point(7, 33)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(296, 26)
        Me.lblTitre.TabIndex = 5
        Me.lblTitre.Text = "Bienvenue Chez ABONNET"
        '
        'pnlEcran
        '
        Me.pnlEcran.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.pnlEcran.Location = New System.Drawing.Point(12, 71)
        Me.pnlEcran.Name = "pnlEcran"
        Me.pnlEcran.Size = New System.Drawing.Size(587, 431)
        Me.pnlEcran.TabIndex = 6
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratToolStripMenuItem, Me.ClientsToolStripMenuItem, Me.ÉquipementToolStripMenuItem, Me.ServicesToolStripMenuItem, Me.FacturesToolStripMenuItem, Me.FournisseursToolStripMenuItem, Me.RapportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContratToolStripMenuItem
        '
        Me.ContratToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréationToolStripMenuItem, Me.RenouvelerToolStripMenuItem, Me.RésilierToolStripMenuItem, Me.ModificationToolStripMenuItem})
        Me.ContratToolStripMenuItem.Name = "ContratToolStripMenuItem"
        Me.ContratToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ContratToolStripMenuItem.Text = "&Contrats"
        '
        'CréationToolStripMenuItem
        '
        Me.CréationToolStripMenuItem.Name = "CréationToolStripMenuItem"
        Me.CréationToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CréationToolStripMenuItem.Text = "&Création"
        '
        'RenouvelerToolStripMenuItem
        '
        Me.RenouvelerToolStripMenuItem.Name = "RenouvelerToolStripMenuItem"
        Me.RenouvelerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RenouvelerToolStripMenuItem.Text = "R&enouveler"
        '
        'RésilierToolStripMenuItem
        '
        Me.RésilierToolStripMenuItem.Name = "RésilierToolStripMenuItem"
        Me.RésilierToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RésilierToolStripMenuItem.Text = "&Résilier"
        '
        'ModificationToolStripMenuItem
        '
        Me.ModificationToolStripMenuItem.Name = "ModificationToolStripMenuItem"
        Me.ModificationToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ModificationToolStripMenuItem.Text = "&Modification"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem})
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ClientsToolStripMenuItem.Text = "C&lients"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'ÉquipementToolStripMenuItem
        '
        Me.ÉquipementToolStripMenuItem.Name = "ÉquipementToolStripMenuItem"
        Me.ÉquipementToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ÉquipementToolStripMenuItem.Text = "É&quipement"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ServicesToolStripMenuItem.Text = "&Services"
        '
        'FacturesToolStripMenuItem
        '
        Me.FacturesToolStripMenuItem.Name = "FacturesToolStripMenuItem"
        Me.FacturesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.FacturesToolStripMenuItem.Text = "F&acturation"
        '
        'FournisseursToolStripMenuItem
        '
        Me.FournisseursToolStripMenuItem.Name = "FournisseursToolStripMenuItem"
        Me.FournisseursToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.FournisseursToolStripMenuItem.Text = "&Fournisseurs"
        '
        'RapportsToolStripMenuItem
        '
        Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RapportsToolStripMenuItem.Text = "&Rapports"
        '
        'frmContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 514)
        Me.Controls.Add(Me.lblDescrButtons)
        Me.Controls.Add(Me.pnlEcran)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmContrat"
        Me.Text = "SGARI :: ABONNET"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents pnlEcran As System.Windows.Forms.Panel
    Friend WithEvents lblDescrButtons As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ContratToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CréationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenouvelerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RésilierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FournisseursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÉquipementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
