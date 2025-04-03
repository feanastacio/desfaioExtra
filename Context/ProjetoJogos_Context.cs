using Microsoft.EntityFrameworkCore;
using ProjetoDeJogos.Domains;


namespace ProjetoDeJogos.Context
{
    public class ProjetoJogos_Context : DbContext
    {
        public ProjetoJogos_Context()
        {
        }
        public ProjetoJogos_Context(DbContextOptions<ProjetoJogos_Context> options)
            : base(options)
        {
        }

        public DbSet<Jogos> Jogos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DESKTOP-S3CGL03\\SQLEXPRESS; Database = Jogos; User id = sa; Pwd = Senai@134; trustServerCertificate = true;");
            }
        }
    }
}
