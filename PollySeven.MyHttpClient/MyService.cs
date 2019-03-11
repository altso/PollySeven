using System;
using Polly;

namespace PollySeven.MyHttpClient
{
    public class MyService
    {
        public MyService()
        {
            // emulate an explicit dependency on Polly
            var policy = Policy.Handle<Exception>().RetryAsync();
        }
    }
}
