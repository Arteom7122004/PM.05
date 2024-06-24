using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using PPM._05.Pages;

namespace PPM._05
{
    /// <summary>
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        public EnterPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            Boolean error = false;
            foreach (Пользователь user in DB.connect.Пользователь.ToList())
            {
                if (LoginTB.Text == user.Логин && PasswordPB.Password == user.Пароль)
                {
                    Manager.MainFrame.Navigate(new WorkersPage());
                    break;
                }
                else { error = true; }
            }
            if (error == true) MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
