using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FUP_Projeto.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cargo { get; set; }

        [StringLength(60, MinimumLength = 3) ]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Chefe { get; set; }
        public string Telefone { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage ="Mínimo 11 caracteres")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Salario { get; set; }
    }
}
