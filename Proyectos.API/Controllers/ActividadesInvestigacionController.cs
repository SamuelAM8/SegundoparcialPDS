using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectos.API.Data;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Controllers
{

    [ApiController]
    [Route("/api/Actividadesinvestigacion")]
    public class Actividadesinvestigacion : ControllerBase
    {

        private readonly DataContext _context;

        public Actividadesinvestigacion(DataContext context)
        {
            _context = context;
        }


        
        [HttpGet]
        public async Task<ActionResult> Get()
        {


            return Ok(await _context.proyectoDeInvestigaciónCientíficas.ToListAsync());
        }


        //Método POST- insertar en base de datos
        [HttpPost]

        public async Task<ActionResult> Post(ProyectodeInvestigaciónCientífica proyectoDeInvestigaciónCientíficas)
        {

            _context.Add(proyectoDeInvestigaciónCientíficas);
            await _context.SaveChangesAsync();
            return Ok(proyectoDeInvestigaciónCientíficas);
        }


        //https://localhost:7000/api/Actividadesinvestigacion/id:int?id=1
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {

            var Proyecto_de_Investigación_Científica = await _context.proyectoDeInvestigaciónCientíficas.FirstOrDefaultAsync(x => x.Id == id);
            if (Proyecto_de_Investigación_Científica == null)
            {


                return NotFound();  //404
            }

            return Ok(Proyecto_de_Investigación_Científica);//200


        }




        //Método PUT- actualizar datos 
        [HttpPut]

        public async Task<ActionResult> Put(ProyectodeInvestigaciónCientífica ProyectodeInvestigaciónCientífica)
        {

            _context.Update(ProyectodeInvestigaciónCientífica);
            await _context.SaveChangesAsync();
            return Ok(ProyectodeInvestigaciónCientífica);
        }

        //Delete - Eliminar registros

        [HttpDelete("id:int")]

        public async Task<ActionResult> Delete(int id)
        {

            var filasafectadas = await _context.proyectoDeInvestigaciónCientíficas
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (filasafectadas == 0)
            {


                return NotFound();  //404
            }

            return NoContent();//204


        }

    }

}