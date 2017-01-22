using System;
using System.Collections.Generic;

namespace Prueba01
{
    public class MoneyParts
    {
        private readonly decimal[] _denominaciones = { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
        public List<Parte> Build(string monto)
        {
            var result = new List<Parte>();
            var montoDecimal = Convert.ToDecimal(monto);

            foreach (var denominacion in _denominaciones)
            {
                var parte = new Parte();
                if (denominacion <= montoDecimal)
                {
                    var cantidad = montoDecimal / denominacion;
                    for (int i = 0; i < cantidad; i++)
                    {
                        parte.Partes.Add(denominacion);
                    }

                    result.Add(parte);
                }
            }

            return result;
        }
    }

    public class Parte
    {
        public List<decimal> Partes { get; set; }

        public Parte()
        {
            Partes = new List<decimal>();
        }
    }
}