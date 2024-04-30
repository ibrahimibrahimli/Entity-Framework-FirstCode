using Meyawo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.Entities.Concret
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public int LikeCount { get; set; }
        public int CommentsId { get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public virtual Comment Comment { get; set; }
        
    }
}
