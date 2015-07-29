namespace MVCDealershipProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVCDealershipProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDealershipProject.Models.VehicleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCDealershipProject.Models.VehicleDBContext";
        }

        protected override void Seed(MVCDealershipProject.Models.VehicleDBContext context)
        {

            context.Vehicles.AddOrUpdate(i => i.ID,
            new Vehicle
            {
                Make="Ford",
                Model="Taurus",
                Year=2014,
                Color="Black",
                MilePerGallon=25,
                MSRP =20000,
                Image="~/images/2.jpg"
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
