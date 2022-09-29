
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: Zones
        public List<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }

        // get by id
        public async Task<Zone> GetById(Guid? id)
        {
            var zone = _context.Zone.FirstOrDefault(m => m.ZoneId == id);
            return zone;
        }
    }
}
