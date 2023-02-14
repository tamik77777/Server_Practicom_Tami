using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IProjectContext
    {

        DbSet<Parent> Parents { get; set; }
        DbSet<Children> Childrens { get; set; }
       
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
