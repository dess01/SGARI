Public Class contrat_Creation

    Private Sub contrat_Creation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' populer le dropdown des clients avec la liste des clients
        FillComboFromFile("clients.txt")

        input_dateFin.Value = New Date(Now.Year + 1, Now.Month, Now.Day, 12, 0, 0)
    End Sub

    Private Sub noClient_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles noClient.SelectedIndexChanged
        
    End Sub

    Private Sub FillComboFromFile(ByVal path As String)
        Try
            If IO.File.Exists(path) Then
                Using sr As New IO.StreamReader(path)
                    While Not sr.EndOfStream
                        noClient.Items.Add(sr.ReadLine)
                    End While
                End Using
            Else
                MsgBox("Client file not found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles input_courriel.TextChanged, input_telephone.TextChanged

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click, Label10.Click, Label11.Click, Label13.Click

    End Sub

    Private Sub sep_1_Click(sender As System.Object, e As System.EventArgs) Handles sep_1.Click, sep_2.Click

    End Sub

    Private Sub pnl_main_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnl_main.Paint

    End Sub
End Class