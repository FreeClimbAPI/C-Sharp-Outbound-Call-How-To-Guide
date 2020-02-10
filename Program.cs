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
            string acctToken = getAuthToken ();
            FreeClimbClient client = new FreeClimbClient (acctId, acctToken);
            Console.WriteLine(acctId);
            Console.WriteLine(acctToken);
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

        private static string getAuthToken () {
          return System.Environment.GetEnvironmentVariable("AUTH_TOKEN");
        }

    }
}
