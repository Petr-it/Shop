using Shop.Context.Seeder;
using Shop.Services.Logger;
using Shop.Services.Settings;

namespace Shop.Api;


 public static class Bootstrapper
{
    public static IServiceCollection RegisterServices(this IServiceCollection service, IConfiguration configuration = null)
    {
        service.AddMainSettings()
               .AddSwaggerSettings()
               .AddLogSettings()
               .AddAppLogger()
               .AddDbSeeder();
               ;

        return service;
    }
}

