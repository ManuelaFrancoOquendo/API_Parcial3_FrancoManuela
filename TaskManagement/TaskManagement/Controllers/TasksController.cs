using Microsoft.AspNetCore.Mvc;
using TaskManagement.DAL;
using TaskManagement.DAL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public TasksController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/<TasksController>
        [HttpGet]
        public IEnumerable<Tasks> Get()
        {
            List<Tasks> tasks = _context.Tasks.OrderBy(x => x.Priority).ToList();

            return tasks;
        }

        // GET: api/<TasksController>
        [HttpGet("GetXId")]
        public IEnumerable<Tasks> GetXId(Guid Id)
        {
            List<Tasks> tasks = _context.Tasks.Where(x => x.Id == Id).ToList();

            return tasks;
        }

        // GET api/<TasksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TasksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TasksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
