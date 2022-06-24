Imports System.Collections.ObjectModel

Namespace DXGrid_CustomScrollAnimation

    Public Class TestDataObject

        Public Property ID As Integer

        Public Property Value As String
    End Class

    Public Class TestData

        Public Shared Function GetData() As ObservableCollection(Of TestDataObject)
            Dim list As ObservableCollection(Of TestDataObject) = New ObservableCollection(Of TestDataObject)()
            For i As Integer = 0 To 100 - 1
                list.Add(New TestDataObject() With {.ID = i, .Value = String.Format("Value {0}", i)})
            Next

            Return list
        End Function
    End Class
End Namespace
