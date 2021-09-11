using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1038_Lanche
    {
        public static void Execute()
        {
            double total = 0;
            String[] venda = Console.ReadLine().Split(' ');
            var codigo = int.Parse(venda[0]);
            var quantidade = int.Parse(venda[1]);

            switch (codigo)
            {
                case 1:
                    total = 4.00 * quantidade;
                    break;
                case 2:
                    total = 4.50 * quantidade;
                    break;
                case 3:
                    total = 5.00 * quantidade;
                    break;
                case 4:
                    total = 2.00 * quantidade;
                    break;
                case 5:
                    total = 1.50 * quantidade;
                    break;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
//A seguir, calcule e mostre o valor da conta a pagar.
//
//Entrada
//O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um
//item conforme tabela acima.
//
//Saída
//O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas 
//após o ponto decimal.