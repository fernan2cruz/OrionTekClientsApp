﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionTekClients.Common.Models
{
    public class Client : BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }

        
    }
}
