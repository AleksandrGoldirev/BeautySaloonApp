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
     class ServicesController
    {
        /// <summary>
        /// вывод всех сервисов
        /// </summary>
        /// <returns></returns>
        public static List<Services> GetServices()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootURL}Services").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;
            }

        }

        /// <summary>
        /// вывод сервисов по категориям
        /// </summary>
        /// <param name="categoryId">
        /// идентификатор категории
        /// </param>
        /// <returns></returns>
        public static List<Services> GetCategoryServices(int categoryId)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootURL}Services/categories/{categoryId}").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;
            }
        }

        /// <summary>
        /// вывод сервисов по id
        /// </summary>
        /// <param name="id">
        /// идентификатор сервиса
        /// </param>
        /// <returns></returns>
        public static Services GetServicesID(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootURL}Services/{id}").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<Services>(content.Result);
                return answer;
            }
        }


    }
}
