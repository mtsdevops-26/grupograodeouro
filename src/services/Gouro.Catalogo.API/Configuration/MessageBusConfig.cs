using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Gouro.Catalogo.API.Services;
using Gouro.Core.Utils;
using Gouro.MessageBus;

namespace Gouro.Catalogo.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                    .AddHostedService<CatalogoIntegrationHandler>();
        }
    }
}
