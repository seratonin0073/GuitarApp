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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        
        public Registration()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Password.Password == RepeatPassword.Password)
            {
                User user = new User(Login.Text, Password.Password, Email.Text);
                StartMenu.Users.Add(user);
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!!!", "Пароли не совпадают", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                Password.Password = String.Empty;
                RepeatPassword.Password = String.Empty;
            }
            
        }
    }
}
