using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.SQLServerRepository.DocumentDB.SeedData
{
    public class DocumentManagementDbInitializer:DropCreateDatabaseAlways<DocumentContext>
    {
        protected override void Seed(DocumentContext context)
        {
            context.Users.Add(new User()
            {
                Login = "SystemAdmin",
                Email = "SystemAdmin@company.com",
                LastNames = "Admin",
                Names = "System",
                Password = "123@123@"
            });
            base.Seed(context);
        }
    }
}
