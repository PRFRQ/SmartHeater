using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SmartHeater
{
    public partial class SmartHeater : Form
    {
        public SmartHeater()
        {
            InitializeComponent();
        }

        public class Meteo
        {
            public Meteo(string json)
            {
                JObject jObject = JObject.Parse(json);
                JToken jMain = jObject["main"];
                temp = (string)jMain["temp"];
                feels_like = (string)jMain["feels_like"];
                temp_min = (string)jMain["temp_min"];
                temp_max = (string)jMain["temp_max"];
                pressure = (string)jMain["pressure"];
                humidity = (string)jMain["humidity"];

                 
            }
            public string temp { get; set; }
            public string feels_like { get; set; }
            public string temp_min { get; set; }
            public string temp_max { get; set; }
            public string pressure { get; set; }
            public string humidity { get; set; }
        }

        private static string GetDataFromAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                string private_Keys = "";
                var url = "https://api.openweathermap.org/data/2.5/weather?lat=48.665916&lon=6.156484&appid="+private_Keys;
                var task = client.GetAsync(url);
                task.Wait();

                if (!task.Result.IsSuccessStatusCode)
                {
                    throw new Exception(task.Result.StatusCode.ToString());
                }

                var readTask = task.Result.Content.ReadAsStringAsync();
                readTask.Wait();
                return readTask.Result;
            }
        }

        private void refreshData_Tick(object sender, EventArgs e)
        {
            
            string json = GetDataFromAPI();
            Meteo meteo = new Meteo(json);

            Random aleatoire = new Random();
            int temp_rad = aleatoire.Next(1, 40);
            tempVal.Text = meteo.temp;
            tempRadTXT.Text = Convert.ToString(temp_rad);
            
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            string json = GetDataFromAPI();
            Meteo meteo = new Meteo(json);

            Random aleatoire = new Random();
            int temp_rad = aleatoire.Next(1, 40);
            int tension_bat = aleatoire.Next(1, 50);
            int bat_power = aleatoire.Next(0, 101);
            int grid_power = aleatoire.Next(0, 50);
            tempVal.Text = meteo.temp+ "°C";
            tempRadTXT.Text = Convert.ToString(temp_rad)+"°C";
            tensionBatTXT.Text = Convert.ToString(tension_bat) + " Volts";
            batteryPowerTXT.Text = Convert.ToString(bat_power) + " %";
            battrypowerValue.Value = bat_power;
            gridPowerTXT.Text= Convert.ToString(grid_power)+" Watts";

            Controleur(bat_power);
        }

        private void Controleur(int _bat_power)
        {
            DateTime dt = DateTime.Now;
            Random aleatoire = new Random();
            int consoFR = aleatoire.Next(0, 50000);
            if (dt.Hour>2 && dt.Hour < 6)
            {
                if( _bat_power< 40 && consoFR<40000)
                {
                    controleurTXT.Text = "Charge activée";
                }
                else
                {
                    controleurTXT.Text = "Charge désactivée";
                }
            }
            else
            {
                controleurTXT.Text = "Charge désactivée";
            }
        }
    }
}
