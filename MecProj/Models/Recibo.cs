using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Models
{
    public class Recibo
    {
        [Key]
        [ForeignKey("OrdemServico")]
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
        public DateTime Saida { get; set; }
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

    }
}
