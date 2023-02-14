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
    public class ParentControler : ControllerBase
    {
        private readonly IParentService _parentService;

        public ParentControler(IParentService parentService)
        {
            _parentService = parentService;
        }

        [HttpGet]
        public async Task<IEnumerable<ParentDTO>> Get()
        {
            return await _parentService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ParentDTO> Get(int id)
        {
            return await _parentService.GetByIdAsync(id);
        }

        [HttpPost]//add
        public async Task<ParentDTO> Post([FromBody] ParentModel model)
        {
            ParentDTO parentDTO = new ParentDTO()
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                Tz=model.Tz,
                Date=model.Date,
                Min=model.Min,
                Hospital=model.Hospital,
    };
            return await _parentService.AddAsync(parentDTO);
        }

        [HttpPut("{id}")]//update
        public async Task<ParentDTO> Put(int id, [FromBody] ParentModel model)
        {
            ParentDTO parentDTO = new ParentDTO()
            {
                IdParent = id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Tz = model.Tz,
                Date = model.Date,
                Min = model.Min,
                Hospital = model.Hospital,
            };
            return await _parentService.UpdateAsync(parentDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _parentService.DeleteAsync(id);
        }
    }
}
