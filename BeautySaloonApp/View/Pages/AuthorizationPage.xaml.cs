using BeautySaloonApp.Controllers;
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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void SignInbutton_Click(object sender, RoutedEventArgs e)
        {
            UsersController db = new UsersController();
            bool isAuth = db.Auth(LoginTextBox.Text, PasswordPasswordBox.Password);
            if (isAuth)
            {
                this.NavigationService.Navigate(new CategoriesPage());
            }
            else
            {
                
            }
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegPage());
        }
    }
}
