﻿using ABBhack.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ABBhack.Data
{
    class RestService
    {
        HttpClient client;

        public IoTDevice DeviceData { get; protected set; }

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task GetDeviceData()
        {
            string restUrl = "http://192.168.4.1";
            var uri = new Uri(restUrl);
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                DeviceData = JsonConvert.DeserializeObject<IoTDevice>(content);
            }
        }

        public async Task PostDeviceData(Device d)
        {
            string restUrl = "http://dragonsiodev.azurewebsites.net/device/update";
            var uri = new Uri(restUrl);
            StringContent c = new StringContent(JsonConvert.SerializeObject(d));
            await client.PostAsync(uri, c);
            string s = "kutas";
        }
    }
}
