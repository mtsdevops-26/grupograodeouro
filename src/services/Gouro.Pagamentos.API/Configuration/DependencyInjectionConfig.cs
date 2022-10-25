using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Gouro.Pagamentos.API.Data;
using Gouro.Pagamentos.API.Data.Repository;
using Gouro.Pagamentos.API.Models;
using Gouro.Pagamentos.API.Services;
using Gouro.Pagamentos.CardAntiCorruption;
using Gouro.Pagamentos.Facade;
using Gouro.WebApi.Core.Usuario;

namespace Gouro.Pagamentos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPagamentoFacade, PagamentoCartaoCreditoFacade>();

            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<PagamentosContext>();
        }
    }
}