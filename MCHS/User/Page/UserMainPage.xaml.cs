using System.IO;
using System.Net;
using System.Net.Http.Json;
using System.Windows.Controls;
using MCHS.Server;
using Newtonsoft.Json;

namespace MCHS.User.Page
{
    public partial class UserMainPage : System.Windows.Controls.Page
    {
        public UserMainPage()
        {
            InitializeComponent();
            Weater();
            
        }

        void Weater()
        {
           
            string uri = "https://api.openweathermap.org/data/2.5/weather?q=Saratov,ru&units=metric&APPID=c7ec18076171c6b223dc1863d186e3d5";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponce weatherResponce = JsonConvert.DeserializeObject<WeatherResponce>(response);

            WeaterResponce_LB.Content = $"Температура в {weatherResponce.Name}, {weatherResponce.Main.Temp}" ;
        }
    }
}