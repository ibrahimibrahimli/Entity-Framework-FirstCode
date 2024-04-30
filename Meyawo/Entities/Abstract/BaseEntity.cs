using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.Entities.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Deleted { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
