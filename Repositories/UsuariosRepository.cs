using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;


namespace ProjetoDeJogos.Repositories
{
    /// <summary>
    /// Repositório para gerenciamento dos usuarios
    /// </summary>
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ProjetoJogos_Context _context;

        /// <summary>
        /// Repositório para gerenciamento dos usuarios
        /// </summary>
        public UsuariosRepository(ProjetoJogos_Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Repositório para gerenciamento dos usuario.
        /// </summary>
        public void Atualizar(Guid id, Usuarios usuario)
        {
            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;

                if(usuarioBuscado != null)
                {
                    usuarioBuscado.Nickname = usuario.Nickname;
                    usuarioBuscado.JogoFav = usuario.JogoFav;
                }

                _context.Usuarios.Update(usuarioBuscado!);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Repositório para gerenciamento dos usuario.
        /// </summary
        public void Cadastrar(Usuarios usuarios)
        {
            try
            {
                usuarios.UsuarioID = Guid.NewGuid();

                _context.Usuarios.Add(usuarios);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Repositório para gerenciamento dos usuario.
        /// </summary
        public void Deletar(Guid id)
        {
            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;

                if (usuarioBuscado != null)
                {
                    _context.Usuarios.Remove(usuarioBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Repositório para gerenciamento dos usuario.
        /// </summary
        Usuarios IUsuariosRepository.BuscarPorId(Guid id)
        {
            try
            {
                return _context.Usuarios.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Repositório para gerenciamento dos usuario.
        /// </summary
        List<Usuarios> IUsuariosRepository.Listar()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
