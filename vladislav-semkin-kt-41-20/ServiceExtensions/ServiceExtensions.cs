using vladislav_semkin_kt_41_20.Interfaces.TeachersInterfaces;
namespace vladislav_semkin_kt_41_20.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITeachersService, TeachersService>();
            return services;
        }

    }
}