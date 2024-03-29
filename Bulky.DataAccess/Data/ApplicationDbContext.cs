﻿
using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //ham nay de them data tu code
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1 ,Name="Action",DisplayOrder=1},
                new Category { Id = 2 ,Name="SciFi",DisplayOrder=2},
                new Category { Id = 3 ,Name="History",DisplayOrder=3}

                );
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tech Solution", PhoneNumber = "0019283924",City="Ha Noi",State="Viet Nam",StreetAddress="Duy Tan, Cau giay",PostalCode="0019" },
                new Company { Id = 2, Name = "Natural Benefit", PhoneNumber = "00192242924",City="Hai Phong",State="Viet Nam",StreetAddress="Vinh Yen",PostalCode="0239" },
                new Company { Id = 3, Name = "Lets Get Start", PhoneNumber = "0192242924",City="Ca Mau",State="Viet Nam",StreetAddress="Can Tho ",PostalCode="8391" }


                );
            modelBuilder.Entity<Product>().HasData(
                    new Product 
                    { 
                        Id = 1 ,
                        Title="Fortune of Time",
                        Author="Billy Parker",
                        Description="Prasent vitae sodales libero ",
                        ISBN="SORJ111101",
                        ListPrice=99,
                        Price=90,
                        Price50=85,
                        Price100=80,
                        CategoryId=1,
                        ImageUrl=""
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "Prasent vitae sodales libero ",
                        ISBN = "SORJ111101",
                        ListPrice = 72,
                        Price = 70,
                        Price50 = 65,
                        Price100 = 60,
                        CategoryId = 2,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "Prasent vitae sodales libero ",
                        ISBN = "SORJ111101",
                        ListPrice = 30,
                        Price = 27,
                        Price50 = 25,
                        Price100 = 20,
                        CategoryId = 2,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "Prasent vitae sodales libero ",
                        ISBN = "SORJ111101",
                        ListPrice = 37,
                        Price = 35,
                        Price50 = 30,
                        Price100 = 20,
                        CategoryId = 3,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "Prasent vitae sodales libero ",
                        ISBN = "SORJ111101",
                        ListPrice = 60,
                        Price = 57,
                        Price50 = 55,
                        Price100 = 50,
                        CategoryId = 1,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "Prasent vitae sodales libero ",
                        ISBN = "SORJ111101",
                        ListPrice = 30,
                        Price = 27,
                        Price50 = 25,
                        Price100 = 20,
                        CategoryId = 3,
                        ImageUrl = ""
                    }
                );
        }
    }
}
