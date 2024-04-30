﻿using Meyawo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.Entities.Concret
{
    public class About : BaseEntity
    {
        public string Description {  get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
    }
}
