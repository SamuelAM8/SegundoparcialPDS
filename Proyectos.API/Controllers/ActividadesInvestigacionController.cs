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


            return Ok(await _context.proyectoDeInvestigacionCientificas.ToListAsync());
        }


        //Método POST- insertar en base de datos
        [HttpPost]

        public async Task<ActionResult> Post(ProyectodeInvestigacionCientifica proyectoDeInvestigaciónCientíficas)
        {

            _context.Add(proyectoDeInvestigaciónCientíficas);
            await _context.SaveChangesAsync();
            return Ok(proyectoDeInvestigaciónCientíficas);
        }


        //https://localhost:7000/api/Actividadesinvestigacion/id:int?id=1
        [HttpGet("{id:int}")]

        public async Task<ActionResult> Get(int id)
        {

            var Proyecto_de_Investigacion_Cientifica = await _context.proyectoDeInvestigacionCientificas.FirstOrDefaultAsync(x => x.Id == id);
            if (Proyecto_de_Investigacion_Cientifica == null)
            {


                return NotFound();  //404
            }

            return Ok(Proyecto_de_Investigacion_Cientifica);//200


        }




        //Método PUT- actualizar datos 
        [HttpPut]

        public async Task<ActionResult> Put(ProyectodeInvestigacionCientifica ProyectodeInvestigacionCientifica)
        {

            _context.Update(ProyectodeInvestigacionCientifica);
            await _context.SaveChangesAsync();
            return Ok(ProyectodeInvestigacionCientifica);
        }

        //Delete - Eliminar registros

        [HttpDelete("id:int")]

        public async Task<ActionResult> Delete(int id)
        {

            var filasafectadas = await _context.proyectoDeInvestigacionCientificas
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