using Microsoft.Extensions.DependencyInjection;
using Plannerico.Data;

namespace Plannerico.Services.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPlannericoServices(this IServiceCollection services)
        {
            services.AddTransient<PlannericoDbContext, PlannericoDbContext>();

            return services;
        }
    }
}

