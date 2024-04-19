using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuanLyShop.Models;

namespace QuanLyShop.Data
{
    public class QuanLyShopContext : IdentityDbContext
    {
        public QuanLyShopContext (DbContextOptions<QuanLyShopContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customer { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
               .HasOne<Product>(p => p.Product)
               .WithMany(c => c.OrderDetails)
               .HasForeignKey(ad => ad.ProductId);

            modelBuilder.Entity<Product>()
                .HasOne<Category>(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(ad => ad.CateId);

            modelBuilder.Entity<Product>()
               .HasOne(e => e.Brand)
               .WithMany(d => d.Products)
               .HasForeignKey(e => e.BrandId);

            modelBuilder.Entity<OrderDetail>()
               .HasOne(e => e.Order)
               .WithMany(d => d.OrderDetails)
               .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Order>()
                 .HasOne(e => e.Customer)
                 .WithMany(d => d.Orders)
                 .HasForeignKey(e => e.CustomerId);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<QuanLyShop.Models.OrderDetail> OrderDetail { get; set; }
    }
}
