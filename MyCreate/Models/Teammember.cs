using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCreate.model
{
    public class Teammember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Jop { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile File { set; get; }
    }

}
