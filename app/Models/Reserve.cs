using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.app.Models
{
    public class Reserve
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public string? Id { get; set; }

        public Guest? Guest { get; set; }

        public Room? Room { get; set; }

        public DateTime? Date { get; set; }

        public Reserve(Guest guest, Room room, DateTime date)
        {
            this.SetGuest(guest);
            this.SetDate(date);
            this.Room = room;
        }

        private Reserve() { }

        private void SetDate(DateTime date)
        {
            if (date < DateTime.Today)
            {
                throw new InvalidDateException("Não foi possível criar a reserva! A data é invalida.");
            }
            this.Date = date;
        }

        private void SetGuest(Guest guest)
        {
            if (guest.Active == false)
            {
                throw new InvalidGuestException("Não foi possível criar a reserva! O Hóspede deve estar ativo.");
            }
            this.Guest = guest;
        }

    }

}
