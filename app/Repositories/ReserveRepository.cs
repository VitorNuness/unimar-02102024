using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.Models;
using Hotel.Database;

namespace Hotel.app.Repositories
{
    public class ReserveRepository
    {
        private readonly HotelDbContext _dbContext;

        public ReserveRepository(
            HotelDbContext dbContext
        )
        {
            _dbContext = dbContext;
        }

        public async Task<Reserve> Store(Reserve reserve)
        {
            _dbContext.Reserves.Add(reserve);
            await _dbContext.SaveChangesAsync();

            return reserve;
        }
    }
}
