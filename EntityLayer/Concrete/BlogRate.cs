using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRate
    {
        public int BlogRateID { get; set; }
        public int BlogID { get; set; }
        public int BlogTScore { get; set; }
        public int BlogRateCount { get; set; }
    }
}
