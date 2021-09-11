using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1043_Triangulo
    {
        public static void Execute()
        {
            double A, B, C, area, perimetro;

            String[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < C + A && C < A + B)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
//Leia 3 valores reais(A, B e C) e verifique se eles formam ou não um triângulo. Em caso 
//positivo, calcule o perímetro do triângulo e apresente a mensagem:


//Perimetro = XX.X


//Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando 
//a mensagem


//Area = XX.X

//Entrada
//A entrada contém três valores reais.

//Saída
//O resultado deve ser apresentado com uma casa decimal.