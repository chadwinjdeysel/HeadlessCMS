using ContentManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Model> Models { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Content> Contents { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Field>()
                .Property(x => x.fieldType)
                .HasConversion<int>();

            builder.Entity<Content>()
                .Property(x => x.Contents)
                .HasColumnType("text");

            base.OnModelCreating(builder);
        }
    }
}
