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
            await this.ValidateRoomInDate(room, date);

            Guest guest = await _guestService.Get(guestId);

            ReserveDTO reserveDTO = new(
                guest,
                room,
                date
            );

            return await _reserveRepository.Store(reserveDTO);
        }

        public async Task<IEnumerable<Reserve?>> GetByDate(DateTime date)
        {
            return await _reserveRepository.WhereDate(date);
        }

        private async Task ValidateRoomInDate(Room room, DateTime date)
        {
            IEnumerable<Reserve?> reservesInDate = await this.GetByDate(date);
            bool isRoomReserved = reservesInDate?.Any(r => r?.Room == room) ?? false;
            if (isRoomReserved)
            {
                throw new Exception("O quarto já possui uma reserva para esta data.");
            }
        }
    }
}
