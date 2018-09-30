using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dada uma sequência de Fibonacci 1,1,2,3,5,8,13,....,n, escreva um programa para
 gerar a sequência até o enésimo termo, o qual deverá ser fornecido pelo usuário. Por exemplo, se
 o usuário digitou o número 40, deverão ser apresentados os 40 números da sequência na tela.  */
            int n, ant=1, prox, atual=1, i;
            Console.Write("Digite o enésimo termo: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write("0");
                }
                if(i==1 || i == 2)
                {
                    Console.Write(" : 1");
                }
                else
                {
                    prox = atual + ant;
                    ant = atual;
                    atual = prox;
                    Console.Write(" : " + prox);
                }
            }
            Console.ReadKey();
        }
    }
}
