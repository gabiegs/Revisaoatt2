using System.ComponentModel.DataAnnotations;

namespace Revisaoatt2.Models
{
    public class Visita
    {
        [Required(ErrorMessage = "RA é obrigatório")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Data obrigatória")]
        public DateOnly Data { get; set; }

        public int Projeto { get; set; }

        [Range(0, 5, ErrorMessage = "A nota do projeto deve estar entre 0 e 5")]
        public int NotaDoProjeto { get; set; }
    }
}
