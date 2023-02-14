using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectPracticom.Common.DTOs;
using ProjectPracticom.MyContext;
using ProjectPracticom.Repositories;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Repositories.Interfaces;
using ProjectPracticom.Repositories.Repositories;
using ProjectPracticom.Services.Interfaces;
using ProjectPracticom.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectPracticom.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped<IService<UserDTO>, UserService>();
            services.AddScoped<IService<ChildDTO>, ChildService>();
            services.AddDbContext<IContext, MyDBContext>();

            services.AddAutoMapper(typeof(Mapping));

            return services;
        }



    }
}
