﻿using Microsoft.Extensions.DependencyInjection;

using MyProject.Services.Interfaces;

using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repositories;

namespace MyProject.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddServicesInjections(this IServiceCollection services)
        {
            services.AddRepositoryInjections();
            /*services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IClaimService, ClaimService>();*/

            services.AddScoped<IParentService, ParentService>();
            services.AddScoped<IChildrenService, ChildrenService>();

            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
