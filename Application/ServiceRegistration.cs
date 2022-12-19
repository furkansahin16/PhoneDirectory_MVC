using Application.Concrete;
using Application.Services;
using Domain.Repository.Abstract;
using Domain.Repository.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection service)
        {
            service.AddSingleton<IPersonService, PersonManager>();
            service.AddSingleton<IPersonRepo, PersonRepo>();
        }
    }
}
