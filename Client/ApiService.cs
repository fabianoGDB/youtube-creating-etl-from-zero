using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace youtube_etl_do_zero.Client
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        public IApiService Client { get; }

        public ApiService(string url, string urlAuth)
        {
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(35),
                BaseAddress = new Uri(url),
            };

            Client = RestService.For<IApiService>(_httpClient);
        }
    }
}