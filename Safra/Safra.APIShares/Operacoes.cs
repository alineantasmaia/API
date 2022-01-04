using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Safra.APIShares
{
    public class Operacoes
    {
        public int idAcao { get; set; }
        public string RazaoSocial { get; set; }
        //Venda ou Compra
        public string TipoOperacao { get; set; }
        public int QuantidadePorOperacao { get; set; }
        public float CustoOperacao { get; set; }
        public string Aliquota => "0,0325";
        public float Emolumentos => (float)(Convert.ToDouble(Aliquota)*CustoOperacao/100);
        public float CustoCorretagemCompra => (float)((5 * QuantidadePorOperacao) + Emolumentos);
        public DateTime DataOperacao { get; set; }        
        public float ValoDaAcao { get; set; }        
        public float ValorTotal => (float)(ValoDaAcao + CustoOperacao);
        //YahooFinance
        public float RetornoCotacao { get; set; }
    }
}
