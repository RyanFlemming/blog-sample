using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSampleApp.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public List<Post> Posts { get; set; }
    }
}