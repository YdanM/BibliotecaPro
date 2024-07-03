

using BibliotecaPro.Lector.Domain.Interfaces;
using System.Linq.Expressions;

namespace BibliotecaPro.Lector.Persistance.Repositories
{
    public class LectorRepository : ILectorRepository
    {
        public bool Exists(Expression<Func<Domain.Entities.Lector, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Lector GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Lector> GetLAll()
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Lector> GetLectorsByLibroId(int libroId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Entities.Lector entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entities.Lector entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Lector entity)
        {
            throw new NotImplementedException();
        }
    }
}
