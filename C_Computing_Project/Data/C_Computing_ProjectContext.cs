using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C_Computing_Project.Models;

namespace C_Computing_Project.Data
{
    public class C_Computing_ProjectContext : DbContext
    {
        public C_Computing_ProjectContext (DbContextOptions<C_Computing_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<C_Computing_Project.Models.Recipe> Recipe { get; set; } = default!;
    }
}
