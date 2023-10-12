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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArtPon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = Singleton.DB.User.Where
                (user => user.Login == login.Text && user.Password == password.Password).ToList();
            if (users.Count == 1)
            {
                User user = users[0];
                List<string> roles = new List<string>();
                string separator = ", ";
                bool addSeparator = false;
                foreach (Role role in user.Role)
                {
                    roles.Add(role.Name);
                }

                MessageBox.Show(string.Join(separator, roles), "Роли");

                if (roles.Contains("Заведующая"))
                {
                    ZavOtdeleniya zavwimdow= new ZavOtdeleniya();
                    Hide();
                    zavwimdow.ShowDialog();
                    Show();
                }
                else
                {
                    Window1 window1 = new Window1();
                    Hide();
                    window1.ShowDialog();
                    Show();
                }

            }
            else
            {
                MessageBox.Show("Пользователь не авторизован: Попробуйте снова");
            }
        }
    }
}
