using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RiskOfRainTracker.Models;

namespace RiskOfRainTracker.Data
{
    public class RiskOfRainTrackerContext : DbContext
    {
        public RiskOfRainTrackerContext (DbContextOptions<RiskOfRainTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<RiskOfRainTracker.Models.RunAttributes> RunAttributes { get; set; } = default!;
    }
}
