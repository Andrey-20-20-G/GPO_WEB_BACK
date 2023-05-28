namespace TestProjectForElcom.MongoService
{
    public interface IGraphMLDatabaseSettings
    {
        string GraphMLCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

    }
}
