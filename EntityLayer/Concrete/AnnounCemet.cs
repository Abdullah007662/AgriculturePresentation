using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnnounCemet
    {    
        public int AnnounCemetID { get; set; }
        public string? AnnounCemetTitle { get; set; }
        public string? AnnounCemetDescription { get; set; }
        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
