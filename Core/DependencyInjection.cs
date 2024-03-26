using Microsoft.Extensions.DependencyInjection;
using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPizzaCore), typeof(PizzaCore));
            return services;
        }
    }
}
