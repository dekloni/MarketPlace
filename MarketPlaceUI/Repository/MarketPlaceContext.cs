//using CustomerManager.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MarketPlaceUI.Models;

namespace MarketPlaceUI.Repository
{
    public class MarketPlaceContext : DbContext
    {
        public MarketPlaceContext()
        {
        }

        static MarketPlaceContext()
        {
            System.Data.Entity.Database.SetInitializer(new MarketPlaceDatabaseInitializer());
        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
    }

    public class MarketPlaceDatabaseInitializer : DropCreateDatabaseIfModelChanges<MarketPlaceContext> // re-creates every time the server starts
    {
        protected override void Seed(MarketPlaceContext context)
        {
            var categories = new List<CategoryModel>();
            categories.Add(new CategoryModel()
            {
                Id = 1,
                Name = "Clothing",
                Description = " Cheap clothing for any day or weather",
                Products = new List<ProductModel>()
                {
                    new ProductModel()
                    {
                        CategoryId = 1,
                        Name = "Jacket",
                         Description = "Super jacket",
                         Price = 99
                    },
                    new ProductModel()
                    {
                        CategoryId = 2,
                        Name = "Trousers",
                         Description = "Very think and dark",
                         Price = 100
                    }
                }
            }
            );

            categories.Add(new CategoryModel()
            {
                Id = 2,
                Name = "Books",
                Description = " Largest range of books on the web",
                Products = new List<ProductModel>()
                {
                    new ProductModel()
                    {
                        CategoryId = 1,
                        Name = "Hobbit",
                         Description = "Hobbit great adventures",
                         Price = 99
                    },
                    new ProductModel()
                    {
                        CategoryId = 2,
                        Name = "Jurassic Park",
                         Description = "Opening new type of zoo",
                         Price = 100
                    }
                }
            }
            );

            context.Categories.Add(categories[0]);
            context.Categories.Add(categories[1]);
            
            //context.Categories = categories.to;

            base.Seed(context);
        }
    }
}