using System.Collections.Generic;
using MCHS.Server;
using MySql.Data.MySqlClient;

namespace MCHS.Model
{
    public class JobTitleModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class JobTitleManager
    {
        public static List<JobTitleModel> GetBuilds()
        {
            List<JobTitleModel> items = new List<JobTitleModel>();
            DB db = new DB();
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM JobTitle", db.GetConnection());
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    items.Add(new JobTitleModel(){ID = rd.GetInt32(0), Name = rd.GetString(1)});
                }
            }

            return items;
        }
    }
}