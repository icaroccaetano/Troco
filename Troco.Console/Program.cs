using Troco.Dominio;

class Program
{
    static void Main(string[] args)
    {
        decimal compraValor, pagamentoValor, valorTroco;
        TrocoStar troco = new TrocoStar();
        List<int> qntCedulas = new List<int>();


        Console.WriteLine("Valor da compra:");
        compraValor = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Valor Pago:");
        pagamentoValor = decimal.Parse(Console.ReadLine());

        valorTroco = troco.CalcularTroco(compraValor, pagamentoValor); 

        Console.WriteLine("Valor troco: " +  valorTroco);

        qntCedulas = troco.CalcularCedulas(valorTroco);

        troco.ImprimirQntCedulas(qntCedulas);
    }
}

