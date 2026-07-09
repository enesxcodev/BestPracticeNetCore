using BestPractice.Persistence.Context;

namespace BestPractice.Persistence.Extension;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services,IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SqlServer") 
            ?? throw new InvalidOperationException("Connection string 'SqlServer' bulunamadı.");

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString, sql =>{ sql.MigrationsAssembly(typeof(PersistenceAssembly).Assembly.FullName);});
        });

        return services;
    }
}