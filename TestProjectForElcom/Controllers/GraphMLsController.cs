using Microsoft.AspNetCore.Mvc;
using TestProjectForElcom.MongoModels;
using TestProjectForElcom.MongoService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProjectForElcom.Controllers
{
    [Route("api/GraphML")]
    [ApiController]
    public class GraphMLsController : ControllerBase
    {
        private readonly IGraphMLService graphMLService;
        public GraphMLsController(IGraphMLService graphMLService)
        {
            this.graphMLService = graphMLService;
        }
        // GET: api/<GroupsController>

        // GET: api/<GroupMembersController>
        [HttpGet]
        public ActionResult<List<GraphML>> Get()
        {
            return graphMLService.GetGraph();
        }

        // GET api/<GroupMembersController>/5
        [HttpGet("{id}")]
        public ActionResult<GraphML> Get(string id)
        {
            var graphML = graphMLService.GetGraph(id);
            if (graphML == null)
            {
                return NotFound();
            }
            return graphML;
        }
    }
}
