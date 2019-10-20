using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context {
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext> {
        public MyContext CreateDbContext (string[] args) {
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=a12345z";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            //optionsBuilder.UseMySql (connectionString);
            optionsBuilder.UseMySql (connectionString);
            return new MyContext (optionsBuilder.Options);
        }
    }
}
