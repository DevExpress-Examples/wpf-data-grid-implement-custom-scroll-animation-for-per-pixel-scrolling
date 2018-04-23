using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace DXGrid_CustomScrollAnimation {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = GetData();
        }

        private void tableView1_CustomScrollAnimation(object sender, DevExpress.Xpf.Grid.CustomScrollAnimationEventArgs e) {
            e.Storyboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = e.OldOffset;
            animation.To = e.NewOffset;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(600));
            animation.EasingFunction = new ExponentialEase() { Exponent = 0 };
            e.Storyboard.Children.Add(animation);
        }

        private List<TestDataObject> GetData() {
            List<TestDataObject> _list = new List<TestDataObject>();
            for (int i = 0; i < 100; i++)
                _list.Add(new TestDataObject() { ID = i, Value = string.Format("Value {0}", i)  });
            return _list;
        }
    }

    public class TestDataObject {
        public int ID { get; set; }
        public string Value { get; set; }
    }
}
