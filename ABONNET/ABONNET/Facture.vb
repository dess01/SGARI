
Imports System.IO




Public Class Facture




    Public Sub New(ByVal name As String)

        Dim nomFichier As String = "Contrats.txt"
        Dim transFichier As String = "transaction.txt"
        Dim ligneText As String = ""
        Dim position As Integer = -4
        Dim fichierContrats As StreamReader
        Dim rdb As New RadioButton


        Try
            fichierContrats = File.OpenText(nomFichier)


            Do
                ligneText = fichierContrats.ReadLine
                frmLigneFacture.lstFormulaire.Items.Add(ligneText)
            Loop Until ligneText = name


            fichierContrats.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




        Try

            fichierContrats = File.OpenText(transFichier)

            Do
                ligneText = fichierContrats.ReadLine

                If Not ligneText = vbNullString Then
                    frmLigneFacture.lstTransaction.Items.Add(ligneText)
                    frmLigneFacture.lstTransaction.Items.Add(" ")

                    frmLigneFacture.lstTransaction.Controls.Add(rdb)
                    rdb.Location = New Point(380, position)
                    rdb = New RadioButton
                End If
                position += 27
            Loop Until ligneText = vbNullString

            fichierContrats.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub





End Class
