using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GranTiete_Devs.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public IdentityUser ContaIdentity { get; set; }

    [Required(ErrorMessage ="Informe um nome...")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no maximo 30 caracteres!")]
        public string Nome { get; set; }

    [Required(ErrorMessage = "Informe a data de nascimento!")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLength(300)]
    public string fotoPerfil { get; set; }

    [Required(ErrorMessage = "Informe a Área de atuação")]

    public int AreaAtuacaoId { get; set; }
    [ForeignKey("AreaAtuacaoId")]

    public AreaAtuacao AreaAtuacao { get; set; }
    
}
