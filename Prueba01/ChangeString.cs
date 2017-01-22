using System.Linq;
using System.Text;

namespace Prueba01
{
    /*
     * Usando C#, crear una clase llamada ChangeString ​que tenga un método llamado
       build ​el cual tome un parámetro string que debe ser modificado por el siguiente
       algoritmo . Reemplazar cada letra de la cadena con la letra siguiente en el
       alfabeto. Por ejemplo reemplazar a por b ó c por d​. Finalmente devolver la
       cadena.
     */
    public class ChangeString
    {
        private readonly string _abecedario = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,ñ,o,p,q,r,s,t,u,v,w,x,y,z";
        public string Build(string input)
        {
            var collection = _abecedario.Split(',').ToList();
            var sb = new StringBuilder();

            foreach (var caracter in input)
            {
                var pos = collection.IndexOf(caracter.ToString().ToLower());
                if (pos > -1)
                    sb.Append(char.IsUpper(caracter) ? collection[pos + 1].ToUpper() : collection[pos + 1]);
                else
                    sb.Append(caracter);
            }

            var result = sb.ToString();
            sb.Length = 0;

            return result;
        }
    }
}