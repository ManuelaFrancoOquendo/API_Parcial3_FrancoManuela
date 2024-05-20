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

        // GET: api/<TasksController>/GetXId
        [HttpGet("GetXId/{Id}")]
        public IEnumerable<Tasks> GetXId(Guid Id)
        {
            List<Tasks> tasks = _context.Tasks.Where(x => x.Id == Id).ToList();

            return tasks;
        }

        // GET: api/<TasksController>/GetXDate
        [HttpGet("GetXDate/{Date}")]
        public IEnumerable<Tasks> GetXDate(DateTime Date)
        {
            DateTime initialDate = Date.Date;
            DateTime endDate = Date.Date.AddDays(1);
            List<Tasks> tasks = _context.Tasks.Where(x => x.DueDate > initialDate && x.DueDate < endDate).ToList();

            return tasks;
        }

        // POST api/<TasksController>
        [HttpPost]
        public Tasks Post([FromBody] Tasks Task)
        {
            DateTime now = DateTime.Now;

            if (Task.DueDate < now)
            {
                return null;
            }

            Task = _context.Tasks.Add(Task).Entity;
            _context.SaveChanges();
            return Task;
        }

        // PUT api/<TasksController>/5
        [HttpPut("ToComplete")]
        public void ToComplete([FromBody] Tasks Tasks)
        {
            Tasks = _context.Tasks.SingleOrDefault(x => x.Id == Tasks.Id);
            if (Tasks is null)
            {
                return;
            }
            Tasks.CompletionDate = DateTime.Now;
            _context.Tasks.Update(Tasks);
            _context.SaveChanges();
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
