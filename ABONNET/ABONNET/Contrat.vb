Public Class frmContrat



    Private Sub btnOuvrir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOuvrir.Click

        Dim client As New frmClient()

        client.TopLevel = False
        pnlEcran.Controls.Add(client)
        client.Show()

    End Sub

#Region "Descriptions des boutons"

    Private Sub btnOuvrir_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOuvrir.MouseHover
        lblDescrButtons.Text = "Ouverture du contrat de location"
    End Sub

    Private Sub btnOuvrir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOuvrir.MouseLeave
        lblDescrButtons.Text = ""
    End Sub



    Private Sub btnRenouveller_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRenouveller.MouseHover
        lblDescrButtons.Text = "Renouvellement du contrat"
    End Sub

    Private Sub btnRenouveller_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRenouveller.MouseLeave
        lblDescrButtons.Text = ""
    End Sub



    Private Sub btnResilier_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnResilier.MouseHover
        lblDescrButtons.Text = "Résiliation du contrat de location"
    End Sub


    Private Sub btnResilier_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnResilier.MouseLeave
        lblDescrButtons.Text = ""
    End Sub




    Private Sub btnLivrer_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLivrer.MouseHover
        lblDescrButtons.Text = "Livraison des équipements au client et la facturation des clients"
    End Sub


    Private Sub btnLivrer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLivrer.MouseLeave
        lblDescrButtons.Text = ""
    End Sub
#End Region

    Private Sub btnFacturer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturer.Click
        frmLigneFacture.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        End
    End Sub
End Class
