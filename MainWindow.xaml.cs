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

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_adminpanel_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Owner = this;
            adminPanel.Show();
            this.Close();
        }
        private void btn_services_Click(object sender, RoutedEventArgs e)
        {
            tabControl_Client.SelectedItem = tab_services;
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            tabControl_Client.SelectedItem = tab_register;
        }

        private void btn_service1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_stat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Действительно выйти? Если Вы нажмете 'Да' то все изменения будут утерянны.", "Выход из программы", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_accountry_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Autorisation autorisation = new Autorisation();
                autorisation.Show();
                this.Close();
            }
        }
    }
}