using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjBlog.Models.DataModel;
namespace ProjBlog.DataEntity
{
    public class DbEntity : DbContext
    {
        public DbEntity() : base("DefautConnection")
        {

        }
        public DbEntity(string connection) : base(connection)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Banner> Banner { get; set; }

    }
}