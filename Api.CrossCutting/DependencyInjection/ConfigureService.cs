using Api.Domain.Interfaces.Services.Clientes;
using Api.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection {
    public class ConfigureService {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IClienteServices, ClienteService> ();
        }
    }
}
