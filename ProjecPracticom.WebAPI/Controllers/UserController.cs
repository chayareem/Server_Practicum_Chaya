using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjectPracticom.Common.DTOs;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Services.Interfaces;
using ProjectPracticom.WebAPI.Models;
using System.Data;
using System.Reflection.PortableExecutable;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectPracticom.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDTO> _user;
        public UserController(IService<UserDTO> user)
        {
            _user=user;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<UserDTO>> Get()
        {
            return await _user.GetAllAsync();
        }

        // GET api/<ChildController>/5
        [HttpGet("{tz}")]
        public async Task<UserDTO> Get(string tz)
        {
            return await _user.GetByTzAsync(tz);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel userModel)
        {
            UserDTO newUserDTO = new UserDTO();
            newUserDTO.FirstName = userModel.FirstName;
            newUserDTO.LastName = userModel.LastName;
            newUserDTO.UserId = userModel.UserId;
            newUserDTO.maleOrFemale = userModel.maleOrFemale;
            newUserDTO.Hmo = userModel.Hmo;
            newUserDTO.DateOfBirth = userModel.DateOfBirth;
            return await _user.AddAsync(newUserDTO);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<UserDTO> Put(int id, [FromBody] UserModel userModel)
        {
            UserDTO newUserDTO = new UserDTO();
            newUserDTO.FirstName = userModel.FirstName;
            newUserDTO.LastName = userModel.LastName;
            newUserDTO.UserId = userModel.UserId;
            newUserDTO.maleOrFemale = userModel.maleOrFemale;
            newUserDTO.Hmo = userModel.Hmo;
            newUserDTO.DateOfBirth = userModel.DateOfBirth;
            return await _user.UpdateAsync(id, newUserDTO);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _user.DeleteAsync(id);
        }
    }
}
