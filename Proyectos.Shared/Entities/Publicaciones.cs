using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    public class Publicaciones
    {
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [MaxLength(100, ErrorMessage = "El {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Titulo { get; set; }

        [Display(Name = "Autor")]
        [MaxLength(150, ErrorMessage = "El {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]

        public string Autores { get; set; }

        [Display(Name = "Fechapublicacion")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        public DateTime Fechapublicacion { get; set; }
    }
}
