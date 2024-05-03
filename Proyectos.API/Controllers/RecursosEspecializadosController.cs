using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectos.API.Data;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Controllers
{

    [ApiController]
    [Route("/api/recursos")]
    public class RecursosEspecializadosContro : ControllerBase
    {

        private readonly DataContext _context;

        public RecursosEspecializadosContro(DataContext context)
        {



            _context = context;
        }

        // Método Get- LISTA
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.RecursosEspecializadoss.ToListAsync());


        }



        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var recurso = await _context.RecursosEspecializadoss.FirstOrDefaultAsync(x => x.Id == id);

            if (recurso == null)
            {


                return NotFound();

            }



            return Ok(recurso);


        }






        [HttpPost]
        public async Task<ActionResult> Post(RecursosEspecializados recursosEspecializados)
        {

            _context.Add(recursosEspecializados);
            await _context.SaveChangesAsync();
            return Ok(recursosEspecializados);



        }



        // Método actualizar
        [HttpPut]

        public async Task<ActionResult> Put(RecursosEspecializados recursosEspecializados)
        {

            _context.Update(recursosEspecializados);
            await _context.SaveChangesAsync();
            return Ok(recursosEspecializados);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.RecursosEspecializadoss

                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (Filasafectadas == 0)
            {


                return NotFound();

            }


            return NoContent();

        }
    }

}