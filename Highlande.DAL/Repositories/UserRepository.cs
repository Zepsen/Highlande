using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Highlande.DAL.Entities;
using Highlande.DAL.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MoreLinq;

namespace Highlande.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IMongoCollection<User> _collection;

        public UserRepository(IMongoDatabase db)
        {
            //db.GetCollection<TEntity>(typeof(TEntity).Name);
            _collection = db.GetCollection<User>("Users");
        }

        public IMongoQueryable<User> GetQueryable()
        {
            return _collection.AsQueryable();
        }


        public async Task<User> Get(string id)
        {
            return await _collection.Find(i => i.Id == ObjectId.Parse(id)).FirstOrDefaultAsync();
        }
        
        public async Task<IList<User>> GetAll()
        {
            return await GetQueryable().ToListAsync();
        }

        

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity"></param>
        public async Task Insert(User entity)
        {
            await _collection.InsertOneAsync(entity);
        }
        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities"></param>
        public async Task Insert(IList<User> entities)
        {
            foreach (var entity in entities)
            {
                await Insert(entity);
            }
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        public async Task Update(User entity)
        {
            await _collection.ReplaceOneAsync(x => x.Id.Equals(entity.Id), entity, 
                new UpdateOptions { IsUpsert = true });
        }
        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entities"></param>
        public async Task Update(IList<User> entities)
        {
            foreach (var entity in entities)
            {
                await Update(entity);
            }
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity"></param>
        public async Task Delete(User entity)
        {
            await _collection.DeleteOneAsync(x => x.Id.Equals(entity.Id));
        }
        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities"></param>
        public async Task Delete(IList<User> entities)
        {
            foreach (var entity in entities)
            {
                await Delete(entity);
            }
        }
    }
}
