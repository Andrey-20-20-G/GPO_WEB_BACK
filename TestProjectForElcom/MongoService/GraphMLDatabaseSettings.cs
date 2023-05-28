namespace TestProjectForElcom.MongoService
{
    public class GraphMLDatabaseSettings : IGraphMLDatabaseSettings
    {
        public string GraphMLCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
