using Gouro.Catalogo.API.Data;
using Gouro.Catalogo.API.Data.Respository;
using Gouro.Catalogo.API.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Gouro.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
