using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User.Api.Entities
{
    public class Paramedic
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string FisrtName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
