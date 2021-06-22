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
        public string Razão_Social { get; set; }
        public string Cnpj { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string  Telefone_Celular { get; set; }
        public string Telefone_Recado { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
