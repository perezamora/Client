using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVCStudent.Models
{
    public class StudentModel
    {
        #region Public Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaCreacion { get; set; }
        #endregion
    }
}