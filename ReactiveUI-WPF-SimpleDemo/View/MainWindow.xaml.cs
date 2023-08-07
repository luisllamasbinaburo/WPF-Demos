using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewmodel;

        public MainWindow()
        {
            InitializeComponent();

            viewmodel = new MainViewModel();
            this.DataContext = viewmodel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            viewmodel.LoadData();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.AddPersona();
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            var source = e.Source as FrameworkElement;
            var vm = source?.DataContext as PersonaVM;

            if (vm == null) return;
            viewmodel.RemovePersona(vm);          
        }
    }
}
