using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MCHS.Server;
using MySql.Data.MySqlClient;

namespace MCHS.Model
{
    public class RankModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
    }

    public class RankManager
    {
        public static List<RankModel> GetBuilds()
        {
            List<RankModel> items = new List<RankModel>();
            DB db = new DB();
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `Rank`", db.GetConnection());
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    items.Add(new RankModel(){ID = rd.GetInt32(0), Name = rd.GetString(1), Img = rd.GetString(2)});
                }
            }

            return items;
        }
    }
}