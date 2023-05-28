using TestProjectForElcom.MongoModels;

namespace TestProjectForElcom.MongoService
{
    public interface IGroupMembersService
    {
        Task<List<GroupMembers>> GetGroupMembers();
        GroupMembers GetGroupMembers(string id);
        //Task<List<GroupMembers>> ResponseMess();
    }
}
