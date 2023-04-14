using System;
using System.Windows;
using MCHS.Server;
using MySql.Data.MySqlClient;

namespace MCHS.User.Page
{
    public partial class FrameWin : Window
    {
        public FrameWin()
        {
            InitializeComponent();
            LNFN();
            
        }

        void LNFN()
        {
            DB db = new DB();
            string query = $"SELECT FirstName, LastName, ID, Img FROM Login WHERE ID = {global.userid}";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            db.openConnection();
            MySqlDataReader myReader = cmd.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    FN_Label.Content = myReader.GetString("FirstName");
                    LN_Label.Content = myReader.GetString("LastName");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void Home_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new UserMainPage();
            MyFrame.NavigationService.RemoveBackEntry();
        }

        private void Close_btn_OnClick(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand($"UPDATE Login SET `TimeExitApp` = '{System.DateTime.Now.ToString("yyyy-MM-dd")}' WHERE ID = '{global.userid}'", db.GetConnection());
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            Application.Current.Shutdown();
        }

        private void Respons_Btn_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ResponsePage();
            MyFrame.NavigationService.RemoveBackEntry();
        }

        private void Profile_Btn_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ProfileUserPage();
            MyFrame.NavigationService.RemoveBackEntry();
        }
    }
}