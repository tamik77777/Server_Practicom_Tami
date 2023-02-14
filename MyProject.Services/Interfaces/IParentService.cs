using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IParentService
    {
        Task<List<ParentDTO>> GetAllAsync();
        Task<ParentDTO> GetByIdAsync(int id);
        Task<ParentDTO> AddAsync(ParentDTO parentDTO);
        Task<ParentDTO> UpdateAsync(ParentDTO parentDTO);
        Task DeleteAsync(int id);
    }
}
