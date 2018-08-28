using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyPubl.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace EasyPubl.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            IEnumerable<Post> posts = null;

            using(var db = new BloggingContext())
            {
                posts = db.Posts.Select(p => new Post() {
                    PostId = p.PostId, 
                    Title = p.Title,
                    Permalink = p.Permalink,
                    CreateDate = p.CreateDate,
                    Excerpt = p.Excerpt }).ToList();
            }

            return posts;
        }

        [HttpGet("{permalink}")]
        public Post GetByPermalink(string permalink)
        {
            Post result = null;

            using(var db = new BloggingContext())
            {
                result = db.Posts.Single(p => p.Permalink == permalink);
            }

            return result;
        }
    }
}