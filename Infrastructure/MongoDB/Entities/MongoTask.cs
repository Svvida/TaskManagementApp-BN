using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MongoDB.Entities
{
    public class MongoTask
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("userId")]
        public ObjectId UserId { get; set; } // Reference to Users's ObjectId

        // Domain to DTO mapping
        public static MongoTask FromDomainEntity(Domain.Entities.Task task)
        {
            return new MongoTask
            {
                Id = string.IsNullOrEmpty(task.Id) ? ObjectId.GenerateNewId() : new ObjectId(task.Id),
                Title = task.Title,
                Description = task.Description,
                UserId = new ObjectId(task.UserId),
            };
        }

        // DTO to Domain mapping
        public Domain.Entities.Task ToDomainEntity()
        {
            return new Domain.Entities.Task(
                Id.ToString(),
                Title,
                Description,
                UserId.ToString());
        }
    }
}
