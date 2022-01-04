using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Entities
{
    public class Operacoes : Acoes
    {
        public Operacoes()
        {

        }
        public int OpId { get; set; }
        public string OpDate { get; set; }
        public int OpQty { get; set; }
        public float OpTotalValue { get; set; }
        public string OpType { get; set; }
    }
}
