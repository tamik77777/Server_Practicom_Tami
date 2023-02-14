using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyProject.Repositories.Repositories
{
    public class ChildrenRepository : IChildrenRepository
    {
        private readonly IProjectContext _projectContext;
        public ChildrenRepository(IProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public async Task<List<Children>> GetAllAsync()
        {
            return await _projectContext.Childrens.Include(p => p.Parent).ToListAsync();
            //return await _projectContext.Childrens.Include(p=>p.IdParent).ToListAsync();
        }

        public async Task<Children> GetByIdAsync(int id)
        {
            return await _projectContext.Childrens.Include(p => p.Parent).
                FirstOrDefaultAsync(i => i.IdChild == id);
        }

        public async Task DeleteAsync(int id)
        {
            _projectContext.Childrens.Remove(await GetByIdAsync(id));
            await _projectContext.SaveChangesAsync();
        }

        public async Task<Children> UpdateAsync(Children children)
        {
            var update = _projectContext.Childrens.Update(children);
            await _projectContext.SaveChangesAsync();
            return update.Entity;
        }

        public async Task<Children> AddAsync(Children children)
        {
            var add = _projectContext.Childrens.Add(children);
            await _projectContext.SaveChangesAsync();
            return add.Entity;
        }
    }
}
