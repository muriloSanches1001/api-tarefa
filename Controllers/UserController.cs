using api_tarefa.DBContext;
using api_tarefa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_tarefa.Controllers
{
    [Route("api/[controller]")] //localhost/api/user/name
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public UserController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("find-all")]
        public async Task<ActionResult<IEnumerable<User>>> FindAll()
        {
            return await _dbContext.users.ToListAsync();
        }

        [HttpGet("find-by-id/{id}")]
        public async Task<ActionResult<User>> FindById(int id)
        {
            return await _dbContext.users.FindAsync(id);
        }

        [HttpPost("create")]
        public async Task<ActionResult<User>> Create(User user)
        {
            _dbContext.users.Add(user);
            await _dbContext.SaveChangesAsync();
            return Ok(user);
        }
    }
}
