using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnailImage { get; set; }
        public string PostImage { get; set; }
        public int PostView { get; set; }
        public DateTime PostCreatedDate { get; set; }
        public bool PostStatus { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }
        public List<PostTag> PostTags { get; set; }
    }
}
