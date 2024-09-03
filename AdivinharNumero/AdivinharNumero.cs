using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinharNumero
{
    public class AdivinhaNumero
    {
        private int numeroSecreto;

        public AdivinhaNumero()
        {
            var random = new Random();
            numeroSecreto = random.Next(1, 101); 
        }

        public AdivinhaNumero(int numeroSecretoDefinido)
        {
            numeroSecreto = numeroSecretoDefinido; 
        }

        public bool Adivinhar(int tentativa)
        {
            if (tentativa == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você adivinhou o número.");
                return true;
            }
            else if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else
            {
                Console.WriteLine("O número secreto é menor.");
            }
            return false;
        }
    }
}
