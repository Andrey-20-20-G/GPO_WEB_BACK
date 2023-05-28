using MongoDB.Driver;
using TestProjectForElcom.MongoModels;

namespace TestProjectForElcom.MongoService
{
    public class GroupService : IGroupService
    {
        private readonly IMongoCollection<Group> _groups;
        public GroupService(IGroupDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _groups = database.GetCollection<Group>(settings.GroupCollectionName);
        }
        public Group GetGroup(string id)
        {
            return _groups.Find(group => group.Id.ToString() == id).FirstOrDefault();
        }

        public List<Group> GetGroups()
        {
            return _groups.Find(group=> true).ToList();
        }
    }
}
