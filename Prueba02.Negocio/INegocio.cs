using System.Collections.Generic;
using Prueba02.Entidades.Models;

namespace Prueba02.Negocio
{
    public interface INegocio<T>
        where T : IEntity
    {
        void Add(T entidad);
        void Delete(int id);
        T GetById(int id);
        List<T> Listar();
        void Update(T entidad);
    }
}