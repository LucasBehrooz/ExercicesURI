using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesURIJudge.Beginner
{
    class _1004_ProdutoSimples
    {
        public static void Execute()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var PROD = A * B;
            Console.WriteLine("PROD = " + PROD);
        }
    }
}


//Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua 
//    esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   

//Entrada
//O arquivo de entrada contém 2 valores inteiros.

//Saída
//Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco 
//antes e depois da igualdade. Não esqueça de imprimir o fim de linha após o produto, caso 
//contrário seu programa apresentará a mensagem: “Presentation Error”.