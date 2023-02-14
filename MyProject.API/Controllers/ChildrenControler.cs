using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenControler : ControllerBase
    {
        private readonly IChildrenService _childrenService;

        public ChildrenControler(IChildrenService childrenService)
        {
            _childrenService = childrenService;
        }

        [HttpGet]
        public async Task<IEnumerable<ChildrenDTO>> Get()
        {
            return await _childrenService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ChildrenDTO> Get(int id)
        {
            return await _childrenService.GetByIdAsync(id);
        }

        [HttpPost]//add
        public async Task<ChildrenDTO> Post([FromBody] ChildrenModel model)
        {
            ChildrenDTO lessonDTO = new ChildrenDTO()
            {
                IdParent= model.IdParent,
                Name=model.Name,    
                BirthDate=model.BirthDate,
                TzChild=model.TzChild,
    };
            return await _childrenService.AddAsync(lessonDTO);
        }

        [HttpPut("{id}")]//update
        public async Task<ChildrenDTO> Put(int id, [FromBody] ChildrenModel model)
        {
            ChildrenDTO lessonDTO = new ChildrenDTO()
            {
                IdChild = id,
                IdParent=model.IdParent,
                Name = model.Name,
                BirthDate = model.BirthDate,
                TzChild = model.TzChild,
            };
            return await _childrenService.UpdateAsync(lessonDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childrenService.DeleteAsync(id);
        }
    }
}
