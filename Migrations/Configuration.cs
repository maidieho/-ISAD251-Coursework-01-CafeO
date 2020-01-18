using System.Collections.Generic;
using CafeO.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CafeO.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CafeO.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CafeO.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (!context.Products.Any())
            {
                var productType = new List<ProductType>
                {
                    new ProductType { Name = "Tea" },
                    new ProductType { Name = "Cake" },
                };

                new List<Product>
                {
                    new Product { Name = "Earl Grey", ProductType = productType.Single(c => c.Name == "Tea"), Price = 1.99M, ImagePath = "/Content/Images/EarlGrey.gif", IsAvailable = true},
                    new Product { Name = "English Breakfast", ProductType = productType.Single(c => c.Name == "Tea"), Price = 1.99M, ImagePath = "/Content/Images/EnglishBreakfast.gif", IsAvailable = true },
                    new Product { Name = "Victoria Sponge", ProductType = productType.Single(c => c.Name == "Cake"), Price = 2.99M, ImagePath = "/Content/Images/VictoriaSponge.gif", IsAvailable = true },
                    new Product { Name = "Battenberg cake", ProductType = productType.Single(c => c.Name == "Cake"), Price = 2.99M, ImagePath = "/Content/Images/BattenbergCake.gif", IsAvailable = true },
                }.ForEach(p => context.Products.AddOrUpdate(p));
                context.SaveChanges();
            }

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser { UserName = "admin@cafe.com" };
                var guestUser = new ApplicationUser { UserName = "guest@cafe.com" };

                userManager.Create(user, "admin123"); //strong password!#@$!
                userManager.Create(guestUser, "guest123"); //strong password!#@$!

                roleManager.Create(new IdentityRole { Name = "Admin" });
                userManager.AddToRole(user.Id, "Admin");

                context.SaveChanges();
            }
        }
    }
}
