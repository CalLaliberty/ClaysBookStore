using ClaysBooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace ClaysBookStore.DataAccess.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                if (context.Products.Any())
                {
                    return;
                }

                context.Products.AddRange(
                    new Product
                    {
                        Title = "Batman Hush",
                        Description = "Batman Hush comic",
                        ISBN = "9788573512441",
                        Author = "Jeph Loeb",
                        ListPrice = 25.99,
                        ImageUrl = "/images/products/BatmanHush.jpg",
                        CategoryId = 36,
                        CoverTypeId = 14
                    },
                    new Product
                    {
                        Title = "Batman The Long Halloween",
                        Description = "Batman The Long Halloween comic",
                        ISBN = "9781840230543",
                        Author = "Jeph Loeb",
                        ListPrice = 25.99,
                        ImageUrl = "/images/products/BatmanLongHalloween.jpg",
                        CategoryId = 36,
                        CoverTypeId = 14
                    },
                    new Product
                    {
                        Title = "Batman The Killing Joke",
                        Description = "Batman The Killing Joke comic",
                        ISBN = "9780930289454",
                        Author = "Alan Moore",
                        ListPrice = 25.99,
                        ImageUrl = "/images/products/BatmanKillingJoke.jpg",
                        CategoryId = 36,
                        CoverTypeId = 14
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
