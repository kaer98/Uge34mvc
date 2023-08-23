using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using uge34mvc.Models;

namespace uge34mvc.Data
{
    public class uge34mvcContext : DbContext
    {
        public uge34mvcContext (DbContextOptions<uge34mvcContext> options)
            : base(options)
        {
        }

        public DbSet<uge34mvc.Models.Movie> Movie { get; set; } = default!;
    }
}
