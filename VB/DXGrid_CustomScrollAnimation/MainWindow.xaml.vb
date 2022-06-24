Imports System
Imports System.Windows
Imports System.Windows.Media.Animation

Namespace DXGrid_CustomScrollAnimation

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = TestData.GetData()
        End Sub

        Private Sub view_CustomScrollAnimation(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CustomScrollAnimationEventArgs)
            e.Storyboard = New Storyboard()
            Dim animation As DoubleAnimation = New DoubleAnimation With {.From = e.OldOffset, .[To] = e.NewOffset, .Duration = New Duration(TimeSpan.FromMilliseconds(600)), .EasingFunction = New ExponentialEase() With {.Exponent = 0}}
            e.Storyboard.Children.Add(animation)
        End Sub
    End Class
End Namespace
