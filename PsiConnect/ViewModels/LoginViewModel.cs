using System.ComponentModel.DataAnnotations;

namespace PsiConnect.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Digite o Email!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        [Display(Name = "Email")]
        public string Email_u { get; set; }

        [Required(ErrorMessage = "Digite a Senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha_u { get; set; }

        public string ReturnUrl { get; set; }
    }
}