﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tag
    {
        [Key]
        public int TagID { get; set; }
        public string TagName { get; set; }
        public List<PostTag> PostTags { get; set; }
    }
}
