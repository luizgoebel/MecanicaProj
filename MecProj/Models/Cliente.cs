using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MecProj.Models
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf_Cnpj { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneRecado { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }


    }
}
