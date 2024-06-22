using System.ComponentModel.DataAnnotations;

namespace PsiConnect.ViewModels
{
    public class CadastroPsicologoViewModel
    {
        [Required(ErrorMessage = "Informe seu primeiro nome")]
        [Display(Name = "Seu primeiro nome")]
        [StringLength(35, ErrorMessage = "O nome deve ter no máximo 35 caracteres")]
        public string Primeiro_nome_p { get; set; }

        [Required(ErrorMessage = "Informe seu Sobrenome")]
        [Display(Name = "Seu Sobrenome")]
        [StringLength(50, ErrorMessage = "O sobrenome deve ter no máximo 50 caracteres")]
        public string Sobrenome_p { get; set; }

        [Required(ErrorMessage = "Informe seu Endereço de E-mail")]
        [Display(Name = "Seu Endereço de E-mail")]
        [EmailAddress(ErrorMessage = "Endereço de e-mail inválido")]
        [StringLength(256, ErrorMessage = "O e-mail deve ter no máximo 256 caracteres")]
        public string Email_p { get; set; }

        [Required(ErrorMessage = "Informe seu CPF")]
        [Display(Name = "Seu CPF")]
        [StringLength(11, ErrorMessage = "O CPF deve ter exatamente 11 dígitos")]
        public string Cpf_p { get; set; }

        [Required(ErrorMessage = "Informe seu Número de Celular")]
        [Display(Name = "Seu Número de Celular")]
        [StringLength(11, ErrorMessage = "O número de celular deve ter exatamente 11 dígitos")]
        public string Celular_p { get; set; }

        [Required(ErrorMessage = "Informe seu CRM")]
        [Display(Name = "Seu CRM")]
        [StringLength(10, ErrorMessage = "O CRM deve ter no máximo 10 caracteres")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "Informe seu Estado de Nascimento")]
        [Display(Name = "Seu Estado de Nascimento")]
        [StringLength(50, ErrorMessage = "O estado de nascimento deve ter no máximo 50 caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe sua Senha")]
        [Display(Name = "Sua Senha")]
        [StringLength(8, ErrorMessage = "A senha deve ter exatamente 8 caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Senha_p { get; set; }

        [Required(ErrorMessage = "Confirme a Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme a Senha")]
        [Compare("Senha_p", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmeSenha { get; set; }

        [Required(ErrorMessage = "Informe seu Gênero")]
        [Display(Name = "Seu Gênero")]
        [StringLength(15, ErrorMessage = "O gênero deve ter no máximo 15 caracteres")]
        public string Genero_p { get; set; }
    }
}
