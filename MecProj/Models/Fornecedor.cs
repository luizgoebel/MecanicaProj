using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome do Fornecedor.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CNPJ do Fornecedor.")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Informe a Cidade do Fornecedor.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe o Bairro do Fornecedor.")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Informe o Endereço do Fornecedor.")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Informe o Número do Endereço.")]
        public int Numero { get; set; }
        public string Observacao { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe a Data do Cadastramento.")]
        public DateTime Data_Cadastro { get; set; }
    }
}
