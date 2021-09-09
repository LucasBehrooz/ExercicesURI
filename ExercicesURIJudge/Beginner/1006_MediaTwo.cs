using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace ExercicesURIJudge.Beginner
{
    class _1006_MediaTwo
    {
        public static void Execute()
        {
            var A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var MEDIA = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"), CultureInfo.InvariantCulture);
        }
    }
}


//Media 2
//Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
//Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

//Entrada
//O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

//Saída
//Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal 
//e com um espaço em branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de 
//imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

