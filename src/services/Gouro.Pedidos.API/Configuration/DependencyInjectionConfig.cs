using FluentValidation.Results;
using Gouro.Core.Mediator;
using Gouro.Pedidos.API.Application.Commands;
using Gouro.Pedidos.API.Application.Events;
using Gouro.Pedidos.API.Application.Queries;
using Gouro.Pedidos.Domain.Pedidos;
using Gouro.Pedidos.Domain.Vouchers;
using Gouro.Pedidos.Infra.Data;
using Gouro.Pedidos.Infra.Data.Repository;
using Gouro.WebApi.Core.Usuario;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Gouro.Pedidos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            // Commands
            services.AddScoped<IRequestHandler<AdicionarPedidoCommand, ValidationResult>, PedidoCommandHandler>();

            // Events
            services.AddScoped<INotificationHandler<PedidoRealizadoEvent>, PedidoEventHandler>();

            // Application
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IVoucherQueries, VoucherQueries>();
            services.AddScoped<IPedidoQueries, PedidoQueries>();

            // Data
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
            services.AddScoped<PedidosContext>();
        }
    }
}