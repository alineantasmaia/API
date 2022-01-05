namespace Safra.Domain.Entities
{
    public class Operacoes : Acoes
    {
        public int OpId { get; set; }
        public string OpDate { get; set; }
        public int OpQty { get; set; }
        public float OpTotalValue { get; set; }
        public string OpType { get; set; }
    }
}
