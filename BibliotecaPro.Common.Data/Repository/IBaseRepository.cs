using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPro.Common.Data.Repository
{ 
    /// <summary>
    /// Interface base para los repositorios de datos.
    /// </summary>
    /// <typeparam name="TEntity">Entidad a trabajar</typeparam>
    /// <typeparam name="TType">Id para buscar</typeparam>
    public  interface IBaseRepository <TEntity, TType> where TEntity : class //Es generico donde TEntity sea una clase
    {                   /*Entidad, Tipo de Dato del PK de la tabla*/
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        List<TEntity> GetLAll();
        TEntity GetEntityBy(TType Id);
        bool Exists(Expression<Func<TEntity, bool>> filter); //Link Query: Metodo para Verifica si existe un registro.

    }
}
