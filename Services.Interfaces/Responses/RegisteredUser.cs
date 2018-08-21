using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Responses
{
    public class RegisteredUser
    {
        public int Id { get; set; }
        public string CompleteName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
