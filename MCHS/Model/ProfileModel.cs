using System.Collections.Generic;
using MCHS.Server;
using MySql.Data.MySqlClient;


namespace MCHS.Model
{
    public class ProfileModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Role { get; set; }
        public int Rank { get; set; }
        public string Image { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int JobTitle { get; set; }
    }

    public class ProfileManager
    {
        public static List<ProfileModel> GetBuilds()
        {
            List<ProfileModel> items = new List<ProfileModel>();
            DB db = new DB();
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Login", db.GetConnection());
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    items.Add(new ProfileModel(){ID = rd.GetInt32(0), FirstName = rd.GetString(1), LastName = rd.GetString(2), Role = rd.GetInt32(3), Rank = rd.GetInt32(4), Image = rd.GetString(5), Login = rd.GetString(6), Password = rd.GetString(7), JobTitle = rd.GetInt32(8)});
                }
            }
            return items;
        }
    }
}