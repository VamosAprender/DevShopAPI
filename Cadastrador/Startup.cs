using Microsoft.OpenApi.Models;
using Privacy.Middleware;

namespace Cadastrador;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddSwaggerGen(c =>
        {
            c.ResolveConflictingActions(x => x.First());
            c.EnableAnnotations();
            c.SwaggerDoc("v2", new OpenApiInfo
            {
                Version = "2.0.1",
                Title = "Micro Services AWS",
                Description = "Projeto de estudo",
            });
        });

        services.AddSwaggerConfiguration();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
#if DEBUG
#else
        app.UseHttpsRedirection();
#endif
        app.UseRouting();

        app.UseAuthorization();

        app.UseSwaggerConfiguration(env);

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}