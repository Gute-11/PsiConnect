using System.ComponentModel.DataAnnotations;

namespace PsiConnect.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Digite o Primeiro Nome!")]
        [Display(Name = "Primeiro Nome")]
        [StringLength(35, ErrorMessage = "O seu nome deve ser menor que 35 caracteres!")]
        public string Primeiro_nome_u { get; set; }

        [Required(ErrorMessage = "Digite o Sobrenome!")]
        [Display(Name = "Sobrenome")]
        [StringLength(50, ErrorMessage = "O seu sobrenome deve ser menor que 50 caracteres!")]
        public string Sobrenome_u { get; set; }

        [Required(ErrorMessage = "Digite o CPF!")]
        [Display(Name = "CPF")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter exatamente 11 dígitos!")]
        public string Cpf_u { get; set; }

        [Required(ErrorMessage = "Digite o Email!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        [Display(Name = "Email")]
        [StringLength(256, ErrorMessage = "O seu E-mail deve ser menor que 256 caracteres!")]
        public string Email_u { get; set; }

        [Required(ErrorMessage = "Digite o Celular!")]
        [Phone(ErrorMessage = "Número inválido!")]
        [Display(Name = "Celular")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O número de celular deve ter exatamente 11 dígitos!")]
        public string Celular_u { get; set; }

        [Display(Name = "Contato de Emergência")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O número de celular do contato de emergência deve ter exatamente 11 dígitos!")]
        public string Ctt_emer_u { get; set; }

        [Required(ErrorMessage = "Digite a Senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "A sua senha deve conter exatamente 8 Caracteres!")]
        public string Senha_u { get; set; }

        [Required(ErrorMessage = "Confirme a Senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme a Senha")]
        [Compare("Senha_u", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmeSenha { get; set; }

        [Required(ErrorMessage = "Informe seu gênero!")]
        [Display(Name = "Gênero")]
        [StringLength(15, ErrorMessage = "Excesso de caracteres!")]
        public string Genero_u { get; set; }
    }
}