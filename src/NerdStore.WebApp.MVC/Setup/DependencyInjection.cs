using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catalogo.Domain;
using NerdStore.Core.Bus;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            //Domain Bus (Mediator)
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();           
        }
    }
}