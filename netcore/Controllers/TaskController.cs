using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using poc_webapi.data;
using Microsoft.AspNetCore.Cors;

namespace poc_webapi.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    public class TaskController : Controller
    {
        private UbcDbContext dbContext = null;

        public TaskController(UbcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET api/task/all
        [HttpGet]
        [Route("api/[controller]/all")]
        public async Task<IActionResult> Get()
        {
            var tasks = await this.dbContext.PocTask
                .Include(t => t.User)
                .ToListAsync();
            return new ObjectResult(tasks);
        }

        [HttpPost]
        [Route("api/[controller]/add")]
        public async Task Add([FromBody] PocTask task)
        {                      
            task.User = this.dbContext.PocUser.Attach(task.User).Entity;
            this.dbContext.Add(task);
            await this.dbContext.SaveChangesAsync();
        }

        [HttpPut]
        [Route("api/[controller]/{id}/markDone")]
        public async Task MarkDone(int id)
        {
            var task = await this.dbContext.PocTask.SingleOrDefaultAsync(t => t.Id == id);
            
            if (task != null)
            {
                task.Done = true;
                await this.dbContext.SaveChangesAsync();
            }
        }
    }
}
