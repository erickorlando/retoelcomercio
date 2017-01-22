using System;

namespace Prueba01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema 01
            /*
             * entrada:​ "123 abcd*3"salida:​ "123 bcde​*3"
               entrada:​"**Casa 52"salida:​"**Dbtb​ 52" 
            */

            var problema01 = new ChangeString();
            var result = problema01.Build("123 abcd*3");
            var expected = "123 bcde*3";

            Console.WriteLine("Valor de Result {0}\nValor de Expected {1}", result, expected);
            if (result == expected)
                Console.WriteLine("Los valores son iguales");

            result = problema01.Build("**Casa 52");
            expected = "**Dbtb 52";

            Console.WriteLine("Valor de Result {0}\nValor de Expected {1}", result, expected);
            if (result == expected)
                Console.WriteLine("Los valores son iguales");

            Console.Read();
        }
    }
}
