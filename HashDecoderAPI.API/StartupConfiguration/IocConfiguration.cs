using Microsoft.Extensions.DependencyInjection;
using HashDecoderAPI.Common.DI;

namespace HashDecoderAPI.API.StartupConfiguration
{
    public static class IocConfiguration
    {
        public static void RegisterAllDependencies(IServiceCollection services)
        {
            services.Scan(scan =>
            {
                scan
                    .FromApplicationDependencies(a => a.GetName().Name.StartsWith("HashDecoderAPI"))
                    .AddClasses(classes => classes.AssignableTo<ITransientDependency>())
                    .AsSelfWithInterfaces()
                    .WithTransientLifetime()
                    .AddClasses(classes => classes.AssignableTo<IScopedDependency>())
                    .AsSelfWithInterfaces()
                    .WithScopedLifetime()
                    .AddClasses(classes => classes.AssignableTo<ISingletonDependency>())
                    .AsSelfWithInterfaces()
                    .WithSingletonLifetime();
            });
        }
    }
}
