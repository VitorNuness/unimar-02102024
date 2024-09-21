using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hotel.app.Models
{
    public class Guest
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool? Ativo { get; set; }

        public Guest(string name, string email, bool ativo)
        {
            this.Name = name;
            this.Email = email;
            this.Ativo = ativo;
        }

        private Guest() { }
    }

}