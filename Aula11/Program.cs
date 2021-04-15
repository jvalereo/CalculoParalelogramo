using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula11, Calcular area do paralelogramo, tipo double
            //Jonas valereo  - Técnico em Informática 

            //Declarando as variaveis tipo double

            double b, h, area;


            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a base menor: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a base maior: ");
            h = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();


            //Declarando a variavel area do paralelogramo

            area = b * h;


            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("Valor do paralelogramo: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Parabéns, tente de novo!!!");

            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programas







        }
    }
}
