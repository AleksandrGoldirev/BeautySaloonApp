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
    /// Логика взаимодействия для Categories.xaml
    /// </summary>
    public partial class CategoriesPage : Page
    {
        public CategoriesPage()
        {
            InitializeComponent();
            ServiceListView.ItemsSource = ServiceCategoriesController.GetServiceCategoryes();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid activeElement = sender as Grid;
            ServiceCategoryes activeCategory = activeElement.DataContext as ServiceCategoryes;
            this.NavigationService.Navigate(new ServicesPage(activeCategory));
        }
    }
}
