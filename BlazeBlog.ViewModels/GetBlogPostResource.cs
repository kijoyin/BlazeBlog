using System;

namespace BlazeBlog.ViewModels
{
    public class GetBlogPostResource
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
    }
}
