using System.Diagnostics;
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
using System.Windows.Threading;

namespace _02_TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = null;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += timer_Tick;
            timer.Start();
            
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = Process.GetProcesses();
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Time");
        }

        private void Details(object sender, RoutedEventArgs e)
        {
            var res = grid.SelectedItem as Process;
            MessageBox.Show(res.Id.ToString());
            var det = Process.GetProcessById(res.Id);
        }

        private void Stop(object sender, RoutedEventArgs e)
        {

        }

        private void grid_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            var res = grid.SelectedItem as Process;
            MessageBox.Show(res.Id.ToString());
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var res = grid.SelectedItem as Process;
            MessageBox.Show(res.Id.ToString());
        }
    }
}