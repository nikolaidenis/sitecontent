using System;
using System.Collections.Generic;

namespace SiteProject.Infrastructure.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string RawText { get; set; }
        public string Annotation { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }
}
