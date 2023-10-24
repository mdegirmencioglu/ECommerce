﻿using Microsoft.EntityFrameworkCore;
using ECommerce.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
           services.AddDbContext<ECommerceDbContext>(options=>options.UseNpgsql(Config));
        }
    }
}
