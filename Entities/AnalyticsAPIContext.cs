using System;
using CROAnalytics.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CROAnalyticsAPI.Entities
{
    public class AnalyticsAPIContext : IdentityDbContext
    {
        public AnalyticsAPIContext(DbContextOptions<AnalyticsAPIContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
