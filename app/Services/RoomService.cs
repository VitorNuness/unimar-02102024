using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.Models;
using Hotel.app.Repositories;

namespace Hotel.app.Services
{
    public class RoomService
    {
        private readonly RoomRepository _roomRepository;

        public RoomService(
            RoomRepository roomRepository
        )
        {
            _roomRepository = roomRepository;
        }

        public async Task<Room> Get(string id)
        {
            return await _roomRepository.FindOrFail(id);
        }
    }
}
