using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Hosting
{
    public static class WebHostExtensions
    {
        public static IWebHost Migrate<T>(this IWebHost webHost, bool seed = false) where T : DbContext
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<T>();
                db.Database.Migrate();
                if (seed)
                    scope.ServiceProvider.GetService<ISeeder<T>>()?.Seed(db);
            }

            return webHost;
        }
    }
}
