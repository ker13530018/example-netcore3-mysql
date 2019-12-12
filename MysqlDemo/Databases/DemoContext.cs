using System;
using Microsoft.EntityFrameworkCore;
using MysqlDemo.Models;

namespace MysqlDemo.Databases
{
    public class DemoContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DemoContext(DbContextOptions<DemoContext> options) : base(options) { }

      
    }
}
