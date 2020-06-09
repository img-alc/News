using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.Entities
{
    public class Article
    {
        public NewsSource Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string ImageURL { get; set; }
        public DateTime PublishedTimestamp { get; set; }
        public string Content { get; set; }
       
    }
}
