using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCreate.model
{
    public class ContactUs
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Message { get; set; }
        public string Email { get; set; }
       


    }
}
