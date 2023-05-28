using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TestProjectForElcom.MongoModels
{
    [BsonIgnoreExtraElements]
    public class GroupMembers
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public long IdGroup { get; set; }
        [BsonElement("FrstName")]
        public string FrstName { get; set; } = string.Empty;
        [BsonElement("LstName")]
        public string LstName { get; set; } = string.Empty;
        [BsonElement("UserId")]
        public long UserId { get; set; }
        [BsonElement("DateTime")]
        public DateTime DateTime { get; set; }
    }
}
