using System.ComponentModel.DataAnnotations;
using Troco.Dominio;

namespace Troco.Testes
{
    public class UnitTest1
    {
        [Fact]
        public void Ao_compra_dar_120_e_pagar_150_o_troco_deve_ser_30()
        {
            //Arrange
            var troco = new TrocoStar();

            //Action
            var resultado = troco.CalcularTroco(120, 150);

            //Assert
            Assert.Equal(30, resultado);
        }

        [Fact]
        public void Ao_comprar_50_centavos_e_pagar_1_o_troco_deve_ser_50_centavos()
        {
            //Arrange
            var troco = new TrocoStar();

            //Action
            var resultado = troco.CalcularTroco(0.50m, 1);

            //Assert
            Assert.Equal(0.50m, resultado);
        }

        [Fact]
        public void Ao_dar_100_reais_o_troco_deve_ser_1_cedula_de_100()
        {
            //Arrange
            var troco = new TrocoStar();

            //Action
            var resultado = troco.CalcularCedulas(100);

            //Assert
            Assert.Equal(new List<int> { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, resultado);
        }

        [Fact]
        public void Ao_dar_387_reais_o_troco_deve_ser_1_cedula_de_200_1_de_100_1_de_50_1_de_20_1_de_10_1_de_5_e_1_de_2()
        {
            //Arrange
            var troco = new TrocoStar();

            //Action
            var resultado = troco.CalcularCedulas(387);

            //Assert
            Assert.Equal(new List<int> { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 }, resultado);
        }

        [Fact]
        public void Ao_dar_133_e_75_centavos_o_troco_deve_ser_1_cedula_de_100_1_de_20_1_de_10_1_de_2_1_de_1_1_1_de_50centavos_e_1_25centavos()
        {
            //Arrange
            var troco = new TrocoStar();

            //Action
            var resultado = troco.CalcularCedulas(133.75m);

            //Assert
            Assert.Equal(new List<int> { 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0 }, resultado);
        }

        [Fact]
        public void Ao_dar_67_e_15_centavos_o_troco_deve_ser_1_cedula_de_50_1_de_10_1_de_5_1_de_2_1_1_de_10_centavos_e_1_5centavos()
        {
            //Arrange
            var troco = new TrocoStar();

            //Action
            var resultado = troco.CalcularCedulas(67.15m);

            //Assert
            Assert.Equal(new List<int> { 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1 }, resultado);
        }
    }
}