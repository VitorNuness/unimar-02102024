using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.DTOs;
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

        public async Task<Reserve> Store(ReserveDTO reserveDTO)
        {
            Reserve reserve = new(
                reserveDTO.Guest,
                reserveDTO.Room,
                reserveDTO.Date
            );

            _dbContext.Reserves.Add(reserve);
            await _dbContext.SaveChangesAsync();

            return reserve;
        }
    }
}
