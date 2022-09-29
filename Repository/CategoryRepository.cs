using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: Zones
        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        // get by id
        public async Task<Category> GetById(Guid? id)
        {
            var category = _context.Category.FirstOrDefault(m => m.CategoryId == id);
            return category;
        }
    }
}
