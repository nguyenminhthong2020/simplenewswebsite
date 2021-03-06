using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using SimpleNewsWebsite.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            //services.AddControllersWithViews(options =>
            //{
            //    options.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
            //});
            services.AddControllersWithViews();

            services.AddControllersWithViews().AddNewtonsoftJson();

            //services.AddControllers().AddNewtonsoftJson();
            //services.AddMvc(options =>
            //{
            //    options.AllowEmptyInputInBodyModelBinding = true;
            //    foreach (var formatter in options.InputFormatters)
            //    {
            //        if (formatter.GetType() == typeof(SystemTextJsonInputFormatter))
            //            ((SystemTextJsonInputFormatter)formatter).SupportedMediaTypes.Add(
            //            Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("text/plain"));
            //    }
            //}).AddJsonOptions(options =>
            //{
            //    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
                //      endpoints.MapControllerRoute(    // không thể thêm dòng này, thêm sẽ lỗi
                //  name: "api",
                //  pattern: "api/{controller=Home}/{id?}"
                //);
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
            });
        }

        private static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
        {
            var builder = new ServiceCollection()
                .AddLogging().AddMvc().AddNewtonsoftJson().Services.BuildServiceProvider();

            return builder
                .GetRequiredService<IOptions<MvcOptions>>()
                .Value
                .InputFormatters
                .OfType<NewtonsoftJsonPatchInputFormatter>()
                .First();
        }
    }
}
