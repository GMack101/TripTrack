using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TripTrack.Models;

namespace TripTrack.Data
{
    public class DestinationDbContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<CodeCategory> CodeCategories { get; set; }

        public DestinationDbContext(DbContextOptions<DestinationDbContext> options)
            : base(options)

            


        {
        
        }
    }
}
