using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ArticleTagMap());
            modelBuilder.Configurations.Add(new EditorMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new AuthorProfileMap());
            modelBuilder.Configurations.Add(new TagMap());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticlesTags { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorProfile> Profiles { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
