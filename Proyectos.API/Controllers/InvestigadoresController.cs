using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectos.API.Data;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Controllers
{

    [ApiController]
    [Route("/api/Investigadores")]
    public class InvestigadoresController: ControllerBase
    {

        private readonly DataContext _context;

        public InvestigadoresController(DataContext context)
        {
            _context = context;
        }


       
        [HttpGet]
        public async Task<ActionResult> Get()
        {


            return Ok(await _context.Investigadoress.ToListAsync());
        }


       
        [HttpPost]

        public async Task<ActionResult> Post(Investigadores Investigadores)
        {

            _context.Add(Investigadores);
            await _context.SaveChangesAsync();
            return Ok(Investigadores);
        }

        //https://localhost:7000/api/Investigadores/id:int?id=1
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {

            var Investigadores = await _context.Investigadoress.FirstOrDefaultAsync(x => x.Id == id);
            if (Investigadores == null)
            {


                return NotFound();  //404
            }

            return Ok(Investigadores);//200


        }




        //Método PUT- actualizar datos 
        [HttpPut]

        public async Task<ActionResult> Put(Investigadores Investigadores)
        {

            _context.Update(Investigadores);
            await _context.SaveChangesAsync();
            return Ok(Investigadores);
        }

        //Delete - Eliminar registros

        [HttpDelete("id:int")]

        public async Task<ActionResult> Delete(int id)
        {

            var filasafectadas = await _context.Investigadoress
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