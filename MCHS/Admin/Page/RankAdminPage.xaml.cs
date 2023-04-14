using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using MCHS.Model;
using MCHS.Server;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace MCHS.Admin.Page
{
    public partial class RankAdminPage : System.Windows.Controls.Page
    {
        public ObservableCollection<RankModel> Rank { get; }
        public RankAdminPage()
        {
            InitializeComponent();
            this.Rank = new ObservableCollection<RankModel>();
            this.Loaded += OnPageLoaded;
        }
        
        private void OnPageLoaded(object sender, RoutedEventArgs e) 
            => UpdateBuildModels();

        // Dynamically update the source collection at any time
        private void UpdateBuildModels()
        {
            this.Rank.Clear();

            // Get data from database
            IEnumerable<RankModel> newBuildModels = RankManager.GetBuilds();

            // Update source collection with new data from the database
            foreach (RankModel buildModel in newBuildModels)
            {
                this.Rank.Add(buildModel);
            }
        }
        private void Btn_Save_Rank(object sender, RoutedEventArgs e)
        {
            if (TB_Name.Text == " ")
            {
                MessageBox.Show("Вы не ввели название звания");
            }
            else
            {
                DB db = new DB();
                MySqlCommand cmd =
                    new MySqlCommand($"INSERT INTO `Rank` (Name, img)  VALUES ('{TB_Name.Text}', '{TB_Img.Text.ToString().Replace("\\", "\\\\")}')", db.GetConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Звание добавлено");
                UpdateBuildModels();
            }
        }

        private void Btn_Update_Rank(object sender, RoutedEventArgs e)
        {
            if (TB_Name.Text == " " || TB_ID.Text == " ")
            {
                MessageBox.Show("Вы не выбрали звание");
            }
            else
            {
                DB db = new DB();
                MySqlCommand cmd = new MySqlCommand($"UPDATE Rank SET Name = '{TB_Name.Text}', img = '{TB_Img.Text.ToString().Replace("\\", "\\\\")}' WHERE ID = '{TB_ID.Text}'", db.GetConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Звание обновлено");
                UpdateBuildModels();
            }
        }

        private void Btn_Delete_Rank(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM Rank WHERE ID = '{TB_ID.Text}'", db.GetConnection());
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Звание удалено");
            UpdateBuildModels();
        }

        private void Btn_Path_Img(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            TB_Img.Text = OFD.FileName;
        }
    }
}