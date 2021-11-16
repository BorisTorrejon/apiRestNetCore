using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiRestNetCore.Models;

namespace apiRestNetCore.Data
{
    public class apiRestNetCoreContext : DbContext
    {
        public apiRestNetCoreContext (DbContextOptions<apiRestNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<apiRestNetCore.Models.Producto> Producto { get; set; }
    }
}
