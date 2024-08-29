using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistence
{
    // Classe estática para estender o IServiceCollection com métodos específicos de configuração de serviços
    public static class ServiceExtensions
    {
        // Método de extensão para configurar serviços relacionados à persistência
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            // Obtém a string de conexão para o banco de dados SQLite a partir das configurações da aplicação
            var connectionString = configuration.GetConnectionString("Sqlite");

            // Registra o serviço IUnitOfWork e sua implementação UnitOfWork como Scoped (vida útil por requisição)
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Registra o serviço IUserRepository e sua implementação UserRepository como Scoped
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
