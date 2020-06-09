using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.Entities
{
    public class NewsSource
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
    }
}
