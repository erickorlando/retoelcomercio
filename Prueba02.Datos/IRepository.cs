using System.Collections.Generic;
using Prueba02.Entidades.Models;

namespace Prueba02.Datos
{
    public interface IRepository<T>
        where T : IEntity
    {

        void Add(T entidad);

        void Update(T entidad);

        T GetById(int id);

        void Delete(int id);

        List<T> ListarTodos();
    }
}