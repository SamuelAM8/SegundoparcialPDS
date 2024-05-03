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


            return Ok(await _context.proyectoDeInvestigacionCientificas.ToListAsync());
        }


        [HttpPost]

        public async Task<ActionResult> Post(ProyectodeInvestigacionCientifica ProyectodeInvestigacionCientifica)
        {

            _context.Add(ProyectodeInvestigacionCientifica);
            await _context.SaveChangesAsync();
            return Ok(ProyectodeInvestigacionCientifica);
        }

        
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {

            var ProyectodeInvestigacionCientifica = await _context.proyectoDeInvestigacionCientificas.FirstOrDefaultAsync(x => x.Id == id);
            if (ProyectodeInvestigacionCientifica == null)
            {


                return NotFound();  //404
            }

            return Ok(ProyectodeInvestigacionCientifica);//200


        }




         
        [HttpPut]

        public async Task<ActionResult> Put(ProyectodeInvestigacionCientifica ProyectodeInvestigacionCientifica)
        {

            _context.Update(ProyectodeInvestigacionCientifica);
            await _context.SaveChangesAsync();
            return Ok(ProyectodeInvestigacionCientifica);
        }

        

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