using Android.App;
using Android.Content;
using Android.Net.Wifi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABBhack
{
    class confwifirifi
    {
        String SSID = "DragonsIO";
        //String Pswd = "";

        //WifiConfiguration conf;

        public confwifirifi()
        {
            //StartActivity(new Intent(Settings.ActionWifiSettings));
            //return;
            WifiManager wifiManager = (WifiManager)Application.Context.GetSystemService(Context.WifiService);
            wifiManager.SetWifiEnabled(true);

            WifiConfiguration wifiConfig = new WifiConfiguration();
            wifiConfig.Ssid = string.Format("\"{0}\"", SSID);
            wifiConfig.AllowedKeyManagement.Set(0);
            //wifiConfig.Ssid = SSID;
            //wifiConfig.PreSharedKey = string.Format("\"{0}\"", Pswd);
            //wifiConfig.PreSharedKey = "\"\"";

            wifiManager.AddNetwork(wifiConfig);


            int netId = wifiManager.AddNetwork(wifiConfig);
            //wifiManager.SaveConfiguration();
            wifiManager.Disconnect();
            wifiManager.EnableNetwork(netId, true);
            wifiManager.Reconnect();

            //List<WifiConfiguration> list = (List<WifiConfiguration>)wifiManager.ConfiguredNetworks;
            //foreach (WifiConfiguration i in list)
            //{
            //    if (i.Ssid != null && i.Ssid.Equals("\"" + SSID + "\""))
            //    {
            //        wifiManager.Disconnect();
            //        wifiManager.EnableNetwork(i.NetworkId, true);
            //        wifiManager.Reconnect();
            //        break;
            //    }
            //}
        }
       
    }
}
