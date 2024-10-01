using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Address
    {
        public int AddressID { get; set; }
        public string? AddressDescription1 { get; set; }
        public string? AddressDescription2 { get; set; }
        public string? AddressDescription3 { get; set; }
        public string? AddressDescription4 { get; set; }
        public string? MapInfo { get; set; }
    }
}
