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
        [Required(ErrorMessage = "Informe o Cliente desta Ordem.")]
        public List<Cliente> Cliente { get; set; }
        [Required(ErrorMessage = "Informe o tipo de Serviço.")]
        public string Service { get; set; }
        [Required(ErrorMessage = "Descrição do Serviço.")]
        public string Descricao { get; set; }
        public string Pecas { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe a Data de entrada.")]
        public DateTime Entrada { get; set; }
        [Required(ErrorMessage = "Informe a Situação da Ordem")]
        public string Situacao { get; set; }



    }
}
