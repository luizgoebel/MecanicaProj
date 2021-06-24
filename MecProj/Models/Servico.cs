using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecProj.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
