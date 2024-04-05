using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    public class ActividadesdeInvestigacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechadeInicio { get; set;}
        public DateTime Fechafinalizacion { get; set; }


    }
}
