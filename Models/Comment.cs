using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Project.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public decimal Score { get; set; }
        public DateTime CommentDate { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
        [ForeignKey("ApllicationUser")]
        public virtual ICollection<ApplicationUser> ApplicationUserID { get; set; }
    }
}
