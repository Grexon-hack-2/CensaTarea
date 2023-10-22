using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCustomer.CapaEntidad
{
    public class CustomerModel
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set;}
        public string? Picture { get; set;}
    }
}
