using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class UpdateUser
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Password { get; set; }
    }
}
