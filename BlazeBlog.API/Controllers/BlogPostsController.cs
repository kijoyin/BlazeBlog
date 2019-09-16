using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazeBlog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazeBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly ILogger<BlogPostsController> _logger;
        public BlogPostsController(ILogger<BlogPostsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GetBlogPostResource> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new GetBlogPostResource
            {
                Content = "Some random content",
                Slug = "some-content",
                Tags = "test,sample",
                Title = $"This is post number {index}"
            })
            .ToArray();
        }
    }
}