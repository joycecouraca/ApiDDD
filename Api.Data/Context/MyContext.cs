using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context {
    public class MyContext : DbContext {
        public DbSet<Cliente> Cliente { get; set; }

        public MyContext (DbContextOptions<MyContext> options) : base (options) {
            Database.Migrate ();
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);
            modelBuilder.Entity<Cliente> (new ClienteMap ().Configure);
        }

    }
}
