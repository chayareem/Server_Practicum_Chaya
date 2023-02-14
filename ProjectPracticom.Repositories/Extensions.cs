using Microsoft.Extensions.DependencyInjection;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Repositories.Interfaces;
using ProjectPracticom.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Repositories
{
    public static class Extensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IRepository<User>, UserRepository>();
            service.AddScoped<IRepository<Child>, ChildRepository>();

            return service;
        }
    }
}
