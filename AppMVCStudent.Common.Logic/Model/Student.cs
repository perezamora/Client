using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVCStudent.Common.Logic.Model
{
    public class Student
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaCreacion { get; set; }
        #endregion

        #region Public Method
        public override String ToString() => string.Format("{0};{1};{2};{3};{4};{5};{6};",
                 this.Id, this.Name, this.Apellidos, this.Dni, this.FechaCreacion, this.Edad, this.FechaCreacion);
        #endregion
    }
}
