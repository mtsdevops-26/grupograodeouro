using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Gouro.Core.Utils;
using Gouro.MessageBus;
using Gouro.Pagamentos.API.Services;

namespace Gouro.Pagamentos.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus")).AddHostedService<PagamentoIntegrationHandler>();
        }
    }
}