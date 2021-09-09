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




            });
            start.SelectAndExecute();
        }
    }
}


