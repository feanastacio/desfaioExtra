using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDeJogos.Domains
{
    /// <summary>
    /// </summary>
    [Table("Jogos")]
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    public class Jogos
    {
        /// <summary>
        /// </summary>
        [Key]
        public Guid JogosID { get; set; }

        /// <summary>
        /// </summary>
        [Column(TypeName = "VARCHAR(75)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public string? NomeDoJogo { get; set; }

        /// <summary>
        /// </summary>
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "A plataforma é obrigatória!")]
        public string? Plataforma { get; set; }
    }
}
