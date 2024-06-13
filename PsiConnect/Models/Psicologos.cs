﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

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
        [MaxLength(11, ErrorMessage = "O CPF deve ter exatamente 11 dígitos!")]
        [MinLength(11, ErrorMessage = "O CPF deve ter exatamente 11 dígitos!")]
        public int Cpf_p { get; set; }

        [Required(ErrorMessage = "Informe seu Número de Celular!")]
        [Display(Name = "Seu Número de Celular")]
        [MaxLength(11, ErrorMessage = "O número de celular deve ter exatamente 11 dígitos!")]
        [MinLength(11, ErrorMessage = "O número de celular deve ter exatamente 11 dígitos!")]
        public int Celular_p { get; set; }

        [Required(ErrorMessage = "Informe sua Área de Atuação!")]
        [Display(Name = "Sua Área de Atuação")]
        [StringLength(100, ErrorMessage = "A sua área de atuação excedeu 100 caracteres!")]
        public int Area_atuacao_p { get; set; }

        [Required(ErrorMessage = "Informe seu CRM!")]
        [Display(Name = "Seu CRM")]
        [StringLength(10, ErrorMessage = "A seu CRM excedeu 10 caracteres!")]
        public int CRM { get; set; }

        [Required(ErrorMessage = "Informe sua Estado de Nascimento!")]
        [Display(Name = "Seu Estado de nascimento")]
        [StringLength(50, ErrorMessage = "A seu Estado excedeu 50 caracteres!")]
        public int Estado { get; set; }

        [Required(ErrorMessage = "Informe sua Senha!")]
        [Display(Name = "Sua Senha")]
        [MaxLength(8, ErrorMessage = "A sua senha deve conter exatamente 8 Caracteres!")]
        [MinLength(8, ErrorMessage = "A sua senha deve conter exatamente 8 Caracteres!")]
        public string Senha_p { get; set; }

        [Required(ErrorMessage = "Informe seu Gênero!")]
        [Display(Name = "Seu Gênero")]
        [StringLength(15, ErrorMessage = "Excesso de caracteres!")]
        public string Genero_p { get; set; }

    }
}
