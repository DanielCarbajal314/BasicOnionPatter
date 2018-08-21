using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.SQLServerRepository.DocumentDB
{
    public class DocumentContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }

        public DocumentContext() : base("DocumentDb") {

        }

    }
}
