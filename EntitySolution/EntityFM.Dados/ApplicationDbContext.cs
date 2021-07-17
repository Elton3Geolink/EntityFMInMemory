using EntityFM.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFM.Dados
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):
            base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.CodigoBarras);

            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.Id);

            //base.OnModelCreating(modelBuilder);

            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Cascade;
            //}
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
