namespace TestProjectForElcom.MongoService
{
    public class GroupDatabaseSettings : IGroupDatabaseSettings
    {
        public string GroupCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
