using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PostTag
    {
        [Key]
        public int PostTagID { get; set; }
        public int PostID { get; set; }
        public int TagID { get; set; }
        public Tag Tag { get; set; }
        public Post Post { get; set; }
    }
}
