using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;


namespace ProjetoDeJogos.Repositories
{
    /// <summary>
    /// Repositório para gerenciamento dos usuarios
    /// </summary>
    public class JogosRepository : IJogosRepository
    {
        private readonly ProjetoJogos_Context _context;

        /// <summary>
        /// Repositório para gerenciamento dos usuarios
        /// </summary>
        public JogosRepository(ProjetoJogos_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Jogos jogos)
        {
            try
            {
                Jogos jogosBuscado = _context.Jogos.Find(id)!;

                if (jogosBuscado != null)
                {
                    jogosBuscado.NomeDoJogo = jogos.NomeDoJogo;
                    jogosBuscado.Plataforma = jogos.Plataforma;
                }

                _context.Jogos.Update(jogosBuscado!);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Jogos BuscarPorId(Guid id)
        {
            try
            {
                return _context.Jogos.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Jogos jogos)
        {
            try
            {
                jogos.JogosID = Guid.NewGuid();

                _context.Jogos.Add(jogos);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Jogos jogosBuscado = _context.Jogos.Find(id)!;

                if (jogosBuscado != null)
                {
                    _context.Jogos.Remove(jogosBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Jogos> Listar()
        {
            try
            {
                return _context.Jogos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
