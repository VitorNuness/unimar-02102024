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
            this.Guest = guest;
            this.Room = room;
            this.SetDate(date);
        }

        private Reserve() { }

        private void SetDate(DateTime date)
        {
            if (date < DateTime.Today)
            {
                throw new Exception ("A data é invalida");
            }
        }

    }

}