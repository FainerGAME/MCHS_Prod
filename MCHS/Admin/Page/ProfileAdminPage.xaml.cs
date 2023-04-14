using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Controls;
using MCHS.Model;
using MCHS.Server;
using MySql.Data.MySqlClient;

namespace MCHS.Admin.Page
{
    public partial class ProfileAdminPage : System.Windows.Controls.Page
    {
        public ObservableCollection<ProfileModel> Profile { get; }

        public ProfileAdminPage()
        {
            InitializeComponent();
            this.Profile = new ObservableCollection<ProfileModel>();
            this.Loaded += OnPageLoaded;
            FillCoboboxRole();
            FillCoboboxRank();
            FillCoboboxJT();
        }
        private void OnPageLoaded(object sender, RoutedEventArgs e) 
            => UpdateBuildModels();

        // Dynamically update the source collection at any time
        private void UpdateBuildModels()
        {
            this.Profile.Clear();

            // Get data from database
            IEnumerable<ProfileModel> newBuildModels = ProfileManager.GetBuilds();

            // Update source collection with new data from the database
            foreach (ProfileModel buildModel in newBuildModels)
            {
                this.Profile.Add(buildModel);
            }
        }

        private void FillCoboboxRole()
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT ID FROM Role", db.GetConnection());
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Role = reader.GetString("ID");
                CB_Role.Items.Add(Role);
            }
            db.closeConnection();
        }
        private void FillCoboboxRank()
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT ID FROM `Rank`", db.GetConnection());
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Rank = reader.GetString("ID");
                CB_Rank.Items.Add(Rank);
            }
            db.closeConnection();
        }
        private void FillCoboboxJT()
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT ID FROM JobTitle", db.GetConnection());
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Jobtitle = reader.GetString("ID");
                CB_JobTitle.Items.Add(Jobtitle);
            }
            db.closeConnection();
        }
        private void Btn_Save_Prof(object sender, RoutedEventArgs e)
        {
            if (TB_Login.Text == " "|| TB_Password.Text == " "|| TB_FirstName.Text == " "|| TB_LastName.Text == " "|| CB_Rank.Text == "" || CB_Role.Text == " "|| CB_JobTitle.Text == " ")
            {
                MessageBox.Show("Профиль не выбран");
            }
            else
            {
                DB db = new DB();
                string query =
                    $"INSERT INTO Login (FirstName, LastName, Role, `Rank`, Login, Password, JobTitle) VALUES ('{TB_FirstName.Text}','{TB_LastName.Text}','{CB_Role.Text}','{CB_Rank.Text}', '{TB_Login.Text}', '{TB_Password.Text}', '{CB_JobTitle.Text}')";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Пользователь сохранен");
                UpdateBuildModels();
            }
        }

        private void Btn_Update_Prof(object sender, RoutedEventArgs e)
        {
            if (TB_Login.Text == " "|| TB_Password.Text == " "|| TB_FirstName.Text == " "|| TB_LastName.Text == " "|| CB_Rank.Text == "" || CB_Role.Text == " "|| CB_JobTitle.Text == " ")
            {
                MessageBox.Show("Профиль не выбран");
            }
            else
            {
                DB db = new DB();
                string query = $"UPDATE Login SET FirstName = '{TB_FirstName.Text}', LastName = '{TB_LastName.Text}', Login = '{TB_Login.Text}', Password = '{TB_Password.Text}', Role = '{CB_Role.Text}', `Rank` = '{CB_Rank.Text}', JobTitle = '{CB_JobTitle.Text}' WHERE ID = '{TB_ID.Text}'";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Профиль обнавлен");
                UpdateBuildModels();
            }
        }

        private void Btn_Delete_Prof(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            string query = $"DELETE FROM Login WHERE ID = '{TB_ID.Text}'";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            db.closeConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Профиль удален");
            UpdateBuildModels();
        }
    }
}