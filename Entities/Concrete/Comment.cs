using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment
    {
        [Key]
        public string CommentId { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle{ get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public string BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
