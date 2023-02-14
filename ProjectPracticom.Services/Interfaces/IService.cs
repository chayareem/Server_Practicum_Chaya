using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Services.Interfaces
{
    public interface IService<T>
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByTzAsync(string Tz);

        Task<T> AddAsync(T obj);

        Task<T> UpdateAsync(int id,T obj);

        Task DeleteAsync(int id);
    }
}
