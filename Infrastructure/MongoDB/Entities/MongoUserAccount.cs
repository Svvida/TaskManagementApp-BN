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
    public class MongoUserAccount
    {
        [BsonId] // Specifies that Id is primary key in MongoDB collection
        public ObjectId Id { get; set; }
        [BsonElement("email")] // Customize element name in MongoDB
        public string Email { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }

        // Domain to DTO mapping
        public static MongoUserAccount FromDomainEntity(UserAccount user)
        {
            return new MongoUserAccount
            {
                Id = string.IsNullOrEmpty(user.Id) ? ObjectId.GenerateNewId() : new ObjectId(user.Id),
                Email = user.Email,
                Password = user.Password,
            };
        }

        // Dto to Domain mapping
        public UserAccount ToDomainEntity()
        {
            return new UserAccount(
                Id.ToString(), // Convert ObjectId to string
                Email,
                Password);
        }
    }
}
