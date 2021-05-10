using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using com.freeclimb;
using com.freeclimb.api;

namespace MakeOutboundCall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string acctId = getAcctId ();
            string apiKey = getApiKey ();
            FreeClimbClient client = new FreeClimbClient (acctId, apiKey);
            Console.WriteLine(acctId);
            Console.WriteLine(apiKey);
            string to = "";
            string from = "";
            string appId = "";
            client.getCallsRequester.create(to, from, appId );
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        private static string getAcctId () {
            return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
        }

        private static string getApiKey () {
          return System.Environment.GetEnvironmentVariable("API_KEY");
        }

    }
}
