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
        static WebView refweb;
        public MainPage()
        {            
            InitializeComponent();
            confwifirifi conf = new confwifirifi();
            refweb = webView;
            
        }
        
        public static void cofnij()
        {
            refweb.GoBack();
        }
    }
}
