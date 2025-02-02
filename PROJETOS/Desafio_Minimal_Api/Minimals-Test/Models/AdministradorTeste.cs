using trilha_net_minimals_api_desafio.Models;

namespace Minimals_Test.Models
{
    [TestClass]
    public class AdministradorTeste
    {
        [TestMethod]
        public void TestarGetSerPropriedades()
        {
            // Arrange
            var adm = new Administrador();

            // Act
            adm.Id = 1;
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm";
        
            // Assert
            Assert.AreEqual(1, adm.Id);
            Assert.AreEqual("teste@teste.com", adm.Email);
            Assert.AreEqual("teste", adm.Senha);
            Assert.AreEqual("Adm", adm.Perfil);
        }
    }
}