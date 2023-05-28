using Microsoft.AspNetCore.Mvc;
using TestProjectForElcom.MongoModels;
using TestProjectForElcom.MongoService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProjectForElcom.Controllers
{
    [Route("api/Groups-haha")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupService groupService;
        public GroupsController(IGroupService groupService)
        {
            this.groupService = groupService;
        }
        // GET: api/<GroupsController>

        // GET: api/<GroupMembersController>
        [HttpGet]
        public ActionResult<List<Group>> Get()
        {
            return groupService.GetGroups();
        }

        // GET api/<GroupMembersController>/5
        [HttpGet("{id}")]
        public ActionResult<Group> Get(string id)
        {
            var group = groupService.GetGroup(id);
            if (group == null)
            {
                return NotFound();
            }
            return group;
        }

    }
}
