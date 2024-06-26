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

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для License.xaml
    /// </summary>
    public partial class License : Window
    {
        public License()
        {
            InitializeComponent();
            MessageBox.Show("Чтобы начать работу, прочитайте и примите пользовательское соглашение", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
        private void btn_decline_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, RoutedEventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            autorisation.Show();
            this.Close();
        }
    }
}
