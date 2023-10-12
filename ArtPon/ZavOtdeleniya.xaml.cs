using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ArtPon
{
    /// <summary>
    /// Логика взаимодействия для ZavOtdeleniya.xaml
    /// </summary>
    public partial class ZavOtdeleniya : Window
    {
        public ZavOtdeleniya()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Singleton.DB.Group.ToList();
            tableGrid.ItemsSource = Singleton.DB.Group.Local;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Singleton.DB.SaveChanges();
        }
    }
}
