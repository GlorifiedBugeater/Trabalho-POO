using VerificadorPalindromo;

namespace VerificadorPalindromoTest
{
    [TestClass]
    public class PalindromoTest
    {
        [TestMethod]
        public void TesteNumeroPalindromo()
        {
            //cenário
            int numero = 121;

            //ação
            bool resultado = Palindromo.EPalindromo(numero);

            //verificação
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TesteNumeroNaoPalindromo()
        {
            //cenário
            int numero = 123;

            //ação 
            bool resultado = Palindromo.EPalindromo(numero);

            //verificação
            Assert.IsFalse(resultado);
        }

    }
}
