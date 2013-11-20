Public Class frmContrat
    Private Sub btnFacturer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLigneFacture.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub RenouvelerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenouvelerToolStripMenuItem.Click

    End Sub

    Private Sub lblSousTitre_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CréationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CréationToolStripMenuItem.Click
        Dim form As New contrat_Creation()

        form.TopLevel = False
        pnlEcran.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub frmContrat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
        Dim client As New frmClient()

        client.TopLevel = False
        pnlEcran.Controls.Add(client)
        client.Show()
    End Sub

    Private Sub lblTitre_Click(sender As System.Object, e As System.EventArgs) Handles lblTitre.Click

    End Sub

    Private Sub pnlEcran_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlEcran.Paint

    End Sub
End Class
