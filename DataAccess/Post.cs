using System;

namespace EasyPubl.DataAccess
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Permalink {get; set;}
        public DateTime CreateDate {get; set;}
        public string Excerpt {get; set;}
        public string Content { get; set; }
    }
}