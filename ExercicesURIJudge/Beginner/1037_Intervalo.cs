using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1037_Intervalo
    {
        public static void Execute()
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}

//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
//seguintes intervalos ([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o 
//valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

//O símbolo ( representa "maior que". Por exemplo:
//[0,25]  indica valores entre 0 e 25.0000, inclusive eles.
//(25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000

//Entrada
//O arquivo de entrada contém um número com ponto flutuante qualquer.

//Saída
//A saída deve ser uma mensagem conforme exemplo abaixo.