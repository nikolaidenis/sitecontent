using System.Data.Entity;
using SiteProject.Infrastructure.Models;

namespace SiteProject.Infrastructure
{
    public class Context: DbContext
    {
        public Context() : base("contextConnection") { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>()
                .HasMany(s => s.ArticleTags)
                .WithRequired(r => r.Article)
                .HasForeignKey(f => f.ArticleID);
            modelBuilder.Entity<Tag>()
                .HasMany(s => s.ArticleTags)
                .WithRequired(r => r.Tag)
                .HasForeignKey(f => f.TagID);
        }
    }
}
