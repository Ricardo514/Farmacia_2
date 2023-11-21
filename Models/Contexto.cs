using Microsoft.EntityFrameworkCore;

namespace Farmacia_2.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :
            base(options)
        { }
        public DbSet<Cliente> Clientes  { get; set; }

    }
}
