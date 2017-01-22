using System.Collections.Generic;
using System.Linq;

namespace Prueba01
{
    public class CompleteRange
    {
        public List<int> Build(List<int> coleccion)
        {
            var result = new List<int>();

            // Primero ordenamos.
            var listaOrdenada = coleccion.OrderBy(i => i).ToList();
            result.AddRange(listaOrdenada);

            for (int index = 0; index < listaOrdenada.Last(); index++)
            {
                var next = index + 1;
                if (!result.Contains(next))
                    result.Add(next);
            }

            return result.OrderBy(i => i).ToList();
        }
    }
}