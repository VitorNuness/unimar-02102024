using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.app.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string? Id { get; set; }
        public string? Number { get; set; }

        public string? Category { get; set; }


        public Room(string number, string category)
        {
            this.Number = number;
            this.Category = category;
        }

        public Room() { }

    }
}