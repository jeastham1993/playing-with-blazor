using System;
using HRM.Server.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HRM.Server
{
	public class Startup
	{
		public Startup(
			IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(
			IServiceCollection services)
		{
			services.AddRazorPages();

			services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(
				client =>
				{
					client.BaseAddress = new Uri("https://localhost:44340");
				});

#if DEBUG
			services.AddServerSideBlazor(options => { options.DetailedErrors = true; });
#endif

#if !DEBUG
            services.AddServerSideBlazor();
#endif
		}

		public void Configure(
			IApplicationBuilder app,
			IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(
				endpoints =>
				{
					endpoints.MapBlazorHub();
					endpoints.MapFallbackToPage("/_Host");
				});
		}
	}
}