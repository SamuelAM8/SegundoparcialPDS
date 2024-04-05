using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectos.API.Data;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Controllers
{

    [ApiController]
    [Route("/api/publicaciones")] 
    public class publicacionesController : ControllerBase
    {

        private readonly DataContext _context;

        public publicacionesController(DataContext context)
        {
            _context = context;
        }


       
        [HttpGet]
        public async Task<ActionResult> Get()
        {


            return Ok(await _context.publicacioness.ToListAsync()); 
        }


       
        [HttpPost]

        public async Task<ActionResult> Post(Publicaciones publicaciones)
        {

            _context.Add(publicaciones);
            await _context.SaveChangesAsync();
            return Ok(publicaciones);
        }

       
        //https://localhost:7000/api/publicaciones/id:int?id=1
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {

            var publicaciones = await _context.publicacioness.FirstOrDefaultAsync(x => x.Id == id);
            if (publicaciones == null)
            {


                return NotFound();  //404
            }

            return Ok(publicaciones);//200


        }



        [HttpPut]

        public async Task<ActionResult> Put(Publicaciones publicaciones)
        {

            _context.Update(publicaciones);
            await _context.SaveChangesAsync();
            return Ok(publicaciones);
        }

        

        [HttpDelete("id:int")]

        public async Task<ActionResult> Delete(int id)
        {

            var filasafectadas = await _context.publicacioness
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