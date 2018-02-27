using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Highlande.DAL.Entities
{
    public class BaseEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
