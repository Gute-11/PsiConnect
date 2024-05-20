using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace PsiConnect.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage ="Informe seu primeiro nome!")]
        [Display(Name = "Seu primeiro nome")]
        [StringLength(35, ErrorMessage = "O seu nome deve ser menor que 35 caracteres!")]
        public string Primeiro_nome_u { get; set; }

        [Required(ErrorMessage ="Digite seu sobrenome!")]
        [Display(Name ="Seu Sobrenome")]
        [StringLength(50, ErrorMessage = "O seu nome deve ser menor que 50 caracteres!")]
        public string Sobrenome_u { get; set; }

        [Required(ErrorMessage ="Digite seu E-mail!")]
        [Display(Name = "Seu Email")]
        [StringLength(256, ErrorMessage = "O seu E-mail deve ser menor que 256 caracteres!")]
        public string Email_u { get; set; }

        [Required(ErrorMessage = "Digite seu CPF!")]
        [Display(Name ="Seu CPF")]
        [MaxLength(11)]
        [MinLength(11)]
        public string Cpf_u { get; set; }

        [Required(ErrorMessage = "Digite seu Celular!")]
        [Display(Name = "Seu Celular")]
        [MaxLength(11)]
        [MinLength(11)]
        public string Celular_u { get; set; }
        [Required(ErrorMessage = "Digite seu Celular!")]
        [Display(Name = "Número do Contato de Emergência")]
        [MaxLength(11)]
        [MinLength(11)]
        public string Ctt_emer_u { get; set; }

        [Required(ErrorMessage = "Digite sua senha!")]
        [Display(Name = "Sua Senha")]
        [StringLength(8)]
        public string Senha_u { get; set; }

        [Required(ErrorMessage = "Informe seu gênero!")]
        [Display(Name = "Seu Gênero")]
        [StringLength(35, ErrorMessage = "O seu gênero deve ser menor que 35 caracteres!")]
        public string Genero_u { get; set; }

    }
}
