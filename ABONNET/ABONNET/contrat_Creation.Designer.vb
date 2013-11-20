<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contrat_Creation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.noClient = New System.Windows.Forms.ComboBox()
        Me.input_prenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.input_nom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.input_adresse = New System.Windows.Forms.TextBox()
        Me.input_ville = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.input_province = New System.Windows.Forms.TextBox()
        Me.input_codePostal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.input_courriel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.input_telephone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.sep_1 = New System.Windows.Forms.Label()
        Me.input_Employe = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.sep_2 = New System.Windows.Forms.Label()
        Me.input_dateDebut = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.input_dateFin = New System.Windows.Forms.DateTimePicker()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Création de contrat"
        '
        'pnl_main
        '
        Me.pnl_main.AutoScroll = True
        Me.pnl_main.Controls.Add(Me.input_dateFin)
        Me.pnl_main.Controls.Add(Me.input_dateDebut)
        Me.pnl_main.Controls.Add(Me.sep_2)
        Me.pnl_main.Controls.Add(Me.sep_1)
        Me.pnl_main.Controls.Add(Me.Label12)
        Me.pnl_main.Controls.Add(Me.Label8)
        Me.pnl_main.Controls.Add(Me.Label13)
        Me.pnl_main.Controls.Add(Me.Label6)
        Me.pnl_main.Controls.Add(Me.Label11)
        Me.pnl_main.Controls.Add(Me.Label10)
        Me.pnl_main.Controls.Add(Me.Label9)
        Me.pnl_main.Controls.Add(Me.Label4)
        Me.pnl_main.Controls.Add(Me.Label7)
        Me.pnl_main.Controls.Add(Me.Label5)
        Me.pnl_main.Controls.Add(Me.Label3)
        Me.pnl_main.Controls.Add(Me.input_Employe)
        Me.pnl_main.Controls.Add(Me.input_codePostal)
        Me.pnl_main.Controls.Add(Me.input_ville)
        Me.pnl_main.Controls.Add(Me.input_province)
        Me.pnl_main.Controls.Add(Me.input_telephone)
        Me.pnl_main.Controls.Add(Me.input_courriel)
        Me.pnl_main.Controls.Add(Me.input_nom)
        Me.pnl_main.Controls.Add(Me.input_adresse)
        Me.pnl_main.Controls.Add(Me.input_prenom)
        Me.pnl_main.Location = New System.Drawing.Point(12, 72)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(563, 347)
        Me.pnl_main.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client existant:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'noClient
        '
        Me.noClient.FormattingEnabled = True
        Me.noClient.Location = New System.Drawing.Point(110, 45)
        Me.noClient.Name = "noClient"
        Me.noClient.Size = New System.Drawing.Size(212, 21)
        Me.noClient.TabIndex = 1
        '
        'input_prenom
        '
        Me.input_prenom.Location = New System.Drawing.Point(98, 9)
        Me.input_prenom.Name = "input_prenom"
        Me.input_prenom.Size = New System.Drawing.Size(178, 20)
        Me.input_prenom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prénom:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'input_nom
        '
        Me.input_nom.Location = New System.Drawing.Point(98, 35)
        Me.input_nom.Name = "input_nom"
        Me.input_nom.Size = New System.Drawing.Size(178, 20)
        Me.input_nom.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nom:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'input_adresse
        '
        Me.input_adresse.Location = New System.Drawing.Point(382, 9)
        Me.input_adresse.Name = "input_adresse"
        Me.input_adresse.Size = New System.Drawing.Size(178, 20)
        Me.input_adresse.TabIndex = 1
        '
        'input_ville
        '
        Me.input_ville.Location = New System.Drawing.Point(382, 35)
        Me.input_ville.Name = "input_ville"
        Me.input_ville.Size = New System.Drawing.Size(178, 20)
        Me.input_ville.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(287, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Adresse:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(287, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Ville:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'input_province
        '
        Me.input_province.Location = New System.Drawing.Point(382, 60)
        Me.input_province.Name = "input_province"
        Me.input_province.Size = New System.Drawing.Size(178, 20)
        Me.input_province.TabIndex = 1
        '
        'input_codePostal
        '
        Me.input_codePostal.Location = New System.Drawing.Point(382, 86)
        Me.input_codePostal.Name = "input_codePostal"
        Me.input_codePostal.Size = New System.Drawing.Size(178, 20)
        Me.input_codePostal.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(287, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Province:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(287, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Code postal:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'input_courriel
        '
        Me.input_courriel.Location = New System.Drawing.Point(98, 60)
        Me.input_courriel.Name = "input_courriel"
        Me.input_courriel.Size = New System.Drawing.Size(178, 20)
        Me.input_courriel.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Courriel:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'input_telephone
        '
        Me.input_telephone.Location = New System.Drawing.Point(98, 86)
        Me.input_telephone.Name = "input_telephone"
        Me.input_telephone.Size = New System.Drawing.Size(178, 20)
        Me.input_telephone.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(3, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Téléphone:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sep_1
        '
        Me.sep_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sep_1.Location = New System.Drawing.Point(6, 117)
        Me.sep_1.Name = "sep_1"
        Me.sep_1.Size = New System.Drawing.Size(554, 2)
        Me.sep_1.TabIndex = 3
        '
        'input_Employe
        '
        Me.input_Employe.Location = New System.Drawing.Point(382, 129)
        Me.input_Employe.Name = "input_Employe"
        Me.input_Employe.Size = New System.Drawing.Size(178, 20)
        Me.input_Employe.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(287, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Employé:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sep_2
        '
        Me.sep_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sep_2.Location = New System.Drawing.Point(3, 158)
        Me.sep_2.Name = "sep_2"
        Me.sep_2.Size = New System.Drawing.Size(554, 2)
        Me.sep_2.TabIndex = 3
        '
        'input_dateDebut
        '
        Me.input_dateDebut.Location = New System.Drawing.Point(98, 182)
        Me.input_dateDebut.Name = "input_dateDebut"
        Me.input_dateDebut.Size = New System.Drawing.Size(200, 20)
        Me.input_dateDebut.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(3, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Date en vigueur:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(3, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Date d'expiration:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'input_dateFin
        '
        Me.input_dateFin.Location = New System.Drawing.Point(98, 208)
        Me.input_dateFin.Name = "input_dateFin"
        Me.input_dateFin.Size = New System.Drawing.Size(200, 20)
        Me.input_dateFin.TabIndex = 4
        '
        'contrat_Creation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 431)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.noClient)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "contrat_Creation"
        Me.Text = "contrat_Creation"
        Me.pnl_main.ResumeLayout(False)
        Me.pnl_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl_main As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents noClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents input_codePostal As System.Windows.Forms.TextBox
    Friend WithEvents input_ville As System.Windows.Forms.TextBox
    Friend WithEvents input_province As System.Windows.Forms.TextBox
    Friend WithEvents input_courriel As System.Windows.Forms.TextBox
    Friend WithEvents input_nom As System.Windows.Forms.TextBox
    Friend WithEvents input_adresse As System.Windows.Forms.TextBox
    Friend WithEvents input_prenom As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents input_telephone As System.Windows.Forms.TextBox
    Friend WithEvents sep_1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents input_Employe As System.Windows.Forms.TextBox
    Friend WithEvents sep_2 As System.Windows.Forms.Label
    Friend WithEvents input_dateDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents input_dateFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
