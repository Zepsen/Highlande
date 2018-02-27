using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace Highlande.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IMongoQueryable<TEntity> GetQueryable();
        Task<TEntity> Get(string id);
        Task<IList<TEntity>> GetAll();

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity"></param>
        Task Insert(TEntity entity);
        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities"></param>
        Task Insert(IList<TEntity> entities);
        
        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        Task Update(TEntity entity);
        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities"></param>
        Task Update(IList<TEntity> entities);
        
        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity"></param>
        Task Delete(TEntity entity);
        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities"></param>
        Task Delete(IList<TEntity> entities);
    }
}