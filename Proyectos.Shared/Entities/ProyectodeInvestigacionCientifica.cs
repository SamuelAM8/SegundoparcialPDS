using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    public class ProyectodeInvestigacionCientifica
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(200,ErrorMessage = "la {0}  no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "Este campo es obligatorio!!")]
        public string Descripcion { get; set; }

        [Display(Name = "FechadeInicio")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechadeInicio { get; set; }

        [Display(Name = "FechaFinalización")]
        [Required(ErrorMessage = "Este campo es obligatorio!")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaEstimadaFinalización { get; set; }


        [JsonIgnore]
        public Investigadores Investigadoress{ get; set;}

        [JsonIgnore]
        public ActividadesdeInvestigacion actividadesde_Investigaciones { get; set; }

        [JsonIgnore]

        public Publicaciones Publicacioness{ get; set; }


        
    }
}
