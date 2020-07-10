using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
    public class AppDbcontext :DbContext
    {
        private readonly IConfiguration _config;
        public AppDbcontext(DbContextOptions options, IConfiguration config) : base(options)
        {
            this._config = config;
        }
        public DbSet<Details> Details { get; set; }
        public DbSet<Signup> Signups { get; set; }
        public DbSet<Books> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("Datas"));
        }
        protected override void OnModelCreating(ModelBuilder bldr)
        {
            
            bldr.Entity<Details>().HasData(new Details { Id =1 ,UserName = "Admin", Password = "admin" });
            bldr.Entity<Signup>().HasData(new Signup { Id = 1, UserName = "Nengi", Password = "nengi", Password1 = "nengi" });
        }

        }
    }
