﻿using Molla_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Molla_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogAuthor> BlogAuthors { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<BrandsInfo> BrandsInfos { get; set; }
        public DbSet<BrandsImage> BrandsImages { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }
        public DbSet<CustomersComment> CustomersComments { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }
}
