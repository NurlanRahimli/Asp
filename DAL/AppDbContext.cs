using Eterna_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna_backend.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Box> Boxes { get; set; }


    }
}
