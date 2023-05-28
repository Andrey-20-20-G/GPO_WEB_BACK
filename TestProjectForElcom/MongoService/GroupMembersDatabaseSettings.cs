namespace TestProjectForElcom.MongoService
{
    public class GroupMembersDatabaseSettings : IGroupMembersDatabaseSettings
    {
        public string GroupMembersCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
