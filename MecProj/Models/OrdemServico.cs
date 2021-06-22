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
        public string Service { get; set; }
        public string Descricao { get; set; }
        public string Pecas { get; set; }
        [DataType(DataType.Date)]
        public DateTime Entrada { get; set; }
        public string Situacao { get; set; }
        //public long? ClienteID { get; set; }
        //public virtual Cliente Cliente { get; set; }

    }
}
