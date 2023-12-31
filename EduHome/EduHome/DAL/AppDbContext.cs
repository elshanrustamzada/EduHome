﻿using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Header> Header { get; set; }
        public DbSet<Footer> Footer { get; set; }

    }
}
