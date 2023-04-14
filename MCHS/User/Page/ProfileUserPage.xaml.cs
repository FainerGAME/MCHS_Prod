using System;
using System.Collections.Generic;
using System.Windows.Controls;
using MCHS.Server;
using MySql.Data.MySqlClient;

namespace MCHS.User.Page
{
    public partial class ProfileUserPage : System.Windows.Controls.Page
    {
        public ProfileUserPage()
        {
            InitializeComponent();
            FillProfile();
        }
        
        public class ProfileModel
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Rank { get; set; }
            public string JobTitle { get; set; }
            public string ImgPath { get; set; }
            public string RankImg { get; set; }
        }

        void FillProfile()
        {
            List<ProfileModel> items = new List<ProfileModel>();
            DB db = new DB();
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand($"SELECT Login.ID, Login.FirstName, Login.LastName, Login.Img,  Rank.Name,  JobTitle.Name, Rank.img FROM Login,`Rank`, JobTitle WHERE Login.ID = {global.userid} AND Login.`Rank` = `Rank`.ID AND Login.JobTitle = JobTitle.ID", db.GetConnection());
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    items.Add(new ProfileModel(){ID = rd.GetInt32(0), FirstName = rd.GetString(1), LastName = rd.GetString(2),  ImgPath = rd.GetString(3), Rank = rd.GetString(4), JobTitle = rd.GetString(5),RankImg = rd.GetString(6) });
                }
            }

            icProfile.ItemsSource = items;
        }
    }
}