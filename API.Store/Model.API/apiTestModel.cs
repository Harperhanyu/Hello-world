using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API.Store.Model.API
{
    public class apiTestModel
    {
        [Required]
        public string userid { get; set; }

        [Required]
        [MaxLength(20)]
        public string uname { get; set; }

        [Required]
        [MaxLength(1)]
        public int sex { get; set; }

        [Required]
        [MaxLength(11)]
        public int phone { get; set; }
    }
}
