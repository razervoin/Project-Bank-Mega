using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TrBpkb> TrBpkbs { get; set; }
        public DbSet<MsStorageLocation> MsStorageLocations { get; set; }
        public DbSet<MsUser> MsUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<TrBpkb>().ToTable("tr_bpkb");
            modelBuilder.Entity<MsStorageLocation>().ToTable("ms_storage_location");
            modelBuilder.Entity<MsUser>().ToTable("ms_user");

            modelBuilder.Entity<TrBpkb>()
                .HasOne<MsStorageLocation>()
                .WithMany()
                .HasForeignKey(bpkb => bpkb.location_id)
                .HasPrincipalKey(location => location.location_id);
            
            modelBuilder.Entity<MsStorageLocation>()
                .HasKey(x => x.location_id); 
            
            modelBuilder.Entity<MsUser>()
                .HasKey(u => u.user_id);

            modelBuilder.Entity<TrBpkb>()
                .HasKey(b => b.agreement_number);
        }
    }
}
