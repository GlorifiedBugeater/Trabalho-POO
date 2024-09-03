using AdivinharNumero;  

namespace AdivinharNumeroTest
{
    [TestClass]
    public class AdivinhaTest
    {
        [TestMethod]
        public void TesteAdivinharNumeroCorreto()
        {
            //cenário
            int numeroSecreto = 42;
            var jogo = new AdivinhaNumero(numeroSecreto);

            //ação
            var resultado = jogo.Adivinhar(numeroSecreto);

            //verificação
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TesteAdivinharNumeroErrado()
        {
            //cenário
            int numeroSecreto = 42;
            var jogo = new AdivinhaNumero(numeroSecreto);
            int numeroErrado = numeroSecreto + 1;

            //ação
            var resultado = jogo.Adivinhar(numeroErrado);

            //verificação
            Assert.IsFalse(resultado);
        }
    }
}


