using Infraestructure.Data.AccessData;
using Infraestructure.Data.Repository;

namespace Infraestructure.Data.Persistent
{
    public class RepositoryProductos : RepositoryBase<tbl_Productos>
    {
        public RepositoryProductos() : base(new DataContext()) { }
    }
}
