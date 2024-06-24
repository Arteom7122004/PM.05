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
using PPM._05.Classes;

namespace PPM._05.Pages
{
    /// <summary>
    /// Логика взаимодействия для WorkersPage.xaml
    /// </summary>
    public partial class WorkersPage : Page
    {
        public WorkersPage()
        {
            InitializeComponent();
            WorkersGrid.ItemsSource = DB.connect.Работник.ToList();
            ScheduleGrid.ItemsSource = DB.connect.График_работы.ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EnterPage());
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            DB.connect.SaveChanges();
        }
    }
}
