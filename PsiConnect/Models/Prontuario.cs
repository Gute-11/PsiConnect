using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsiConnect.Models
{
    [Table("Prontuario")]
    public class Prontuario
    {
        [Key]
        public int ProntuarioId { get; set; }

        [Required(ErrorMessage = "O nome do paciente é obrigatório.")]
        [Display(Name = "Nome do Paciente")]
        [StringLength(100, ErrorMessage = "O nome do paciente deve ter no máximo 100 caracteres.")]
        public string Nome_Paciente { get; set; }

        [Display(Name = "Idade do Paciente")]
        public int? Idade_Paciente { get; set; }

        [Required(ErrorMessage = "A data da consulta é obrigatória.")]
        [Display(Name = "Data da Consulta")]
        [DataType(DataType.Date)]
        public DateTime Data_Consulta { get; set; }

        [Display(Name = "Diagnóstico")]
        public string Diagnostico { get; set; }

        [Display(Name = "Tratamento")]
        public string Tratamento { get; set; }
    }
}