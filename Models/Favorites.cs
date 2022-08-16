using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Project.Models
{
    public class Favorites
    {
        public int FavoritesID { get; set; }

        [ForeignKey("Post")]
        public virtual Post PostId { get; set; }
        

    }
}
