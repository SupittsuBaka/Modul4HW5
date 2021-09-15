using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Modul4HW5.Services;

namespace Modul4HW5.DataAccess
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        private readonly ConfigService _config;
        public ContextFactory()
        {
            _config = new ConfigService();
        }

        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(_config.ConnectionString);
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
