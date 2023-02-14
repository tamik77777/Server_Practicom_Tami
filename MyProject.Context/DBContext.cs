using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyProject.Context
{
    public class DBContext:DbContext,IProjectContext
    {        
        public DbSet<Children> Childrens { get ; set; }
        public DbSet<Parent> Parents { get; set; }
        //DbSet<Children> IProjectContext.Parents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //DbSet<Parent> IProjectContext.Childrens { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Sport_T_S_Database;Trusted_Connection=True;");
        }
    }
}
