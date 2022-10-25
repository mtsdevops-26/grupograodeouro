using Microsoft.Extensions.DependencyInjection;
using Gouro.Clientes.API.Data;
using Gouro.Clientes.API.Models;
using Gouro.Clientes.API.Data.Repository;
using Gouro.Core.Mediator;
using MediatR;
using Gouro.Clientes.API.Application.Commands;
using FluentValidation.Results;
using Gouro.Clientes.API.Application.Events;
using Microsoft.AspNetCore.Http;
using Gouro.WebApi.Core.Usuario;

namespace Gouro.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IMediatorHandler, MediatorHandler>();

            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();
            services.AddScoped<IRequestHandler<AdicionarEnderecoCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}