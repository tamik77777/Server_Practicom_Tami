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
    public class ParentRepository : IParentRepository
    {
        private readonly IProjectContext _projectContext;
        public ParentRepository(IProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public async Task<Parent> AddAsync(Parent parent)
        {
            var add = _projectContext.Parents.Add(parent);
            await _projectContext.SaveChangesAsync();
            return add.Entity;
        }
        public async Task DeleteAsync(int id)
        {
            _projectContext.Parents.Remove(await GetByIdAsync(id));
            await _projectContext.SaveChangesAsync();
        }
        public async Task<List<Parent>> GetAllAsync()
        {
            return await _projectContext.Parents.ToListAsync();
        }

        public async Task<Parent> GetByIdAsync(int id)
        {
            return await _projectContext.Parents.FindAsync(id);
        }

        public async Task<Parent> UpdateAsync(Parent parent)
        {
            var update = _projectContext.Parents.Update(parent);
            await _projectContext.SaveChangesAsync();
            return update.Entity;
        }
    }
}
