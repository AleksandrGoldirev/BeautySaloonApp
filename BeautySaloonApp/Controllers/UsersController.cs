using BeautySaloonApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonApp.Controllers
{
    class UsersController
    {
        /// <summary>
        /// Получение списка пользователей
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public List<Users> GetUsers()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootURL}Users").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Users>>(content.Result);
                return answer;
            }

        }

        // http://127.0.0.1:55891/api/Users/adad/adad
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="login">Строка с логином пользователя</param>
        /// <param name="password">Строка с паролем пользователя</param>
        /// <returns></returns>
        public bool Auth(string login, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootURL}Users/{login}/{password}").Result;
                return response.IsSuccessStatusCode;
            }
        }

        /// <summary>
        /// Добавление пользователя в таблицу при регистрации
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool AddUser(Users user)
        {
            string jsonStr = JsonConvert.SerializeObject(user);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync($"{Manager.RootURL}Users", byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
