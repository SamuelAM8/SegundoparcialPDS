using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    public class Publicaciones
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Autores { get; set; }

        public DateTime Fechapublicacion { get; set; }
    }
}
