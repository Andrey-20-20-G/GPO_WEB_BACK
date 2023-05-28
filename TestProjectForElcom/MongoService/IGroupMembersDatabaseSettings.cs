namespace TestProjectForElcom.MongoService
{
    public interface IGroupMembersDatabaseSettings
    {
        string GroupMembersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
