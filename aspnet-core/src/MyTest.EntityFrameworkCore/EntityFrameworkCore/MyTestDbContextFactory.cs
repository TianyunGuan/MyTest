using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyTest.Configuration;
using MyTest.Web;

namespace MyTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyTestDbContextFactory : IDesignTimeDbContextFactory<MyTestDbContext>
    {
        public MyTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyTestConsts.ConnectionStringName));

            return new MyTestDbContext(builder.Options);
        }
    }
}
