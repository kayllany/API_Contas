using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using contasAPagar.Model;

namespace contasAPagar.Data
{
    public class contasAPagarContext : DbContext
    {
        public contasAPagarContext (DbContextOptions<contasAPagarContext> options)
            : base(options)
        {
        }

        public DbSet<contasAPagar.Model.ContaModel> Conta { get; set; }
    }
}
