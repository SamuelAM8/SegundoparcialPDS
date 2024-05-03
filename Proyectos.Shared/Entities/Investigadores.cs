using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    public class Investigadores
    {
        public int Id { get; set; }


        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]

        public string Nombre { get; set; }

        [Display(Name = "Especialidad")]
        [MaxLength(50,ErrorMessage = "la {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Especialidad { get; set; }

        [Display(Name = "Afiliacion")]
        [MaxLength(50, ErrorMessage = "la {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Afiliacion { get; set; }

        [JsonIgnore]
        public ICollection<ProyectodeInvestigacionCientifica> ProyectodeInvestigacionCientificas { get; set; }

    }
}
