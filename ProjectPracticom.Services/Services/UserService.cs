using AutoMapper;
using ProjectPracticom.Common.DTOs;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Repositories.Interfaces;
using ProjectPracticom.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Services.Services
{
    public class UserService : IService<UserDTO>
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public UserService(IRepository<User> userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(UserDTO obj)
        {
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync((_mapper.Map<User>(obj))));
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeletAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByTzAsync(string id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByTzAsync(id));
        }

        public async Task<UserDTO> UpdateAsync(int id, UserDTO obj)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(id,_mapper.Map<User>(obj)));
        }
    }
}
