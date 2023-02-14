using Microsoft.EntityFrameworkCore;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Repositories.Repositories
{
    public class ChildRepository : IRepository<Child>
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child child)
        {
            var newChild = _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return newChild.Entity;
        }

        public async Task DeletAsync(int id)
        {
            var child = await _context.Children.FindAsync(id);
            _context.Children.Remove(child);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByTzAsync(string id)
        {

            //return await _context.Children.FindAsync(id);
            return await _context.Children.SingleAsync(a => a.ChildId == id);
        }

        public async Task<Child> UpdateAsync(int id, Child obj)
        {
            var children = _context.Children.Update(obj);
            await _context.SaveChangesAsync();
            return children.Entity;
        }

    }
}
