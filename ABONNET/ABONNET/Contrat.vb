Public Class frmContrat
    Private Sub btnFacturer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLigneFacture.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        End
    End Sub

    Private Sub RenouvelerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenouvelerToolStripMenuItem.Click

    End Sub

    Private Sub lblSousTitre_Click(sender As System.Object, e As System.EventArgs) Handles lblSousTitre.Click

    End Sub

    Private Sub CréationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CréationToolStripMenuItem.Click
        Dim client As New frmClient()

        client.TopLevel = False
        pnlEcran.Controls.Add(client)
        client.Show()
    End Sub

    Private Sub frmContrat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
