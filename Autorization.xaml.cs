using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using System.Windows.Threading;

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для Autorisation.xaml
    /// </summary>
    public partial class Autorisation : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        string clientLogin = "qwe";
        string clientPassword = "123";
        string adminLogin = "qwe123";
        string adminPassword = "321";
        string accLogin = "qweAcc";
        string accPassword = "12345";
        string realtorLogin = "qweReal";
        string realtorPassword = "qwerty";
        int type = -1; // 0 - клиент, 1 - админ, 2 - бухгалтер, 3 - риелтор
        bool isTimerDown = false;
        public Autorisation()
        {
            InitializeComponent();

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (isTimerDown == true)
            {
                MessageBox.Show("Время на авторизацию вышло! Попробуйте авторизоваться снова, перезапустив приложение.");
                this.Close();
            }
            else
            {
                if (tb_login.Text == clientLogin & pb_password.Password.ToString() == clientPassword)
                {
                    type = 0;
                    MessageBox.Show("Вход успешно выполнен! Добро пожаловать, клиент!", "Авторизация");
                }

                else if (tb_login.Text == adminLogin & pb_password.Password.ToString() == adminPassword)
                {
                    type = 1;
                    MessageBox.Show("Вход успешно выполнен! Добро пожаловать, администратор!", "Авторизация");
                }
                else if (tb_login.Text == accLogin & pb_password.Password.ToString() == accPassword)
                {
                    type = 2;
                    MessageBox.Show("Вход успешно выполнен! Добро пожаловать, бухгалтер!", "Авторизация");
                }
                else if (tb_login.Text == realtorLogin & pb_password.Password.ToString() == realtorPassword)
                {
                    type = 3;
                    MessageBox.Show("Вход успешно выполнен! Добро пожаловать, риэлтор!", "Авторизация");
                }
                else MessageBox.Show("Проверьте правильность введённых данных!", "Авторизация");
            }
            switch (type)
                {
                    case 0:
                        MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                        timer.Stop();
                        break;
                    case 1:
                        AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Close();
                        timer.Stop();
                        break;
                    case 2:
                    timer.Stop();
                    this.Close();
                        break;
                    case 3:
                    timer.Stop();
                    this.Close();
                        break;

                }
        }
        void win_Auto_Loaded(object sender, RoutedEventArgs e)
        {  
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 2, 5);
            timer.Start();
        }
        void timerTick(object sender, EventArgs e)
        {
            isTimerDown = true;
            timer.Stop();
            MessageBox.Show("Время на авторизацию вышло.");
        }
    }
}
