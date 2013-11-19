Public Class frmLigneFacture

    Dim CheckBox As Object

    Private Sub frmLigneFacture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fact As New Facture("--Fin de la Transaction--")

    



    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        frmContrat.Enabled = True
        Me.Close()

    End Sub
End Class