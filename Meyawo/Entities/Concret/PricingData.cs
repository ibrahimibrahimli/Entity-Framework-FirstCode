using Meyawo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.Entities.Concret
{
    public class PricingData : BaseEntity
    {
        public string Text { get; set; }
        public int PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }
    }
}
