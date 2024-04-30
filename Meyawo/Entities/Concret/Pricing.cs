using Meyawo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.Entities.Concret
{
    public class Pricing : BaseEntity
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

    }
}
