using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace PsiConnect.Models
{
    [Table("Prontuario")]
    public class Prontuario
    {
        [Key]
        public int ProntuarioId { get; set; }
        
        public string Nome_Paciente { get; set; }

        public string Idade_Paciente { get; set; }

        public string Data_Consulta { get; set; }

        public string Diagnostico { get; set; }

        public string Tratamento { get; set; }

    }
}
