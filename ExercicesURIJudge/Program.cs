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

            });
            start.SelectAndExecute();
        }
    }
}


