using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome da Empresa.")]
        public string Razao_Social { get; set; }
        [Required(ErrorMessage = "Informe o CNPJ da Empresa.")]
        public string Cnpj { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o Telefone Celular.")]
        public string Telefone_Celular { get; set; }
        public string Telefone_Recado { get; set; }
        [Required(ErrorMessage = "Informe o Estado.")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Informe a Cidade.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe o Bairro.")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Informe o Endereço.")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Informe o Número do Endereço.")]
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
