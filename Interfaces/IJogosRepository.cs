using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    /// <summary>
    /// </summary>
    public interface IJogosRepository
    {
        /// <summary>
        /// </summary>
        void Cadastrar(Jogos jogos);


        /// <summary>
        /// </summary>
        void Deletar(Guid id);

        /// <summary>
        /// </summary>
        void Atualizar(Guid id, Jogos jogos);

        /// <summary>
        /// </summary>
        Jogos BuscarPorId(Guid id);

        /// <summary>
        /// </summary>
        List<Jogos> Listar();
    }
}
