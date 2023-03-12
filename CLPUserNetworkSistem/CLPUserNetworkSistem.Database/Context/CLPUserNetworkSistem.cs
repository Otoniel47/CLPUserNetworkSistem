using CLPUserNetworkSistem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CLPUserNetworkSistem.Database.Context
{
    public class CLPUserNetworkSistem : DbContext
    {
        public CLPUserNetworkSistem(DbContextOptions<CLPUserNetworkSistem> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }

        public DbSet<T> GetDbSet<T>() where T : class => Set<T>();
        public bool HasChanges() => ChangeTracker.HasChanges();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}