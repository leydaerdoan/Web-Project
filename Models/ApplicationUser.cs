using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Project.Models
{
    public class ApplicationUser
    {
        public int ApplicationUserID { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        [ForeignKey("Foto")]
        public Foto ProfileFoto { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public UserRoles UserRoles { get; set; }

        //public ICollection<UserRoles> UserRolesList { get; set; }
    }
}
