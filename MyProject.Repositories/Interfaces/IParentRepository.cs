using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IParentRepository
    {
        Task<List<Parent>> GetAllAsync();
        Task<Parent> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<Parent> UpdateAsync(Parent place);
        Task<Parent> AddAsync(Parent place);
    }
}
