using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using youtube_etl_do_zero.Models;

namespace youtube_etl_do_zero.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {

        }

        public DbSet<Albums> Albums { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Todos> Todos { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}