using BeautySaloonApp.Controllers;
using BeautySaloonApp.Models;
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

namespace BeautySaloonApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();

        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTextBox.Text != "" && PasswordPasswordBox.Password != "" && RepeatPasswordPasswordBox.Password != "")
            {
                if (PasswordPasswordBox.Password == RepeatPasswordPasswordBox.Password)
                {
                    Users newUser = new Users
                    {
                        Idrole = 2,
                        UserName = NameTextBox.Text,
                        UserLastName = LastNameTextBox.Text,
                        UserOtherName = OtherNameTextBox.Text,
                        UserLogin = LoginTextBox.Text,
                        UserPassword = PasswordPasswordBox.Password
                    };

                    if (UsersController.AddUser(newUser))
                    {
                        MessageBox.Show("запись добавлена");
                    }
                }
                else
                {
                    MessageBox.Show("Внимание: пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Логин и пароль обязательны для заполнения");
            }
        }
    }
}
