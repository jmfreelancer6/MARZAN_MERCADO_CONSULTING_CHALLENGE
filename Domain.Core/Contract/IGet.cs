using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Core.Agregados
{
    public interface IGet<T>
    {
        IQueryable<T> ObtenerListado(Expression<Func<T, object>> orderBy);
        IQueryable<T> ObtenerListadoByExpression(Expression<Func<T, bool>> Expre);
        T ObtenerOneByExpression(Expression<Func<T, bool>> Expre);
    }
}
