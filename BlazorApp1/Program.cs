using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1
{
   public class Program
   {
      public static void Main(string[] args)
      {
         var builder = WebApplication.CreateBuilder(args);
         builder.Services.AddSingleton<WeatherForecastService>();
         builder.Services.AddDbContext<DatabaseContext>(configuration =>
         {
            configuration.UseMySql("Server=127.0.0.1;Database=db;Uid=root;Pwd=senha;", new MySqlServerVersion(new Version(8, 0, 31)));
         });
         builder.Services.AddRazorPages();
         builder.Services.AddServerSideBlazor();
         var app = builder.Build();
         if (!app.Environment.IsDevelopment())
         {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
         }
         app.UseHttpsRedirection();
         app.UseStaticFiles();
         app.UseRouting();
         app.MapBlazorHub();
         app.MapFallbackToPage("/_Host");
         app.Run();
      }
   }
}