using System.ComponentModel.DataAnnotations;

namespace Revisaoatt2.Models
{
    public class Projeto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 50 caracteres")]
        public string NomeDoProjeto { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Range(1, 8, ErrorMessage = "A turma deve estar entre 1 e 8")]
        public int Turma { get; set; }

        [Required(ErrorMessage = "Descrição da proposta é obrigatória")]
        [StringLength(500, ErrorMessage = "Descrição do projeto deve ter no máximo 500 caracteres")]
        public string DescricaoDoProjeto { get; set; }

        [Range(10, 99, ErrorMessage = "Número do projeto deve estar entre 10 e 99")]
        public int NumeroDoProjeto { get; set; }
    }
}
