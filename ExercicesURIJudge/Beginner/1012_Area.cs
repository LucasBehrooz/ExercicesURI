using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1012_Area
    {
        public static void Execute()
        {
            String[] valores = Console.ReadLine().Split(' ');
            var A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            var B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            var C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            var triangulo = (A * C) / 2;
            var circulo = (C * C) * 3.14159;
            var trapezio = (A + B) * C / 2;
            var quadrado = B * B;
            var retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}


//Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
//Em seguida, calcule e mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.
//Entrada
//O arquivo de entrada contém três valores com um dígito após o ponto decimal.

//Saída
//O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas 
//    descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. 
//    O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.