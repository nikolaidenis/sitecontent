using System;
using System.Collections.Generic;
using System.Data.Entity;
using SiteProject.Infrastructure.Models;

namespace SiteProject.Infrastructure
{
    public class Initializer: DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var articles = new List<Article>()
            {
                new Article
                {
                    Title = "Test article",
                    RawText = "<h1 style=\"color: #5e9ca0;\">You can edit <span style=\"color: #2b2301;\">this demo</span> text!</h1><h2 style=\"color: #2e6c80;\">How to use the editor:</h2><p>Paste your documents in the visual editor on the left or your HTML code in the source editor in the right. <br />Edit any of the two areas and see the other changing in real time.&nbsp;</p><p>Click the <span style=\"background-color: #2b2301; color: #fff; display: inline-block; padding: 3px 10px; font-weight: bold; border-radius: 5px;\">Clean</span> button to clean your source code.</p><h2 style=\"color: #2e6c80;\">&nbsp;</h2>",
                    Annotation = "Test annotation",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Article
                {
                    Title = "Test article 2",
                    RawText = "<h1 style=\"color: #5e9ca0;\">You can edit <span style=\"color: #2b2301;\">this demo</span> text!</h1><h2 style=\"color: #2e6c80;\">How to use the editor:</h2><p>Paste your documents in the visual editor on the left or your HTML code in the source editor in the right. <br />Edit any of the two areas and see the other changing in real time.&nbsp;</p><p>Click the <span style=\"background-color: #2b2301; color: #fff; display: inline-block; padding: 3px 10px; font-weight: bold; border-radius: 5px;\">Clean</span> button to clean your source code.</p><h2 style=\"color: #2e6c80;\">&nbsp;</h2>",
                    Annotation = "Test annotation 2",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            };
            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();

            var tags = new List<Tag>
            {
                new Tag { Title = "hello"},
                new Tag { Title = "from"},
                new Tag { Title = "Minsk"},
                new Tag { Title = "article"},
                new Tag { Title = "good"}
            };
            tags.ForEach(t => context.Tags.Add(t));
            context.SaveChanges();
        }
    }
}
