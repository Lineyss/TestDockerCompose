using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace API.DataBaseExtensions
{
    public static class MigrationsExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using DataBaseContext dbContexts =
                scope.ServiceProvider.GetRequiredService<DataBaseContext>();

            dbContexts.Database.Migrate();
        }
    }
}
