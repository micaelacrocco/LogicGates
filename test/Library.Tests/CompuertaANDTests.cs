using NUnit.Framework;
using Library;

namespace Library.Tests
{
    [TestFixture]
    public class CompuertaANDTests
    {
        [Test]
        public void CompuertaAND_Calcular_DeberiaRetornarFalseSiAlMenosUnaEntradaEsFalse()
        {
            // Arrange
            var compuerta = new CompuertaAND();
            var entrada1 = new Compuerta();
            var entrada2 = new Compuerta();
            compuerta.AgregarEntrada(entrada1);
            compuerta.AgregarEntrada(entrada2);
            entrada1.Estado = true;
            entrada2.Estado = false;

            // Act
            var resultado = compuerta.Calcular();

            // Assert
            Assert.IsFalse(resultado);
        }
        [Test] //REVISAR XQ DA ERROR
        public void CompuertaAND_Calcular_DeberiaRetornarTrueSiTodasLasEntradasSonTrue()
        {
            // Arrange
            var compuerta = new CompuertaAND();
            var entrada1 = new Compuerta();
            var entrada2 = new Compuerta();
            compuerta.AgregarEntrada(entrada1);
            compuerta.AgregarEntrada(entrada2);
            entrada1.Estado = true;
            entrada2.Estado = true;

            //Act
            var resultado = compuerta.Calcular();

            //Assert
            Assert.IsTrue(resultado);
        }
    }
}

