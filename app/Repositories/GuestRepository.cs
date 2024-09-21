using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.Models;
using Hotel.Database;

namespace Hotel.app.Repositories
{
    public class GuestRepository
    {
        private readonly HotelDbContext _dbContext;

        public GuestRepository(
            HotelDbContext dbContext
        )
        {
            _dbContext = dbContext;
        }

        public async Task<Guest?> Find(string id)
        {
            return await _dbContext.Guests.FindAsync(id);
        }

        public async Task<Guest> FindOrFail(string id)
        {
            return await Find(id) ?? throw new Exception("Hóspede não encontrado.");
        }
    }
}
