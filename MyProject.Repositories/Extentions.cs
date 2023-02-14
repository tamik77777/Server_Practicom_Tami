﻿using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories.Interfaces;

using MyProject.Repositories.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories
{
    public static class Extentions
    {
        public static IServiceCollection AddRepositoryInjections(this IServiceCollection services)
        {
            services.AddScoped<IChildrenRepository, ChildrenRepository>();
            services.AddScoped<IParentRepository, ParentRepository>();
           
            //services.AddScoped<IChildrenRepository, ParentRepository>();

            /*services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IClaimRepository, ClaimRepository>();*/
            return services;

        }
    }
}
