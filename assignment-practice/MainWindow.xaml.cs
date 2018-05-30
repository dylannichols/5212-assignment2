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
using static assignment_practice.Collections;

namespace assignment_practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserLogin(object sender, RoutedEventArgs e)
        {
            if (Users.ContainsKey(Username.Text))
            {
                var isUser = Users.TryGetValue(Username.Text, out var username);
                if (username.Password == Passwords.Text)
                {
                    // logic to log user in
                }
            }
            else
            {
                Users.Add(Username.Text, new User { Username = Username.Text, Password = Passwords.Text, Role = "User" });

                // logic to log user in
            }
        }

        private void AdminLogin(object sender, RoutedEventArgs e)
        {

        }
    }
}
