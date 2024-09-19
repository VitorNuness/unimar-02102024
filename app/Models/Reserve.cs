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
        public string? Numero { get; set; }

        public string? Categoria { get; set; }


        public Reserve(string id, string numero, string categoria)
        {
            this.Id = id;
            this.Numero = numero;
            this.Categoria = categoria;
        }

        public Reserve() { }

    }

}