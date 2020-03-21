using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MyDBContext : IdentityDbContext<ApplicationUser>
    {
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Movie> Movies { get; set; }
       public DbSet<MembershipType> MembershipTypes { get; set; }
       public DbSet<Genre> Genres { get; set; }


        public MyDBContext()
            : base("Vidly.Models.MyDBContext", throwIfV1Schema: false)
        {
        }

        public static MyDBContext Create()
        {
            return new MyDBContext();
        }

    }
}