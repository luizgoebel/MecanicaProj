using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MecProj.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o Nome do Cliente.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CPF do Cliente.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Informe o Email do Cliente.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneRecado { get; set; }
        [Required(ErrorMessage = "Informe o Estado do Cliente.")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Informe a Cidade do Cliente.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe o Bairro do Cliente.")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Informe a Rua do Cliente.")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Informe o Número do Cliente.")]
        public int Numero { get; set; }
        public string Complemento { get; set; }



    }
}
