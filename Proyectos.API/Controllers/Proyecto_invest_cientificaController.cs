using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectos.API.Data;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Controllers
{

    [ApiController]
    [Route("/api/proyectoDeInvestigaciónCientífica")]
    public class ProyinvcientController : ControllerBase 
    {

        private readonly DataContext _context;

        public ProyinvcientController(DataContext context)
        {
            _context = context;
        }


        
        [HttpGet]
        public async Task<ActionResult> Get()
        {


            return Ok(await _context.proyectoDeInvestigaciónCientíficas.ToListAsync());
        }


        [HttpPost]

        public async Task<ActionResult> Post(ProyectodeInvestigaciónCientífica ProyectodeInvestigaciónCientífica)
        {

            _context.Add(ProyectodeInvestigaciónCientífica);
            await _context.SaveChangesAsync();
            return Ok(ProyectodeInvestigaciónCientífica);
        }

        
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {

            var ProyectodeInvestigaciónCientífica = await _context.proyectoDeInvestigaciónCientíficas.FirstOrDefaultAsync(x => x.Id == id);
            if (ProyectodeInvestigaciónCientífica == null)
            {


                return NotFound();  //404
            }

            return Ok(ProyectodeInvestigaciónCientífica);//200


        }




         
        [HttpPut]

        public async Task<ActionResult> Put(ProyectodeInvestigaciónCientífica ProyectodeInvestigaciónCientífica)
        {

            _context.Update(ProyectodeInvestigaciónCientífica);
            await _context.SaveChangesAsync();
            return Ok(ProyectodeInvestigaciónCientífica);
        }

        

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