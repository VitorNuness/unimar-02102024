using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.Models;
using Hotel.app.Repositories;

namespace Hotel.app.Services
{
    public class GuestService
    {
        private readonly GuestRepository _guestRepository;

        public GuestService(
            GuestRepository guestRepository
        )
        {
            _guestRepository = guestRepository;
        }

        public async Task<Guest> Get(string id)
        {
            return await _guestRepository.FindOrFail(id);
        }
    }
}
