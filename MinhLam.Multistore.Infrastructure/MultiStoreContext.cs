using Microsoft.EntityFrameworkCore;
using MinhLam.Multistore.Infrastructure.DbConfigurations;
using MinhLam.MultiStore.Domain.Entities;

namespace MinhLam.Multistore.Infrastructure
{
    public class MultiStoreContext : DbContext
    {
        public MultiStoreContext(DbContextOptions<MultiStoreContext> options)
         : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new NoteConfiguration().Configure(modelBuilder.Entity<Note>());
        }
    }
}
