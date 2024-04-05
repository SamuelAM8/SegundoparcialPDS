using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    public class ActividadesdeInvestigacion
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(200,ErrorMessage = "La {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]

        public string Descripcion { get; set; }

        [Display(Name = "FechadeInicio")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechadeInicio { get; set;}

        [Display(Name = "Fechafinalizacion")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fechafinalizacion { get; set; }

        public ICollection<RecursosEspecializados> RecursosEspecializadoss { get; set; }


    }
}
