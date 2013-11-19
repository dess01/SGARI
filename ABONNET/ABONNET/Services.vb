

Public Class Services


    Private services() As String = {"Installation des équipements", "Réparation des équipements", "Programmation de pages Web", "Assistance téléphonique", "Impression des rapports"}

    Default Public ReadOnly Property GetServices(ByVal numero As Integer) As String
        Get
            Return services(numero)
        End Get
    End Property


End Class
