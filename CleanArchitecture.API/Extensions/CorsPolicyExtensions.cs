namespace CleanArchitecture.API.Extensions;

public static class CorsPolicyExtensions
{
    public static void ConfigureCorsPolicy(this IServiceCollection services) 
    {

        //em um codigo em produção necessario validar esse serviço
        services.AddCors(opt =>
        {
            opt.AddDefaultPolicy(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });
    }
}
