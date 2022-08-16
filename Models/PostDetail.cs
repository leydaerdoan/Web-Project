using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Project.Models
{
    public class PostDetail
    {
        [ForeignKey("CategoryFK")]
        [Required]
        public Category CategoryID { get; set; }

        [ForeignKey("PostFK")]
        public Post PostID { get; set; }

        public string Serving { get; set; }
        public string PreperationTime { get; set; }
        public string Ingredient { get; set; }
        public string Description { get; set; }
        public string? FoodType { get; set; }

    }
}
