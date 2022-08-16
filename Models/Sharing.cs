using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Project.Models
{
    public class Sharing
    {
        public int SharingID { get; set; } 
        public Platforms Platforms { get; set; }
        [ForeignKey("PostFK")]
        public Post PostID { get; set; }
        
    }
}
