using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace MakeOutboundCall
{
    public class Program
    {
        private static string getAcctId()
        {
            return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
        }

        private static string getApiKey()
        {
            return System.Environment.GetEnvironmentVariable("API_KEY");
        }
        private static string getFromNumber()
        {
            return System.Environment.GetEnvironmentVariable("FROM_NUMBER");
        }
        private static string getToNumber()
        {
            return System.Environment.GetEnvironmentVariable("TO_NUMBER");
        }
        private static string getAppID()
        {
            return System.Environment.GetEnvironmentVariable("APP_ID");
        }
        private static string getCallConnectURL()
        {
            return System.Environment.GetEnvironmentVariable("CALL_CONNECT_URL");
        }
        public static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = getAcctId();
            config.Password = getApiKey();

            var apiInstance = new DefaultApi(config);
            string to = getToNumber();
            string from = getFromNumber();
            string appId = getAppID();
            string callConnectUrl = getCallConnectURL();
            MakeCallRequest makeCallRequest = new MakeCallRequest(from, to, appId, null, null, null, 30, null, false, callConnectUrl);
            apiInstance.MakeACall(makeCallRequest);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();



    }
}
