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
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.input_nom = New System.Windows.Forms.TextBox()
        Me.input_prenom = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.input_adresse = New System.Windows.Forms.TextBox()
        Me.codePostal_lbl = New System.Windows.Forms.Label()
        Me.input_codePostal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input_telephone = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.Location = New System.Drawing.Point(179, 9)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(118, 21)
        Me.lblClient.TabIndex = 1
        Me.lblClient.Text = "Ajout de client"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(12, 47)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(32, 13)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(12, 74)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(46, 13)
        Me.lblPrenom.TabIndex = 3
        Me.lblPrenom.Text = "Prenom:"
        '
        'input_nom
        '
        Me.input_nom.Location = New System.Drawing.Point(76, 47)
        Me.input_nom.Name = "input_nom"
        Me.input_nom.Size = New System.Drawing.Size(122, 20)
        Me.input_nom.TabIndex = 6
        '
        'input_prenom
        '
        Me.input_prenom.Location = New System.Drawing.Point(76, 74)
        Me.input_prenom.Name = "input_prenom"
        Me.input_prenom.Size = New System.Drawing.Size(122, 20)
        Me.input_prenom.TabIndex = 7
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(241, 47)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(48, 13)
        Me.lblAdresse.TabIndex = 10
        Me.lblAdresse.Text = "Adresse:"
        '
        'input_adresse
        '
        Me.input_adresse.Location = New System.Drawing.Point(303, 47)
        Me.input_adresse.Name = "input_adresse"
        Me.input_adresse.Size = New System.Drawing.Size(165, 20)
        Me.input_adresse.TabIndex = 12
        '
        'codePostal_lbl
        '
        Me.codePostal_lbl.AutoSize = True
        Me.codePostal_lbl.Location = New System.Drawing.Point(223, 78)
        Me.codePostal_lbl.Name = "codePostal_lbl"
        Me.codePostal_lbl.Size = New System.Drawing.Size(66, 13)
        Me.codePostal_lbl.TabIndex = 10
        Me.codePostal_lbl.Text = "Code postal:"
        Me.codePostal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'input_codePostal
        '
        Me.input_codePostal.Location = New System.Drawing.Point(303, 78)
        Me.input_codePostal.Name = "input_codePostal"
        Me.input_codePostal.Size = New System.Drawing.Size(165, 20)
        Me.input_codePostal.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Sauvegarder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Téléphone:"
        '
        'input_telephone
        '
        Me.input_telephone.Location = New System.Drawing.Point(76, 102)
        Me.input_telephone.Name = "input_telephone"
        Me.input_telephone.Size = New System.Drawing.Size(122, 20)
        Me.input_telephone.TabIndex = 7
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 171)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.input_codePostal)
        Me.Controls.Add(Me.codePostal_lbl)
        Me.Controls.Add(Me.input_adresse)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.input_telephone)
        Me.Controls.Add(Me.input_prenom)
        Me.Controls.Add(Me.input_nom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClient"
        Me.Text = "ABONET -Client-"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents input_nom As System.Windows.Forms.TextBox
    Friend WithEvents input_prenom As System.Windows.Forms.TextBox
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents input_adresse As System.Windows.Forms.TextBox
    Friend WithEvents codePostal_lbl As System.Windows.Forms.Label
    Friend WithEvents input_codePostal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input_telephone As System.Windows.Forms.TextBox
End Class
