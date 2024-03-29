namespace Troco.Dominio
{
    public class TrocoStar
    {
        public decimal ValorTroco (decimal valorCompra, decimal valorPago)
        {
            return valorPago - valorCompra;
        }
    }
}
