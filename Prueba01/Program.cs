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

            Titulo("Problema 03");
            Problema03("0.10");
            Problema03("0.50");

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

        static void Problema03(string monto)
        {
            Console.WriteLine("El monto a calcular es {0}", monto);
            var problema03 = new MoneyParts();
            var result = problema03.Build(monto);

            foreach (var parte in result)
            {
                Console.Write("[");
                var index = 0;
                foreach (var partecita in parte.Partes)
                {
                    index++;
                    Console.Write(partecita);
                    if (index != parte.Partes.Count)
                        Console.Write(", ");
                }
                Console.Write("]\t");
            }
            Console.WriteLine();
        }
    }
}
