using TestProjectForElcom.MongoModels;

namespace TestProjectForElcom.MongoService
{
    public interface IGroupService
    {
        List<Group> GetGroups();
        Group GetGroup(string id);
    }
}
