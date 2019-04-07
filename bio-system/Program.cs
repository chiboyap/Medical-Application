using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using bio_system;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleApp.NewDb

{
    class Program
    {

        static void Main(string[] args)
        {
            /* using (var db = new Patient())
             {
                 //db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });

                 var count = db.SaveChanges();
                 Console.WriteLine("{0} records saved to database", count);

                 Console.WriteLine();
                 Console.WriteLine("All blogs in database:");
                 foreach (var Patient in db.Patients)
                 {
                     Console.WriteLine(" - {0}");
                 }
             }
             using (var db = new User())
             {
                 //db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });

                 var count = db.SaveChanges();
                 Console.WriteLine("{0} records saved to database", count);

                 Console.WriteLine();
                 Console.WriteLine("All blogs in database:");
                 foreach (var User in db.Users)
                 {
                     Console.WriteLine(" - {0}");
                 }
             
         } */
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>();
    }
}

