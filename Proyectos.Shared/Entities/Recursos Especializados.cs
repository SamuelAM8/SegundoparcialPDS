using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    public class RecursosEspecializados

    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Nombre { get; set; }

        [Display(Name = "Cantidadrequerida")]
        [MaxLength(50, ErrorMessage = "La {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public int Cantidadrequerida { get; set; }

        [Display(Name = "Proveedor")]
        [MaxLength(50, ErrorMessage = "El {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Proveedor { get; set; }

        [Display(Name = "Fechadeentrega")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fechadeentrega { get; set; }
        




    }
}
