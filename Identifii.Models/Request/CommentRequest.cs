using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifii.Models.Request
{
    public class CommentRequest
    {
        public int PostID { get; set; }
        public string UserID { get; set; } 
        public string Content { get; set; }
    }
}
