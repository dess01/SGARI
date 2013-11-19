<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLigneFacture
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
        Me.lstTransaction = New System.Windows.Forms.ListBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.gbFactureClients = New System.Windows.Forms.GroupBox()
        Me.lstFormulaire = New System.Windows.Forms.ListBox()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.gbFactureClients.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTransaction
        '
        Me.lstTransaction.BackColor = System.Drawing.SystemColors.Info
        Me.lstTransaction.FormattingEnabled = True
        Me.lstTransaction.Location = New System.Drawing.Point(85, 69)
        Me.lstTransaction.Name = "lstTransaction"
        Me.lstTransaction.Size = New System.Drawing.Size(614, 173)
        Me.lstTransaction.TabIndex = 0
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTransaction.Location = New System.Drawing.Point(286, 23)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(192, 21)
        Me.lblTransaction.TabIndex = 1
        Me.lblTransaction.Text = "Transactions des Clients"
        '
        'gbFactureClients
        '
        Me.gbFactureClients.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbFactureClients.Controls.Add(Me.lstFormulaire)
        Me.gbFactureClients.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFactureClients.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.gbFactureClients.Location = New System.Drawing.Point(85, 281)
        Me.gbFactureClients.Name = "gbFactureClients"
        Me.gbFactureClients.Size = New System.Drawing.Size(614, 156)
        Me.gbFactureClients.TabIndex = 2
        Me.gbFactureClients.TabStop = False
        Me.gbFactureClients.Text = "Facture du Client"
        '
        'lstFormulaire
        '
        Me.lstFormulaire.FormattingEnabled = True
        Me.lstFormulaire.ItemHeight = 19
        Me.lstFormulaire.Location = New System.Drawing.Point(22, 19)
        Me.lstFormulaire.Name = "lstFormulaire"
        Me.lstFormulaire.Size = New System.Drawing.Size(576, 118)
        Me.lstFormulaire.TabIndex = 0
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(583, 471)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(75, 23)
        Me.btnFermer.TabIndex = 3
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'frmLigneFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 514)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.gbFactureClients)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.lstTransaction)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Name = "frmLigneFacture"
        Me.Text = "LigneFacture"
        Me.gbFactureClients.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTransaction As System.Windows.Forms.ListBox
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents gbFactureClients As System.Windows.Forms.GroupBox
    Friend WithEvents lstFormulaire As System.Windows.Forms.ListBox
    Friend WithEvents btnFermer As System.Windows.Forms.Button
End Class
