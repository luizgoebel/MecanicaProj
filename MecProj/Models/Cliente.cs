using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MecProj.Models
{
    public class Cliente
    {

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
        //public virtual OrdemServico OrdemServico { get; set; }


        //public Cliente(int id, string nome, string cpf_Cnpj, string email, string telefoneCelular, string telefoneRecado, string estado, string cidade, string bairro, string rua, int numero, string complemento, IEnumerable<Cliente> clientes)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Cpf_Cnpj = cpf_Cnpj;
        //    Email = email;
        //    TelefoneCelular = telefoneCelular;
        //    TelefoneRecado = telefoneRecado;
        //    Estado = estado;
        //    Cidade = cidade;
        //    Bairro = bairro;
        //    Rua = rua;
        //    Numero = numero;
        //    Complemento = complemento;
        //    Clientes = clientes;
        //}
    }
}
