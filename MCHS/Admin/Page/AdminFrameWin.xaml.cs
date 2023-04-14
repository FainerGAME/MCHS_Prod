using System.Windows;
using MCHS.Server;
using MySql.Data.MySqlClient;

namespace MCHS.Admin.Page
{
    public partial class AdminFrameWin : Window
    {
        public AdminFrameWin()
        {
            InitializeComponent();
        }
        private void Profile_Btn_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ProfileAdminPage();
            MyFrame.NavigationService.RemoveBackEntry();
        }

        private void JobTitle_Btn_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new JobTitleAdminPage();
            MyFrame.NavigationService.RemoveBackEntry();
        }

        private void Rank_Btn_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new RankAdminPage();
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
    }
}