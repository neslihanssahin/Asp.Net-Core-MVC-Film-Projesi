using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace MovieApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // MVC hizmetini ekliyoruz
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles  ();//wwwroot dosyası dışarıya açılmış olur.Özel bir klasör olduğu için belirtmeye gerek yok

            app.UseStaticFiles(new StaticFileOptions { 
            FileProvider=new PhysicalFileProvider(Path.Combine
            (Directory.GetCurrentDirectory(),"node_modules")),
            RequestPath="/modules"
             });//burda hangi klasörü dışarı açacaksak belitmemiz gerek 


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Routing'i kullanabilmek için
            app.UseRouting();

            // Endpoint'leri yapılandırıyoruz
            app.UseEndpoints(endpoints =>
            {
                // Default route
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
