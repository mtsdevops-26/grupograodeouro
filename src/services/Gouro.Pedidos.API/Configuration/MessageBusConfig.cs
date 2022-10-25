using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Gouro.Core.Utils;
using Gouro.MessageBus;
using Gouro.Pedidos.API.Services;

namespace Gouro.Pedidos.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                    .AddHostedService<PedidoOrquestradorIntegrationHandler>()
                    .AddHostedService<PedidoIntegrationHandler>();
        }
    }
}
