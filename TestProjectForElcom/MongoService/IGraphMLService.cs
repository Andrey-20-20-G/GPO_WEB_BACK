using TestProjectForElcom.MongoModels;

namespace TestProjectForElcom.MongoService
{
    public interface IGraphMLService
    {
        List<GraphML> GetGraph();
        GraphML GetGraph(string id);
    }
}
