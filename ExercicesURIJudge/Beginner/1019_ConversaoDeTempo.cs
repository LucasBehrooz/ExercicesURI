﻿using System;

namespace ExercicesURIJudge.Beginner
{
    class _1019_ConversaoDeTempo
    {
        public static void Execute()
        {
            var N = int.Parse(Console.ReadLine());
            var hora = N / 3600;
            var minutos = (N % 3600) / 60;
            var segundos = (N % 3600) % 60;
            Console.WriteLine($"{hora}:{minutos}:{segundos}");
        }
    }
}

//Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e
//informe-o expresso no formato horas:minutos: segundos.

//Entrada
//O arquivo de entrada contém um valor inteiro N.

//Saída
//Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos: segundos, conforme
//exemplo fornecido.
