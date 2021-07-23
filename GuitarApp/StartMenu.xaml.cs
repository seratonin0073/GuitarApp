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
        static public List<User> Users;
        public StartMenu()
        {
            Users = new List<User>();
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(Login.Text, Password.Password);
            if(Users.Count > 0)
            {
                bool isCorrect = false;
                foreach(User item in Users)
                {
                    isCorrect = item.Equals(user);
                    if (isCorrect)
                        break;
                }

                if(isCorrect)
                {
                    MainWindow win = new MainWindow();
                    win.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль!!!", "Не правильный пароль", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Нету пользователей. Зарегестрируйтесь и будуте первым!!!", "Нету пользователей", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
    }
}
