public static class ExchangeApiExtensions
{

    public static IServiceCollection UseExchangeApi(

        this IServiceCollection services
    )
    {
        services.AddTransient<ExchangeRepository>();
        services.AddTransient<ExchangeSymbolRepository>();
        services.AddCors(p => p.AddPolicy("corspolicy", build =>
        {

            build.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();

        }));

        return services;
    }


    public static WebApplication MapExchangeApi(
        this WebApplication app
    )
    {
        app.MapGet("/exchanges", (ExchangeRepository repository) =>
            {

                return Results.Ok(repository.Get());

            });

        app.MapGet("/exchangesymbols", (ExchangeSymbolRepository repository) =>
            {

                return Results.Ok(repository.Get());

            }
            );

        return app;
    }
}


