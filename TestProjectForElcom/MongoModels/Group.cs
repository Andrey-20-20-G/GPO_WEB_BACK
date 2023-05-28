using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TestProjectForElcom.MongoModels
{
    [BsonIgnoreExtraElements]
    public class Group
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; set; }
        [BsonElement("CountofMembers")]
        public int CountofMembers { get; set; }
        [BsonElement("GroupName")]
        public string GroupName { get; set; } = string.Empty;
        [BsonElement("DateTime")]
        public DateTime DateTime { get; set; }
    }
}
