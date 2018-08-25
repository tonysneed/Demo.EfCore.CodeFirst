using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Demo.EfCore.CodeFirst.Data
{
    public class CodeFirstDemoContextFactory : IDesignTimeDbContextFactory<CodeFirstDemoContext>
    {
        public CodeFirstDemoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CodeFirstDemoContext>();
            optionsBuilder.UseSqlServer(Constants.ConnectionStrings.LocalDbConnection);
            return new CodeFirstDemoContext(optionsBuilder.Options);
        }
    }
}