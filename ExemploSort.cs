using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Existem muitos métodos de array disponíveis, por exemplo Sort(), que classifica um array em ordem alfabética ou crescente:

namespace ClassificacaoMatrizesCsharp
{
    internal class ExemploSort
    {
        public static void Main(string[] args)
        {

            //Vetor em string
            string[] doce = { "brigadeiro", "Alfajor", "Pavê", "Manjar" };
            Array.Sort(doce);
            foreach (string contadora in doce)
            {
                Console.WriteLine(contadora);
            }

            //Vetor em números
            int[] numero = { 50, 15, 83, 1 };
            Array.Sort(numero);
            foreach (int contadora in numero)
            {
                Console.WriteLine(contadora);

            }
        }
    }
}
