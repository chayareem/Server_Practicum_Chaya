using ProjectPracticom.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        public Task<List<T>> GetAllAsync();
        //public Task<T> GetByIdAsync(int id);
        public Task<T> GetByTzAsync(string id);
        public Task<T> AddAsync(T obj);
        public Task<T> UpdateAsync(int id,T obj);
        public Task DeletAsync(int id);
    }
}
