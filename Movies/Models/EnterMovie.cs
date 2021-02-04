using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class EnterMovie
    {
        [StringLength(25, ErrorMessage ="You cannot enter more notes")]
        public string note { get; set; }
        public string rating { get; set; }
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [MinLength(2000)]
        public int year { get; set; }
        
        [Required()]
        public string director { get; set; }
        public bool edited { get; set; }

      
    }
}
