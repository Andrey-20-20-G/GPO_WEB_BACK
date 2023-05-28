using TestProjectForElcom.MongoModels;
using MongoDB.Driver;

namespace TestProjectForElcom.MongoService
{
    public class GroupMembersService : IGroupMembersService
    {
        private readonly IMongoCollection<GroupMembers> _groupmembers;
        public GroupMembersService(IGroupMembersDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _groupmembers = database.GetCollection<GroupMembers>(settings.GroupMembersCollectionName);
        }
        public async Task<List<GroupMembers>> GetGroupMembers()
        {
            //return await Task.FromResult(_groupmembers.Find(groupmembers => true).ToList());
            return await Task.FromResult(_groupmembers.FindAsync(_groupmembers => true).Result.ToList());
        }

        //public async Task<List<GroupMembers>> ResponseMess()
        //{
        //    //return await Task.Delay(() => GetGroupMembers());
        //    return await Task.FromResult(GetGroupMembers());
        //}
        public GroupMembers GetGroupMembers(string id)
        {
            return _groupmembers.Find(groupmembers => groupmembers.UserId.ToString() == id).FirstOrDefault();
        }
    }
}
