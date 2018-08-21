using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User:BaseEntity
    {
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
