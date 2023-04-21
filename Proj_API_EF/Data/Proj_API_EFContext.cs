using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proj_API_EF.Models;

namespace Proj_API_EF.Data
{
    public class Proj_API_EFContext : DbContext
    {
        public Proj_API_EFContext (DbContextOptions<Proj_API_EFContext> options)
            : base(options)
        {
        }

        public DbSet<Proj_API_EF.Models.Animal> Animal { get; set; } = default!;

        public DbSet<Proj_API_EF.Models.Client>? Client { get; set; }

        public DbSet<Proj_API_EF.Models.Address>? Address { get; set; }
    }
}
