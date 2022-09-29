using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //get all devices
        public List<Device> GetAll()
        {
            return _context.Device.ToList();
        }

        // get devices by id
        public async Task<Device> GetById(Guid? id)
        {
            var device = _context.Device.FirstOrDefault(m => m.DeviceId == id);
            return (device);
        }
    }
}
