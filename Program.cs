using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

/*  Instructions

dotnet new webapi -n SimpleAPI
dotnet new xunit -n SimpleAPI.Tests
dotnet sln SimpleAPI.sln add ./SimpleAPI/SimpleAPI.csproj ./SimpleAPI.Tests/SimpleAPI.Tests.csproj
dotnet add ./SimpleAPI.Tests/SimpleAPI.Tests.csproj reference ./SimpleAPI/SimpleAPI.csproj

*/





namespace SimpleAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
