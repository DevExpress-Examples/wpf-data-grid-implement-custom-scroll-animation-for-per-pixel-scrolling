Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Media.Animation

Namespace DXGrid_CustomScrollAnimation
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = GetData()
        End Sub

        Private Sub tableView1_CustomScrollAnimation(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CustomScrollAnimationEventArgs)
            e.Storyboard = New Storyboard()
            Dim animation As New DoubleAnimation()
            animation.From = e.OldOffset
            animation.To = e.NewOffset
            animation.Duration = New Duration(TimeSpan.FromMilliseconds(600))
            animation.EasingFunction = New ExponentialEase() With {.Exponent = 0}
            e.Storyboard.Children.Add(animation)
        End Sub

        Private Function GetData() As List(Of TestDataObject)
            Dim _list As New List(Of TestDataObject)()
            For i As Integer = 0 To 99
                _list.Add(New TestDataObject() With {.ID = i, .Value = String.Format("Value {0}", i)})
            Next i
            Return _list
        End Function
    End Class

    Public Class TestDataObject
        Public Property ID() As Integer
        Public Property Value() As String
    End Class
End Namespace
