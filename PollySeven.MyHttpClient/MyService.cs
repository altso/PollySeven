using System;
using System.Net.Http;
using Polly;

namespace PollySeven.MyHttpClient
{
    public class MyService
    {
        private readonly HttpClient _httpClient;

        public MyService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // emulate an explicit dependency on Polly
            var policy = Policy.Handle<Exception>().RetryAsync();
        }
    }
}
