using Microsoft.AspNetCore.Mvc;
using TestProjectForElcom.MongoModels;
using TestProjectForElcom.MongoService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProjectForElcom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupMembersController : ControllerBase
    {
        private readonly IGroupMembersService groupMembersService;

        public GroupMembersController(IGroupMembersService groupMembersService)
        {
            this.groupMembersService = groupMembersService;
        }
        // GET: api/<GroupMembersController>
        //[HttpGet]
        //public ActionResult<Task<List<GroupMembers>>> Get()
        //{
        //    //Task res = groupMembersService.ResponseMess();
        //    //return groupMembersService.GetGroupMembers();
        //    return groupMembersService.ResponseMess();
        //}

        [HttpGet]
        public async Task<List<GroupMembers>> Get()
        {
            return await groupMembersService.GetGroupMembers();
        }

        // GET api/<GroupMembersController>/5
        [HttpGet("{id}")]
        public ActionResult<List<GroupMembers>> Get(string id)
        {
            var groupmembers = groupMembersService.GetGroupMembers(id);
            if (groupmembers == null)
            {
                return NotFound();
            }
            return Ok(groupmembers);
        }

        
    }
}
