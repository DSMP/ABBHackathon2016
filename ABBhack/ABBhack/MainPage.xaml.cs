using ABBhack.Data;
using Android.Content;
using Android.Locations;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ABBhack
{
    public partial class MainPage : ContentPage
    {
        static WebView refWeb;
        public MainPage()
        {
            InitializeComponent();
            refWeb = webView;
            confwifirifi conf = new confwifirifi();
            webView.Navigated += WebView_Navigating;

        }

        async Task<Position> Lokacja()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            return position;

            //Console.WriteLine("Position Status: {0}", position.Timestamp);
            //Console.WriteLine("Position Latitude: {0}", position.Latitude);
            //Console.WriteLine("Position Longitude: {0}", position.Longitude);
        }

        public static void cofnij()
        {
            refWeb.GoBack();
        }


        private async void WebView_Navigating(object sender, WebNavigatedEventArgs e)
        {
            if (e.Url.Contains("/game/hidingok/"))
            {
                int pointer = e.Url.Length - 2;
                int id = 0;
                int multiplier = 1;
                while (IsNumber(e.Url[pointer]))
                {
                    id += Convert.ToInt32(e.Url[pointer]) * multiplier;
                    multiplier *= 10;
                    pointer--;
                }

                RestService restService = new RestService();
                await restService.GetDeviceData();
                //Position p = (Position)await Lokacja();
                Models.Device dataToSend = new Models.Device
                {
                    ID = id,
                    Humidity = restService.DeviceData.Humidity,
                    //todo

                    //Latitude = p.Latitude,
                    //Longtitude = p.Longitude,
                    Latitude = 1,
                    Longtitude = 1,
                    Light = restService.DeviceData.FotoResistor,
                    Temperature = restService.DeviceData.Temperature
                };
                await restService.PostDeviceData(dataToSend);
            }
        }
                private bool IsNumber(char c)
        {
            if (c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9')
                return false;
            return true;
        }
    }
}
