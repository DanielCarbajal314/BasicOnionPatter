﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public class BaseEntityWithStringId
    {
        public string Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
