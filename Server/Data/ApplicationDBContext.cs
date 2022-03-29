using BlazorCRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
