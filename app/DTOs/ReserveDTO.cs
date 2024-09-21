using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.app.Models;

namespace Hotel.app.DTOs
{
    public class ReserveDTO
    {
        public Guest? Guest { get; set; }
        public Room? Room { get; set; }
        public DateTime Date { get; set; }
    }
}
