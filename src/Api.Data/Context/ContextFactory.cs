using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // Usado para criar as Migrações em tempo de designer da aplicação

            var connectionString = "Server=.\\SQLEXPRESS;Initial Catalog=dbAPI_3;Trusted_Connection=True;MultipleActiveResultSets=true";
            //var connectionString = "Server=localhost;Port=3306;Database=dbAPI2;Uid=root;Pwd=vetrigo";

            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseMySql(connectionString);
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
