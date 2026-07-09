namespace BestPractice.Extension
{
    public class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Bağımlılıkları gruplu bir şekilde burada tanımlıyoruz
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped < typeof(IGenericRepository<>), typeof(GenericRepository<>)();
            //eğer birden fazla generic alsaydı <,,,>


            // Options pattern kayıtları da burada tutulabilir
            services.Configure<SmsSettings>(configuration.GetSection("SmsSettings"));

            // Zincirleme kullanım için services nesnesini geri dönüyoruz
            return services;
        }
    }
}
