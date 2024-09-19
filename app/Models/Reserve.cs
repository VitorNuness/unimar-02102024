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

        public Guest? Hospede { get; set; }

        public Room? Quarto { get; set; }

        public DateTime? Data { get; set; }

        public Reserve(string id, Guest hospede, Room quarto, DateTime data)
        {
            this.Id = id;
            this.Hospede = hospede;
            this.Quarto = quarto;
        }

        private Reserve() { }

    }

}