using System;

namespace SiteProject.Infrastructure.Models
{
    public class ArticleTag : BaseEntity
    {
        public Guid ArticleID { get; set; }
        public Guid TagID { get; set; }

        public virtual Article Article { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
