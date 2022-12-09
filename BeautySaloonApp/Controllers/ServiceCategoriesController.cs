using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonApp.Models;
using Newtonsoft.Json;

namespace BeautySaloonApp.Controllers
{
    class ServiceCategoriesController
    {
        public static List<ServiceCategoryes> GetServiceCategoryes()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootURL}ServiceCategoryes").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
                return answer;
            }

        }
    }
}
