using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppMVCStudent.Models
{
    public class UserModel
    {

        #region Public Attributes
        [Key]
        [Column(Order = 0)]
        public int IdUser { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        #endregion
    }
}