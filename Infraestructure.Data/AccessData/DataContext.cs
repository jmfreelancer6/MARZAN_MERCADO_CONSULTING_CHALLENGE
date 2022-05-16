using Infraestructure.Data.AccessData;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public virtual DbSet<tbl_Clientes> tbl_Clientes { get; set; }
        public virtual DbSet<Tbl_Ordenes> Tbl_Ordenes { get; set; }
        public virtual DbSet<tbl_OrdenesDetails> tbl_OrdenesDetails { get; set; }
        public virtual DbSet<tbl_Productos> tbl_Productos { get; set; }
        public virtual DbSet<tbl_Users> tbl_Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Clientes>()
            .HasMany(c => c.Tbl_Ordenes)
            .WithOne(e => e.tbl_Clientes)
            .HasForeignKey(x => x.ID_Cliente);

            modelBuilder.Entity<tbl_Productos>()
            .HasMany(c => c.Tbl_OrdenesDetail)
            .WithOne(e => e.tbl_Productos)
            .HasForeignKey(x => x.ID_Productos);

            modelBuilder.Entity<Tbl_Ordenes>()
            .HasMany(c => c.tbl_OrdenesDetails)
            .WithOne(e => e.tbl_Ordenes)
            .HasForeignKey(x => x.ID_Ordenes);

            modelBuilder.Entity<Tbl_Ordenes>()
            .HasOne(c => c.tbl_Clientes)
            .WithMany(e => e.Tbl_Ordenes)
            .HasForeignKey(x => x.ID_Cliente);

            modelBuilder.Entity<tbl_OrdenesDetails>()
            .HasOne(c => c.tbl_Ordenes)
            .WithMany(e => e.tbl_OrdenesDetails)
            .HasForeignKey(x => x.ID_Ordenes);
        }
    }
}
