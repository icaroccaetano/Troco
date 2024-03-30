namespace Troco.Dominio
{
    public class TrocoStar
    {
        public decimal CalcularTroco (decimal valorCompra, decimal valorPago)
        {
            return valorPago - valorCompra;
        }

        /*
         As cedulas do troco sao dadas via lista
         O numero de cada cedula e dado em ordem decrescente
         { qnt_notas_200, qnt_notas_100, qnt_notas_50, qnt_notas_20, qnt_notas_10, qnt_notas_5, qnt_notas_2, qnt_moedas_1, qnt_moedas_50, qnt_moedas_25, qnt_moedas_10, qnt_moedas_5 }    
        */

        public List<int> CalcularCedulas(decimal valorTroco)
        {
            int contadorQuantidade = 0;
            List<int> cedulas = new List<int>();

            while (valorTroco >= 200)
            {
                contadorQuantidade++;
                valorTroco -= 200;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 100)
            {
                contadorQuantidade++;
                valorTroco -= 100;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 50)
            {
                contadorQuantidade++;
                valorTroco -= 50;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;
            
            while (valorTroco >= 20)
            {
                contadorQuantidade++;
                valorTroco -= 20;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 10)
            {
                contadorQuantidade++;
                valorTroco -= 10;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 5)
            {
                contadorQuantidade++;
                valorTroco -= 5;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 2)
            {
                contadorQuantidade++;
                valorTroco -= 2;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 1)
            {
                contadorQuantidade++;
                valorTroco -= 1;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 0.5m)
            {
                contadorQuantidade++;
                valorTroco -= 0.5m;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 0.25m)
            {
                contadorQuantidade++;
                valorTroco -= 0.25m;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 0.10m)
            {
                contadorQuantidade++;
                valorTroco -= 0.10m;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            while (valorTroco >= 0.05m)
            {
                contadorQuantidade++;
                valorTroco -= 0.05m;
            }
            cedulas.Add(contadorQuantidade);
            contadorQuantidade = 0;

            return cedulas;
        }

        public void ImprimirQntCedulas (List<int> Cedulas)
        {
            if (Cedulas[0] != 0)
            {
                Console.WriteLine(Cedulas[0] + " cedula de R$200,00");
            }
            if (Cedulas[1] != 0)
            {
                Console.WriteLine(Cedulas[1] + " cedula de R$100,00");
            }
            if (Cedulas[2] != 0)
            {
                Console.WriteLine(Cedulas[2] + " cedula de R$50,00");
            }
            if (Cedulas[3] != 0)
            {
                Console.WriteLine(Cedulas[3] + " cedula de R$20,00");
            }
            if (Cedulas[4] != 0)
            {
                Console.WriteLine(Cedulas[4] + " cedula de R$10,00");
            }
            if (Cedulas[5] != 0)
            {
                Console.WriteLine(Cedulas[5] + " cedula de R$5,00");
            }
            if (Cedulas[6] != 0)
            {
                Console.WriteLine(Cedulas[6] + " cedula de R$2,00");
            }
            if (Cedulas[7] != 0)
            {
                Console.WriteLine(Cedulas[7] + " moeda de R$1,00");
            }
            if (Cedulas[8] != 0)
            {
                Console.WriteLine(Cedulas[8] + " moeda de R$0,50");
            }
            if (Cedulas[9] != 0)
            {
                Console.WriteLine(Cedulas[9] + " moeda de R$0,25");
            }
            if (Cedulas[10] != 0)
            {
                Console.WriteLine(Cedulas[10] + " moeda de R$0,10");
            }
            if (Cedulas[11] != 0)
            {
                Console.WriteLine(Cedulas[11] + " moeda de R$0,05");
            }
        }
    }  
}
