using Domain.Entities;
using Infraestructure.SQLServerRepository.DocumentDB;
using Infraestructure.SQLServerRepository.DocumentDB.SeedData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.TestConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<DocumentContext>(new DocumentManagementDbInitializer());
            using (DocumentContext documentDb = new DocumentContext())
            {
                documentDb.Clients.ToList().ForEach(x =>
                {
                    Console.WriteLine(x.Name);
                });
                Console.ReadKey();
            }
        }
    }
}
