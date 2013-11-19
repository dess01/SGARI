Imports System.IO


    Public Class frmClient


        Private Sub frmClient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim nomService As New Services

            cmbServices.Text = "<--Choisir-->"

            For i As Integer = 0 To 5 - 1 Step 1
                cmbServices.Items.Add(nomService(i))
            Next

        End Sub

        Private Sub EnregistrerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerToolStripMenuItem.Click
        Dim nomFichier As String = "Contrats.txt"
        Dim transFichier As String = "transaction.txt"
        Dim position As Integer = 0
        Dim fichierContrats As StreamWriter

            Try
                If Not File.Exists(nomFichier) Then
                    fichierContrats = File.CreateText(nomFichier)
                Else
                    fichierContrats = File.AppendText(nomFichier)
                End If



            For Each info As TextBox In Controls.OfType(Of TextBox)()
                fichierContrats.WriteLine(info.Text)

                position += 1
            Next

            fichierContrats.WriteLine(cmbServices.Text)
            fichierContrats.WriteLine("--Fin de la Transaction--")
            fichierContrats.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            If Not File.Exists(transFichier) Then
                fichierContrats = File.CreateText(transFichier)
            Else
                fichierContrats = File.AppendText(transFichier)
            End If

            fichierContrats.WriteLine(txtNom.Text & " " & Date.Now)

            fichierContrats.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        End Sub

        Private Sub NouveauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauToolStripMenuItem.Click

        For Each info As TextBox In Controls.OfType(Of TextBox)()
            info.Clear()
        Next
            cmbServices.Text = "<--Choisir-->"
        End Sub
    End Class