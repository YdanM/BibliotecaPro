using BibliotecaPro.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPro.Lector.Domain.Interfaces
{
    public interface ILectorRepository : IBaseRepository<Lector.Domain.Entities.Lector, int>
    { 
        List<Lector.Domain.Entities.Lector> GetLectorsByLibroId(int libroId); 
    }
}
