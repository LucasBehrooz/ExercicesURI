using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1041_CoordenadasPonto
    {
        public static void Execute()
        {
            String[] entrada = Console.ReadLine().Split(' ');
            var x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            var y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0) { Console.WriteLine("Q1"); }
            else if (x < 0 && y > 0) { Console.WriteLine("Q2"); }
            else if (x < 0 && y < 0) { Console.WriteLine("Q3"); }
            else if (x > 0 && y < 0) { Console.WriteLine("Q4"); }
            else if (x == 0 && y != 0) { Console.WriteLine("Eixo Y"); }
            else if (y == 0 && x != 0) { Console.WriteLine("Eixo X"); }
            else { Console.WriteLine("Origem"); }
        }
    }
}

//Leia 2 valores com uma casa decimal (x e y), que devem representar as 
//coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual 
//pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

//Se o ponto estiver na origem, escreva a mensagem “Origem”.

//Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

//Entrada
//A entrada contem as coordenadas de um ponto.

//Saída
//A saída deve apresentar o quadrante em que o ponto se encontra.