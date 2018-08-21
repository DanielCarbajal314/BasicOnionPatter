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
            DocumentContext db = new DocumentContext();
            Document document = new Document();
            document.Description = "asdasd";            
            db.Documents.Add(document);
            db.SaveChanges();
        }
    }
}
