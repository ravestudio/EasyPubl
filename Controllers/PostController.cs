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
                posts = db.Posts.ToList();
            }

            return posts;
        }
    }
}