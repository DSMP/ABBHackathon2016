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


        private void WebView_Navigating(object sender, WebNavigatedEventArgs e)
        {
            if (e.Url.Contains("google"))
            {
                //RestService restService = new RestService();
                //await restService.GetDeviceData();
                //int id = e.Url[e.Url.Length - 1];

                //webView.Navigation.
                //webView.Source = new UrlWebViewSource { Url = "http://reddit.com/" };
                //webView.IsEnabled = false;
                //webView.IsEnabled = true;

                //webView = new WebView
                //{
                //    Source = new UrlWebViewSource
                //    {
                //        Url = "http://reddit.com/"
                //    },
                //    VerticalOptions = LayoutOptions.FillAndExpand
                //};
                webView = null;
                //e = new WebNavigatingEventArgs(e.NavigationEvent,e.Source,new Uri("http://reddit.com").ToString());
                //e = null;
            }
        }
    }
}
