using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectos.API.Data;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Controllers
{

    [ApiController]
    [Route("/api/recursos")] 
    public class recursosController : ControllerBase
    {

        private readonly DataContext _context;

        public recursosController(DataContext context)
        {
            _context = context;
        }


        
        [HttpGet]
        public async Task<ActionResult> Get()
        {


            return Ok(await _context.RecursosEspecializadoss.ToListAsync()); 
        }


        //Método POST- insertar en base de datos
        [HttpPost]

        public async Task<ActionResult> Post(RecursosEspecializados RecursosEspecializados)
        {

            _context.Add(RecursosEspecializados);
            await _context.SaveChangesAsync();
            return Ok(RecursosEspecializados);
        }

        //GEt por párametro- select * from Owners where id=1
        //https://localhost:7000/api/recursos/id:int?id=1
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {

            var recursos = await _context.RecursosEspecializadoss.FirstOrDefaultAsync(x => x.Id == id);
            if (recursos == null)
            {


                return NotFound();  //404
            }

            return Ok(recursos);//200


        }




        //Método PUT- actualizar datos 
        [HttpPut]

        public async Task<ActionResult> Put(RecursosEspecializados RecursosEspecializados)
        {

            _context.Update(RecursosEspecializados);
            await _context.SaveChangesAsync();
            return Ok(RecursosEspecializados);
        }

        //Delete - Eliminar registros

        [HttpDelete("id:int")]

        public async Task<ActionResult> Delete(int id)
        {

            var filasafectadas = await _context.RecursosEspecializadoss
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