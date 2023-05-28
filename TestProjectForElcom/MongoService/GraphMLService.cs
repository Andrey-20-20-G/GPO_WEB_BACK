using TestProjectForElcom.MongoModels;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace TestProjectForElcom.MongoService
{
    public class GraphMLService : IGraphMLService
    {
        private readonly IMongoCollection<GraphML> _graphML;
        public GraphMLService(IGraphMLDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _graphML = database.GetCollection<GraphML>(settings.GraphMLCollectionName);
        }
        public List<GraphML> GetGraph()
        {
            return _graphML.Find(graphML => true).ToList();
        }

        public GraphML GetGraph(string id)
        {
            return _graphML.Find(graphML => graphML.Id.ToString() == id).FirstOrDefault();
        }
    }
}
