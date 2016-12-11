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
        public MainPage()
        {            
            InitializeComponent();
            confwifirifi conf = new confwifirifi();
            webView.Navigating += WebView_Navigating;

        }

        private async void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.Contains("game/hiding"))
            {
                RestService restService = new RestService();
                await restService.GetDeviceData();
                //restService.DeviceData;
                //webView.
            }
            
            throw new NotImplementedException();
        }
    }
}
