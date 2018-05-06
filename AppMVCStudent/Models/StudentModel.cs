using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMVCStudent.Models
{
    public class StudentModel
    {
        #region Public Attributes
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Dni")]
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaCreacion { get; set; }
        #endregion
    }
}