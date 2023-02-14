using Microsoft.EntityFrameworkCore;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Repositories.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User user)
        {
            var newUser=_context.Users.Add(user);
            await _context.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task DeletAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByTzAsync(string id)
        {
            return await _context.Users.SingleAsync(a => a.UserId == id);
        }

        public async Task<User> UpdateAsync(int id,User obj)
        {
            var users = _context.Users.Update(obj);
            await _context.SaveChangesAsync();
            return users.Entity;  
        }
    }
}
