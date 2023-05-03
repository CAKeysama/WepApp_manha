using Microsoft.EntityFrameworkCore;
using WepApp_manha.Entidades;

namespace WepApp_manha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base( opt ) 
        {}

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<PermissaoEntidade> PERMISSAO { get; set; }
        public DbSet<CategoriaEntidade> CATEGORIA { get; set; }

    }
}
