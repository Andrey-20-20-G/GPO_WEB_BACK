using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TestProjectForElcom.MongoModels
{
    [BsonIgnoreExtraElements]
    public class GraphML
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; set; }
        [BsonElement("GraphMLFile")]
        public string GraphMLFile { get; set; } = string.Empty;
        [BsonElement("DateTime")]
        public DateTime DateTime { get; set; }
    }
}
