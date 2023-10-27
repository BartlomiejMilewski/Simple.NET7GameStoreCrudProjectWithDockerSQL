using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreAPIv3NET7.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GameStoreAPIv3NET7.Data
{
    public static class DataExtensions
    {
        public static async Task InitializeDbAsync(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
            await dbContext.Database.MigrateAsync();
        }

        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            var connString = configuration.GetConnectionString("GameStoreContext");
            services.AddSqlServer<GameStoreContext>(connString)
                    .AddScoped<IGamesRepository, EntityFrameworkGamesRepository>();

            return services;
        }
    }
}