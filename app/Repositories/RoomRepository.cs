using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.Models;
using Hotel.Database;

namespace Hotel.app.Repositories
{
    public class RoomRepository
    {
        private readonly HotelDbContext _dbContext;

        public RoomRepository(
            HotelDbContext dbContext
        )
        {
            _dbContext = dbContext;
        }

        public async Task<Room?> Find(string id)
        {
            return await _dbContext.Rooms.FindAsync(id);
        }

        public async Task<Room> FindOrFail(string id)
        {
            return await Find(id) ?? throw new Exception("Quarto não encontrado.");
        }
    }
}
