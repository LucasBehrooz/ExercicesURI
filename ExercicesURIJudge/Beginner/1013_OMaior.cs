﻿using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1013_OMaior
    {
        public static void Execute()
        {
            String[] valores = Console.ReadLine().Split(' ');
            var A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            var B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            var C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            var MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            if (MaiorAB > C)
            {
                Console.WriteLine("{0} eh o maior", MaiorAB);
            }
            else
            {
                Console.WriteLine($"{C} eh o maior");
            }
        }
    }
}


//Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem
//“eh o maior”. Utilize a fórmula:

//MaiorAB=(a+b+abs(a-b)) / 2

//Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é 
//necessário para chegar no resultado esperado.

//Entrada
//O arquivo de entrada contém três valores inteiros.

//Saída
//Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".