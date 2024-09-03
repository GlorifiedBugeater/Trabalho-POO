using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VerificadorPalindromo
{
    public static class Palindromo
    {
        public static bool EPalindromo(int numero)
        {
            string numeroStr = numero.ToString();  
            char[] arr = numeroStr.ToCharArray();  
            Array.Reverse(arr); 
            string numeroInvertido = new string(arr); 

            return numeroStr == numeroInvertido; 
        }
    }
}
