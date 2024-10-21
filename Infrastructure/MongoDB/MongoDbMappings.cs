using Infrastructure.MongoDB.Entities;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MongoDB
{
    public static class MongoDbMappings
    {
        public static void Configure()
        {
            // Configure UserAccount mapping
            BsonClassMap.RegisterClassMap<MongoUserAccount>(map =>
            {
                map.AutoMap();
                map.MapIdMember(c => c.Id);
                map.MapMember(c => c.Email).SetElementName("email");
                map.MapMember(c => c.Password).SetElementName("password");
            });

            // Confiure Task mapping
            BsonClassMap.RegisterClassMap<MongoTask>(map =>
            {
                map.AutoMap();
                map.MapIdMember(c => c.Id);
                map.MapMember(c => c.Title).SetElementName("title");
                map.MapMember(c => c.Description).SetElementName("description");
                map.MapMember(c => c.UserId).SetElementName("userId");
            });
        }
    }
}
