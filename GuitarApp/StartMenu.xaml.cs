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

namespace GuitarApp
{
    /// <summary>
    /// Логика взаимодействия для StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {
        private User user;
        public StartMenu()
        {
            user = new User("login", "1111");
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (user.Login == Login.Text && user.Password == Password.Password)
            {
                MessageBox.Show("Пароль введен верно!", "Поздравление!!!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пароль введен не верно!", "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
