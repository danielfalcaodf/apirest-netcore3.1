using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connection = "Server=localhost;Port=3306;Database=CourseApidotnet;Uid=root;Pwd=";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connection);
            // var db = new ContextNameContext(optionsBuilder.Options)
            return new MyContext(optionsBuilder.Options);

        }
    }
}