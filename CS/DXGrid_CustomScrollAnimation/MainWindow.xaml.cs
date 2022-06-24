using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace DXGrid_CustomScrollAnimation {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = TestData.GetData();
        }

        void view_CustomScrollAnimation(object sender, DevExpress.Xpf.Grid.CustomScrollAnimationEventArgs e) {
            e.Storyboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation {
                From = e.OldOffset,
                To = e.NewOffset,
                Duration = new Duration(TimeSpan.FromMilliseconds(600)),
                EasingFunction = new ExponentialEase() { Exponent = 0 }
            };
            e.Storyboard.Children.Add(animation);
        }
    }
}
