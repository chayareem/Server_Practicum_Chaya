using Microsoft.AspNetCore.Mvc;
using ProjectPracticom.Common.DTOs;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Services.Interfaces;
using ProjectPracticom.WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectPracticom.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IService<ChildDTO> _child;
        public ChildController(IService<ChildDTO> child)
        {
            _child= child;
        }
       
        // GET: api/<ChildController>
        [HttpGet]
        public async Task<IEnumerable<ChildDTO>> Get()
        {
            return await _child.GetAllAsync();
        }

        // GET api/<ChildController>/5
        [HttpGet("{tz}")]
        public async Task<ChildDTO> Get(string tz)
        {
            return await _child.GetByTzAsync(tz);
        }

        //POST api/<ChildController>
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildModel childModel)
        {
            ChildDTO newChildDTO = new ChildDTO();
            newChildDTO.ChildId = childModel.ChildId;
            newChildDTO.FullName=childModel.FullName;
            newChildDTO.DateOfBirth=childModel.DateOfBirth;
            newChildDTO.ParentId = childModel.ParentId;
            return await _child.AddAsync(newChildDTO);
        }

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public async Task<ChildDTO> Put(int id, [FromBody] ChildModel childModel)
        {
            ChildDTO newChildDTO = new ChildDTO();
            newChildDTO.ChildId=childModel.ChildId;
            newChildDTO.FullName = childModel.FullName;
            newChildDTO.DateOfBirth = childModel.DateOfBirth;
            return await _child.UpdateAsync(id, newChildDTO);
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _child.DeleteAsync(id);
        }
    }
}
