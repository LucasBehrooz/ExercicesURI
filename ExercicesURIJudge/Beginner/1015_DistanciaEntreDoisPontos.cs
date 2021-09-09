using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1015_DistanciaEntreDoisPontos
    {
        public static void Execute()
        {

            String[] p1 = Console.ReadLine().Split(' ');
            var x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            var y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            String[] p2 = Console.ReadLine().Split(' ');
            var x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
            var y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

            var distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}


//Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano,
//p1(x1, y1) e p2(x2, y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo
//a fórmula:

//Distancia = Raiz Quadrada de (x2-x1)²+(y2-y1)²

//Entrada
//O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

//Saída
//Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.