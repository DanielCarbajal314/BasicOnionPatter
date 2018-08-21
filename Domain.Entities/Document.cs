using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Document:BaseEntity
    {
        public string Description { get; set; }
        public byte[] Content { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
