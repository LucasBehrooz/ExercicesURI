using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesURIJudge.Beginner
{
    class _1020_IdadeEmDias
    {
        public static void Execute()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N / 365 + " ano(s)");
            var resto = (N % 365);

            Console.WriteLine(resto / 30 + " mes(es)");
            resto = (resto % 30);

            Console.WriteLine(resto + " dia(s)");
        }
    }
}

//Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

//Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos 
//de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas 
//um exercício com objetivo de testar raciocínio matemático simples.

//Entrada
//O arquivo de entrada contém um valor inteiro.

//Saída
//Imprima a saída conforme exemplo fornecido.