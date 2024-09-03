using VerificadorPalindromo;

namespace VerificadorPalindromoTest
{
    [TestClass]
    public class PalindromoTest
    {
        [TestMethod]
        public void TesteNumeroPalindromo()
        {
            //cen�rio
            int numero = 121;

            //a��o
            bool resultado = Palindromo.EPalindromo(numero);

            //verifica��o
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TesteNumeroNaoPalindromo()
        {
            //cen�rio
            int numero = 123;

            //a��o 
            bool resultado = Palindromo.EPalindromo(numero);

            //verifica��o
            Assert.IsFalse(resultado);
        }

    }
}
