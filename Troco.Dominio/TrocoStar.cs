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
    }  
}
