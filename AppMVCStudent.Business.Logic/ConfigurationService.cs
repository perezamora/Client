using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppMVCStudent.Business.Logic
{
    public class ConfigurationService
    {
        public static HttpClient InitClient(HttpClient client)
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings[Resources.Config.basendpoint]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}
