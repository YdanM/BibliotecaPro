using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPro.Lector.Persistance.Context
{
    public class BibliotecaContext : DbContext
    {
        #region"Constructor"
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }
        #endregion

        #region"DB Sets"
        public DbSet<Domain.Entities.Lector> Lectors { get; set; }
        #endregion

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Domain.Entities.Lector>().HasKey(e => e.IdLector);

        //}
    }
}
