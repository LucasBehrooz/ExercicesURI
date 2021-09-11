using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicesURIJudge.Beginner;


namespace ExercicesURIJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new MenuUri(new Dictionary<string, Action>()
            {
                {"1000 - Hello World", _1000_HelloWorld.Execute },
                {"1001 - Extremamente Basico", _1001_ExtremamenteBasico.Execute },
                {"1002 - Area do Circulo", _1002_AreaDoCirculo.Execute },
                {"1003 - Area do Circulo", _1003_SomaSimples.Execute },
                {"1004 - Produto Simples", _1004_ProdutoSimples.Execute },
                {"1005 - Média 1", _1005_MediaOne.Execute },
                {"1006 - Média 2", _1006_MediaTwo.Execute },
                {"1007 - Diferença ", _1007_Diferenca.Execute },
                {"1008 - Salário", _1008_Salario.Execute },
                {"1009 - Salário com Bonus", _1009_SalarioComBonus.Execute },
                {"1010 - Cálculo Simples", _1010_CalculoSimples.Execute },
                {"1011 - Esfera", _1011_Esfera.Execute },
                {"1012 - Área", _1012_Area.Execute },
                {"1013 - O Maior", _1013_OMaior.Execute },
                {"1014 - Consumo", _1014_Consumo.Execute },
                {"1015 - Distância Entre Dois Pontos", _1015_DistanciaEntreDoisPontos.Execute },
                {"1016 - Distância", _1016_Distancia.Execute },
                {"1017 - Gasto de Combustível", _1017_GastoDeCombustivel.Execute },
                {"1018 - Cédulas", _1018_Cedulas.Execute },
                {"1019 - Conversão de Tempo", _1019_ConversaoDeTempo.Execute },
                {"1020 - Idade em Dias", _1020_IdadeEmDias.Execute },
                {"1021 - Notas e Moedas", _1021_NotasEMoedas.Execute },
                {"1035 - Teste de Seleção 1", _1035_TesteDeSelecaoOne.Execute },
                {"1036 - Formula de Bhaskara", _1036_FormulaDeBhaskara.Execute },
                {"1037 - Intervalo", _1037_Intervalo.Execute },
                {"1038 - Lanche", _1038_Lanche.Execute },
                {"1040 - Média 3", _1038_Lanche.Execute },
                {"1041 - Coordenadas de um Ponto", _1041_CoordenadasPonto.Execute },
                {"1042 - Sort Simples", _1042_SortSimples.Execute },
                {"1043 - Triângulo", _1043_Triangulo.Execute },
                {"1044 - Múltiplos", _1044_Multiplos.Execute },
                {"1045 - Tipos de Triângulos", _1045_TiposDeTriangulos.Execute },

              




            });
            start.SelectAndExecute();
        }
    }
}


