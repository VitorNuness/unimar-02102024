using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.DTOs;
using Hotel.app.Models;
using Hotel.app.Repositories;

namespace Hotel.app.Services
{
    public class ReserveService
    {
        private readonly ReserveRepository _reserveRepository;
        private readonly RoomService _roomService;
        private readonly GuestService _guestService;

        public ReserveService(
            ReserveRepository reserveRepository,
            RoomService roomService,
            GuestService guestService
        )
        {
            _reserveRepository = reserveRepository;
            _roomService = roomService;
            _guestService = guestService;
        }

        public async Task<Reserve> Create(string roomId, string guestId, DateTime date)
        {
            Room room = await _roomService.Get(roomId);
            Guest guest = await _guestService.Get(guestId);

            ReserveDTO reserveDTO = new(
                guest,
                room,
                date
            );

            return await _reserveRepository.Store(reserveDTO);
        }
    }
}
