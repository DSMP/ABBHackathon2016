using ABBhack.Data;
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

        public static void cofnij()
        {
            refWeb.GoBack();
        }


        private async void WebView_Navigating(object sender, WebNavigatedEventArgs e)
        {
            if (e.Url.Contains("/game/hidingok/"))
            {
                int pointer = e.Url.Length - 1;
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
                //var d = restService.DeviceData.FotoResistor
                //var dataToSend = new Device { }
                //restService.DeviceData.


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
