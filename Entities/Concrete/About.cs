using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About
    {
        [Key]
        public string AboutId { get; set; }
        public string AboutDetailOne { get; set; }
        public string AboutDetailTwo { get; set; }
        public string AboutImageOne { get; set; }
        public string AboutImageTwo { get; set; }
        public string AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }
    }
}
