using Infraestructure.Data.AccessData;
using Infraestructure.Data.Repository;

namespace Infraestructure.Data.Persistent
{
    public class RepositoryClientes : RepositoryBase<tbl_Clientes>
    {
        public RepositoryClientes() : base(new DataContext()) { }
    }
}
