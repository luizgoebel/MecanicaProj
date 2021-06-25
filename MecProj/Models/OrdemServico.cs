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
        [Required(ErrorMessage = "Informe o Nome do Cliente.")]
        public string Cliente { get; set; }
        [Required(ErrorMessage = "Informe CPF ou CNPJ.")]
        public string CPF_CNPJ { get; set; }
        [Required(ErrorMessage = "Informe o Telefone Celular.")]
        public string Telefone_Celular { get; set; }
        [Required(ErrorMessage = "Informe a Marca do veículo.")]
        public string Marca_Veiculo { get; set; }
        [Required(ErrorMessage = "Informe o Modelo do veículo.")]
        public string Modelo_Veiculo { get; set; }
        [Required(ErrorMessage = "Informe o Ano do veículo.")]
        public string Ano_Veiculo { get; set; }
        public string Obs_Veiculo { get; set; }
        public string Service { get; set; }
        public string Descricao { get; set; }
        public string Pecas { get; set; }

        public string Valor_Total { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe a Data de Entrada.")]
        public DateTime Entrada { get; set; }
        [Required(ErrorMessage = "Informe a Situação.")]
        public string Situacao { get; set; }
        //public List<Cliente> Clientes { get; set; }

    }
}
