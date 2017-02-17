using System.Collections.Generic;

namespace SiteProject.Infrastructure.Models
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }
}
