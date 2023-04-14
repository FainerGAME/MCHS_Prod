using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using MCHS.Model;
using MCHS.Server;
using MySql.Data.MySqlClient;

namespace MCHS.Admin.Page
{
    public partial class JobTitleAdminPage : System.Windows.Controls.Page
    {
        public ObservableCollection<JobTitleModel> JobTitle { get; }
        public JobTitleAdminPage()
        {
            InitializeComponent();
            this.JobTitle = new ObservableCollection<JobTitleModel>();
            this.Loaded += OnPageLoaded;
        }
        private void OnPageLoaded(object sender, RoutedEventArgs e) 
            => UpdateBuildModels();

        // Dynamically update the source collection at any time
        private void UpdateBuildModels()
        {
            this.JobTitle.Clear();

            // Get data from database
            IEnumerable<JobTitleModel> newBuildModels = JobTitleManager.GetBuilds();

            // Update source collection with new data from the database
            foreach (JobTitleModel buildModel in newBuildModels)
            {
                this.JobTitle.Add(buildModel);
            }
        }
        private void Btn_Save_JobTitle(object sender, RoutedEventArgs e)
        {
            if (TB_Name.Text == " ")
            {
                MessageBox.Show("Не введено название должности");
            }
            else
            {
                DB db = new DB();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO JobTitle (Name) VALUES ('{TB_Name.Text}') ", db.GetConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Должность добавлена");
                UpdateBuildModels();
            }
        }

        private void Btn_Update_JobTitle(object sender, RoutedEventArgs e)
        {
            if (TB_Name.Text == " " || TB_ID.Text == " ")
            {
                MessageBox.Show("Не выбрана должность");
            }
            else
            {
                DB db = new DB();
                MySqlCommand cmd = new MySqlCommand($"UPDATE JobTitle SET Name = '{TB_Name.Text}'", db.GetConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Должность обновлена");
                UpdateBuildModels();
            }
        }

        private void Btn_Delete_JobTitle(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM JobTitle WHERE ID = '{TB_ID.Text}'", db.GetConnection());
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Должность удалена");
            UpdateBuildModels();
        }
    }
}