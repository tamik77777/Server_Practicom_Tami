using AutoMapper;
using MyProject.Common.DTOs;

using MyProject.Repositories.Entities;

using MyProject.Repositories.Interfaces;

using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ParentService:IParentService
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;

        public ParentService(IParentRepository parentRepository, IMapper mapper)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
        }

        public async Task<ParentDTO> AddAsync(ParentDTO parentDTO)
        {
            return _mapper.Map<ParentDTO>(await _parentRepository.AddAsync(_mapper.Map<Parent>(parentDTO)));
        }

        public async Task DeleteAsync(int id)
        {
            await _parentRepository.DeleteAsync(id);
        }

        public async Task<List<ParentDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ParentDTO>>(await _parentRepository.GetAllAsync());
        }

        public async Task<ParentDTO> GetByIdAsync(int id)
        {
            return  _mapper.Map<ParentDTO>(await _parentRepository.GetByIdAsync(id));
        }

        public async Task<ParentDTO> UpdateAsync(ParentDTO parentDTO)
        {
            return _mapper.Map<ParentDTO>(await _parentRepository.UpdateAsync
                (_mapper.Map<Parent>(parentDTO)));
        }
    }
}
