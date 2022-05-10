using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionTekClients.Common.Models
{
    public class Address : BaseModel
    {
        public string City { get; set; }
        public string Address { get; set; }
    }
}
