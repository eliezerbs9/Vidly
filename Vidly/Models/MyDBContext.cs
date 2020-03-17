using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MyDBContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Movie> Movies { get; set; }

    }
}