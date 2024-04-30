using Meyawo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.Entities.Concret
{
    public class Like : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
