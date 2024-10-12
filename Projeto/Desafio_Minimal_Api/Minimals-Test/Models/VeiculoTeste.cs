using trilha_net_minimals_api_desafio.Models;

namespace Minimals_Test.Models
{
    [TestClass]
    public class VeiculoTeste
    {
        [TestMethod]
        public void TestarGetSerPropriedades()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Id = 1;
            veiculo.Marca = "teste";
            veiculo.Nome = "teste";
            veiculo.Ano = 1900;
        
            // Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("teste", veiculo.Marca);
            Assert.AreEqual("teste", veiculo.Nome);
            Assert.AreEqual(1900, veiculo.Ano);
        }
    }
}