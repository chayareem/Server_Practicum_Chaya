using AutoMapper;
using ProjectPracticom.Common.DTOs;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Repositories.Interfaces;
using ProjectPracticom.Repositories.Repositories;
using ProjectPracticom.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Services.Services
{
    public class ChildService:IService<ChildDTO>
    {
        private readonly IRepository<Child> _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IRepository<Child> childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }

        public async Task<ChildDTO> AddAsync(ChildDTO obj)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync((_mapper.Map<Child>(obj))));
        }

        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeletAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByTzAsync(string id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByTzAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(int id, ChildDTO obj)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(id,_mapper.Map<Child>(obj)));
        }
    }
}
