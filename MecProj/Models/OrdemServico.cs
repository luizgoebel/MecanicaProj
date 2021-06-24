using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Models
{
    public class OrdemServico
    {
        [Key]
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Telefone_Celular { get; set; }
        public string Marca_Veiculo { get; set; }
        public string Modelo_Veiculo { get; set; }
        public string Ano_Veiculo { get; set; }
        public string Obs_Veiculo { get; set; }
        public string Service { get; set; }
        public string Descricao { get; set; }
        public string Pecas { get; set; }
        public decimal Valor_Total { get; set; }
        [DataType(DataType.Date)]
        public DateTime Entrada { get; set; }
        public string Situacao { get; set; }

        //public List<Cliente> Clientes { get; set; }

    }
}
