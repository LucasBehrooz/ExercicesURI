using System;

namespace ExercicesURIJudge.Beginner
{
    class _1035_TesteDeSelecaoOne
    {
        public static void Execute()
        {
            String[] valores = Console.ReadLine().Split(' ');
            var A = int.Parse(valores[0]);
            var B = int.Parse(valores[1]);
            var C = int.Parse(valores[2]);
            var D = int.Parse(valores[3]);

            if ((B > C) && (D > A) && (C + D > A + B) && C > 0 && D > 0 && (A % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
//Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a
//soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for
//par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

//Entrada
//Quatro números inteiros A, B, C e D.

//Saída
//Mostre a respectiva mensagem após a validação dos valores.