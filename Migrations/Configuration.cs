﻿using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ClothesWebNET.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<ClothesWebNET.Models.CLOTHESEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClothesWebNET.Models.CLOTHESEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}