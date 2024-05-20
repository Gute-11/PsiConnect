using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsiConnect.Models
{
    [Table("Psicologos")]
    public class Psicologos
    {
        [Key]
        public int PsicologosId { get; set; }

        [Required(ErrorMessage = "Informe seu primeiro nome")]
        [Display(Name = "Seu primeiro nome")]
        [StringLength(35, ErrorMessage = "O seu nome deve ser menor que 35 caracteres!")]
        public string Primeiro_nome_p { get; set; }

        [Required(ErrorMessage = "Informe seu Sobrenome")]
        [Display(Name = "Seu Sobrenome")]
        [StringLength(50, ErrorMessage = "O seu sobrenome deve ser menor que 50 caracteres!")]
        public string Sobrenome_p { get; set; }

        [Required(ErrorMessage = "Informe seu Endewreço de E-mail")]
        [Display(Name = "Seu Endereço de E-mail")]
        [StringLength(256, ErrorMessage = "O seu E-mail deve ser menor que 256 caracteres!")]
        public string Email_p { get; set; }

        [Required(ErrorMessage = "Informe seu CPF!")]
        [Display(Name = "Seu CPF")]
        
        public int Cpf_p { get; set; }

        [Required(ErrorMessage = "Informe seu Número de Celular!")]
        [Display(Name = "Seu Número de Celular")]

        public int Celular_p { get; set; }

        [Required(ErrorMessage = "Informe sua Área de Atuação!")]
        [Display(Name = "Sua Área de Atuação")]

        public int Area_atuacao_p { get; set; }

        [Required(ErrorMessage = "Informe sua Senha!")]
        [Display(Name = "Sua Senha")]
        
        public string Senha_p { get; set; }

        [Required(ErrorMessage = "Informe seu Gênero!")]
        [Display(Name = "Seu Gênero")]

        public string Genero_p { get; set; }

    }
}
