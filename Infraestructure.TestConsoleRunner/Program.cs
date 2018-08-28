using Domain.Entities;
using Infraestructure.SQLServerRepository.DocumentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.TestConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
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
