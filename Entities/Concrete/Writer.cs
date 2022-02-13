using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Writer
    {
        [Key]
        public string WriterId { get; set; }
        public string WriterFirstName { get; set; }
        public string WriterLastName { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public bool WriterStatus { get; set; }
    }
}
