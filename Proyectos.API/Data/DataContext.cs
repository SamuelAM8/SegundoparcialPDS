using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Data
{
    public class DataContext:IdentityDbContext<User>
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        
        
        }

        public DbSet<Investigadores>Investigadoress{ get; set; }
        public DbSet<ProyectodeInvestigacionCientifica>proyectoDeInvestigacionCientificas { get; set; }
        public DbSet<ActividadesdeInvestigacion> actividadesde_Investigaciones { get; set; }

        public DbSet<Publicaciones> publicacioness{ get; set;}

        public DbSet<RecursosEspecializados> RecursosEspecializadoss{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

    }
}
