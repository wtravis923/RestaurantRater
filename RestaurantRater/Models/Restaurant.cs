using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        //RestaurantID will be the primary key; the identifier.
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
    }

    // : is the inheritance symbol; if you get an error, you'll need to Ctrl . to add a using statement.
    public class RestaurantDBContext : DbContext
    {
        //This sets a table that uses restaurant (class) as a guide. Columns for all properties. Will use first property as a primary key. 
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}