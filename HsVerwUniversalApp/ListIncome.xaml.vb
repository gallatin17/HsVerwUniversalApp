﻿' Die Elementvorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

''' <summary>
''' Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
''' </summary>
Public NotInheritable Class ListIncome
    Inherits Page

    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.


        Dim vlo_client As New HsVerwSvc.Service1Client
        Dim _hhkatresult As Task(Of ObservableCollection(Of HsVerwSvc.Einnahme)) = vlo_client.GetEinnahmenAsync

        ListviewIncome.ItemsSource = _hhkatresult.Result

    End Sub

End Class