using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnvironmentalChanges.Models;

namespace EnvironmentalChanges.Data
{
    public class EnvironmentalChangesContext : DbContext
    {
        public EnvironmentalChangesContext (DbContextOptions<EnvironmentalChangesContext> options)
            : base(options)
        {
        }

        public DbSet<EnvironmentalChanges.Models.EChange> EChange { get; set; }
    }
}