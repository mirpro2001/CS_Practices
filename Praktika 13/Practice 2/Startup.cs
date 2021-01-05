using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      //string con = "Server=(localdb)\\mssqllocaldb;Database=usersdbstore;Trusted_Connection=True;";
      string con = "Server = localhost;Database = usersdbstore;Trusted_Connection = True;";
      // ������������� �������� ������
      services.AddDbContext<UsersContext>(options => options.UseSqlServer(con));

      services.AddControllers(); // ���������� ����������� ��� �������������
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseDeveloperExceptionPage();

      app.UseDefaultFiles();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers(); // ���������� ������������� �� �����������
      });
    }
  }
}
