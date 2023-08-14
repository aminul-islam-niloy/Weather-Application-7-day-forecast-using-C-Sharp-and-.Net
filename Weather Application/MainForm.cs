using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Security.Cryptography.X509Certificates;





// api  bb9f38871e6eaeb785f75bc764dca4f8
//call https://api.openweathermap.org/data/2.5/weather?q=khulna&appid=bb9f38871e6eaeb785f75bc764dca4f8

namespace Weather_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void mininmixe_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //weatherText.Parent = mainPicture;
            //weatherText.BackColor = Color.Transparent;
            //iconpictureBox1.BackColor = Color.Transparent;

            DateTime date = DateTime.Now;
            //CurrentDay.Text = date.ToString();


        }

        private void mainPicture_Click(object sender, EventArgs e)
        {

        }

        private void GetCityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {


        }
       

        private void SearchCityname_Click(object sender, EventArgs e)
        {
           
            getWeather();
            // getDailyWeather();
            GetDaily();




        }

        string APIKEY = "bb9f38871e6eaeb785f75bc764dca4f8";
        // string cityName = "khulna";


        double lata;
        double latu;


        void getWeather()
        {
            try
            {

                using (WebClient web = new WebClient())
                {
               

                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",GetCityName.Text, APIKEY);

                    //download weather in json object
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    iconpictureBox1.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    conditionText.Text = Info.weather[0].main;
                    DescriptionText.Text = Info.weather[0].description;

                    //weatherText.Text = Info.main.temp.ToString();

                    double kelvinTemperature = Info.main.temp;
                    double celsiusTemperature = kelvinTemperature - 273.15;

                    // Convert the temperature to string and assign it to weatherText.Text
                    weatherText.Text = celsiusTemperature.ToString() + "°C";

                    double kelvinTemp = Info.main.feels_like;
                    double celsiusTem = kelvinTemp - 273.15;
                    feelLike.Text = celsiusTem.ToString() + "°C";

                    double MaxTemp = Info.main.temp_max;
                    double celsiusTemMax = MaxTemp - 273.15;
                    MaxTem.Text = celsiusTemMax.ToString() + "°C";

                    double MinTempra = Info.main.temp_min;
                    double celsiusTemMin = MinTempra - 273.15;
                    MinTemp.Text = celsiusTemMax.ToString() + "°C";


                    Pressure.Text = Info.main.pressure.ToString();
                    humidityText.Text = Info.main.humidity.ToString();

                    WindSpeed.Text = Info.wind.speed.ToString();
                    allClouds.Text = Info.clouds.all.ToString();

                    SunRise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                    SunSetText.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

                    Country.Text = Info.sys.country.ToString();

                   
                    WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(json);

                    string cityName = weatherInfo.name;
                   

                   // CurrentDay.Text = convertDateTime(weatherInfo.dt[0]).DayOfWeek.ToString();

                    City.Text = cityName;
                    

                    // Convert the long value to a DateTime
                    DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds(1689590188).DateTime;

                    // Get the name of the day
                    string dayName = dateTime.ToString("dddd");
                  //  CurrentDay.Text = dayName.ToString();

                    MessegeBoxE.Text = "Loaded Data from Server";


                    lata = Info.coord.lat;
                    latu = Info.coord.lon;

                }
            }
            catch (Exception ex)
            {

                MessegeBoxE.Text = ex.Message;
            }

        }
        

        DateTime convertDateTime(long sec)
        {
            DateTime day= new  DateTime(1970,1,1,0,0,0,0,DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void GetLocation_Click(object sender, EventArgs e)
        {
            GetLocationClilck();
            // getDailyWeather();
            GetDaily();

            
        }

      

        private void GetLocationClilck()
        {
            
            try
            {

                using (WebClient web = new WebClient())
                {

                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=dhaka&appid={0}", APIKEY);
                    //download weather in json object
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    iconpictureBox1.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    conditionText.Text = Info.weather[0].main;
                    DescriptionText.Text = Info.weather[0].description;

               

                    double kelvinTemperature = Info.main.temp;
                    double celsiusTemperature = kelvinTemperature - 273.15;
                    weatherText.Text = celsiusTemperature.ToString() + "°C";

                    double kelvinTemp = Info.main.feels_like;
                    double celsiusTem = kelvinTemp - 273.15;
                    feelLike.Text = celsiusTem.ToString() + "°C";

                    double MaxTemp = Info.main.temp_max;
                    double celsiusTemMax = MaxTemp - 273.15;
                    MaxTem.Text = celsiusTemMax.ToString() + "°C";

                    double MinTempra = Info.main.temp_min;
                    double celsiusTemMin = MinTempra - 273.15;
                    MinTemp.Text = celsiusTemMax.ToString() + "°C";


                    Pressure.Text = Info.main.pressure.ToString();
                    humidityText.Text = Info.main.humidity.ToString();

                    WindSpeed.Text = Info.wind.speed.ToString();
                    allClouds.Text = Info.clouds.all.ToString();

                    SunRise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                    SunSetText.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

                    Country.Text = Info.sys.country.ToString();

                    WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(json);

                    string cityName = weatherInfo.name;

                    City.Text = cityName;

                    MessegeBoxE.Text = "Loaded Data from Server";


                    lata = Info.coord.lat;
                    latu = Info.coord.lon;

                }
            }
            catch (Exception ex)
            {

                MessegeBoxE.Text = ex.Message;
            }
        }


        void getDailyWeather()
        {
            try
            {

                using (WebClient web = new WebClient())
                {


                    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}", lata, latu, APIKEY);

              
                    var json = web.DownloadString(url);
                    Daily_forecast.ForecastInfo ForecastINfo = JsonConvert.DeserializeObject<Daily_forecast.ForecastInfo>(json);

                    Forecast7D FUC;


                    for (int i = 0; i < 7; i++)
                    {
                        FUC = new Forecast7D();

                        FUC.weathericon.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[i].weather[0].icon + ".png";
                        FUC.DayLable.Text = convertDateTime(ForecastINfo.list[i].dt).DayOfWeek.ToString();
                        //FUC.temp.Text = ForecastINfo.list[i].
                        FUC.mainDes.Text = ForecastINfo.list[i].weather[0].main;


                        double kelvinTemperature = ForecastINfo.list[i].main.temp;
                        double celsiusTemperature = kelvinTemperature - 273.15;

                        // Convert the temperature to string and assign it to weatherText.Text
                        FUC.temp.Text = celsiusTemperature.ToString() + "°C";

                       // flowLayoutPanel1.Controls.Add(FUC);

                    }


                    MessegeBoxE.Text = "Loaded Data from Server";

                }
            }
            catch (Exception ex)
            {

                MessegeBoxE.Text = ex.Message;
            }

        }

        void GetDaily()
        {
            try
            {

                using (WebClient web = new WebClient())
                {


                    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}", lata, latu, APIKEY);

                    //download weather in json object
                    var json = web.DownloadString(url);
                    Daily_forecast.ForecastInfo ForecastINfo = JsonConvert.DeserializeObject<Daily_forecast.ForecastInfo>(json);


                    icon0.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[0].weather[0].icon + ".png";
                    icon1.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[1].weather[0].icon + ".png";
                    icon2.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[2].weather[0].icon + ".png";
                    icon3.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[3].weather[0].icon + ".png";
                    icon4.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[4].weather[0].icon + ".png";
                    icon5.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[5].weather[0].icon + ".png";
                    icon6.ImageLocation = "https://api.openweathermap.org/img/w/" + ForecastINfo.list[6].weather[0].icon + ".png";


                    //DayText0.Text = convertDateTime(ForecastINfo.list[0].dt).DayOfWeek.ToString();
                    //DayText1.Text = convertDateTime(ForecastINfo.list[1].dt).DayOfWeek.ToString();
                    //DayText2.Text = convertDateTime(ForecastINfo.list[2].dt).DayOfWeek.ToString();
                    //DayText3.Text = convertDateTime(ForecastINfo.list[3].dt).DayOfWeek.ToString();
                    //DayText4.Text = convertDateTime(ForecastINfo.list[4].dt).DayOfWeek.ToString();
                    //DayText5.Text = convertDateTime(ForecastINfo.list[5].dt).DayOfWeek.ToString();
                    //DayText6.Text = convertDateTime(ForecastINfo.list[6].dt).DayOfWeek.ToString();

                    mainDes0.Text = ForecastINfo.list[0].weather[0].main;
                    mainDes1.Text = ForecastINfo.list[1].weather[0].main;
                    mainDes2.Text = ForecastINfo.list[2].weather[0].main;
                    mainDes3.Text = ForecastINfo.list[3].weather[0].main;
                    mainDes4.Text = ForecastINfo.list[4].weather[0].main;
                    mainDes5.Text = ForecastINfo.list[5].weather[0].main;
                    mainDes6.Text = ForecastINfo.list[6].weather[0].main;


                    double kelvinTemperature1 = ForecastINfo.list[0].main.temp;
                    double celsiusTemperature1 = kelvinTemperature1 - 273.15;
                    temp0.Text = celsiusTemperature1.ToString() + "°C";

                    double kelvinTemperature = ForecastINfo.list[1].main.temp;
                    double celsiusTemperature = kelvinTemperature - 273.15;
                    temp1.Text = celsiusTemperature.ToString() + "°C";

                    double kelvinTempera = ForecastINfo.list[2].main.temp;
                    double celsiusTemperatur = kelvinTempera - 273.15;
                    temp2.Text = celsiusTemperatur.ToString() + "°C";


                    double kelvinTemperature3 = ForecastINfo.list[3].main.temp;
                    double celsiusTemperature3 = kelvinTemperature3 - 273.15;
                    temp3.Text = celsiusTemperature3.ToString() + "°C";

                    double kelvinTemperatur4 = ForecastINfo.list[4].main.temp;
                    double celsiusTemperature4 = kelvinTemperatur4 - 273.15;
                    temp4.Text = celsiusTemperature4.ToString() + "°C";

                    double kelvinTempera5 = ForecastINfo.list[5].main.temp;
                    double celsiusTemperatur5 = kelvinTempera5 - 273.15;
                    temp5.Text = celsiusTemperatur5.ToString() + "°C";
                   


                    double kelvinTemperature6 = ForecastINfo.list[6].main.temp;
                    double celsiusTemperature6 = kelvinTemperature6 - 273.15;
                    temp6.Text = celsiusTemperature6.ToString() + "°C";


                    MessegeBoxE.Text = "Loaded Data from Server";

                }
            }
            catch (Exception ex)
            {

                MessegeBoxE.Text = ex.Message;
            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToShortTimeString();
            CurrentDate.Text = DateTime.Now.ToShortDateString();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel25_Click(object sender, EventArgs e)
        {

        }

        private void LocationBtn_Click(object sender, EventArgs e)
        {
            GetLocationClilck();
            // getDailyWeather();
            GetDaily();
        }

        private void feelLike_Click(object sender, EventArgs e)
        {

        }

        private void GetCityName_Enter(object sender, EventArgs e)
        {
            getWeather();
            // getDailyWeather();
            GetDaily();
        }

        private void DayText0_Click(object sender, EventArgs e)
        {

        }
    }
}
