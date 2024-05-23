using PsiConnect.Context;
using Microsoft.EntityFrameworkCore;
using PsiConnect.Repositorios.Interfaces;
using PsiConnect.Repositorios;

namespace PsiConnect
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método é chamado pelo runtime. Use este método para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPsiConnectRepositorio, PsiConnectRepositorio>();

            // Adiciona os serviços de autorização
            services.AddAuthorization();

            // Adiciona os serviços MVC (controladores com views)
            services.AddControllersWithViews();

            // Outros serviços podem ser adicionados aqui
        }

        // Este método é chamado pelo runtime. Use este método para configurar o pipeline de requisições HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}