namespace TestProjectForElcom.MongoService
{
    public interface IGroupDatabaseSettings
    {
        string GroupCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
