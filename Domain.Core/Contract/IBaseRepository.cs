using System.Collections.Generic;

namespace Domain.Core.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        void Agregar(T entidad);
        void Eliminar(T entidad);
        void Editar(T entidad);
        T Obtener(int id);
        IEnumerable<T> GetAll();

    }
}
