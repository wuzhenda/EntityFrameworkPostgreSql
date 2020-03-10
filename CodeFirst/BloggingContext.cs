using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<MJSensorData> MJSensorDatas { get; set; }

        //"Host=10.0.0.155:15432;Database=mjsensor;Username=postgres;Password=postgres"
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=10.0.0.155;Port=15432; Database=mjsensor;Username=postgres;Password=123456");
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string Reader { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
