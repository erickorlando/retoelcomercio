using System;
using System.Collections.Generic;

namespace Prueba01
{
    class Program
    {
        static void Main()
        {

            Titulo("Problema 01");
            Problema01("123 abcd*3");
            Problema01("**Casa 52");

            Titulo("Problema 02");
            Problema02(new List<int> { 2, 1, 4, 5 });
            Problema02(new List<int> { 4, 2, 9 });
            Problema02(new List<int> { 58, 60, 55 });

            Console.Read();
        }

        private static void Separador()
        {
            Console.WriteLine("=============================");
        }

        private static void Titulo(string mensaje)
        {
            Console.WriteLine("\n");
            Separador();
            Console.WriteLine(mensaje);
            Separador();
        }

        static void Problema01(string entrada)
        {
            var problema01 = new ChangeString();
            var result = problema01.Build(entrada);

            Console.WriteLine("Valor de Entrada => {0}\nValor de Salida => {1}", entrada, result);
        }

        static void Problema02(List<int> coleccion)
        {
            var problema02 = new CompleteRange();
            var result = problema02.Build(coleccion);

            foreach (var item in result)
                Console.Write("{0} ", item);

            Console.WriteLine();
        }
    }
}
