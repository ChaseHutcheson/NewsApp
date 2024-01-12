using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Models;
using Newtonsoft.Json;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=70732fb825be93b59eecbf18254fdca0&topic=breaking-news&lang=en");

            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
