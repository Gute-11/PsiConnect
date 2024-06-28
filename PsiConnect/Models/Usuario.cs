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

        [Required(ErrorMessage = "Informe seu primeiro nome!")]
        [Display(Name = "Seu primeiro nome")]
        [StringLength(35, ErrorMessage = "O seu nome deve ser menor que 35 caracteres!")]
        public string Primeiro_nome_u { get; set; }

        [Required(ErrorMessage = "Digite seu sobrenome!")]
        [Display(Name = "Seu Sobrenome")]
        [StringLength(50, ErrorMessage = "O seu sobrenome deve ser menor que 50 caracteres!")]
        public string Sobrenome_u { get; set; }

        [Required(ErrorMessage = "Digite seu E-mail!")]
        [Display(Name = "Seu Email")]
        //[EmailAddress(ErrorMessage = "O Email informado não é valido!")]
        [StringLength(256, ErrorMessage = "O seu E-mail deve ser menor que 256 caracteres!")]
        public string Email_u { get; set; }

        [Required(ErrorMessage = "Digite seu CPF!")]
        [Display(Name = "Seu CPF")]
        [MaxLength(11, ErrorMessage = "O CPF deve ter exatamente 11 dígitos!")]
        [MinLength(11, ErrorMessage = "O CPF deve ter exatamente 11 dígitos!")]
        public string Cpf_u { get; set; }

        [Required(ErrorMessage = "Digite seu Celular!")]
        [Display(Name = "Seu Celular")]
        [Phone(ErrorMessage = "Numero Invalido!")]
        [MaxLength(11, ErrorMessage = "O número de celular deve ter exatamente 11 dígitos!")]
        [MinLength(11, ErrorMessage = "O número de celular deve ter exatamente 11 dígitos!")]
        public string Celular_u { get; set; }

        //[Required(ErrorMessage = "Digite o número do celular do seu contato de emergência!")]
        [Display(Name = "Número do Contato de Emergência")]
        [MaxLength(11, ErrorMessage = "O número de celular do contato de emergência deve ter exatamente 11 dígitos!")]
        [MinLength(11, ErrorMessage = "O número de celular do contato de emergência deve ter exatamente 11 dígitos!")]
        public string Ctt_emer_u { get; set; }

        [Required(ErrorMessage = "Digite sua senha!")]
        [Display(Name = "Sua Senha")]
        [MaxLength(8, ErrorMessage = "A sua senha deve conter exatamente 8 Caracteres!")]
        [MinLength(8, ErrorMessage = "A sua senha deve conter exatamente 8 Caracteres!")]
        public string Senha_u { get; set; }

        [Required(ErrorMessage = "Informe seu gênero!")]
        [Display(Name = "Seu Gênero")]
        [StringLength(15, ErrorMessage = "Excesso de caracteres!")]
        public string Genero_u { get; set; }

        public bool psico { get; set; } = false;
    }
}
