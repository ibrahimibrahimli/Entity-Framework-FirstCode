using Meyawo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.Entities.Concret
{
    public class Service : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
