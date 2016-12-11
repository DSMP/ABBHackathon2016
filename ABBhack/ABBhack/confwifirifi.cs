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
        String Pswd = "";

        WifiConfiguration conf;

        public confwifirifi()
        {
            conf = new WifiConfiguration();
            conf.Ssid = "\"" + SSID + "\"";
            conf.WepKeys[0] = "\"" + Pswd + "\"";
            conf.WepTxKeyIndex = 0;
            conf.AllowedKeyManagement.Set(0); //WifiConfiguration.KeyMgmt.None
                                              //conf.AllowedGroupCiphers.Set(0); //WifiConfiguration.GroupCipher.Wep40

            WifiManager wifiManager = (WifiManager)Context.WifiService;
            wifiManager.AddNetwork(conf);

            List<WifiConfiguration> list = (List<WifiConfiguration>)wifiManager.ConfiguredNetworks;
            for (WifiConfiguration i : list)
            {
                if (i.Ssid != null && i.Ssid.equals("\"" + SSID + "\""))
                {
                    wifiManager.Disconnect();
                    wifiManager.EnableNetwork(i.networkId, true);
                    wifiManager.Reconnect();

                    break;
                }
            }
        }
       
    }
}
