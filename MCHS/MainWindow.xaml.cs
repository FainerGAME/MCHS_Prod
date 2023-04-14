using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MCHS.Admin;
using MCHS.Admin.Page;
using MCHS.Server;
using MCHS.User.Page;
using MySql.Data.MySqlClient;

namespace MCHS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            int num = random.Next(6, 8);
            string captcha = "";
            int total = 0;
            do
            {
                int chr = random.Next(48, 123);
                if ((chr>=48 && chr<=57)|| (chr>=68 && chr<=90) || (chr>=97 && chr<=122) )
                {
                    captcha = captcha + (char) chr;
                    total++;
                    if (total==num)
                        break;
                    {
                        
                    }
                }
            } while (true);

            LB_Captcha.Content = captcha;
        }
        private async void Btn_LogIn_OnClick(object sender, RoutedEventArgs e)
        {
            if (TB_Name.Text == "" || PB_Password.Password == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else if (TB_EnterCapch.Text == "")
            {
                MessageBox.Show("Капча не введена");
            }
            else if (TB_EnterCapch.Text != (string) LB_Captcha.Content)
            {
                MessageBox.Show("Капча введена не правильно");
                UIElement element = (UIElement)sender;

                element.IsEnabled = false;
                await Task.Delay(10000);
                element.IsEnabled = true;
            }
            else
            {
                DB db = new DB();
                string userName = TB_Name.Text;
                string password = PB_Password.Password;

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Login WHERE Login = @uL AND Password = @uP AND Role = 1", db.GetConnection());

                cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userName;
                cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if (table.Rows.Count>0)
                {
                    global.userid = Convert.ToInt32(table.Rows[0]["ID"].ToString());
                    global.username = table.Rows[0]["Login"].ToString();
                    global.rank = table.Rows[0]["Rank"].ToString();
                    UserPage(); 
                }
                else
                {
                    DB dbAdmin = new DB();
                    string adminName = TB_Name.Text;
                    string adpassword = PB_Password.Password;

                    DataTable adminTabel = new DataTable();
                    MySqlDataAdapter adminAdapter = new MySqlDataAdapter();
                    
                    MySqlCommand command = new MySqlCommand("SELECT * FROM Login WHERE Login = @uL AND Password = @uP AND Role = 2", dbAdmin.GetConnection());
                    
                    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = adminName;
                    command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = adpassword;

                    adminAdapter.SelectCommand = command;
                    adminAdapter.Fill(adminTabel);
                    if (adminTabel.Rows.Count >0)
                    {
                        AdminPage();
                    }
                }
            }
        }

        void UserPage()
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand($"UPDATE Login SET `TimeEnterApp` = '{System.DateTime.Now.ToString("yyyy-MM-dd")}' WHERE ID = '{global.userid}'", db.GetConnection());
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            FrameWin FW = new FrameWin();
            Application.Current.MainWindow.Close();
            FW.Show();
        }
        void AdminPage()
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand($"UPDATE Login SET `TimeEnterApp` = '{System.DateTime.Now.ToString("yyyy-MM-dd")}' WHERE ID = '{global.userid}'", db.GetConnection());
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            AdminFrameWin AFW = new AdminFrameWin();
            Application.Current.MainWindow.Close();
            AFW.Show();
        }

        private void Close_Btn_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}