using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Outros métodos de array úteis, como Min, Maxe Sum, podem ser encontrados no System.Linqnamespace:

namespace ClassificacaoMatrizesCsharp
{
    internal class ExemploMinMaxSum
    {
        public static void Main(string[] args)
        {
            int[] numero = { 100, 1, 55, 12 };

            //O maior número

            Console.WriteLine(numero.Max()); 

            //O menor número.

            Console.WriteLine(numero.Min());

            // soma dos números

            Console.WriteLine(numero.Sum());
            
        }
    }
}
