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
            var resultado = troco.ValorTroco(120, 150);

            //Assert
            Assert.Equal(30, resultado);
        }
        [Fact]
        public void Ao_comprar_50_centavos_e_pagar_1_o_troco_deve_ser_50_centavos()
        {
            //Arrange
            var troco = new TrocoStar();

            //Action
            var resultado = troco.ValorTroco(0.50m, 1);

            //Assert
            Assert.Equal(0.50m, resultado);
        }
    }
}